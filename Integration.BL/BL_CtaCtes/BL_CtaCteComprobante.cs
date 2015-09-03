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
    public class BL_CtaCteComprobante
    {
        //---------------------
        //Ins_CtaCteComprobante
        //---------------------
        public bool Ins_CtaCteComprobante(string cPerJurCodigo, string cPerCodigo,string cCtaCteRecAbono, long nCajCodigo,long nCtaCteComCodigo,string cCtaCteComNumero,DateTime dCtaCteComFecEmision,double nCtaCteComImporte,string cPerUserCodigo)
        {
            bool exito=false;
            //para CtaCteComprobante
            BE_ReqCtaCteComprobante ReqCCComprobante = new BE_ReqCtaCteComprobante();
            DA_CtaCteComprobante daCCComprobante = new DA_CtaCteComprobante();

            try
            {
                ReqCCComprobante.cPerJurCodigo = cPerJurCodigo;
                ReqCCComprobante.cPerCodigo = cPerCodigo;
                ReqCCComprobante.cCtaCteRecAbono = cCtaCteRecAbono;
                ReqCCComprobante.nCajCodigo = nCajCodigo;
                ReqCCComprobante.nCtaCteComCodigo = nCtaCteComCodigo; 
                ReqCCComprobante.cCtaCteComNumero = cCtaCteComNumero;
                ReqCCComprobante.dCtaCteComFecEmision = dCtaCteComFecEmision;
                ReqCCComprobante.nCtaCteComImporte = nCtaCteComImporte;
                ReqCCComprobante.cPerUserCodigo = cPerUserCodigo;

                if (!daCCComprobante.Ins_CtaCteComprobante(ReqCCComprobante))
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

        //------------------------
        //select CtaCteComprobante
        //------------------------
        public DataTable Get_CtaCteComprobante(string cPerJurCodigo,string cPerCodigo, long nCtaCteComCodigo, string cCtaCteComNumero)
        {
            BE_Req_Get_CtaCteComprobante Request = new BE_Req_Get_CtaCteComprobante();
            DA_CtaCteComprobante Obj = new DA_CtaCteComprobante();

            Request.cPerJurCodigo  = cPerJurCodigo;
            Request.cPerCodigo = cPerCodigo;
            Request.nCtaCteComCodigo = nCtaCteComCodigo;
            Request.cCtaCteComNumero = cCtaCteComNumero;

            return Obj.Get_CtaCteComprobante(Request);

        }
    }
}
