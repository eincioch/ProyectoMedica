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
    public class BL_CtaCtePago
    {
        //---------------
        //Ins_CtaCtePago
        //---------------
        public int Ins_CtaCtePago(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecAbono, long nCajCodigo, long nCtaCteComCodigo, string cCtaCteComNumero, string cPerUserCodigo, string cCtaCteObserv ="")
        {
            int nCtaCtePagCodigo = 0;

            BE_ReqCtaCtePago Request = new BE_ReqCtaCtePago();
            DA_CtaCtePago da = new DA_CtaCtePago();

            try
            {
                Request.cPerJurCodigo = cPerJurCodigo;
                Request.cPerCodigo = cPerCodigo;
                Request.cCtaCteRecAbono = cCtaCteRecAbono;
                Request.nCajCodigo = nCajCodigo;
                Request.nCtaCteComCodigo = nCtaCteComCodigo;
                Request.cCtaCteComNumero = cCtaCteComNumero;
                Request.cPerUseCodigo = cPerUserCodigo;
                Request.cCtaCteObserv = cCtaCteObserv;

                nCtaCtePagCodigo = da.Ins_CtaCtePago(Request);

                if (nCtaCtePagCodigo == 0)
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCtePago.!");
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nCtaCtePagCodigo;
        }
    }
}
