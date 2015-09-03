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

//Medica
namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCtePrecioServicio
    {
        //---------------------------
        //Insert CtaCtePrecioServicio
        //---------------------------
        public BE_ResGenerico Ins_CtaCtePrecioServicio(BE_ReqCtaCtePrecioServicio Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_CtaCtePrecioServicio Obj = new DA_CtaCtePrecioServicio();
            Item = Obj.Ins_CtaCtePrecioServicio(Request);
            return Item;
        }

        //------------------------------
        //Select CtaCtePrecioServicio
        //------------------------------
        public DataTable Get_CtaCtePrecioServicio(BE_ReqCtaCtePrecioServicio Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCtePrecioServicio Obj = new DA_CtaCtePrecioServicio();
            return Obj.Get_CtaCtePrecioServicio(Request);

        }

        //------------------------
        //Select Lista Servicios
        //------------------------
        public DataTable Get_List_CtaCteServicio(BE_ReqCtaCtePrecioServicio Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCtePrecioServicio Obj = new DA_CtaCtePrecioServicio();
            return Obj.Get_List_CtaCteServicio(Request);

        }
    }
}
