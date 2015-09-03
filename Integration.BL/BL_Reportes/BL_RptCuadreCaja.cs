using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Reportes;
using Integration.DAService.DA_Reportes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_Reportes
{
    public class BL_RptCuadreCaja
    {
        //------------------------
        //select CtaCteComprobante
        //------------------------
        public DataTable Get_ReportCuadraCaja(string cPerJurCodigo, int nTurno, DateTime dCtaCteComFecIni, DateTime dCtaCteComFecFin)
        {
            //Recuperando...
            BE_ReqRptCuadreCaja Request = new BE_ReqRptCuadreCaja();
            DA_RptCuadreCaja Obj = new DA_RptCuadreCaja();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.nTurno = nTurno;
            Request.dCtaCteComFecIni = dCtaCteComFecIni;
            Request.dCtaCteComFecFin = dCtaCteComFecFin;
            
            return Obj.Get_ReportCuadraCaja(Request);

        }
    }
}
