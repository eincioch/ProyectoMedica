using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Constante
{
    public class BE_ReqConstante
    {
        public string flag { get; set; }
        public long nConCodigo { get; set; }
    }

    public class BE_ReqInsUpdConstante
    {
        public string flag { get; set; }
        public long nConCodigo { get; set; }
        public string cConDescripcion { get; set; }
        public long nConValor { get; set; }
    }
}
