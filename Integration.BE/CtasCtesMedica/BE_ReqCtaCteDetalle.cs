using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqCtaCteDetalle
    {
        public string cCtaCteRecibo { get; set; }
        public int Item { get; set; }
        public int nSerCodigo { get; set; } //codigo servicio CtaCteServicio
        public double nCtaCteCantidad { get; set; }
        public int nMoneda { get; set; }
        public double fCtaCteTC { get; set; }
        public double fCtaCteIGV { get; set; }
        public double fCtaCteDetimporte { get; set; }
        public DateTime dCtaCteDetRegistro { get; set; }
        public int nCtaCtedetEstado { get; set; }
    }
}
