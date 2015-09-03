using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Integration.BE.PerUsuGruAcc;
using Integration.BE.Interface;
using Integration.Conection;

namespace Integration.DAService
{
    public class DAPerUsuGruAcc
    {
        public IList<BE_Res_PerUsuGruAcc> ObtenerPermisos(BE_Req_PerUsuGruAcc Request)
        {
            BE_Res_PerUsuGruAcc Item = new BE_Res_PerUsuGruAcc();
            var lista = new List<BE_Res_PerUsuGruAcc>();

            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "spTD_Obtener_Permisos";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nSisGruTipo", Request.nSisGruTipo);
                        cm.Parameters.AddWithValue("nObjTipo", Request.nObjTipo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            lista.Clear();
                            while (dr.Read())
                            {
                                Item = new BE_Res_PerUsuGruAcc();
                                Item.cPerCodigo = dr.GetString(dr.GetOrdinal("cPerCodigo")).Trim();
                                Item.cIntNombre = dr.GetString(dr.GetOrdinal("cIntNombre")).Trim();
                                lista.Add(Item);
                                //dr.NextResult();
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


        public IList<BE_Res_Interface> ObtenerPermisosMenu(BE_Req_PermisosMenu Request)
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
                        cm.CommandText = "usp_General_Get_PermisosMenu_By_Modulo_Per";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cModulo", Request.cModulo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            lista.Clear();
                            while (dr.Read())
                            {
                                Item = new BE_Res_Interface();
                                Item.cIntJerarquia = dr.GetString(dr.GetOrdinal("cIntJerarquia")).Trim();
                                Item.cIntNombre = dr.GetString(dr.GetOrdinal("cIntNombre")).Trim();
                                Item.cIntDescripcion = dr.GetString(dr.GetOrdinal("cIntDescripcion")).Trim();
                                Item.nIntTipo = dr.GetInt32(dr.GetOrdinal("nIntTipo"));

                                lista.Add(Item);
                                //dr.NextResult();
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
        


    }
}
