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
    public class BL_DocIdentifica
    {
        //Store Procedure para Constante (Insert y Update)
        public bool InsDocIdentifica(BE_ReqDocIdentifica Request)
        {
            DA_DocIdentifica Obj = new DA_DocIdentifica();
            return Obj.InsDocIdentifica(Request);
        }
    }
}
