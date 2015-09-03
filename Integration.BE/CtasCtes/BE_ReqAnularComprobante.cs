using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqBuscaComprobante
    {
        public string cPerJurCodigo { get; set; }
        public long nCtaCteComCodigo { get; set; }
        public string cCtaCteComNumero { get; set; }
	    public DateTime dFecIni {get; set;}
	    public DateTime dFecFin {get; set;}
        public string cFlag {get; set;}
    }

    public class BE_AnularComprobante
    {
        public string cflag  {get; set;}
	    public string cPerJurCodigo  {get; set;}
	    public string cPerCodigo  {get; set;}
        public string cCtaCteRecibo {get; set;}
        public string cCtaCteRecAbono { get; set; }
        public string cPerUserCodigo { get; set; }
    }
}
