using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqCuentaCorriente
    {
        public string cCtaCteRecibo { get; set; }
        public int nPerCtaCodigo { get; set; }
        public int nCtaCteTipo { get; set; }
        public int nCtaCteItem { get; set; }
        public double fCtaCteImporte { get; set; }
        public int nCtaCteCuota { get; set; }
        public int nCtaCteEstado { get; set; }
        public DateTime dCtaCteFecVence { get; set; }
        public DateTime  dCtaCteFecPago { get; set; }
        public DateTime dCtaCteFecEmis { get; set; }
        public string cCtaCteGlosa { get; set; }
        public int nPrdCodigo { get; set; } //Periodo Mes Abierto
        public int nMonCodigo { get; set; }
        public double fCtaCteIgv { get; set; }
        public DateTime dCtaCteFecProg { get; set; }
        public string cSerDescripcion { get; set; }
        public double fCtaCteSaldo { get; set; }
        public int nTipoOperacion { get; set; }
    }
}
