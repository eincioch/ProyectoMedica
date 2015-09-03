using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_PerParentesco
    {
        //----------------------
        // Insert PerParentesco
        //---------------------
        public bool Ins_PerParentesco(BE_ReqPerParentesco Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_PerParentesco]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Request.cPerParCodigo);
                        cm.Parameters.AddWithValue("nPerParTipo", Request.nPerParTipo);
                        cm.Parameters.AddWithValue("bPerApo", Request.bPerApo);
                        cm.Parameters.AddWithValue("bPerCarta", Request.bPerCarta);
                        cm.Parameters.AddWithValue("nPerParEstado", Request.nPerParEstado);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerParentesco]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------
        // Update PerParentesco
        //---------------------
        public bool Upd_PerParentesco(BE_ReqPerParentesco Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Upd_PerParentesco]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerParCodigo", Request.cPerParCodigo);
                        cm.Parameters.AddWithValue("nPerParTipo", Request.nPerParTipo);
                        cm.Parameters.AddWithValue("bPerApo", Request.bPerApo);
                        cm.Parameters.AddWithValue("bPerCarta", Request.bPerCarta);
                        cm.Parameters.AddWithValue("nPerParEstado", Request.nPerParEstado);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_PerParentesco]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------
        //Get Obtener Familiar
        //---------------------
        public DataTable Get_PerParentesco(BE_ReqPerParentesco Request)
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
                        cm.CommandText = "[usp_Get_PerParentesco]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
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
