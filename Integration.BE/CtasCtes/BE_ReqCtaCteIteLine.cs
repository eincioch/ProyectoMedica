using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteIteLine
    {
        public string cPerJurCodigo	{get; set;}
	    public string cPerCodigo	{get; set;}
	    public string cCtaCteRecibo {get; set;}
        public long nCtaCteRecLine { get; set; }
        public long nCtaCteSerCodigo { get; set; }
	    public long nCtaCteLinMoneda { get; set; }
	    public long nCtaCteLinCantidad { get; set; }
        public double nCtaCteLinPrecioUnit { get; set; }
        public double nCtaCteLinImporte	{ get; set; }
	    public double nCtaCteLinTC { get; set; }
        public double nCtaCteLinIGV { get; set; }
        public double nCtaCteLinEstado { get; set; }
    }
}
