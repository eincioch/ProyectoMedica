using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Solicitud
{
    public class BE_ReqSolRegistro
    {
        public string   cPerJuridica { get; set; }
        public long     nProCodigo { get;set; }
        public long     nSolAdmNumero { get;set; }
        public string   cPerCodigo { get;set; }
        public long     nPerAdmEstado { get;set; }
        public string   dPerAdmRegistro { get;set; }
        public long nPrdCodigo { get; set; }
        public string   cPerJurCodigo { get;set; }
        public string   dAdmSolAcaFecEgreso { get;set; }
        //public double     nAdmSolAcaNota { get;set; }
        public long     nAdmSolEspCodigo { get;set; }
        public long nSolAdmEstado { get; set; }
        public long nSolAdmTipo { get; set; } 
        //public string cPerIdeNumero { get; set; }
    }

    public class BE_ReqSolCorrelativo
    {
        public string cPerCodigo { get; set; } 
    }

    //Buscar AdmSolicitud
    public class BE_ReqBuscaAdmSolicitud
    {
        public string nSolAdmNumero { get; set; } 
	    public string cPerIdeNumero { get; set; } 
        public string fec_ini { get; set; } 
	    public string fec_fin { get; set; }
        public Int16 Condicion { get; set; } 
    }

    //Insert AdmSolDetalle
    public class BE_ReqAdmSolDetalle
    {
        public string cPerJuridica	{get; set;}
	    public long nProCodigo	{get; set;}
	    public string nSolAdmNumero	{get; set;}
	    public long nSolAdmEstado	{get; set;}
	    public long nSolAdmTipo	{get; set;}
	    public long nSolAdmSubTipo	{get; set;}
        public long nSolAdmPrograma { get; set; }
    }

    //Insert AtenderSolicitud
    public class BE_ReqAtenderSolicitud
    {
        public string cPerJuridica {get; set;}
	    public string cPerCodigo {get; set;}
	    public long nProCodigo {get; set;}
	    public string nSolAdmNumero {get; set;}
        public long  nPerTipo { get; set; }
        //public long nSolAdmPrograma { get; set; }
    }

    //Update AdmSolicitud (cCtaCteRecibo)
    public class BE_ReqUpd_AdmSol_cCtaCteRecibo
    {
        public string cPerJuridica { get; set; }
        public long nProCodigo { get; set; }
        public string nSolAdmNumero { get; set; }
        public string cCtaCteRecibo { get; set; }
    }
}
