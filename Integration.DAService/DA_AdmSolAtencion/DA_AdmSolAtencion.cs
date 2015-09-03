using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.FichaAtencion;
using Integration.BE;
using Integration.BE.Solicitud;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_AdmSolAtencion
{
    public class DA_AdmSolAtencion
    {
        //Obtiene correlativo Admision Solicitud Atencion
        public string Get_Correlativo_Sol(BE_ReqAdmSolAtencion Request)
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
                        //cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerCodigo);
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

        // Insert Adm Solicitud Atencion
        public bool Ins_AdmSolAtencion(BE_ReqAdmSolAtencion Request)
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
                        cm.CommandText = "[usp_Ins_AdmSolAtencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJuridica", Request.cPerJuridica);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nSolAdmNumero", Request.nSolAdmNumero);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("dFecExamen", Request.dFecExamen);
                        cm.Parameters.AddWithValue("nAdmSolEstado", Request.nAdmSolEstado);
                        cm.Parameters.AddWithValue("nImpTotal", Request.nImpTotal);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);

                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteCantidad", Request.nCtaCteCantidad);
                        cm.Parameters.AddWithValue("nCtaCteCosto", Request.nCtaCteCosto);

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
