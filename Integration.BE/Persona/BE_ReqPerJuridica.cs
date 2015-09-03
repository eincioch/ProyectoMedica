using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPerJuridica
    {
        public string cPerCodigo { get; set; }
        public string cPerJurRepCodigo { get; set; }
        public int nPerJurTipInversion { get; set; }
        public int nPerJurSecEconomico { get; set; }
    }

    public class BE_ReqPerJurSecEconomico
    {
        public string cFlag { get; set; }
    }
}
