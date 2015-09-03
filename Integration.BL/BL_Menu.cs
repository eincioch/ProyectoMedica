using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Menu;
using Integration.BL;
using Integration.DAService;
using System.Data;
using System.Data.Sql;

namespace Integration.BL
{
    public class BL_Menu
    {
        public DataTable GetMenu_By_Persona_Clase(BE_ReqMenu Request)
        {
            DA_Menu ObjMenu = new DA_Menu();
            return ObjMenu.GetMenu_By_Persona_Clase(Request);
        }
    }
}
