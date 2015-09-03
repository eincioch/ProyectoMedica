using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_CtaCteComprobante_Pago
    {
        #region Registrar CtaCtePago y CtaCtePagDatos

        //------------------------------------
        // Insert CtaCtePago / CtaCtePagDatos
        //------------------------------------
        public bool Ins_CtaCtePago_PagDatos(string cPerCodigo, string cPerJurCodigo, string cCtaCteRecibo, int nCaja, int nForPago, string cCtaCtePagNroOperacion, DateTime dCtaCtePagfecha, string CtaCtePagGlosa, double fCtaCtePagImporte, string cPerCodigoBanco, string cDescrBanco, string cNroTarjCta, string NroTrasacVoucher)
        {
            bool exito = false;

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    int nCtaCtePagcodigo = 0;
                    int nPerCtaCodigo = 0;
                    //int vnCtaCteTipo = 0;

                    //-------------
                    //Get PerCuenta
                    //-------------
                    BL_PerCuenta ObjPerCta = new BL_PerCuenta();
                    DataTable dt = new DataTable();
                    dt = ObjPerCta.Get_PerCuenta(cPerCodigo, cPerJurCodigo);

                    if (dt.Rows.Count > 0)
                    {
                        nPerCtaCodigo = Convert.ToInt32(dt.Rows[0]["nPerCtaCodigo"]);
                        //vnCtaCteTipo = Convert.ToInt32(dt.Rows[0]["nPerCtaTipo"]);
                    }
                    else {
                        throw new ApplicationException("Persona <NO> tiene Numero Cuenta en. [PerCuenta].!");
                    }

                    //-------------------
                    //Insert: CtaCtePago
                    //-------------------
                    BL_CtaCtePago ObjPago = new BL_CtaCtePago();

                    //OUTPUT inserted.nCtaCtaPagCodigo (cm.ExecuteScalar()) 
                    nCtaCtePagcodigo = ObjPago.Ins_CtaCtePago(cCtaCteRecibo, cPerCodigo, nPerCtaCodigo, nCaja, nForPago, cCtaCtePagNroOperacion, dCtaCtePagfecha, CtaCtePagGlosa, fCtaCtePagImporte);

                    if (nCtaCtePagcodigo == 0) {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCtePago].!");
                    }

                    //----------------------------------------------------------
                    //Insert CtaCtePagDatos.- (Solo es diferente de 1-Efectivo)
                    //----------------------------------------------------------
                    if (nForPago != 1)
                    {
                        BL_CtaCtePagDatos ObjPagDatos = new BL_CtaCtePagDatos();
                        exito = ObjPagDatos.Ins_CtaCtePagDatos(nCtaCtePagcodigo, cPerCodigoBanco, cDescrBanco, cNroTarjCta, dCtaCtePagfecha, NroTrasacVoucher, fCtaCtePagImporte);
                        if (!exito)
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCtePagDatos].!");
                        }
                    }
                    tx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        #endregion

        #region Registrar CtaCteComprobante / Medica.CtaCteNumeracion / AdmSolAtencion(nAdmSolEstado) / Upd CuentaCorriente

        //------------------------------------------------------------------------------------------------------------------
        // Insert CtaCteComprobante / Upd-Medica.CtaCteNumeracion / Upd-AdmSolAtencion(nAdmSolEstado) / Upd CuentaCorriente
        //------------------------------------------------------------------------------------------------------------------
        public bool Ins_CtaCteComprobante_Upd_AdmSolAtencion_Upd_CtaCteNumeracion(string cCtaCteRecibo, int nCtaCteComCodigo, string cCtaCteComNumero, int nCtaCteTipoPago, DateTime dCtaCteEmiFecha, string cPerJurCodigo, string nSolAdmNumero, int nAdmSolEstado, string cPerCodigoAut, int nCajCodigo)
        {
            bool exito = false;

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    //-------------------------
                    //Insert CtaCteComprobante 
                    //-------------------------
                    BL_CtaCteComprobante ObjComp = new BL_CtaCteComprobante();

                    if (!ObjComp.Ins_CtaCteComprobante(cCtaCteRecibo, nCtaCteComCodigo, cCtaCteComNumero, nCtaCteTipoPago, cPerCodigoAut, dCtaCteEmiFecha))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: CtaCteComprobante].!");
                    }

                    //-------------------------------------------
                    //Actualizando AdmSolAtencion (cCtaCteRecibo)
                    //-------------------------------------------
                    BL_FichaAtencion.BL_FichaAtencion Obj_UpdFichaAtencion = new BL_FichaAtencion.BL_FichaAtencion();

                    if (!Obj_UpdFichaAtencion.Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(cPerJurCodigo, nSolAdmNumero, cCtaCteRecibo, nAdmSolEstado, cPerCodigoAut))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero.!");
                    }
                    
                    //------------------------------------------
                    // Actualiza CuentaCorriente(cCtaCteRecibo)
                    //------------------------------------------
                    BL_CuentaCorriente ObjCC = new BL_CuentaCorriente();
                    if (!ObjCC.Upd_CuentaCorriente(cCtaCteRecibo, dCtaCteEmiFecha))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: BL-Upd_CuentaCorriente.!");
                    }

                    //-------------------------------------------
                    // Actualizar CtaCteNumeracion(nCtaCteNumero)
                    //-------------------------------------------
                    BL_CtaCteNumeracion blCCNumeracion = new BL_CtaCteNumeracion();

                    int value = cCtaCteComNumero.Length - 7;
                    string result = cCtaCteComNumero.Substring(value, 7);

                    long Numeracion = 0;
                    Numeracion = Convert.ToInt32(result);

                    if (!blCCNumeracion.Upd_CtaCteNumeracion_nCtaCteNumero(cPerJurCodigo, nCajCodigo, nCtaCteComCodigo, Numeracion))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteItem_nCtaCteImpAplicado].!");
                    }
                    else exito = true;

                    tx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        #endregion

    }
}
