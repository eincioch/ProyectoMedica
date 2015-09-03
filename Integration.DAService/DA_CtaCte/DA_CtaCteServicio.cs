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
    public class DA_CtaCteServicio
    {
        //--------------------------------------
        // INSERT CtaCteServicio Upd-31/10/2013
        //-------------------------------------
        public bool Ins_CtaCteServicio(BE_ReqCtaCteServicio Request)
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
                        cm.CommandText = "[usp_Ins_CtaCtaServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteSerJerarquia", Request.cCtaCteSerJerarquia);
                        cm.Parameters.AddWithValue("cCtaCteSerKeyWord", Request.cCtaCteSerKeyWord);
                        cm.Parameters.AddWithValue("nBieCodigo", Request.nBieCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerAfecto", Request.nCtaCteSerAfecto);
                        cm.Parameters.AddWithValue("nCtaCteSerExonerado", Request.nCtaCteSerExonerado);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerImpMin", Request.nCtaCteSerImpMin);
                        cm.Parameters.AddWithValue("nCtaCteSerImpMax", Request.nCtaCteSerImpMax);
                        cm.Parameters.AddWithValue("nCtaCteSerImpDef", Request.nCtaCteSerImpDef);
                        cm.Parameters.AddWithValue("nSeuCodigo", Request.nSeuCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerFacturable", Request.nCtaCteSerFacturable);
                        cm.Parameters.AddWithValue("nCtaCteTipoCta", Request.nCtaCteTipoCta);
                        cm.Parameters.AddWithValue("nCtaAlterna", Request.nCtaAlterna);
                        //update 13/08/2015 - eincio
                        cm.Parameters.AddWithValue("cRequisitoIndica", Request.cRequisitoIndica);
                        cm.Parameters.AddWithValue("cPreparaPaciente", Request.cPreparaPaciente);
                        cm.Parameters.AddWithValue("cIdentificaMuestra", Request.cIdentificaMuestra);
                        cm.Parameters.AddWithValue("cEntregaResultado", Request.cEntregaResultado);
                        cm.Parameters.AddWithValue("cRecepcionMuestra", Request.cRecepcionMuestra);
                        cm.Parameters.AddWithValue("cConservaTransporte", Request.cConservaTransporte);
                        cm.Parameters.AddWithValue("cEstabilidadMuestra", Request.cEstabilidadMuestra);

                        cm.Parameters.AddWithValue("nCantMuestra", Request.nCantMuestra);
                        //update 13/08/2015 - eincio
                        cm.Parameters.AddWithValue("nCodEnvase", Request.nCodEnvase);
                        cm.Parameters.AddWithValue("nCodTipoMuestra", Request.nCodTipoMuestra);
                        cm.Parameters.AddWithValue("cVolumMinimo", Request.cVolumMinimo);
                        cm.Parameters.AddWithValue("cDiaHoraProceso", Request.cDiaHoraProceso);

                        cm.Parameters.AddWithValue("nTiempoEntrega", Request.nTiempoEntrega);

                        cm.Connection = cn;
                        //ExecuteNonQuery.- devuelve las filas afectadas
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCtaServicio]; Consulte al administrador del sistema");
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
        // UPDATE CtaCteServicio
        //--------------------------
        //
        public bool Upd_CtaCteServicio(BE_ReqCtaCteServicio Request)
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
                        cm.CommandText = "[usp_Upd_CtaCteServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cCtaCteSerJerarquia", Request.cCtaCteSerJerarquia);
                        cm.Parameters.AddWithValue("cCtaCteSerKeyWord", Request.cCtaCteSerKeyWord);
                        //cm.Parameters.AddWithValue("nBieCodigo", Request.nBieCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerAfecto", Request.nCtaCteSerAfecto);
                        cm.Parameters.AddWithValue("nCtaCteSerExonerado", Request.nCtaCteSerExonerado);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerImpMin", Request.nCtaCteSerImpMin);
                        cm.Parameters.AddWithValue("nCtaCteSerImpMax", Request.nCtaCteSerImpMax);
                        cm.Parameters.AddWithValue("nCtaCteSerImpDef", Request.nCtaCteSerImpDef);
                        cm.Parameters.AddWithValue("nSeuCodigo", Request.nSeuCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerFacturable", Request.nCtaCteSerFacturable);
                        cm.Parameters.AddWithValue("nCtaCteTipoCta", Request.nCtaCteTipoCta);
                        cm.Parameters.AddWithValue("nCtaAlterna", Request.nCtaAlterna);
                        //update 13/08/2015 - eincio
                        cm.Parameters.AddWithValue("cRequisitoIndica", Request.cRequisitoIndica);
                        cm.Parameters.AddWithValue("cPreparaPaciente", Request.cPreparaPaciente);
                        cm.Parameters.AddWithValue("cIdentificaMuestra", Request.cIdentificaMuestra);
                        cm.Parameters.AddWithValue("cEntregaResultado", Request.cEntregaResultado);
                        cm.Parameters.AddWithValue("cRecepcionMuestra", Request.cRecepcionMuestra);
                        cm.Parameters.AddWithValue("cConservaTransporte", Request.cConservaTransporte);
                        cm.Parameters.AddWithValue("cEstabilidadMuestra", Request.cEstabilidadMuestra);

                        cm.Parameters.AddWithValue("nCantMuestra", Request.nCantMuestra);
                        //update 13/08/2015 - eincio
                        cm.Parameters.AddWithValue("nCodEnvase", Request.nCodEnvase);
                        cm.Parameters.AddWithValue("nCodTipoMuestra", Request.nCodTipoMuestra);
                        cm.Parameters.AddWithValue("cVolumMinimo", Request.cVolumMinimo);
                        cm.Parameters.AddWithValue("cDiaHoraProceso", Request.cDiaHoraProceso);

                        cm.Parameters.AddWithValue("nTiempoEntrega", Request.nTiempoEntrega);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_CtaCteServicio]; Consulte al administrador del sistema");
                    
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
        // SELECT CtaCteServicio
        //--------------------------
        public DataTable Get_CtaCteServicio(BE_ReqCtaCteServBusca Request)
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
                        cm.CommandText = "[usp_Get_CtaCteServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
                        cm.Parameters.AddWithValue("nCtaCteTipoCta", Request.nCtaCteTipoCta);

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

        //-----------------------------------
        //Obtener Servicio por Tipo de Cuenta
        //-----------------------------------
        public DataTable Get_ServicioporTipoCta(BE_ReqServicioporTipoCta Request)
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
                        cm.CommandText = "usp_Get_ServicioporTipoCta";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaCteTipoCta", Request.nCtaCteTipoCta);
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
        // SELECT Get_ImpuestoServicio
        //----------------------------
        public DataTable Get_ImpuestoServicio(BE_ReqCtaCteSerImpuesto Request)
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
                        cm.CommandText = "[usp_Get_ImpuestoServicio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nSysTasContry", Request.nSysTasContry);
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

        //-------------------------------------
        //Get_CtaCteServicio_nCtaCteSerImpDef - 
        //-------------------------------------
        public double Get_CtaCteServicio_nCtaCteSerImpDef(BE_ReqCtaCteSerImpDefault Request)
        {
            double ImpDefault = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_CtaCteServicio_nCtaCteSerImpDef]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Connection = cn;

                        SqlParameter pImp = new SqlParameter();
                        pImp.ParameterName = "nCtaCteSerImpDef";
                        pImp.DbType = DbType.Double;
                        pImp.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pImp);
                        cm.ExecuteNonQuery();

                        ImpDefault = Convert.ToDouble(cm.Parameters["nCtaCteSerImpDef"].Value);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ImpDefault;
        }
    }
}
