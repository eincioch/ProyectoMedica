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
    public class BL_CtaCteItem
    {
        //--------------
        //Ins_CtaCteItem
        //--------------
        public string Ins_CtaCteItem(string cPerJurCodigo, string cPerCodigo, long nPrdCodigo, string cTipCtaCodigo, long nYear, double nCtaCteImporte, DateTime dCtaCteFecRegistro, long nCtaCteEstado, string cDocCodigo = null)
        {
            string cCtaCteRecibo = "";
            string NroRecibo="";

            //para CtaCteItem
            BE_ReqCtaCteItem ReqCCItem = new BE_ReqCtaCteItem();
            DA_CtaCteItem daCCItem = new DA_CtaCteItem();
            try
            {
                //para obtener correlativo SP: Get_NewCorrelativoRecCtaCteItem
                NroRecibo = daCCItem.Get_NewCorrelativoRecCtaCteItem();

                ReqCCItem.cPerJurCodigo = cPerJurCodigo;
                ReqCCItem.cPerCodigo = cPerCodigo;
                ReqCCItem.cCtaCteRecibo = NroRecibo;
                ReqCCItem.nPrdCodigo = nPrdCodigo;
                ReqCCItem.cTipCtaCodigo = cTipCtaCodigo; //' 1003 '-- INSCRIPCION COLEGATURA nCtaCteTipoCta
                ReqCCItem.nYear = nYear;
                ReqCCItem.nCtaCteImporte = nCtaCteImporte;
                ReqCCItem.nCtaCteImpAplicado = 0;
                ReqCCItem.dCtaCteFecRegistro = dCtaCteFecRegistro;
                ReqCCItem.dCtaCteFecVence = dCtaCteFecRegistro;
                ReqCCItem.nCtaCtePagCodigo = 0;
                ReqCCItem.dCtaCteFecContabiliza = "";
                ReqCCItem.nCtaCtePedCodigo = 0;
                ReqCCItem.nCtaCteEstado = nCtaCteEstado;  //1-Activo ; 0-Anulado
                ReqCCItem.cDocCodigo = cDocCodigo;
                ReqCCItem.dCtaCteLasModify = dCtaCteFecRegistro;

                cCtaCteRecibo = daCCItem.Ins_CtaCteItem(ReqCCItem);

                if (cCtaCteRecibo == null)
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: CtaCteItem.!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cCtaCteRecibo;
        }

        //Actualiza campo "nCtaCteImpAplicado" de CtaCteItem
        public bool Upd_CtaCteItem_nCtaCteImpAplicado(string cPerJurCodigo, string cCtaCteRecibo, double nCtaCteImpAplicado, string cFlag)
        {
            BE_ReqCtaCteItem Request = new BE_ReqCtaCteItem();
            DA_CtaCteItem Obj = new DA_CtaCteItem();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.cCtaCteRecibo = cCtaCteRecibo;
            Request.nCtaCteImpAplicado = nCtaCteImpAplicado;
            Request.cFlag = cFlag;

            return Obj.Upd_CtaCteItem_nCtaCteImpAplicado(Request);
        }

        //------------------
        //select CtaCteItem
        //------------------
        public DataTable Get_CtaCteItem(string cPerJurCodigo,string cCtaCteRecibo)
        {
            //Recuperando registros 
            BE_ReqCtaCteItem ReqCCItem = new BE_ReqCtaCteItem();
            DA_CtaCteItem daCCItem = new DA_CtaCteItem();

            ReqCCItem.cPerJurCodigo = cPerJurCodigo;
            ReqCCItem.cCtaCteRecibo = cCtaCteRecibo;

            return daCCItem.Get_CtaCteItem(ReqCCItem);

        } 
    }
}
