using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE;
using Integration.BE.Documento ;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.Documento
{
    public class DA_FondoMortorio
    {
        public bool InsFondoMortorio(BE_FondoMortorio  Request)
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
                        cm.CommandText = "[usp_Ins_FondoMortorio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("nDocPerTipo", Request.nDocPerTipo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerRelacion", Request.nPerRelacion);
                        cm.Parameters.AddWithValue("nDocTipo", Request.nDocTipo);
                        cm.Parameters.AddWithValue("nDocTipoNum", Request.nDocTipoNum);
                        cm.Parameters.AddWithValue("cDocNDoc", Request.cDocNDoc);
                        cm.Parameters.AddWithValue("dFecInicial", Request.dFecInicial);
                        cm.Parameters.AddWithValue("dFecFinal", Request.dFecFinal);
                        cm.Parameters.AddWithValue("nMvoCodigo", Request.nMvoCodigo);
                        cm.Parameters.AddWithValue("nDocConTipo", Request.nDocConTipo);
                        cm.Parameters.AddWithValue("tDocConContenido", Request.tDocConContenido);
                        cm.Parameters.AddWithValue("dFechaIni", Request.dFechaIni);
                        cm.Parameters.AddWithValue("dFechaFin", Request.dFechaFin);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_FondoMortorio]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //[usp_Get_Doc_Afiliacion_for_cDocCodigo]
        public DataTable Get_Doc_Afiliacion_for_cDocCodigo(BE_Get_Doc_Afiliacion_for_cDocCodigo Request)
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
                        cm.CommandText = "[usp_Get_Doc_Afiliacion_for_cDocCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
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

        //Del_Beneficiario_for_cDocCodigo_and_cPerCodigo
        public bool Del_Beneficiario_for_cDocCodigo_and_cPerCodigo(BE_Del_Beneficiario_for_cDocCodigo Request)
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
                        cm.CommandText = "[usp_Del_Beneficiario_for_cDocCodigo_and_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_Beneficiario_for_cDocCodigo_and_cPerCodigo]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //usp_Get_Beneficiario_for_cDocCodigo_and_cPerCodigo - * Para la Regla de Negocio *
        public bool Get_Beneficiario_for_cDocCodigo_and_cPerCodigo(BE_Get_Beneficiario_for_cDocCodigo Request)
        {   
            bool nExists = false;
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
                        cm.CommandText = "[usp_Get_Beneficiario_for_cDocCodigo_and_cPerCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                        dt.Load(dr);

                        if (dt.Rows.Count == 0)
                        {
                            nExists = true ; //si NO existe devuelve TRUE para crear nuevo
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return nExists;
        }

        //Ins_Beneficiario_for_cDocCodigo
        public bool Ins_Beneficiario_for_cDocCodigo(BE_Ins_Beneficiario_for_cDocCodigo Request)
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
                        cm.CommandText = "[usp_Ins_Beneficiario_for_cDocCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("nDocPerTipo", Request.nDocPerTipo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerRelacion", Request.nPerRelacion);
                        cm.Parameters.AddWithValue("nDocTipo", Request.nDocTipo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        //else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_Beneficiario_for_cDocCodigo]; Consulte al administrador del sistema");
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
