using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Documento;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.Documento
{
    public class DA_NewIdcDocCodigo
    {
        //----------------------------------
        //Generar cDocCodigo para Documentos
        //----------------------------------
        public string Get_NewIdcDocCodigo(BE_GeneraNewIdcDocCodigo  Request) 
        {
            string Item = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Get_NewIDDocumento";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cNewIdcDocCodigo";
                        pCod.DbType = DbType.String;
                        pCod.Size = 36;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["cNewIdcDocCodigo"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }
    }
}
