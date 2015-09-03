
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Solicitud;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_Solicitud
    {
        //Obtiene correlativo Solicitud
        public string Get_Correlativo_Sol(BE_ReqSolCorrelativo Request)  
        {
           string  Item = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Persona_Get_NewId]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerCodigo );
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Item = dr.GetString(dr.GetOrdinal("NewCodigo")).Trim();
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //Obtener Codigo Colegiado nuevo
        public string Get_NewIdColegiado() //BE_ReqSolCorrelativo Request)
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
                        cm.CommandText = "usp_Get_NewIdColegiado";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "NewIdColegiado";
                        pCod.DbType =  DbType.String  ;
                        pCod.Size = 25;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["NewIdColegiado"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        // Insert Solicitud Colegiado
        public bool RegistrarSolictud(BE_ReqSolRegistro Request)
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
                    cm.CommandText = "usp_Ins_AdmSolicitud";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("cPerJuridica",Request.cPerJuridica);
                    cm.Parameters.AddWithValue("nProCodigo",Request.nProCodigo);
                    cm.Parameters.AddWithValue("nSolAdmNumero",Request.nSolAdmNumero);
                    cm.Parameters.AddWithValue("cPerCodigo",Request.cPerCodigo);
                    cm.Parameters.AddWithValue("nPerAdmEstado",Request.nPerAdmEstado);
                    cm.Parameters.AddWithValue("dPerAdmRegistro",Request.dPerAdmRegistro);
                    cm.Parameters.AddWithValue("nPrdCodigo",Request.nPrdCodigo);
                    cm.Parameters.AddWithValue("cPerJurCodigo",Request.cPerJurCodigo);
                    cm.Parameters.AddWithValue("dAdmSolAcaFecEgreso",Request.dAdmSolAcaFecEgreso);
                    cm.Parameters.AddWithValue("nAdmSolEspCodigo",Request.nAdmSolEspCodigo);
                    cm.Parameters.AddWithValue("nSolAdmEstado", Request.nSolAdmEstado);
                    cm.Parameters.AddWithValue("nSolAdmTipo", Request.nSolAdmTipo);
                    cm.Connection = cn;
                    if (cm.ExecuteNonQuery() > 0)
                    {
                        exito = true;
                    }
                    else exito = false;

                    //Resultado= cm.ExecuteNonQuery();
                    //Item.Resultado=Resultado;
                }
             }

        }
        catch (Exception )
        {
            throw ;
        }
            return exito;
        }

        //---------------------------------
        //Buscar AdmSolicitud - para grilla
        //----------------------------------
        public DataTable Get_AdmSolicitud(BE_ReqBuscaAdmSolicitud Request)
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
                        cm.CommandText = "usp_Get_AdmSolicitud";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("fec_ini", Request.fec_ini);
                        cm.Parameters.AddWithValue("fec_fin", Request.fec_fin);
                        cm.Parameters.AddWithValue("Condicion", Request.Condicion);
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

        //-------------------------------------
        //Buscar AdmSolicitud - para actualizar
        //--------------------------------------
        public DataTable Get_AdmSolicitudAcademica(BE_ReqSolRegistro Request)
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
                        cm.CommandText = "usp_Get_AdmSolicitudAcademica";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
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

        //-----------------------
        //Insert AtenderSolicitud
        //-----------------------
        public BE_ResGenerico InsAtenderSolicitud(BE_ReqAtenderSolicitud Request)
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
                        cm.CommandText = "usp_Ins_AtenderSolicitud";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nProCodigo", Request.nProCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("nPerTipo", Request.nPerTipo);
                        //cm.Parameters.AddWithValue("nSolAdmPrograma", Request.nSolAdmPrograma);
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
        //Get_FichaIndividual
        //-------------------
        public DataTable Get_FichaIndividual(BE_ReqSolFichaIndividual Request)
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
                        cm.CommandText = "usp_Get_FichaIndividual";
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
        
        //----------------------------------
        //Update Solicitud - AdmSolAcademica
        //----------------------------------
        public bool Upd_AdmSolicitudAcademica(BE_ReqSolRegistro Request)
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
                        cm.CommandText = "usp_UpdAdmSolicitudAcademica";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nProCodigo", Request.nProCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("dAdmSolAcaFecEgreso", Request.dAdmSolAcaFecEgreso);
                        cm.Parameters.AddWithValue("nAdmSolEspCodigo", Request.nAdmSolEspCodigo);
                        cm.Connection = cn;

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

        //----------------------------------
        //Update "Upd_AdmSol_cCtaCteRecibo"
        //----------------------------------
        public bool Upd_AdmSol_cCtaCteRecibo(BE_ReqUpd_AdmSol_cCtaCteRecibo Request)
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
                        cm.CommandText = "usp_Upd_AdmSol_cCtaCteRecibo";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nProCodigo", Request.nProCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Connection = cn;

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
    }
}
