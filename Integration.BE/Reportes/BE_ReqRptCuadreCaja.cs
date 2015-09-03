using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Reportes
{
    public class BE_ReqRptCuadreCaja
    {
        public string  cPerJurCodigo { get; set; }
        public int nTurno { get; set; }
	    public DateTime dCtaCteComFecIni {get; set;}
        public DateTime dCtaCteComFecFin { get; set; }
    }
}
