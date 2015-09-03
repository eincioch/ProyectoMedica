using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CIE;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.CIE
{
    public class DA_CIE
    {
        public DataTable Get_Diagnostico_CIE10(BE_ReqCIE Request)
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
                        cm.CommandText = "[usp_Get_Diagnostico_CIE10]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
                        cm.Parameters.AddWithValue("cDiagCodigo", Request.cDiagCodigo);
                        cm.Parameters.AddWithValue("cDiagGrupo", Request.cDiagGrupo);
                        cm.Parameters.AddWithValue("cDiagDescripcion", Request.cDiagDescripcion);

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
