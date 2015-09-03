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
    public class BL_DocVigencia
    {
        //Store Procedure para Constante (Insert y Update)
        public bool InsDocVigencia(BE_ReqDocVigencia Request)
        {
            DA_DocVigencia Obj = new DA_DocVigencia(); 
            return Obj.InsDocVigencia(Request);
        }
    }
}
