using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtaCte
{
    public class DA_CtaCteItem
    {
        //--------------------------
        // INSERT CtaCteItem
        //--------------------------
        public string Ins_CtaCteItem(BE_ReqCtaCteItem Request)
        {
            //bool exito = false;
            string cCtaCteRecibo = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_CtaCteItem]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("cTipCtaCodigo", Request.cTipCtaCodigo);
                        cm.Parameters.AddWithValue("nYear", Request.nYear);
                        cm.Parameters.AddWithValue("nCtaCteImporte", Request.nCtaCteImporte);
                        cm.Parameters.AddWithValue("nCtaCteImpAplicado", Request.nCtaCteImpAplicado);
                        cm.Parameters.AddWithValue("dCtaCteFecRegistro", Request.dCtaCteFecRegistro);
                        cm.Parameters.AddWithValue("dCtaCteFecVence", Request.dCtaCteFecVence);
                        cm.Parameters.AddWithValue("nCtaCtePagCodigo", Request.nCtaCtePagCodigo);
                        cm.Parameters.AddWithValue("dCtaCteFecContabiliza", Request.dCtaCteFecContabiliza);
                        cm.Parameters.AddWithValue("nCtaCtePedCodigo", Request.nCtaCtePedCodigo);
                        cm.Parameters.AddWithValue("nCtaCteEstado", Request.nCtaCteEstado);
                        cm.Parameters.AddWithValue("dCtaCteLasModify", Request.dCtaCteLasModify);
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Connection = cn;

                        cCtaCteRecibo = Convert.ToString(cm.ExecuteScalar());
                        if (cCtaCteRecibo == null)
                        {
                            throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteItem]; Consulte al administrador del sistema");
                        }

                        //if (cm.ExecuteNonQuery() > 0)
                        //{
                        //    exito = true;
                        //}
                        //else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteItem]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return cCtaCteRecibo;
        }

        //para obtener correlativo SP: Get_NewCorrelativoRecCtaCteItem
        public string Get_NewCorrelativoRecCtaCteItem() 
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
                        cm.CommandText = "usp_Get_NewCorrelativoRecCtaCteItem";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cNewCorrelativo";
                        pCod.DbType = DbType.String;
                        pCod.Size = 15;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["cNewCorrelativo"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //----------------------------------------
        // UPDATE CtaCteItem (@nCtaCteImpAplicado)
        //----------------------------------------
        public bool Upd_CtaCteItem_nCtaCteImpAplicado(BE_ReqCtaCteItem Request)
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
                        cm.CommandText = "[usp_Upd_CtaCteItem_nCtaCteImpAplicado]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nCtaCteImpAplicado", Request.nCtaCteImpAplicado);
                        cm.Parameters.AddWithValue("cFlag", Request.cFlag);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_CtaCteItem_nCtaCteImpAplicado]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------------
        // SELECT CtaCteItem
        //--------------------------
        public DataTable Get_CtaCteItem(BE_ReqCtaCteItem Request)
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
                        cm.CommandText = "[usp_Get_CtaCteItem]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
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
