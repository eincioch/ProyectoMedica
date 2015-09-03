using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteDetalle
    {
        public long nCtaCtePagCodigo {get; set;}
	    public long nCtaCteForPago  {get; set;}
	    public long nPerCtaCodigo	 {get; set;}
	    public string cPerjurCodigoFin {get; set;}
	    public DateTime dCtaCteFecTransacion {get; set;}
	    public string cCtaCtePagTracer {get; set;}
	    public long nMonCodigo {get; set;}
	    public double nCtaCtePagImpMon {get; set;}
	    public double nTC {get; set;}
        public double nCtaCtePagImporte { get; set; }
    }
}
