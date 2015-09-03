using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Interface;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_Interface
    {
        //------------------
        // Insert: Interface
        //------------------
        public BE_ResGenerico InsInterface(BE_ReqInterface Request)
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
                        cm.CommandText = "[usp_Ins_Interface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        //cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
                        cm.Parameters.AddWithValue("cIntNombre", Request.cIntNombre);
                        cm.Parameters.AddWithValue("cIntDescripcion", Request.cIntDescripcion);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
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

        //-------------------
        // Update: Interface
        //-------------------
        public BE_ResGenerico UpdInterface(BE_ReqInterface Request)
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
                        cm.CommandText = "[usp_Upd_Interface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
                        cm.Parameters.AddWithValue("cIntNombre", Request.cIntNombre);
                        cm.Parameters.AddWithValue("cIntDescripcion", Request.cIntDescripcion);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
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

        //-----------------------------------------------
        // Select: Interface por (nIntClase and nIntTipo)
        //-----------------------------------------------
        public DataTable Get_Interface(BE_ReqInterface Request)
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
                        cm.CommandText = "[usp_Get_Interface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Parameters.AddWithValue("cFlag", Request.cFlag);
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

        //------------------------------------------------------------------
        // Select: Interface por (nIntClase AND nIntTipo AND cIntJerarquia )
        //------------------------------------------------------------------
        public DataTable Get_Interface_and_cIntJerarquia(BE_ReqInterface Request)
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
                        cm.CommandText = "usp_Get_Interface_AND_cIntJerarquia";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);
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

        //-----------------------------------------------
        // en SqlDataReader: Interface por (nIntClase and nIntTipo)
        //-----------------------------------------------
        public DataTable Get_Interface_DataTable(BE_ReqInterface Request)
        {
            DataTable dt = new DataTable() ;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Get_Interface";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Connection = cn;
                        dt.Load(cm.ExecuteReader());

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public IList<BE_Res_Interface> Get_InterfaceDR(BE_ReqInterface Request)
        {
            BE_Res_Interface Item = new BE_Res_Interface();
            var lista = new List<BE_Res_Interface>();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Get_Interface";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            lista.Clear();
                            while (dr.Read())
                            {
                                Item = new BE_Res_Interface();
                                Item.nIntClase = dr.GetInt32(dr.GetOrdinal("nIntClase"));
                                Item.nIntCodigo = dr.GetInt32(dr.GetOrdinal("nIntCodigo"));
                                Item.nIntTipo = dr.GetInt32(dr.GetOrdinal("nIntTipo"));
                                Item.cIntDescripcion = dr.GetString(dr.GetOrdinal("cIntDescripcion")).Trim();
                                Item.cIntJerarquia = dr.GetString(dr.GetOrdinal("cIntJerarquia")).Trim();
                                Item.cIntNombre = dr.GetString(dr.GetOrdinal("cIntNombre")).Trim();
                                lista.Add(Item);
                            }
                            dr.Close();
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        //Obtener correlativo cIntJerarquia para la Tabla [Interface]
        public string Get_NewIdcIntJerarquia(BE_ReqInterface Request) //BE_ReqSolCorrelativo Request)
        {
            string nNewId = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Get_NewIdcIntJerarquia";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nNewId";
                        pCod.DbType = DbType.String;
                        pCod.Size = 25;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        nNewId = cm.Parameters["nNewId"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nNewId;
        }


        //------------------------------------------------------------------
        // Select: Interface por (nIntClase and nIntCodigo) - Configuracion
        //------------------------------------------------------------------
        public string Get_Interface_CFG(BE_Req_Interface Request)
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
                        cm.CommandText = "[usp_Get_Interface_CFG]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cIntNombre";
                        pCod.DbType =  DbType.String  ;
                        pCod.Size = 200;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["cIntNombre"].Value.ToString();
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
