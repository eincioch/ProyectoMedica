using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class DA_CtaCteNumeracion
    {
        //---------------------------
        // Get NewId Recibo CtasCtes
        //---------------------------
        public string Get_NroRecibo_By_cPerJuridica_NewId(BE_ReqCtaCteNumeracion Request)
        {
            string NewRecibo = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_NroRecibo_By_cPerJuridica_NewId]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cNumeracion";
                        pCod.DbType = DbType.String;
                        pCod.Size = 15;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        NewRecibo = cm.Parameters["cNumeracion"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return NewRecibo;
        }
    }
}
