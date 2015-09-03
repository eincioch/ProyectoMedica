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
    public class BL_CtaCteComprobante
    {
        public bool Ins_CtaCteComprobante(string cCtaCteRecibo, int nCtaCteComCodigo, string cCtaCteComNumero, int nCtaCteTipoPago, string cPerCodigo, DateTime dCtaCteEmiFecha)
        {
            bool exito = false;

            try
            {
                BE_ReqCtaCteComprobante Request = new BE_ReqCtaCteComprobante();
                Da_CtaCteComprobante ObjComprobante = new Da_CtaCteComprobante();

                Request.cCtaCteRecibo = cCtaCteRecibo;
                Request.nCtaCteComCodigo = nCtaCteComCodigo;
                Request.cCtaCteComNumero = cCtaCteComNumero;
                Request.nCtaCteTipoPago = nCtaCteTipoPago; //Al Contado / Credito
                Request.cPerCodigo = cPerCodigo;
                Request.dCtaCteEmiFecha = dCtaCteEmiFecha;

                if (!ObjComprobante.Ins_CtaCteComprobante(Request))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteComprobante].!");
                }
                else
                {
                    exito = true;
                }

                //exito = ObjComprobante.Ins_CtaCteComprobante(Request);
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
