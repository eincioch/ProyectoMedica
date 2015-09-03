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
    public class DA_EstadoCuentaCole
    {
        public DataTable Get_EstadoCuentaCole(BE_ReqEstadoCuentaCole Request)
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
                        cm.CommandText = "[usp_Get_EstadoCuentaCole]";
                        cm.CommandTimeout = 0;
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cperideNumero", Request.cperideNumero);
                        cm.Parameters.AddWithValue("nintCodigo", Request.nintCodigo);
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
