using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_PerParentesco
    {
        //--------------------
        //Insert PerParentesco
        //--------------------
        public bool Ins_PerParentesco(BE_ReqPerParentesco Request)
        {
            DA_PerParentesco Obj = new DA_PerParentesco();
            return Obj.Ins_PerParentesco(Request);
        }

        //--------------------
        //Update PerParentesco
        //--------------------
        public bool Upd_PerParentesco(BE_ReqPerParentesco Request)
        {
            DA_PerParentesco Obj = new DA_PerParentesco();
            return Obj.Upd_PerParentesco(Request);
        }

        //---------------------
        //Get Obtener Familiar
        //---------------------
        public DataTable Get_PerParentesco(BE_ReqPerParentesco Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_PerParentesco Obj = new DA_PerParentesco();
            return Obj.Get_PerParentesco(Request);

        }

        
    }
}
