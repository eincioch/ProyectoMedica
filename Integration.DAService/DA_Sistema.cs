using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Sistema;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService
{
    public class DA_Sistema
    {
        public BE_Info Get_Info()
        {
            clsConection Obj = new clsConection();
            string Cadena = Obj.GetConexionString("Naylamp");
            BE_Info ObjInfo = new BE_Info();
            ObjInfo.BD = Obj.DataBase();
            ObjInfo.Server = Obj.Server();
            return ObjInfo;
        }

        //-----------------------
        //fecha servidor (global)
        //-----------------------
        public string Get_FechaServidor (BE_ReqFechaServidor Request)
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
                        cm.CommandText = "SET LANGUAGE 'Español' SELECT CONVERT(CHAR(10),GETDATE(),103) FechaServerSQL ";
                        cm.CommandType = CommandType.Text ;
                        //cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerCodigo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Item = dr.GetString(dr.GetOrdinal("FechaServerSQL")).Trim();
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

        //---------------------------------------------------------
        //Obtengo List Empresa del Sistema (90000) -Peridentifica-
        //---------------------------------------------------------
        public DataTable Get_SysEmpresa(BE_ReqFechaServidor Request)
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
                        cm.CommandText = "[usp_Get_PerSysJuridica]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.dFechaServer);
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

        public DataTable Get_Empresa_By_Per_Mod(BE_ReqSistema Request)
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
                        cm.CommandText = "usp_Get_PerSysJuridica_By_Per_Mod";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nSisGruCodigo", Request.nSisGruCodigo);
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

        // Obtengo Ubigeo 
        public string Get_Ubigeo(BE_ReqUbigeo Request)
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
                        cm.CommandText = "SELECT cDptDescripcion + '; ' + cPrvDescripcion + '; ' + cDisDescripcion as DPDUbigeo  FROM Ubigeo_2007 WITH(NOLOCK) WHERE Codigo = '" + Request.Codigo + "'";
                        cm.CommandType = CommandType.Text;
                        //cm.Parameters.AddWithValue("Codigo", Request.Codigo);
                        cm.Connection = cn;
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Item = dr.GetString(dr.GetOrdinal("DPDUbigeo")).Trim();
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

        // Establecer como Empresa del Sistema
        public BE_ResGenerico Set_EmpresaSys(BE_ReqSistema Request)
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
                        cm.CommandText = "usp_SetEmpresaSys";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerJurRepCodigo", Request.cPerJurRepCodigo);
                        cm.Parameters.AddWithValue("nPerJurTipInversion", Request.nPerJurTipInversion);
                        cm.Parameters.AddWithValue("nPerJurSecEconomico", Request.nPerJurSecEconomico);
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

        //------------------------------------------------
        // SysConTasImpuesto: tabla impuestos por Country
        //------------------------------------------------
        public BE_ResGenerico Set_SysConTasImpuesto(BE_ReqSysConTasImpuesto Request)
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
                        cm.CommandText = "usp_Ins_SysConTasImpuesto";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSysTasContry", Request.nSysTasContry );

                        cm.Parameters.AddWithValue("nSysTasCodigo", Request.nSysTasCodigo);
                        cm.Parameters.AddWithValue("nSysTasFecha", Request.nSysTasFecha);

                        cm.Parameters.AddWithValue("cSysTasDescripcion", Request.cSysTasDescripcion);
                        cm.Parameters.AddWithValue("cSysTasNombre", Request.cSysTasNombre);
                        cm.Parameters.AddWithValue("fSysTasValor", Request.fSysTasValor);
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

        //---------------------------------------
        //Obtengo SysConTasImpuesto maxima fecha
        //---------------------------------------
        public DataTable Get_SysConTasImpuesto(BE_ReqSysConTasImpuesto Request)
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
                        cm.CommandText = "usp_Get_SysConTasImpuesto";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nSysTasContry", Request.nSysTasContry);
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

        //---------------------------------------------------
        //Obtener Lista de dias por mes (form tipo de cambio)
        //---------------------------------------------------
        public DataTable Get_DiasxMes(BE_ReqGetDias Request)
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
                        cm.CommandText = "usp_Get_ListaFechaporMes";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("sMes", Request.sMes);
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

        //----------------------------------------
        //Obtener Tipo de cambio (Compra - venta)
        //----------------------------------------
        public DataTable Get_TipodeCambio(BE_ReqTipodeCambio Request)
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
                        cm.CommandText = "[usp_Get_TipodeCambio]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nAnno ", Request.nAnno);
                        cm.Parameters.AddWithValue("nMes", Request.nMes);

                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
                        cm.Parameters.AddWithValue("cFecha", Request.cFecha);
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

        //----------------------
        // Insert: TipodeCambio
        //---------------------
        public BE_ResGenerico Ins_TipodeCambio(BE_ReqInsTipodeCambio Request)
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
                        cm.CommandText = "usp_Ins_TipodeCambio";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("dTasFecha", Request.dTasFecha);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nTasTipo", Request.nTasTipo);
                        cm.Parameters.AddWithValue("fTasValor", Request.fTasValor);
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

        //-------------------------
        //CREA Y/O OBTIENE PERIODO
        //-------------------------
        public DataTable Ins_Get_Periodo(BE_ReqPeriodo Request)
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
                        cm.CommandText = "[usp_Ins_Get_Periodo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nAnno", Request.cAnno);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cflag", Request.cflag);
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

        //------------------------------------------------
        // Actuliza ESTADO de Periodo Constable
        //------------------------------------------------
        public BE_ResGenerico Upd_Periodo(BE_ReqPeriodoUpd Request)
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
                        cm.CommandText = "[usp_Upd_Periodo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("nPrdEstado ", Request.nPrdEstado);
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

        //------------------------------------------------
        // Establecer por Defaul -  Periodo Constable
        //------------------------------------------------
        public BE_ResGenerico Set_PeriodoDefault(BE_ReqPeriodoDefault Request)
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
                        cm.CommandText = "[usp_Set_PeriodoDefault]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("cAnno", Request.cAnno);
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

        //-------------------------
        //OBTIENE Año - Periodo
        //-------------------------
        public DataTable Get_Periodo(BE_ReqPeriodo Request)
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
                        cm.CommandText = "[usp_Get_Periodo]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cflag", Request.cflag);
                        cm.Parameters.AddWithValue("cAnno", Request.cAnno);
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

        //------------------------------------
        //OBTIENE Periodo Contable por defecto
        //------------------------------------
        public DataTable Get_PeriodoContDefault(BE_ReqPeriodo Request)
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
                        cm.CommandText = "[usp_Get_PeriodoContDefault]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cAnno", Request.cAnno);
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


        //--------------------------------------------------
        // Parametros de configuracion "SysConfigParametros"
        //--------------------------------------------------
        public BE_ResGenerico Set_SysConfigParametros(BE_ReqSysConfig Request)
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
                        cm.CommandText = "usp_Set_SysConfigParametros";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("NameHosts", Request.NameHosts);
                        cm.Parameters.AddWithValue("AdressIP ", Request.AdressIP);
                        cm.Parameters.AddWithValue("PathRpt ", Request.PathRpt);
                        cm.Parameters.AddWithValue("NroCaja ", Request.NroCaja);
                        cm.Parameters.AddWithValue("nTipoDocuDefault ", Request.nTipoDocuDefault);
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

        //-------------------------------------------------------------------
        //Verifica si existe Caja y Host ya registrados "SysConfigParametros"
        //-------------------------------------------------------------------
        public int Get_SysConfigParametros(BE_ReqSysConfig Request)
        {
            int nRows = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_SysConfigParametros]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("NameHosts", Request.NameHosts);
                        cm.Parameters.AddWithValue("AdressIP", Request.AdressIP);
                        cm.Parameters.AddWithValue("NroCaja", Request.NroCaja);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nExiste";
                        pCod.DbType = DbType.Int32;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        nRows = Convert.ToInt32( cm.Parameters["nExiste"].Value);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nRows;
        }

        //------------------------------------------------------------------------
        //VERIFICANDO SI EXISTE DATA - VALIDANDO SI EXISTE REGISTRO FOR CONDICION
        //------------------------------------------------------------------------
        public Int32 Get_ValidarCondicion(BE_ReqValidaCondicion Request) 
        {
            Int32 nRegCant = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");
                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_ValidarCondicion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("Table", Request.Table);
                        cm.Parameters.AddWithValue("campo", Request.campo);
                        cm.Parameters.AddWithValue("condicion", Request.condicion);
                        cm.Connection = cn;

                        SqlParameter pCount = new SqlParameter();
                        pCount.ParameterName = "nResultadof";
                        pCount.DbType = DbType.Int32;
                        pCount.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCount);
                        cm.ExecuteNonQuery();
                        nRegCant = Convert.ToInt32(cm.Parameters["nResultadof"].Value);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nRegCant;
        }

        //----------------------------------------------------------------
        //Get Value for CampoSelect, NameTabla, CampoWhere, Condicion
        //----------------------------------------------------------------
        public DataTable Get_Value_Table(BE_ReqObtieneValue  Request)
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
                        cm.CommandText = "[usp_Get_Value_Table]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("CampoSelect", Request.CampoSelect);
                        cm.Parameters.AddWithValue("NameTabla", Request.NameTabla);
                        cm.Parameters.AddWithValue("CampoWhere", Request.CampoWhere);
                        cm.Parameters.AddWithValue("nFlag", Request.nFlag);
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

        //----------------------------------------------------------
        //Obtengo Estructura "Cabecera" para el comprobante de venta
        //----------------------------------------------------------
        public DataTable Get_Fiscal_Header(BE_ReqSistema Request)
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
                        cm.CommandText = "[usp_Get_Fiscal_Header]";
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

        //------------------------------------
        //Obtiene Periodo (nPrdCodigo) Actual 
        //------------------------------------
        public int Get_Periodo_by_cPerJurCodigo(BE_ReqSistema Request)
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
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurRepCodigo);
                        cm.Connection = cn;

                        SqlParameter pCod = new SqlParameter();
                        pCod.ParameterName = "nPrdCodigo";
                        pCod.DbType = DbType.Int32;
                        pCod.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(pCod);
                        cm.ExecuteNonQuery();
                        nPrdCodigo = Convert.ToInt32(cm.Parameters["nPrdCodigo"].Value);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nPrdCodigo;
        }
    }
}
