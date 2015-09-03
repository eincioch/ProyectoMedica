using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteEstadoCuentaCole
    {
        public string cPerJurCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public long nCtaCteSerCodigo { get; set; }
    }

    public class BE_ReqCtaCteEstadoCole
    {
        public string cPerJurCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public string cPerIdeNumero { get; set; }
    }
}
