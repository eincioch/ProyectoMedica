using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerCuenta
    {
        public long nPerCtaCodigo {get; set;}
	    public string cPerCodigo {get; set;}
	    public string cNroCuenta {get; set;}
	    public long nPerCtaTipo	 {get; set;}
	    public string cPerJurCodigo {get; set;}
	    public long nMonCodigo  {get; set;}
	    public long nPerCtaEstado  {get; set;}
        public string cNroCuentaOpera { get; set; }
    }

    public class BE_ReqBuscarEntidadFinanciera
    { 
        public string cFlag {get; set;}
	    public string cPerJurCodigo {get; set;}
	    public string cPerCodigo {get; set;}
        public long nPerIntCodigo { get; set; }
    }
}
