using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqProgramacionBath
    {
        public string cPerJurCodigo	{get; set;}
	    public long nPrdCodigo {get; set;}
	    public long nCtaCteSerCodigo {get; set;}
        public long nMesProceso { get; set; }
        public string cPerCodigo { get; set; }
        public string cPerColeFalle { get; set; }
        public DateTime  dFecFallece  { get; set; }
    }
}
