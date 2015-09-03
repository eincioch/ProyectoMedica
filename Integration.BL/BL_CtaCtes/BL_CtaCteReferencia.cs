using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.DAService;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCteReferencia
    {
        //--------------------
        //Ins_CtaCteReferencia
        //--------------------
        public bool Ins_CtaCteReferencia(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecCargo,string cCtaCteRecAbono, long nCtaCtePagCodigo,  double nCtaCteLinImporte, string cDocCodigo, DateTime dCtaCteFecRegistro)
        {
            bool exito = false;
            BE_ReqCtaCteReferencia ReqCCRefe = new BE_ReqCtaCteReferencia();
            DA_CtaCteReferencia daCCRefe = new DA_CtaCteReferencia();

            try
            {
                ReqCCRefe.cPerJurCodigo = cPerJurCodigo;
                ReqCCRefe.cPerCodigo = cPerCodigo;
                ReqCCRefe.cCtaCteRecCargo = cCtaCteRecCargo;
                ReqCCRefe.cCtaCteRecAbono = cCtaCteRecAbono;
                ReqCCRefe.nCtaCtePagCodigo = nCtaCtePagCodigo;
                ReqCCRefe.nCtaCtePagImporte = nCtaCteLinImporte;
                ReqCCRefe.cDocCodigo = cDocCodigo;
                ReqCCRefe.dCtaCteFecRegistro = dCtaCteFecRegistro;

                if (!daCCRefe.Ins_CtaCteReferencia(ReqCCRefe))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteReferencia.!");
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
