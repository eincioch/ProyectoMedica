using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_AnularComprobante
    {
        //------------------------------
        // Get Comprobante(s) de venta
        //-------------------------------
        public DataTable Get_Comprobante_Venta_by_cPerJurCodigo_nCtaCteComCodigo_cCtaCteComNumero(string cPerJurCodigo, long nCtaCteComCodigo, string cCtaCteComNumero, DateTime dFecIni, DateTime dFecFin, string cFlag)
        {
            BE_ReqBuscaComprobante Request = new BE_ReqBuscaComprobante();
            DA_AnularComprobante da = new DA_AnularComprobante();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.nCtaCteComCodigo = nCtaCteComCodigo;
            Request.cCtaCteComNumero = cCtaCteComNumero;
            Request.dFecIni = dFecIni;
            Request.dFecFin = dFecFin;
            Request.cFlag = cFlag;

            return da.Get_Comprobante_Venta_by_cPerJurCodigo_nCtaCteComCodigo_cCtaCteComNumero(Request);

        }

        //---------------------
        //Set_AnularComprobante
        //---------------------
        public bool Set_AnularComprobante(string cflag, string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo,string cCtaCteRecAbono, string cPerUserCodigo="")
        {
            bool exito = false;

            BE_AnularComprobante Request = new BE_AnularComprobante();
            DA_AnularComprobante da = new DA_AnularComprobante();

            try
            {
                Request.cflag = cflag;
                Request.cPerJurCodigo = cPerJurCodigo;
                Request.cPerCodigo = cPerCodigo;
                Request.cCtaCteRecibo = cCtaCteRecibo;
                Request.cCtaCteRecAbono = cCtaCteRecAbono;
                Request.cPerUserCodigo = cPerUserCodigo;

                if (!da.Set_AnularComprobante(Request))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: CtaCteComprobante.!");
                }
                else exito = true;
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
