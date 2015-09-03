using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Persona;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_PerInterface
    {
        //----------------
        // PerInterface
        //----------------
        //INSERT
        public bool Ins_PerInterface(BE_ReqPerInterface Request)
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
                        cm.CommandText = "[usp_Ins_PerInterface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerIntCodigo", Request.nPerIntCodigo);
                        cm.Parameters.AddWithValue("nPerIntClase", Request.nPerIntClase);
                        cm.Parameters.AddWithValue("dPerIntFecha", Request.dPerIntFecha);
                        cm.Parameters.AddWithValue("cPerIntJerarquia", Request.cPerIntJerarquia);
                        cm.Parameters.AddWithValue("cPerIntDescripcion", Request.cPerIntDescripcion);
                        cm.Parameters.AddWithValue("nPerIntTipo", Request.nPerIntTipo);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerInterface]; Consulte al administrador del sistema");

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------
        // PerInterface
        //----------------
        //INSERT
        public bool Upd_PerInterface(BE_ReqPerInterface Request)
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
                        cm.CommandText = "[usp_Upd_PerInterface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerIntCodigo", Request.nPerIntCodigo);
                        cm.Parameters.AddWithValue("nPerIntClase", Request.nPerIntClase);
                        cm.Parameters.AddWithValue("cPerIntJerarquia", Request.cPerIntJerarquia);
                        cm.Parameters.AddWithValue("cPerIntDescripcion", Request.cPerIntDescripcion);
                        cm.Parameters.AddWithValue("nPerIntTipo", Request.nPerIntTipo);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_PerInterface]; Consulte al administrador del sistema");

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------------------------------------
        //Obtener PerInterface "Get_PerInterface"
        //--------------------------------------------------
        public DataTable Get_PerInterface()
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
                        cm.CommandText = "[usp_Get_PerInterface]";
                        cm.CommandType = CommandType.StoredProcedure;
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
