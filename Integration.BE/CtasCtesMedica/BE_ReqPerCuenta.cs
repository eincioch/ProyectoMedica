using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtesMedica
{
    public class BE_ReqPerCuenta
    {
        public int nPerCtaCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public string cNroCuenta { get; set; }
        public int nPerCtaTipo { get; set; }
        public string cPerJurCodigo { get; set; }
        public int nMonCodigo { get; set; }
        public int nPerCtaEstado { get; set; }
        public string cNroCuentaOpera { get; set; }
    }
}
