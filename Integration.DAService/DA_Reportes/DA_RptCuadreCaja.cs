using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Reportes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Reportes
{
    public class DA_RptCuadreCaja
    {
        //----------------------------
        // SELECT Get_ReportCuadraCaja
        //----------------------------
        public DataTable Get_ReportCuadraCaja(BE_ReqRptCuadreCaja Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_CuadreCaja_by_cPerJurCodigo_nTurno_fecini_fecfin]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nTurno", Request.nTurno);
                        cm.Parameters.AddWithValue("fecini", Request.dCtaCteComFecIni);
                        cm.Parameters.AddWithValue("fecfin", Request.dCtaCteComFecFin);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
