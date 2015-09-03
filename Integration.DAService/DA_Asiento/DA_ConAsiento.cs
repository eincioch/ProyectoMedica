using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Asientos;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_Asiento
{
    public class DA_ConAsiento
    {
        //------------------
        // Insert ConAsiento
        //------------------
        public bool Ins_ConAsiento(BE_ReqConAsiento Request)
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
                        cm.CommandText = "[usp_Ins_ConAsiento]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nAsiCodigo", Request.nAsiCodigo);
                        cm.Parameters.AddWithValue("nOrigen", Request.nOrigen);
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("nAsiCorrelativo", Request.nAsiCorrelativo);
                        cm.Parameters.AddWithValue("nUniOrgCodigo", Request.nUniOrgCodigo);
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dAsiFecha", Request.dAsiFecha);
                        cm.Parameters.AddWithValue("cAsiGlosa", Request.cAsiGlosa);
                        cm.Parameters.AddWithValue("nAsiEstado", Request.nAsiEstado);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_ConAsiento]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------
        // Insert ConAsiDetalle
        //---------------------
        public bool Ins_ConAsiDetalle(BE_ReqConAsiDetalle Request)
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
                        cm.CommandText = "[usp_Ins_ConAsiDetalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nAsiCodigo", Request.nAsiCodigo);
                        cm.Parameters.AddWithValue("nCorrelativo", Request.nCorrelativo);
                        cm.Parameters.AddWithValue("nConCtaCodigo", Request.nConCtaCodigo);
                        cm.Parameters.AddWithValue("nMoneda", Request.nMoneda);
                        cm.Parameters.AddWithValue("nDestino", Request.nDestino);
                        cm.Parameters.AddWithValue("fMonto", Request.fMonto);
                        cm.Parameters.AddWithValue("dFecha", Request.dFecha);
                        cm.Parameters.AddWithValue("fTC", Request.fTC);
                        cm.Parameters.AddWithValue("cGlosa", Request.cGlosa);
                        cm.Parameters.AddWithValue("nEstado", Request.nEstado);
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_ConAsiDetalle]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------
        // Insert ConAsiDetInt
        //--------------------
        public bool Ins_ConAsiDetInt(BE_ReqConAsiDetInt Request)
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
                        cm.CommandText = "[usp_Ins_ConAsiDetInt]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaConCodigo", Request.nCtaConCodigo);
                        cm.Parameters.AddWithValue("nCorrelativo", Request.nCorrelativo);
                        cm.Parameters.AddWithValue("nAsiCodigo", Request.nAsiCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("fMonto", Request.fMonto);
                        cm.Parameters.AddWithValue("fTC", Request.fTC);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_ConAsiDetInt]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------
        // Insert ConAsiDetInt
        //--------------------
        public bool Ins_Documentos(BE_ReqDocumentos Request)
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
                        cm.CommandText = "[usp_Ins_Documentos]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dDocFecha", Request.dDocFecha);
                        cm.Parameters.AddWithValue("cDocObserv", Request.cDocObserv);
                        cm.Parameters.AddWithValue("nDocTipo", Request.nDocTipo);
                        cm.Parameters.AddWithValue("nEstado", Request.nEstado);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_Documentos]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------
        // Insert DocInterface
        //--------------------
        public bool Ins_DocInterface(BE_ReqDocInterface Request)
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
                        cm.CommandText = "[usp_Ins_DocInterface]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("nIntCodigo", Request.nIntCodigo);
                        cm.Parameters.AddWithValue("nIntClase", Request.nIntClase);
                        cm.Parameters.AddWithValue("dDocIntReg", Request.dDocIntReg);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocInterface]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------------
        // Insert DocIdentifica
        //---------------------
        public bool Ins_DocIdentifica(BE_ReqDocIdentifica Request)
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
                        cm.CommandText = "[usp_Ins_DocIdentifica]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("nDocTipoNum", Request.nDocTipoNum);
                        cm.Parameters.AddWithValue("cDocNDoc", Request.cDocNDoc);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocIdentifica]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------------
        // Insert DocComprobante
        //----------------------
        public bool Ins_DocComprobante(BE_ReqDocComprobante Request)
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
                        cm.CommandText = "[usp_Ins_DocComprobante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("nTipo", Request.nTipo);
                        cm.Parameters.AddWithValue("nMoneda", Request.nMoneda);
                        cm.Parameters.AddWithValue("fMonto", Request.fMonto);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocComprobante]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------
        // Insert DocPersona
        //------------------
        public bool Ins_DocPersona(BE_ReqDocPersona Request)
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
                        cm.CommandText = "[usp_Ins_DocPersona]";
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
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocPersona]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------
        // Insert DocVigencia
        //--------------------
        public bool Ins_DocVigencia(BE_ReqDocVigencia Request)
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
                        cm.CommandText = "[usp_Ins_DocVigencia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dFechaIni", Request.dFechaIni);
                        cm.Parameters.AddWithValue("dFechaFin", Request.dFechaFin);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocVigencia]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //---------------
        // Insert DocRef
        //---------------
        public bool Ins_DocRef(BE_ReqDocRef Request)
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
                        cm.CommandText = "[usp_Ins_DocRef]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("cDocRefCodigo", Request.cDocRefCodigo);
                        cm.Parameters.AddWithValue("dDocRefFecReg", Request.dDocRefFecReg);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocRef]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------------------------
        //Obtiene NewID Documento Autogenerado
        //------------------------------------
        public string Get_NewID_Documento(BE_ReqGetDocumentoNewId Request)
        {
            string cDocCodigo = "";
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Documentos_NewID]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cDocCodigo = dr.GetString(dr.GetOrdinal("newcdoccodigo")).Trim();
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return cDocCodigo;
        }

        //-------------------------------------
        //Obtiene NewID ConAsiento Autogenerado
        //-------------------------------------
        public int Get_NewID_ConAsiento(BE_ReqGetConAsientoNewId Request)
        {
            int nAsiCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[sp_ConAsiento_Get_NewId]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nUniOrgCodigo", Request.cPerJurCodigo);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                nAsiCodigo = dr.GetInt32(dr.GetOrdinal("nAsiCodigo"));
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nAsiCodigo;
        }

        //-----------------------------
        //Obtiene Unidad Organizacional
        //-----------------------------
        public int Get_UnidadOrganizacional_by_cPerJuridica(BE_ReqParametros Request)
        {
            int nIntCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_UnidadOrganizacional_by_cPerJuridica]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                nIntCodigo = dr.GetInt32(dr.GetOrdinal("nIntCodigo"));
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nIntCodigo;
        }

        //-------------------------
        //Obtiene Periodo Contable
        //-------------------------
        public int Get_Periodo_by_cPerJurCodigo(BE_ReqParametros Request)
        {
            int nPrdCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Periodo_by_cPerJurCodigo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                nPrdCodigo = dr.GetInt32(dr.GetOrdinal("nPrdCodigo"));
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nPrdCodigo;
        }
        
        //---------------------------------------------------------------------------
        //Obtiene nIntCodigo de Interface by (cPerJurCodigo, nIntTipo, cIntJerarquia)
        //---------------------------------------------------------------------------
        public int usp_Get_Interface_nIntCodigo_by_cPerJurCodigo_and_nIntTipo_and_cIntJerarquia(BE_ReqParametros Request)
        {
            int nIntCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_Interface_nIntCodigo_by_cPerJurCodigo_and_nIntTipo_and_cIntJerarquia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nIntTipo", Request.nIntTipo);
                        cm.Parameters.AddWithValue("cIntJerarquia", Request.cIntJerarquia);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                nIntCodigo = dr.GetInt32(dr.GetOrdinal("nIntCodigo"));
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nIntCodigo;
        }

        //--------------------------------------
        //Obtiene nAsiCorrelativo "Autogenerado"
        //--------------------------------------
        public int Get_nAsiCorrelativo_by_nUniOrgCodigo_and_nPrdCodigo_and_nOrigen(BE_ReqParametros Request)
        {
            int nAsiCorrelativo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_nAsiCorrelativo_by_nUniOrgCodigo_and_nPrdCodigo_and_nOrigen]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nUniOrgCodigo", Request.nUniOrgCodigo);
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("nOrigen", Request.nOrigen);

                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                nAsiCorrelativo = dr.GetInt32(dr.GetOrdinal("nAsiCorrelativo"));
                            }
                        }

                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nAsiCorrelativo;
        }
    }
}
