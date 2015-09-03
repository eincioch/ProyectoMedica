using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCtePago
    {
        //public long nCtaCtaPagCodigo {get; set;} se autogenera por el SQL identi
	    public string cPerJurCodigo	{get; set;}
	    public string cPerCodigo {get; set;}
	    public string cCtaCteRecAbono {get; set;}
        public long nCajCodigo { get; set; }
        public long nCtaCteComCodigo { get; set; }
        public string cCtaCteComNumero { get; set; }
	    public string cPerUseCodigo  {get; set;}
        public string  cCtaCteObserv { get; set; } 
    }
}
