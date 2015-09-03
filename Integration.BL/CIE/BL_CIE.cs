using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CIE;
using Integration.DAService.CIE;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.CIE
{
    public class BL_CIE
    {
        //------------------------
        //select DIAGNOSTICO_CIE10
        //------------------------
        public DataTable Get_Diagnostico_CIE10(int nFlag, string cDiagCodigo="", string cDiagGrupo="", string cDiagDescripcion = "")
        {
            BE_ReqCIE Request = new BE_ReqCIE();
            DA_CIE Obj = new DA_CIE();

            Request.nFlag = nFlag;
            Request.cDiagCodigo = cDiagCodigo;
            Request.cDiagGrupo = cDiagGrupo;
            Request.cDiagDescripcion = cDiagDescripcion;

            return Obj.Get_Diagnostico_CIE10(Request);
        }
    }
}
