using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqCtaCtePago
    {
        public string cCtaCteRecibo { get; set; }
        public int nCtaCtePagcodigo { get; set; } //Correlativo Max(nCtaCtePagcodigo) + 1
        public string cPerCodigo { get; set; }
        public int nPerCtaCodigo { get; set; }
        public int nTurno { get; set; } //Nro. Caja
        public int nForPago { get; set; }
        public string cCtaCtePagNroOperacion { get; set; }
        public DateTime dCtaCtePagfecha { get; set; }
        public string CtaCtePagGlosa { get; set; }
        public double fCtaCtePagImporte { get; set; }
    }
}
