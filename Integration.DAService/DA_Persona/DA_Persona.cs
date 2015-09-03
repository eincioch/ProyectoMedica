using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Persona;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_Persona
    {
        //---------------------------------------------------
        // usp_Persona_Get_NewId.- Generar Codigo cPerCodigo
        //--------------------------------------------------
        public DataTable Get_NewIdcPerCodigo(BE_ReqPersona Request)
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
                        cm.CommandText = "[usp_Persona_Get_NewId]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
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

        //----------------
        // SearhPersona
        //----------------
        public DataTable Get_SearhPersona(BE_ReqPersonaSearh  Request)
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
                        cm.CommandText = "[usp_Get_FiltroPersona]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cNombre", Request.cNombre);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("nPerTipo", Request.nPerTipo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCodColegio", Request.cCodColegio);
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
            return dt ;
        }

        //GET PERSONA AUTOCOMPLETAR
        public DataTable Get_PersonaAutocompletar()
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
                        cm.CommandText = "[usp_Get_PersonaAutoCompletar]";
                        cm.CommandType = CommandType.StoredProcedure;
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

        //----------------
        // Insert Persona
        //----------------
        public bool Ins_Persona(BE_ReqPersona Request)
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
                        cm.CommandText = "[usp_Ins_Persona]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerIdeTipo", Request.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("cPerApellPaterno", Request.cPerApellPaterno);
                        cm.Parameters.AddWithValue("cPerApellMaterno", Request.cPerApellMaterno);
                        cm.Parameters.AddWithValue("cPerPriNombre", Request.cPerPriNombre);
                        cm.Parameters.AddWithValue("cPerSegNombre", Request.cPerSegNombre);
                        cm.Parameters.AddWithValue("cPerTerNombre", Request.cPerTerNombre);
                        cm.Parameters.AddWithValue("dPerNacimiento", Request.dPerNacimiento);
                        cm.Parameters.AddWithValue("nPerTipo", Request.nPerTipo);
                        cm.Parameters.AddWithValue("cUbiGeoCodigo", Request.cUbiGeoCodigo);
                        cm.Parameters.AddWithValue("nPerTratamiento", Request.nPerTratamiento);
                        cm.Parameters.AddWithValue("nPerNatSexo", Request.nPerNatSexo);
                        cm.Parameters.AddWithValue("nPerNatEstCivil", Request.nPerNatEstCivil);
                        cm.Parameters.AddWithValue("nPerNatTipResidencia", Request.nPerNatTipResidencia);
                        cm.Parameters.AddWithValue("nPerNatSitLaboral", Request.nPerNatSitLaboral);
                        cm.Parameters.AddWithValue("nPerNatOcupacion", Request.nPerNatOcupacion);
                        cm.Parameters.AddWithValue("nPerNatCondicion", Request.nPerNatCondicion);
                        cm.Parameters.AddWithValue("cPerJurRepCodigo", Request.cPerJurRepCodigo);
                        cm.Parameters.AddWithValue("nPerJurTipInversion", Request.nPerJurTipInversion);
                        cm.Parameters.AddWithValue("nPerJurSecEconomico", Request.nPerJurSecEconomico);

                        cm.Parameters.AddWithValue("nCarCodigo", Request.nCarCodigo);
                        cm.Parameters.AddWithValue("cCarValor", Request.cCarValor);
                        cm.Parameters.AddWithValue("dFecha ", Request.dFecha);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_Persona]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------
        // Update Persona
        //----------------
        public bool Upd_Persona(BE_ReqPersona Request)
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
                        cm.CommandText = "[usp_Upd_Persona]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerIdeTipo", Request.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("cPerApellPaterno", Request.cPerApellPaterno);
                        cm.Parameters.AddWithValue("cPerApellMaterno", Request.cPerApellMaterno);
                        cm.Parameters.AddWithValue("cPerPriNombre", Request.cPerPriNombre);
                        cm.Parameters.AddWithValue("cPerSegNombre", Request.cPerSegNombre);
                        cm.Parameters.AddWithValue("cPerTerNombre", Request.cPerTerNombre);
                        cm.Parameters.AddWithValue("dPerNacimiento", Request.dPerNacimiento);
                        cm.Parameters.AddWithValue("nPerTipo", Request.nPerTipo);
                        cm.Parameters.AddWithValue("cUbiGeoCodigo", Request.cUbiGeoCodigo);
                        cm.Parameters.AddWithValue("nPerTratamiento", Request.nPerTratamiento);
                        cm.Parameters.AddWithValue("nPerNatSexo", Request.nPerNatSexo);
                        cm.Parameters.AddWithValue("nPerNatEstCivil", Request.nPerNatEstCivil);
                        cm.Parameters.AddWithValue("nPerNatTipResidencia", Request.nPerNatTipResidencia);
                        cm.Parameters.AddWithValue("nPerNatSitLaboral", Request.nPerNatSitLaboral);
                        cm.Parameters.AddWithValue("nPerNatOcupacion", Request.nPerNatOcupacion);
                        cm.Parameters.AddWithValue("nPerNatCondicion", Request.nPerNatCondicion);
                        cm.Parameters.AddWithValue("cPerJurRepCodigo", Request.cPerJurRepCodigo);
                        cm.Parameters.AddWithValue("nPerJurTipInversion", Request.nPerJurTipInversion);
                        cm.Parameters.AddWithValue("nPerJurSecEconomico", Request.nPerJurSecEconomico);

                        cm.Parameters.AddWithValue("nCarCodigo", Request.nCarCodigo);
                        cm.Parameters.AddWithValue("cCarValor", Request.cCarValor);
                        cm.Parameters.AddWithValue("dFecha ", Request.dFecha);

                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Upd_Persona]; Consulte al administrador del sistema");
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
        // Insert PerDomicilio
        //---------------------
        public BE_ResGenerico InsPerDomicilio(BE_ReqPerDomicilio  Request)
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
                        cm.CommandText = "[usp_Ins_PerDomicilio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerDomTipo", Request.nPerDomTipo);
                        cm.Parameters.AddWithValue("cPerDomDireccion", Request.cPerDomDireccion);
                        cm.Parameters.AddWithValue("cPerDomNumero", Request.cPerDomNumero);
                        cm.Parameters.AddWithValue("cPerDomManzana", Request.cPerDomManzana);
                        cm.Parameters.AddWithValue("cPerDomLote", Request.cPerDomLote);
                        cm.Parameters.AddWithValue("nPerDomSubTipo", Request.nPerDomSubTipo);
                        cm.Parameters.AddWithValue("cPerDomSubTipoNumero", Request.cPerDomSubTipoNumero);
                        cm.Parameters.AddWithValue("nPerDomResTipo", Request.nPerDomResTipo);
                        cm.Parameters.AddWithValue("cPerDomResNombre", Request.cPerDomResNombre);
                        cm.Parameters.AddWithValue("nPerDomSecTipo", Request.nPerDomSecTipo);
                        cm.Parameters.AddWithValue("cPerDomSecNombre", Request.cPerDomSecNombre);
                        cm.Parameters.AddWithValue("cUbiGeoCodigo", Request.cUbiGeoCodigo);
                        cm.Parameters.AddWithValue("nPerDomStatus", Request.nPerDomStatus);
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

        //---------------------
        // Update PerDomicilio
        //---------------------
        public BE_ResGenerico UpdPerDomicilio(BE_ReqPerDomicilio Request)
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
                        cm.CommandText = "[usp_Upd_PerDomicilio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerDirCodigo", Request.nPerDirCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerDomTipo", Request.nPerDomTipo);
                        cm.Parameters.AddWithValue("cPerDomDireccion", Request.cPerDomDireccion);
                        cm.Parameters.AddWithValue("cPerDomNumero", Request.cPerDomNumero);
                        cm.Parameters.AddWithValue("cPerDomManzana", Request.cPerDomManzana);
                        cm.Parameters.AddWithValue("cPerDomLote", Request.cPerDomLote);
                        cm.Parameters.AddWithValue("nPerDomSubTipo", Request.nPerDomSubTipo);
                        cm.Parameters.AddWithValue("cPerDomSubTipoNumero", Request.cPerDomSubTipoNumero);
                        cm.Parameters.AddWithValue("nPerDomResTipo", Request.nPerDomResTipo);
                        cm.Parameters.AddWithValue("cPerDomResNombre", Request.cPerDomResNombre);
                        cm.Parameters.AddWithValue("nPerDomSecTipo", Request.nPerDomSecTipo);
                        cm.Parameters.AddWithValue("cPerDomSecNombre", Request.cPerDomSecNombre);
                        cm.Parameters.AddWithValue("cUbiGeoCodigo", Request.cUbiGeoCodigo);
                        cm.Parameters.AddWithValue("nPerDomStatus", Request.nPerDomStatus);
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

        //--------------------
        // Insert PerTelefono
        //--------------------
        public BE_ResGenerico InsPerTelefono(BE_ReqPerTelefono  Request)
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
                        cm.CommandText = "[usp_Ins_PerTelefono]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerTelTipo", Request.nPerTelTipo);
                        cm.Parameters.AddWithValue("cPerTelNumero", Request.cPerTelNumero);
                        cm.Parameters.AddWithValue("nPerTelStatus", Request.nPerTelStatus);
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

        //--------------------
        // Update PerTelefono
        //--------------------
        public BE_ResGenerico UpdPerTelefono(BE_ReqPerTelefono Request)
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
                        cm.CommandText = "[usp_Upd_PerTelefono]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerTelTipo", Request.nPerTelTipo);
                        cm.Parameters.AddWithValue("cPerTelNumero", Request.cPerTelNumero);
                        cm.Parameters.AddWithValue("nPerTelStatus", Request.nPerTelStatus);
                        cm.Parameters.AddWithValue("dPerTelFecRegistro", Request.dPerTelFecRegistro);
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

        //----------------
        // Insert PerMail
        //----------------
        public BE_ResGenerico InsPerMail(BE_ReqPerMail Request)
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
                        cm.CommandText = "[usp_Ins_PerMail]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerMaiTipo", Request.nPerMaiTipo);
                        cm.Parameters.AddWithValue("cPerMaiNombre", Request.cPerMaiNombre);
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

        //----------------
        // Update PerMail
        //----------------
        public BE_ResGenerico UpdPerMail(BE_ReqPerMail Request)
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
                        cm.CommandText = "[usp_Upd_PerMail]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerMaiTipo", Request.nPerMaiTipo);
                        cm.Parameters.AddWithValue("cPerMaiNombre", Request.cPerMaiNombre);
                        cm.Parameters.AddWithValue("dPerMaiFecRegistro", Request.dPerMaiFecRegistro);
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


        //----------------
        // PerImagen
        //----------------
        public BE_ResGenerico InsPerImagen(BE_ReqPerPhoto Request)
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
                        cm.CommandText = "[usp_Ins_PerImagen]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerTipImagen", Request.nPerTipImagen);

                        SqlParameter pImg  = new SqlParameter("iPerImaFoto", SqlDbType.Image);

                        pImg.Value = Request.iPerImaFoto ;

                        cm.Parameters.Add(pImg);
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

        //Buscar Photo
        public DataTable Get_PerImagen(BE_ReqPerPhoto Request)
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
                        cm.CommandText = "[usp_Get_PerImagen]";
                        cm.CommandType = CommandType.StoredProcedure ;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cUltimaPhoto", Request.cUltimaPhoto);
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

        //----------------
        // PerIdentifica
        //----------------
        //Insert
        public BE_ResGenerico InsPerIdentifica(BE_ReqPerIdentifica  Request)
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
                        cm.CommandText = "[usp_Ins_PerIdentifica]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerIdeTipo", Request.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
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

        //Obtener todos los tipos docu. por persona 
        public DataTable Get_PerIdentifica(BE_ReqPerIdentifica Request)
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
                        cm.CommandText = "[usp_Get_PerIdentifica]";
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

        //----------------
        // PerJuridica (Vista)
        //----------------
        // para obtener por tipo de empresa ? (hacer SP)
        public DataTable Get_PerJurTipInversion(BE_ReqPerJurSecEconomico Request)
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
                        cm.CommandText = "[usp_Get_PerJurSecEconomico]";
                        cm.CommandType = CommandType.StoredProcedure;
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

        //----------------
        // PerIdioma
        //----------------
        //INSERT
        public BE_ResGenerico InsPerIdioma(BE_ReqPerIdioma Request)
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
                        cm.CommandText = "[usp_Ins_PerIdioma]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nIdioma", Request.nIdioma);
                        cm.Parameters.AddWithValue("nIdiHabilidad", Request.nIdiHabilidad);
                        cm.Parameters.AddWithValue("nNivel", Request.nNivel);
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

        //Get_PerIdioma
        public DataTable Get_PerIdioma(BE_ReqPerIdioma Request)
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
                        cm.CommandText = "[usp_Get_PerIdioma]";
                        cm.CommandType = CommandType.StoredProcedure ;
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


        //Get_Afiliacion Fondo Mutual
        public DataTable Get_AfiliacionFondo(BE_ReqAfilicacion Request)
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
                        cm.CommandText = "[usp_Get_AfiliacionFondo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Parameters.AddWithValue("cPerIdeNumeroDNI", Request.cPerIdeNumeroDNI);
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

        //------------------------------------------------------------------------------
        //[usp_Get_ExistePerIdentifica] para Verificar si existe Nro. docu PerIdentifica
        //------------------------------------------------------------------------------
        public int Get_ExistePerIdentifica(BE_ReqPerIdentifica Request)
        {
            int nResultado = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_ExistePerIdentifica]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerIdeTipo", Request.nPerIdeTipo);
                        cm.Parameters.AddWithValue("cPerIdeNumero", Request.cPerIdeNumero);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nRows";
                        pCod.DbType =  DbType.Int32;
                        //pCod.Size = 25;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        nResultado = Convert.ToInt32(cm.Parameters["nRows"].Value);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nResultado;
        }


        //----------------
        // PerCuenta
        //----------------
        //INSERT
        public bool Ins_PerCuenta(BE_ReqPerCuenta Request)
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
                        cm.CommandText = "[usp_Ins_PerCuenta]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerCtaCodigo", Request.nPerCtaCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cNroCuenta", Request.cNroCuenta);
                        cm.Parameters.AddWithValue("nPerCtaTipo", Request.nPerCtaTipo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nPerCtaEstado", Request.nPerCtaEstado);
                        cm.Parameters.AddWithValue("cNroCuentaOpera", Request.cNroCuentaOpera);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_PerCuenta]; Consulte al administrador del sistema");
                        
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
        //Obtener Calculo Edad
        //---------------------
        public string Get_ObtenerEdad(BE_ReqPersona Request)
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
                        cm.CommandText = "[usp_Get_nEdad]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("dFecNac", Request.dFecha);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nEdad";
                        pCod.DbType = DbType.String;
                        pCod.Size = 3;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["nEdad"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //---------------------------------
        //Obtener NewIdPersona for Sucursal
        //---------------------------------
        public string Get_NewIdcPerCodigo_Out(BE_ReqPersona Request)
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
                        cm.CommandText = "[usp_Persona_Get_NewId_Out]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "cPerCodigo";
                        pCod.DbType = DbType.String;
                        pCod.Size = 10;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        Item = cm.Parameters["cPerCodigo"].Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return Item;
        }

        //---------------------------------------------
        // Get Persona con PerRelacion for nPerRelTipo 
        //---------------------------------------------
        public DataTable Get_List_Persona_PerRelacion_for_nPerRelTipo(BE_Req_Persona  Request)
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
                        cm.CommandText = "[usp_Get_List_Persona_PerRelacion_for_nPerRelTipo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerRelTipo", Request.nPerRelTipo);
            
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

        //-----------------------------------------------------------------------------
        // Get Persona con PerJuridica for nPerJurTipInversion and nPerJurSecEconomico 
        //-----------------------------------------------------------------------------
        public DataTable Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(BE_ReqPerJuridica  Request)
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
                        cm.CommandText = "[usp_Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPerJurTipInversion", Request.nPerJurTipInversion);
                        cm.Parameters.AddWithValue("nPerJurSecEconomico", Request.nPerJurSecEconomico);

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
