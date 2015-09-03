using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Constante;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_Constante
    {
        
        public DataTable Get_Constante(BE_ReqConstante  Request)
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
                        cm.CommandText = "[usp_Get_Constante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("flag", Request.flag);
                        cm.Parameters.AddWithValue("nConCodigo", Request.nConCodigo);
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

        public BE_ResGenerico ExecInsUpdConstante(BE_ReqInsUpdConstante Request)
        {
            BE_ResGenerico Item = new BE_ResGenerico();
            long Resultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_InsUpd_Contante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("flag", Request.flag);
                        cm.Parameters.AddWithValue("nConCodigo", Request.nConCodigo);
                        cm.Parameters.AddWithValue("cConDescripcion", Request.cConDescripcion);
                        cm.Parameters.AddWithValue("nConValor", Request.nConValor);
                        cm.Connection = cn;
                        Resultado = cm.ExecuteNonQuery();
                        Item.Resultado = Resultado;
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
