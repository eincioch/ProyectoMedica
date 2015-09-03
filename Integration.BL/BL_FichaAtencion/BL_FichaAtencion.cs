using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.FichaAtencion;
using Integration.DAService.DA_FichaAtencion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_FichaAtencion
{
    public class BL_FichaAtencion
    {
        //-----------------------
        // Insert AdmSolAtencion
        //-----------------------
        public bool Ins_AdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_AdmSolAtencion(Request);
        }

        //-----------------------
        // Update AdmSolAtencion
        //-----------------------
        public bool Upd_AdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Upd_AdmSolAtencion(Request);
        }

        //---------------------------
        // Insert DetAdmSolAtencion
        //---------------------------
        public bool Ins_DetAdmSolAtencion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_DetAdmSolAtencion(Request);
        }

        //---------------------------
        // Delete DetAdmSolAtencion
        //---------------------------
        public bool Del_DetAdmSolAtencion(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, int nCtaCteSerCodigo){
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.nCtaCteSerCodigo = nCtaCteSerCodigo;

            if (Obj.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero_nCtaCteSerCodigo(Request).Rows.Count  > 0) { 
                Resultado = Obj.Del_DetAdmSolAtencion(Request);
            }

            return Resultado;
        }

        //---------------------------
        // Insert AdmSolDerivacion
        //---------------------------
        public bool Ins_AdmSolDerivacion(BE_ReqSolAtencion Request)
        {

            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();
            return Obj.Ins_AdmSolDerivacion(Request);
        }

        //---------------------------
        // Insert AdmSolAtenAutoriza
        //---------------------------
        public bool Ins_AdmSolAtenAutoriza(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cPerCodigoAut) 
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigoAut = cPerCodigoAut;

            return Obj.Ins_AdmSolAtenAutoriza(Request);
        }

        //-----------------------------------------------
        //Obtener Nuevo Id correlativo for AddSolAtencion
        //-----------------------------------------------
        public string Get_NewId_AdmSolAtencion()
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            return Obj.Get_NewId_AdmSolAtencion();

        }

        //-------------------------
        //Get List AdmSolAtencion
        //------------------------
        public DataTable Get_List_AdmSolAtencion(string Flag, string nSolAdmNumero, string cPerIdeNumero, string cPerApellidos, string dFecIni, string dFecFin)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.Flag = Flag;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerIdeNumero = cPerIdeNumero;
            Request.cPerApellidos= cPerApellidos;
            Request.dFecIni= dFecIni;
            Request.dFecFin= dFecFin;

            return Obj.Get_List_AdmSolAtencion(Request);

        }

        //-------------------------
        //Get DetAdmSolAtencion
        //------------------------
        public DataTable Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_DetAdmSolAtencion_for_cPerJuridica_nSolAdmNumero(Request);

        }

        //---------------------------
        // Insert AdmSolAtenAutoriza
        //---------------------------
        public bool Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero, string cCtaCteRecibo, int nAdmSolEstado, string cPerCodigoAut)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cCtaCteRecibo = cCtaCteRecibo;
            Request.nAdmSolEstado = nAdmSolEstado;
            Request.cPerCodigoAut = cPerCodigoAut;

            return Obj.Upd_AdmSolAtencion_for_cPerJuridica_nSolAdmNumero(Request);
        }


        //-------------------------
        // Insert AdmSolDiagnostico
        //-------------------------
        public bool Ins_AdmSolDiagnostico(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cDiagCodigo)
        {
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cDiagCodigo = cDiagCodigo;

            return Obj.Ins_AdmSolDiagnostico(Request);
        }

        //-------------------------
        // Delete AdmSolDiagnostico
        //-------------------------
        public bool Del_AdmSolDiagnostico(string cPerJuridica, int nIntCodigo, string nSolAdmNumero, string cDiagCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cDiagCodigo = cDiagCodigo;

            if (Obj.Get_AdmSolDiagnostico_for_cPerJuridica_nSolAdmNumero_cDiagCodigo(Request).Rows.Count > 0)
            {
                Resultado = Obj.Del_AdmSolDiagnostico(Request);
            }
            return Resultado;
        }

        //-------------------------
        //Get DetAdmSolAtencion
        //------------------------
        public DataTable Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(string cPerJuridica, int nIntCodigo, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_AdmSolDiagnostico_for_cPerJuridica_nIntCodigo_nSolAdmNumero(Request);

        }

        //---------------------------
        // Insert AdmSolListaEmpleado
        //---------------------------
        public bool Ins_Upd_AdmSolListaEmpleado(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero, string cPerCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            if (!Obj.Ins_Upd_AdmSolListaEmpleado(Request))
            {
                throw new ApplicationException("Se encontraron errores en la transaccion: [Insert/Update: AdmSolListaEmpleado].!");
            }
            else {
                Resultado = true; 
            }

            return Resultado;
        }

        //---------------------------
        // Delete AdmSolListaEmpleado
        //---------------------------
        public bool Del_AdmSolListaEmpleado(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero, string cPerCodigo)
        {
            bool Resultado = false;

            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            if (Obj.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(Request).Rows.Count > 0)
            {
                Resultado = Obj.Del_AdmSolListaEmpleado(Request);
            }

            return Resultado;
        }

        //--------------------------------------------------------------------------------------------
        //Get List AdmSolListaEmpleado for cPerJuridica, nIntCodigo, cPerCodigoTerceros, nSolAdmNumero
        //--------------------------------------------------------------------------------------------
        public DataTable Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(string cPerJuridica, int nIntCodigo, string cPerCodigoTerceros, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nIntCodigo = nIntCodigo;
            Request.cPerCodigoTerceros = cPerCodigoTerceros;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_AdmSolListaEmpleado_by_cPerJuridica_nIntCodigo_cPerCodigoTerceros_nSolAdmNumero(Request);

        }

        //-----------------------------------------------------------------------
        //Get List AdmSolAtencion by cPerJuridica, nSolAdmNumero y cPercodigo
        //-----------------------------------------------------------------------
        public DataTable Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(string cPerJuridica, string nSolAdmNumero, string cPerCodigo)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;
            Request.cPerCodigo = cPerCodigo;

            return Obj.Get_Cab_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero_cPerCodigo(Request);

        }

        //-----------------------------------------------------------
        //Get Detalle AdmSolAtencion by cPerJuridica y nSolAdmNumero 
        //-----------------------------------------------------------
        public DataTable Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero(string cPerJuridica, string nSolAdmNumero)
        {
            //Recuperando registros 
            BE_ReqSolAtencion Request = new BE_ReqSolAtencion();
            DA_AdmSolAtencion Obj = new DA_AdmSolAtencion();

            Request.cPerJuridica = cPerJuridica;
            Request.nSolAdmNumero = nSolAdmNumero;

            return Obj.Get_Det_AdmSolAtencion_by_cPerJuridica_nSolAdmNumero(Request);

        }

    }
}
