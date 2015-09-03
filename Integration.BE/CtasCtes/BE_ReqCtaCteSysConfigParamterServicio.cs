using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteSysConfigParamterServicio
    {
        public string  cPerJurCodigo {get; set;}
	    public long nSisModulo	{get; set;}
	    public long nParCodigo_nProCodigo	{get; set;}
	    public long nParCodigo_nSolAdmTipo	{get; set;}
	    public long nParCodigo_nCtaCteSerCodigo	{get; set;}
	    public double nSysValor	{get; set;}
	    //--,@dSysFecEfctiva	datetime
        public long nSysEstado { get; set; }
        public string cFLag { get; set; }
    }
}
