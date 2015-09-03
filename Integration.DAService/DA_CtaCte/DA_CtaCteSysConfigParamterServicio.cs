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
    public class DA_CtaCteSysConfigParamterServicio
    {
        //------------------------------
        // INSERT SysConfParametrosServ
        //------------------------------
        public bool  Ins_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
        {
            bool exito;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Ins_SysConfParametrosServ";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nSisModulo", Request.nSisModulo);
                        cm.Parameters.AddWithValue("nParCodigo_nProCodigo", Request.nParCodigo_nProCodigo);
                        cm.Parameters.AddWithValue("nParCodigo_nSolAdmTipo", Request.nParCodigo_nSolAdmTipo);
                        cm.Parameters.AddWithValue("nParCodigo_nCtaCteSerCodigo", Request.nParCodigo_nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nSysValor", Request.nSysValor);
                        cm.Parameters.AddWithValue("nSysEstado", Request.nSysEstado);
                        cm.Connection = cn;

                        //ExecuteNonQuery.- devuelve filas afectadas cuando sea mayor a 0 todo fue OK.
                        if (cm.ExecuteNonQuery() > 0) 
                        {
                            exito = true;
                        }
                        else exito = false;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------------------
        // Update SysConfParametrosServ
        //------------------------------
        public bool Upd_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
        {
            bool exito;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "usp_Upd_SysConfParametrosServ";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nSisModulo", Request.nSisModulo);
                        cm.Parameters.AddWithValue("nParCodigo_nProCodigo", Request.nParCodigo_nProCodigo);
                        cm.Parameters.AddWithValue("nParCodigo_nSolAdmTipo", Request.nParCodigo_nSolAdmTipo);
                        cm.Parameters.AddWithValue("nParCodigo_nCtaCteSerCodigo", Request.nParCodigo_nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nSysValor", Request.nSysValor);
                        cm.Parameters.AddWithValue("nSysEstado", Request.nSysEstado);
                        cm.Connection = cn;

                        //ExecuteNonQuery.- devuelve filas afectadas cuando sea mayor a 0 todo fue OK.
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else exito = false;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        //-----------------------------
        // SELECT SysConfParametrosServ
        //-----------------------------
        public DataTable Get_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
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
                        cm.CommandText = "[usp_Get_SysConfParametrosServ]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nSisModulo", Request.nSisModulo);
                        cm.Parameters.AddWithValue("nParCodigo_nProCodigo", Request.nParCodigo_nProCodigo);
                        cm.Parameters.AddWithValue("cFlag", Request.cFLag);
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
