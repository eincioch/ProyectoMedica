using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE;
using Integration.BE.Documento;
using Integration.DAService.Documento ;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.Documento
{
    public class BL_GeneraNewIdcDocCodigo
    {
        public string Get_NewIdcDocCodigo(BE_GeneraNewIdcDocCodigo  Request)
        {
            DA_NewIdcDocCodigo Obj = new DA_NewIdcDocCodigo();
            return Obj.Get_NewIdcDocCodigo(Request);

        }
    }
}
