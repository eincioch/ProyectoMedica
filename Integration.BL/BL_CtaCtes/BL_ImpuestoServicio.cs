using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.BE;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_ImpuestoServicio
    {
        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_ImpuestoServicio(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo,long nCtaCteSerCodigo, long nSysTasContry)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            BE_ReqImpuestoServicio Request =  new BE_ReqImpuestoServicio();
            DA_ImpuestoServicio DA = new DA_ImpuestoServicio();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.cPerCodigo=cPerCodigo;
            Request.cCtaCteRecibo=cCtaCteRecibo;
            Request.nCtaCteSerCodigo = nCtaCteSerCodigo;
            Request.nSysTasContry=nSysTasContry;

            return DA.Get_ImpuestoServicio(Request);

        }

        //------------------------------------------
        //select Get_Calc_Impuesto_for_cCtaCteRecibo
        //-------------------------------------------
        public DataTable Get_Calc_Impuesto_for_cCtaCteRecibo(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            BE_ReqCalcImpuestoforRecibo Request = new BE_ReqCalcImpuestoforRecibo();
            DA_ImpuestoServicio DA = new DA_ImpuestoServicio();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.cPerCodigo = cPerCodigo;
            Request.cCtaCteRecibo = cCtaCteRecibo;

            return DA.Get_Calc_Impuesto_for_cCtaCteRecibo(Request);

        }
    }
}
