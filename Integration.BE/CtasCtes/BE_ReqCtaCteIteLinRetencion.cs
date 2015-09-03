using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteIteLinRetencion
    {
        public string cPerJurCodigo	{get; set;}
	    public string  cPerCodigo {get; set;}
	    public string cCtaCteRecibo	 {get; set;}
	    public long nCtaCteRecLine	 {get; set;}
	    public long nCtaCteRecLinTipo	{get; set;}
	    public double nCtaCteRecLinImpote	{get; set;}
	    public double nCtaCteRecLinPorce {get; set;}
        public DateTime dCtaCteRecLinFecha { get; set; }
    }
}
