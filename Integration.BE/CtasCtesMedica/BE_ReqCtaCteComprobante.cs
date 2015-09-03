using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqCtaCteComprobante
    {
        public string cCtaCteRecibo { get; set; }
        public int nCtaCteComCodigo { get; set; } //Codigo Docu. Venta Constante(1063)
        public string cCtaCteComNumero { get; set; }
        public int nCtaCteTipoPago { get; set; } //cod Constante (3002)
        public string cPerCodigo { get; set; }
        public DateTime dCtaCteEmiFecha { get; set; }
    }
}
