using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteComprobante
    {
        public string cPerJurCodigo	{get; set;}
        public string cPerCodigo {get; set;}
	    public string cCtaCteRecAbono {get; set;}
        public long nCajCodigo { get; set; }
	    public long nCtaCteComCodigo{get; set;}
	    public string cCtaCteComNumero {get; set;} 
	    public DateTime dCtaCteComFecEmision {get; set;}
	    public double nCtaCteComImporte	{get; set;}
	    public string cPerUserCodigo {get; set;}
    }

    public class BE_Req_Get_CtaCteComprobante
    {
        public string cPerJurCodigo { get; set; }
        public string cPerCodigo { get; set; }
        public long nCtaCteComCodigo { get; set; }
        public string cCtaCteComNumero { get; set; }
    }

}
