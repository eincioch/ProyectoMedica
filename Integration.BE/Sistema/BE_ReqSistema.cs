using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Sistema
{
    public class BE_ReqSistema
    {
        public string cPerCodigo {get;set;}
        public string cPerJurRepCodigo { get; set; }
        public long nPerJurTipInversion { get; set; }
        public long nPerJurSecEconomico { get; set; }
        public long nSisGruCodigo { get; set; }

    }

    public class BE_ReqSysConfig
    { 
        public string NameHosts	{ get; set; }
	    public string AdressIP	{ get; set; }
	    public string PathRpt	{ get; set; }
        public long NroCaja { get; set; }
        public long nTipoDocuDefault { get; set; } 
    }

    public class BE_Info
    {
        public string Server { get; set; }
        public string BD { get; set; }
    }
}
