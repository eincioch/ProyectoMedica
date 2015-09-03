using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Sistema ;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_Sistema
    {
        public BE_Info Consulta_Info()
        {
            DA_Sistema Obj = new DA_Sistema();
            
            return Obj.Get_Info();
            
        }
        //-----------------------
        // Obtener Fecha Servidor
        //-----------------------
        public string Get_FechaServidor(BE_ReqFechaServidor Request)
        {
            string Item = "";
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Get_FechaServidor(Request);
            return Item;
            //return Obj.Get_FechaServidor

        }


        //------------------------------
        // Obtener Empresas del Sistema
        //------------------------------
        public DataTable Get_Empresas_Per_Mod(BE_ReqSistema Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_Empresa_By_Per_Mod(Request);
        }

        //------------------------------
        // Obtener Empresas del Sistema
        //------------------------------
        public DataTable Get_SysEmpresa(BE_ReqFechaServidor Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_SysEmpresa(Request);

        }

        //Set_EmpresaSys
        public BE_ResGenerico Set_EmpresaSys(BE_ReqSistema Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Set_EmpresaSys(Request);
            return Item;
        }

        //------------------------------
        // Obtener descripcion de Ubigeo
        //------------------------------
        public string Get_Ubigeo(BE_ReqUbigeo Request)
        {
            string Item = "";
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Get_Ubigeo(Request);
            return Item;

        }

        //-------------------------------
        //Set_SysConTasImpuesto Impuestos
        //-------------------------------
        public BE_ResGenerico Set_SysConTasImpuesto(BE_ReqSysConTasImpuesto Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Set_SysConTasImpuesto(Request);
            return Item;
        }

        //------------------------------
        //Get_SysConTasImpuesto Impuestos
        //------------------------------
        public DataTable Get_SysConTasImpuesto(BE_ReqSysConTasImpuesto Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_SysConTasImpuesto(Request);

        }

        //-------------
        //Get_DiasxMes
        //------------
        public DataTable Get_DiasxMes(BE_ReqGetDias Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_DiasxMes(Request);

        }

        //---------------------------------
        //Get_TipodeCambio (compra -  venta)
        //---------------------------------
        public DataTable Get_TipodeCambio(long nMonCodigo, string nFlag, string dFechaSys, long anno, long mes) //BE_ReqTipodeCambio Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();

            BE_ReqTipodeCambio ReqTC = new BE_ReqTipodeCambio();
            DA_Sistema daTC = new DA_Sistema();

            //--------------
            //Tipo de cambio
            //--------------
            ReqTC.nMonCodigo = nMonCodigo; // Convert.ToInt32(row["nMonCodigo"]); // nMonCodigo;
            ReqTC.nAnno = anno;
            ReqTC.nMes = mes;
            ReqTC.nFlag = nFlag;  //"TCD";
            ReqTC.cFecha = String.Format("{0:dd/MM/yyyy}", dFechaSys);

            return daTC.Get_TipodeCambio(ReqTC);

        }

        //---------------------
        //Insert: TipodeCambio
        //---------------------
        public BE_ResGenerico Ins_TipodeCambio(BE_ReqInsTipodeCambio Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Ins_TipodeCambio(Request);
            return Item;
        }

        //---------------------------------
        //Ins - Get (Periodo)
        //---------------------------------
        public DataTable Ins_Get_Periodo(BE_ReqPeriodo Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Ins_Get_Periodo(Request);

        }

        //update ESTADO Perido Contable
        public BE_ResGenerico Upd_Periodo(BE_ReqPeriodoUpd Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Upd_Periodo(Request);
            return Item;
        }

        //Establecer como Default -  Perido Contable
        public BE_ResGenerico Set_PeriodoDefault(BE_ReqPeriodoDefault Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Set_PeriodoDefault(Request);
            return Item;
        }

        //---------------------------------
        //Get (Periodo) Año - Periodo
        //---------------------------------
        public DataTable Get_Periodo(BE_ReqPeriodo Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_Periodo(Request);

        }

        //---------------------------------
        //Get Periodo Contable por default
        //---------------------------------
        public DataTable Get_PeriodoContDefault(BE_ReqPeriodo Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_PeriodoContDefault(Request);

        }

        //SysConfigParametros
        public BE_ResGenerico Set_SysConfigParametros(BE_ReqSysConfig Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Sistema Obj = new DA_Sistema();
            Item = Obj.Set_SysConfigParametros(Request);
            return Item;
        }

        //[usp_Get_SysConfigParametros]
        public int Get_SysConfigParametros(BE_ReqSysConfig Request)
        {
            DA_Sistema Obj = new DA_Sistema();
            return Obj.Get_SysConfigParametros(Request);
        }


        //Get_ValidarCondicion
        public bool Get_ValidarCondicion(string Table, string campo, string condicion)
        {
            bool exito=false;

            BE_ReqValidaCondicion Request = new BE_ReqValidaCondicion();
            DA_Sistema da = new DA_Sistema();

            Request.Table = Table;
            Request.campo = campo;
            Request.condicion = condicion;
            
            if (da.Get_ValidarCondicion(Request) > 0)
            {
                exito = false;
            }
            else  exito = true;

            return exito;
        }

        //--------------------------------------------------------------
        //Get_ValidarCondicion.- Verifica si Hay registro en una tabla
        //--------------------------------------------------------------
        public int Get_CountFila(string Table, string campo, string condicion)
        {
            BE_ReqValidaCondicion Request = new BE_ReqValidaCondicion();
            DA_Sistema da = new DA_Sistema();

            Request.Table = Table;
            Request.campo = campo;
            Request.condicion = condicion;

            return da.Get_ValidarCondicion(Request);
        }

        //----------------------------------------------------------------
        //Get Value for CampoSelect, NameTabla, CampoWhere, Condicion
        //----------------------------------------------------------------
        public DataTable Get_Value_Table(string CampoSelect, string NameTabla, string CampoWhere,int nFlag, string Condicion)
        {
            BE_ReqObtieneValue Request = new BE_ReqObtieneValue();
            DA_Sistema Obj = new DA_Sistema();

            Request.CampoSelect = CampoSelect;
            Request.NameTabla = NameTabla;
            Request.CampoWhere = CampoWhere;
            Request.nFlag = nFlag;
            Request.Condicion = Condicion;

            return Obj.Get_Value_Table(Request);

        }

        //----------------------------------------------------------
        //Obtengo Estructura "Cabecera" para el comprobante de venta
        //----------------------------------------------------------
        public DataTable Get_Fiscal_Header(string cPerCodigo)
        {
            BE_ReqSistema ReqParam = new BE_ReqSistema();
            DA_Sistema Obj = new DA_Sistema();
            ReqParam.cPerCodigo = cPerCodigo;
            return Obj.Get_Fiscal_Header(ReqParam);

        }

        //------------------------------------
        //Obtiene Periodo (nPrdCodigo) Actual 
        //------------------------------------
        public int Get_Periodo_by_cPerJurCodigo(string cPerJurCodigo)
        {
            BE_ReqSistema Request = new BE_ReqSistema();
            DA_Sistema Obj = new DA_Sistema();
            Request.cPerJurRepCodigo = cPerJurCodigo;

            return Obj.Get_Periodo_by_cPerJurCodigo(Request);
        }
    }
}
