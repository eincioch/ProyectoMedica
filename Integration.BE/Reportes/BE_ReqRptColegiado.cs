using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Reportes
{
    public class BE_ReqRptColegiado
    {
        public string cNameRpt { get; set; }
        public DateTime  dFecIni { get; set; }
        public DateTime  dFecFin { get; set; }
        public string  cPerCodigo { get; set; }
        public long nCtaCteSerCodigo { get; set; }
        public string cEstado { get; set; }
    }
}
