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
    public class DA_RptconColegiado
    {
        //----------------------------------------
        // SELECT usp_Get_RptVarios_for_Colegiado
        //---------------------------------------
        public DataTable usp_Get_RptVarios_for_Colegiado(BE_ReqRptColegiado Request)
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
                        cm.CommandText = "[usp_Get_RptVarios_for_Colegiado]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cNameRpt ", Request.cNameRpt);
                        cm.Parameters.AddWithValue("dFecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.dFecFin);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("cEstado ", Request.cEstado);
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
