using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqCtaCtePagDatos
    {
        public int nCtaCtePagcodigo { get; set; } //Correlativo de CtaCtePago
        public string cCtaCtePagDatPerJurCodigo { get; set; }
        public string cCtaCtePagDatBanco { get; set; }
        public string cCtaCtePagDatNroCuenta { get; set; }
        public DateTime dCtaCtePagDatFecha { get; set; }
        public string cCtaCtePagDatNroOperacion { get; set; }
        public double fCtaCtePagDatImporte { get; set; }
    }
}
