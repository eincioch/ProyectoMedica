using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Documento
{
    public class BE_ReqDocPersona
    {
        public string cDocCodigo {get; set;}
	    public long nDocPerTipo {get;set;}
	    public string cPerCodigo {get;set;}
	    public long nPerRelacion {get;set;}
        public long nDocTipo { get; set; }
    }
}
