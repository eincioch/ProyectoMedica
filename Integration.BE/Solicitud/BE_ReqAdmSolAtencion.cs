using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Solicitud
{
    public class BE_ReqAdmSolAtencion
    {
        //cabecera
        public string   cPerJuridica { get; set; }
        public long     nIntCodigo { get; set; }
        public long     nSolAdmNumero { get; set; }
        public string   cPerCodigo { get; set; }
        public string   dFecRegistro { get; set; }
        public string   dFecExamen { get; set; }
        public string   dFecEntResultado { get; set; }
        public long     nAdmSolEstado { get; set; }
        public string   cCtaCteRecibo { get; set; }
        public double   nImpTotal { get; set; }
        public string   cPerUseCodigo { get; set; }

        //detalle
        public int      nCtaCteSerCodigo { get; set; }
        public long     nCtaCteCantidad { get; set; }
        public double   nCtaCteCosto { get; set; }

    }
}
