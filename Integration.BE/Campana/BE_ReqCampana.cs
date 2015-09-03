using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Campana
{
    public class BE_ReqCampana
    {
        public int nIntCamp { get; set; }
        public string cPerJurCodigo { get; set; }
        public string cNombreCamp { get; set; }
        public DateTime  dFecIniCamp { get; set; }
        public DateTime  dFecFinCamp { get; set; }
        public double nTCostoCamp { get; set; }
        public string cPerUseCodigo { get; set; }

        public int nCtaCteSerCodigo { get; set; }
        public double nCtaCteCosto { get; set; }

    }
}
