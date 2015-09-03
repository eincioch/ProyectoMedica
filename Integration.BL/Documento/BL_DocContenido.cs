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
    public class BL_DocContenido
    {
        //Store Procedure para Constante (Insert y Update)
        public bool InsDocContenido(BE_ReqDocContenido Request)
        {
            DA_DocContenido Obj = new DA_DocContenido();
            return Obj.InsDocContenido(Request); ;
        }
    }
}
