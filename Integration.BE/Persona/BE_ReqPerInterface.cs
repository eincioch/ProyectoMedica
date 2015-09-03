using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerInterface
    {
        public string cPerCodigo {get; set;}
	    public long nPerIntCodigo {get; set;}
	    public long nPerIntClase {get; set;}
	    public DateTime  dPerIntFecha {get; set;}
	    public string cPerIntJerarquia {get; set;}
	    public string cPerIntDescripcion {get; set;}
        public long nPerIntTipo { get; set; }
    }
}
