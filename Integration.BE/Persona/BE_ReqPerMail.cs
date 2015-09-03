using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerMail
    {
        public string cPerCodigo {get; set;} 
        public long nPerMaiTipo {get; set;}
        public string cPerMaiNombre { get; set; }
        public DateTime dPerMaiFecRegistro { get; set; }
    }
}
