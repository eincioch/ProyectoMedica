using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE;
using Integration.BE.Documento;
using Integration.DAService.Documento;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.Documento
{
    public class BL_DocFecTramite
    {
        //Store Procedure para Constante (Insert y Update)
        public bool InsDocFecTramite(BE_ReqDocFecTramite Request)
        {
            DA_DocFecTramite Obj = new DA_DocFecTramite();
            return Obj.InsDocFecTramite(Request);
        }
    }
}
