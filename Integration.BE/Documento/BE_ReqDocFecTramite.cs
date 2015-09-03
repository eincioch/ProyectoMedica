using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Documento
{
    public class BE_ReqDocFecTramite
    {
        public string cDocCodigo {get; set;}
	    public string dFecInicial {get; set;}
	    public string dFecFinal	{get; set;}
        public long nMvoCodigo { get; set; }
    }
}
