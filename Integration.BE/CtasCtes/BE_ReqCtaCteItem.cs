using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.CtasCtes
{
    public class BE_ReqCtaCteItem
    {
        public string cPerJurCodigo	{get; set;}
        public string cPerCodigo	{get; set;}
        public string cCtaCteRecibo	{get; set;}
        public long nPrdCodigo	{get; set;}
        public string cTipCtaCodigo	{get; set;}
        public long nYear	{get; set;}
        public double nCtaCteImporte	{get; set;}
        public double nCtaCteImpAplicado	{get; set;}
        public DateTime dCtaCteFecRegistro { get; set; }
        public DateTime dCtaCteFecVence { get; set; }
        public long nCtaCtePagCodigo	{get; set;}     //de tabla pagos cuando es cargo va 0
        public string dCtaCteFecContabiliza { get; set; }
        public long nCtaCtePedCodigo	{get; set;}     //Se hace referencia de una pedido para el caso del colegio en 0
        public long nCtaCteEstado	{get; set;}         //Para identificar si esta pendiente 0, cancelado 1
        public DateTime dCtaCteLasModify { get; set; }
        public string cDocCodigo { get; set; }
        public string cFlag { get; set; } 
    }
}
