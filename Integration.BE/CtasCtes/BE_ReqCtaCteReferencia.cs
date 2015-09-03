using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteReferencia
    {
        public string cPerJurCodigo	{get; set;}
	    public string cPerCodigo {get; set;}
	    public string cCtaCteRecCargo {get; set;}
	    public string cCtaCteRecAbono {get; set;}
	    public long nCtaCtePagCodigo {get; set;}
	    public double nCtaCtePagImporte {get; set;}
	    public string cDocCodigo {get; set;}
        public DateTime dCtaCteFecRegistro { get; set; }
    }
}
