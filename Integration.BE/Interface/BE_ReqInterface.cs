using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//--eincio
namespace Integration.BE.Interface
{
    public class BE_ReqInterface
    {
        public long nIntCodigo	{get;set;}
        public long	nIntClase	{get;set;}
	    public string cIntJerarquia	{get;set;}
	    public string cIntNombre	{get;set;}
	    public string cIntDescripcion	{get;set;}
        public long nIntTipo { get; set; }
        public string cFlag { get; set; }
    }
}
