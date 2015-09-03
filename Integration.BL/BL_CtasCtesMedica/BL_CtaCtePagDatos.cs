using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_CtaCtePagDatos
    {
        public bool Ins_CtaCtePagDatos(int nCtaCtePagcodigo, string cCtaCtePagDatPerJurCodigo, string cCtaCtePagDatBanco, string cCtaCtePagDatNroCuenta, DateTime dCtaCtePagDatFecha, string cCtaCtePagDatNroOperacion, double fCtaCtePagDatImporte)
        {
            bool exito = false;

            try
            {
                BE_ReqCtaCtePagDatos Request = new BE_ReqCtaCtePagDatos();
                DA_CtaCtePagDatos DAPagDatos = new DA_CtaCtePagDatos();

                Request.nCtaCtePagcodigo = nCtaCtePagcodigo;
                Request.cCtaCtePagDatPerJurCodigo = cCtaCtePagDatPerJurCodigo; //Cod. Entidad Bancaria (cPerCodigo)
                Request.cCtaCtePagDatBanco = cCtaCtePagDatBanco;  //Descripcion banco
                Request.cCtaCtePagDatNroCuenta = cCtaCtePagDatNroCuenta; //Nro. Tarjeta / Cuenta en la cual hizo el deposito
                Request.dCtaCtePagDatFecha = dCtaCtePagDatFecha;
                Request.cCtaCtePagDatNroOperacion = cCtaCtePagDatNroOperacion; // nro operacion y/o transaccion / voucher deposito
                Request.fCtaCtePagDatImporte = fCtaCtePagDatImporte;

                if (!DAPagDatos.Ins_CtaCtePagDatos(Request)){
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCtePagDatos].!");
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
