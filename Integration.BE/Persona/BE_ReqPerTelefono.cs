using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerTelefono
    {
        public string cPerCodigo {get; set;} 
        public long nPerTelTipo {get; set;} 
        public string cPerTelNumero {get; set;}
        public long nPerTelStatus { get; set; }
        public DateTime dPerTelFecRegistro { get; set; }
    }
}
