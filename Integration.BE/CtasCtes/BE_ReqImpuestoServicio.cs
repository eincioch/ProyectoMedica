using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqImpuestoServicio
    {
        public string cPerJurCodigo {get; set;}
	    public string cPerCodigo {get; set;}
	    public string cCtaCteRecibo {get; set;}
        public long nCtaCteSerCodigo { get; set; }
        public long nSysTasContry { get; set; }
    }

    public class BE_ReqCalcImpuestoforRecibo
    {
        public string cPerJurCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public string cCtaCteRecibo { get; set; }
    }
}
