using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerParentesco
    {
        public string cPerCodigo { get; set; }
        public string cPerParCodigo { get; set; }
        public int nPerParTipo { get; set; }
        public int bPerApo { get; set; }
        public int bPerCarta { get; set; }
        public int nPerParEstado { get; set; }
    }
}
