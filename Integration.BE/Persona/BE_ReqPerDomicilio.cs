using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerDomicilio
    {
        public long  nPerDirCodigo { get; set; }
        public string cPerCodigo {get; set; }
        public long nPerDomTipo {get; set; } 
        public string cPerDomDireccion {get; set; } 
        public string cPerDomNumero {get; set; } 
        public string cPerDomManzana {get; set; } 
        public string cPerDomLote {get; set; }
        public long nPerDomSubTipo {get; set; } 
        public string cPerDomSubTipoNumero {get; set; }
        public long nPerDomResTipo {get; set; } 
        public string cPerDomResNombre {get; set; } 
        public long nPerDomSecTipo {get; set; } 
        public string cPerDomSecNombre {get; set; } 
        public string cUbiGeoCodigo {get; set; }
        public long nPerDomStatus { get; set; } 
    }
}
