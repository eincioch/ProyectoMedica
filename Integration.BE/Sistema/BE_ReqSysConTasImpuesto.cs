using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Sistema
{
    public class BE_ReqSysConTasImpuesto
    {
        public long nSysTasContry {get;set;}
        public long nSysTasCodigo { get; set; }
        public string nSysTasFecha { get; set; }
	    public string cSysTasDescripcion {get;set;} 
	    public string cSysTasNombre	{get;set;}
        public double fSysTasValor {get;set;}
    }

    public class BE_ReqTipodeCambio
    { 
        public long nMonCodigo {get;set;}
	    public long nAnno {get;set;}
        public long nMes { get; set; }
        public string nFlag	{ get; set; }
        public string cFecha { get; set; }
    }

    public class BE_ReqInsTipodeCambio
    { 
        public string dTasFecha	{get;set;}
	    public long nMonCodigo {get;set;}
	    public long  nTasTipo {get;set;}
        public double fTasValor {get; set;}
    }
}
