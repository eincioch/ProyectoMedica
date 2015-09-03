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
    public class DA_BookElectronicoVta
    {
        //Get_CtasCtes_Get_LibroVentas_Electronico
        public DataTable Get_CtasCtes_Get_LibroVentas_Electronico(BE_ReqBookElectronicoVta Request)
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
                        cm.CommandText = "[usp_CtasCtes_Get_LibroVentas_Electronico]";
                        //cm.CommandTimeout = 0;
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("Year", Request.Year);
                        cm.Parameters.AddWithValue("Month", Request.Month);
                        cm.Parameters.AddWithValue("Empresa", Request.Empresa);
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
