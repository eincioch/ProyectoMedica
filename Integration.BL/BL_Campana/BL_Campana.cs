using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Campana;
using Integration.DAService.DA_Campana;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Campana
{
    public class BL_Campana
    {
        //Genera nuevo Codigo nIntCamp
        public string Get_NewId_nIntCampana(BE_ReqCampana Request) 
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_NewId_nIntCampana(Request);

        }

        //Insert Campana
        public bool Ins_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Ins_Campana(Request);
        }

        //Update Campana
        public bool Upd_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Upd_Campana(Request);
        }

        //Insert Detalle Campana
        public bool Ins_DetalleCampana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Ins_DetalleCampana(Request);
        }
 
        //Update Detalle Campana
        public bool Upd_DetalleCampana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Upd_DetalleCampana(Request);
        }

        //Delete Item Detalle Campana
        public bool Del_DetalleCampana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Del_DetalleCampana(Request);
        }

        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_List_Campana(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_List_Campana(Request);
        }

        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_Servicios_for_nIntCamp(BE_ReqCampana Request)
        {
            DA_Campana Obj = new DA_Campana();
            return Obj.Get_Servicios_for_nIntCamp(Request);
        }
    }
}
