using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_Persona
    {
		public DataTable ListaPeronas_BycPerApellido(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersonas_BycPerApellido(Request);
        }
        public DataTable ListaPeronas_BycPerApellido_cPerRelTipo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersonas_BycPerCodigo_cPerRelTipo(Request);
        }
        public DataTable ListaPersona_BycPerCodigo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.ListaPersona_BycPerCodigo(Request);
        }
        public SqlDataReader DRListaPeronas_BycPerApellido_cPerRelTipo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.DRListaPersonas_BycPerCodigo_cPerRelTipo(Request);
        }
        public SqlDataReader DRListaDelegados_BycPerCodigo(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.DRListaDelegados_BycPerCodigo(Request);
        }
        public BE_Res_Persona getcPerCodigoNew()
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.getcPerCodigoNew();
        }
        //----------------
        // Persona
        //----------------
        //para Generar nuevo cPerCodigo
        public DataTable Get_NewIdcPerCodigo(BE_ReqPersona Request)
        {
            //Recuperando registros 
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_NewIdcPerCodigo(Request);

        }

        //Get_PersonaAutocompletar
        public DataTable Get_PersonaAutocompletar()
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_PersonaAutocompletar();

        }

        //para buscar persona
        public DataTable Get_SearhPersona(BE_ReqPersonaSearh  Request)
        {
            //Recuperando registros 
            DataTable dt= new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_SearhPersona(Request);

        }

        //---------------
        //Insert Persona
        //--------------
        public bool Ins_Persona(BE_ReqPersona  Request)
        {
            DA_Persona Obj = new DA_Persona();
            return Obj.Ins_Persona(Request);
        }

        //Update Persona
        public bool Upd_Persona(BE_ReqPersona Request)
        {
            DA_Persona Obj = new DA_Persona();
            return Obj.Upd_Persona(Request);
        }

        //----------------
        // PerDomicilio
        //----------------
        public BE_ResGenerico InsPerDomicilio(BE_ReqPerDomicilio  Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerDomicilio(Request);
            return Item;
        }

        //---------------------
        // Update PerDomicilio
        //--------------------
        public BE_ResGenerico UpdPerDomicilio(BE_ReqPerDomicilio Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.UpdPerDomicilio(Request);
            return Item;
        }

        //----------------
        // PerTelefono
        //----------------
        public BE_ResGenerico InsPerTelefono(BE_ReqPerTelefono Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerTelefono(Request);
            return Item;
        }

        //--------------------
        // update PerTelefono
        //-------------------
        public BE_ResGenerico UpdPerTelefono(BE_ReqPerTelefono Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.UpdPerTelefono(Request);
            return Item;
        }

        //----------------
        // PerMail
        //----------------
        public BE_ResGenerico InsPerMail(BE_ReqPerMail Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerMail(Request);
            return Item;
        }

        //----------------
        // Update PerMail
        //----------------
        public BE_ResGenerico UpdPerMail(BE_ReqPerMail Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.UpdPerMail(Request);
            return Item;
        }

        //----------------
        // PerImagen
        //----------------
        public BE_ResGenerico InsPerImagen(BE_ReqPerPhoto Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerImagen(Request);
            return Item;
        }

        //Obtener Photo x cPercodigo
        public DataTable Get_PerImagen(BE_ReqPerPhoto Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_PerImagen(Request);

        }

        public Boolean setPersona(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.setPersona(Request);
        }

        //----------------
        // PerIdentifica
        //----------------
        public BE_ResGenerico InsPerIdentifica(BE_ReqPerIdentifica  Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerIdentifica(Request);
            return Item;
        }

        //Obtener PerIdentifica
        public DataTable Get_PerIdentifica(BE_ReqPerIdentifica Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_PerIdentifica(Request);

        }

        //----------------
        // PerJuridica
        //----------------
        public DataTable Get_PerJurTipInversion(BE_ReqPerJurSecEconomico Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_PerJurTipInversion(Request);

        }

        public string getDelegadoAnduser(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.getDelegadoAnduser(Request);
        }

        //-----------
        //PerIdioma
        //-----------
        //Insert PerIdioma
        public BE_ResGenerico InsPerIdioma(BE_ReqPerIdioma Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Persona Obj = new DA_Persona();
            Item = Obj.InsPerIdioma(Request);
            return Item;
        }

        public Boolean setDelegado(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.setDelegado(Request);
        }

        public DataTable Get_PerIdioma(BE_ReqPerIdioma Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_PerIdioma(Request);

        }

        public Boolean delDelegado(BE_Req_Persona Request)
        {
            DAPersona ObjPersona = new DAPersona();
            return ObjPersona.delDelegado(Request);
        }

        //Get_AfiliacionFondo
        public DataTable Get_AfiliacionFondo(BE_ReqAfilicacion Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_AfiliacionFondo(Request);

        }

        //[usp_Get_ExistePerIdentifica]
        public int Get_ExistePerIdentifica(BE_ReqPerIdentifica Request)
        {
            DA_Persona Obj = new DA_Persona();
            return Obj.Get_ExistePerIdentifica(Request);

        }

        //---------------------
        //Obtener Calculo Edad
        //---------------------
        public string Get_ObtenerEdad(DateTime dFecnaci) 
        {
            BE_ReqPersona Request = new BE_ReqPersona();
            DA_Persona Obj = new DA_Persona();
            Request.dFecha = dFecnaci;
            return Obj.Get_ObtenerEdad(Request);

        }

        //---------------------------------
        //Obtener NewIdPersona for Sucursal
        //---------------------------------
        public string Get_NewIdcPerCodigo_Out(String cPerJurCodigo)
        {
            BE_ReqPersona Request = new BE_ReqPersona();
            DA_Persona Obj = new DA_Persona();
            Request.cPerJurCodigo = cPerJurCodigo;
            return Obj.Get_NewIdcPerCodigo_Out(Request);

        }

        //---------------------------------------------
        // Get Persona con PerRelacion for nPerRelTipo 
        //---------------------------------------------
        public DataTable Get_List_Persona_PerRelacion_for_nPerRelTipo(int nPerRelTipo)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();

            BE_Req_Persona Request = new BE_Req_Persona();
            DA_Persona Obj = new DA_Persona();

            Request.nPerRelTipo = nPerRelTipo;
            return Obj.Get_List_Persona_PerRelacion_for_nPerRelTipo(Request);

        }

        //-----------------------------------------------------------------------------
        // Get Persona con PerJuridica for nPerJurTipInversion and nPerJurSecEconomico 
        //-----------------------------------------------------------------------------
        public DataTable Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(int nPerJurTipInversion, int nPerJurSecEconomico)
        {
            DataTable dt = new DataTable();

            BE_ReqPerJuridica Request = new BE_ReqPerJuridica();
            DA_Persona Obj = new DA_Persona();

            Request.nPerJurTipInversion = nPerJurTipInversion;
            Request.nPerJurSecEconomico = nPerJurSecEconomico;
            return Obj.Get_List_Persona_PerJuridica_for_nPerJurTipInversion_and_nPerJurSecEconomico(Request);

        }
    }
}
