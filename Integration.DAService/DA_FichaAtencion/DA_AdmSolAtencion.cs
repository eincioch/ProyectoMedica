using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.FichaAtencion;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_FichaAtencion
{
    public class DA_AdmSolAtencion
    {
        //-----------------------
        // Insert AdmSolAtencion 2
        //-----------------------
        public bool Ins_AdmSolAtencion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_AdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("dFecExamen", Request.dFecExamen);
                        cm.Parameters.AddWithValue("nImpTotal", Request.nImpTotal);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_AdmSolAtencion]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------
        // Update AdmSolAtencion
        //-----------------------
        public bool Upd_AdmSolAtencion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Upd_AdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("dFecExamen", Request.dFecExamen);
                        cm.Parameters.AddWithValue("nImpTotal", Request.nImpTotal);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_AdmSolAtencion]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------------
        // Insert DetAdmSolAtencion
        //---------------------------
        public bool Ins_DetAdmSolAtencion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_DetAdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteCantidad", Request.nCtaCteCantidad);
                        cm.Parameters.AddWithValue("nCtaCteCosto", Request.nCtaCteCosto);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DetAdmSolAtencion]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------------
        // Delete DetAdmSolAtencion
        //---------------------------
        public bool Del_DetAdmSolAtencion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Del_DetAdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_DetAdmSolAtencion]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------------
        // Insert AdmSolDerivacion
        //---------------------------
        public bool Ins_AdmSolDerivacion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_AdmSolDerivacion]"; 
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigoDoctor", Request.cPerCodigoDoctor);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_AdmSolDerivacion]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }


        //---------------------------
        // Insert AdmSolAtenAutoriza
        //---------------------------
        public bool Ins_AdmSolAtenAutoriza(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_AdmSolAtenAutoriza]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigoAut", Request.cPerCodigoAut);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_AdmSolAtenAutoriza]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------------------------------
        //Obtener Nuevo Id correlativo for AddSolAtencion
        //-----------------------------------------------
        public string Get_NewId_AdmSolAtencion()
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
                        cm.CommandText = "[usp_Get_NewId_AdmSolAtencion]";
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

        //-------------------------
        //Get List AdmSolAtencion
        //------------------------
        public DataTable Get_List_AdmSolAtencion(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_List_AdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("Flag", Request.Flag);     
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("cPerApellidos", Request.cPerApellidos);
                        cm.Parameters.AddWithValue("dFecIni", Request.dFecIni);
                        cm.Parameters.AddWithValue("dFecFin", Request.dFecFin);

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

        //---------------------------
        //Get List DetAdmSolAtencion
        //--------------------------
        public DataTable Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
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

        //----------------------------------------------------------------------------
        //Get List DetAdmSolAtencion for cPerJuridica nSolAdmNumero nCtaCteSerCodigo
        //----------------------------------------------------------------------------
        public DataTable Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_nCtaCteSerCodigo(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_nCtaCteSerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);

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

        //-----------------------------------------------------
        // Update Adm Solicitud for_cPerJuridica_nSolAdmNumero
        //-----------------------------------------------------
        public bool Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nAdmSolEstado", Request.nAdmSolEstado);
                        cm.Parameters.AddWithValue("cPerUseCodUpd", Request.cPerCodigoAut);

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

        //--------------------------
        // Insert AdmSolDiagnostico
        //--------------------------
        public bool Ins_AdmSolDiagnostico(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_AdmSolDiagnostico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cDiagCodigo", Request.cDiagCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_AdmSolDiagnostico]; Consulte al administrador del sistema");
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
        // Delete AdmSolDiagnostico
        //--------------------------
        public bool Del_AdmSolDiagnostico(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Del_AdmSolDiagnostico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cDiagCodigo", Request.cDiagCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_AdmSolDiagnostico]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------------------------------------------------------------
        //Get List AdmSolDiagnostico for cPerJuridica nSolAdmNumero cDiagCodigo (CIE)
        //----------------------------------------------------------------------------
        public DataTable Get_AdmSolDiagnostico_for_cPerJuridica_nSolAdmNumero_cDiagCodigo(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_AdmSolDiagnostico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cDiagCodigo", Request.cDiagCodigo);

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

        //----------------------------------------------------------------------
        //Get List AdmSolDiagnostico for cPerJuridica, nIntCodigo, nSolAdmNumero
        //----------------------------------------------------------------------
        public DataTable Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Get_AdmSolDiagnostico_for_cPerJuridica_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
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

        //----------------------------
        // Insert AdmSolListaEmpleado
        //----------------------------
        public bool Ins_Upd_AdmSolListaEmpleado(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_Upd_AdmSolListaEmpleado]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_Upd_AdmSolListaEmpleado]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------------
        // Delete AdmSolListaEmpleado
        //----------------------------
        public bool Del_AdmSolListaEmpleado(BE_ReqSolAtencion Request)
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
                        cm.CommandText = "[usp_Del_AdmSolListaEmpleado]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_AdmSolListaEmpleado]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------------------------------------------------------------------------------
        //Get List AdmSolListaEmpleado for cPerJuridica, nIntCodigo, cPerCodigoTerceros, nSolAdmNumero
        //--------------------------------------------------------------------------------------------
        public DataTable Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(BE_ReqSolAtencion Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                long CerrarConexion = Obj.CerrarConexion();
               
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("cPerCodigoTerceros", Request.cPerCodigoTerceros);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }
            }
            catch (Exception Ex)
            {
                //throw;
                throw new Exception(Ex.Message, Ex);
            }
            return dt;
        }

        //--------------------------------------------------------------------------------------------
        //Get Cabecera AdmSolAtencion by cPerJuridica, nSolAdmNumero y cPercodigo
        //--------------------------------------------------------------------------------------------
        public DataTable Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(BE_ReqSolAtencion Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                long CerrarConexion = Obj.CerrarConexion();

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }
            }
            catch (Exception Ex)
            {
                //throw;
                throw new Exception(Ex.Message, Ex);
            }
            return dt;
        }

        //--------------------------------------------------------------------------------------------
        //Get Detalle AdmSolAtencion by cPerJuridica y nSolAdmNumero
        //--------------------------------------------------------------------------------------------
        public DataTable Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero(BE_ReqSolAtencion Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                long CerrarConexion = Obj.CerrarConexion();

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);

                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }
            }
            catch (Exception Ex)
            {
                //throw;
                throw new Exception(Ex.Message, Ex);
            }
            return dt;
        }
    }
}
