using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Solicitud;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_Solicitud
    {
        public bool RegistrarSolicitud(BE_ReqSolRegistro Request)
        {
            
            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Solicitud Obj = new DA_Solicitud();
            return Obj.RegistrarSolictud(Request);
        }

        public string Get_Correlativo_Sol(BE_ReqSolCorrelativo Request)
        {
            string Item = "";
            DA_Solicitud Obj = new DA_Solicitud();
            Item = Obj.Get_Correlativo_Sol(Request);
            return Item;

        }

        public string Get_NewIdColegiado() //BE_ReqSolCorrelativo Request)
        {
            DA_Solicitud Obj = new DA_Solicitud();
            return Obj.Get_NewIdColegiado();

        }

        //buscar AdmSolicitud
        public DataTable Get_AdmSolicitud(BE_ReqBuscaAdmSolicitud Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Solicitud Obj = new DA_Solicitud();
            return Obj.Get_AdmSolicitud(Request);

        }

        //buscar AdmSolicitud en pantalla
        public DataTable Get_AdmSolicitudAcademica(BE_ReqSolRegistro Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Solicitud Obj = new DA_Solicitud();
            return Obj.Get_AdmSolicitudAcademica(Request);

        }

        //Insert AtenderSolicitud
        public BE_ResGenerico InsAtenderSolicitud(BE_ReqAtenderSolicitud Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Solicitud Obj = new DA_Solicitud();
            Item = Obj.InsAtenderSolicitud(Request);
            return Item;
        }

        //Get_FichaIndividual
        public DataTable Get_FichaIndividual(BE_ReqSolFichaIndividual Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_Solicitud Obj = new DA_Solicitud();
            return Obj.Get_FichaIndividual(Request);

        }

        //Upd_AdmSolicitudAcademica
        public bool Upd_AdmSolicitudAcademica(BE_ReqSolRegistro Request)
        {
            DA_Solicitud Da = new DA_Solicitud();
            return Da.Upd_AdmSolicitudAcademica(Request);
        }

        //------------------------
        //Upd_AdmSol_cCtaCteRecibo
        //------------------------
        public bool Upd_AdmSol_cCtaCteRecibo(string cPerJuridica, long nProCodigo, string nSolAdmNumero, string cCtaCteRecibo) 
        {
            bool exito = false;
            try
            { 
                BE_ReqUpd_AdmSol_cCtaCteRecibo ReqAdmSol = new BE_ReqUpd_AdmSol_cCtaCteRecibo();
                DA_Solicitud Da = new DA_Solicitud();

                ReqAdmSol.cPerJuridica = cPerJuridica;
                ReqAdmSol.nProCodigo = nProCodigo;
                ReqAdmSol.nSolAdmNumero = nSolAdmNumero;
                ReqAdmSol.cCtaCteRecibo = cCtaCteRecibo;

                exito = Da.Upd_AdmSol_cCtaCteRecibo(ReqAdmSol);
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
