using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Medica
namespace Integration.BE.CtasCtes
{

    public class BE_ReqCtaCtePrecioServicio
    {
        public int nCtaCteSerCodigo { get; set; }
        public string cPerJurCodigo { get; set; }
        public int nIntCodigo { get; set; }
        public string cIntDescripcion { get; set; }
        public double nCtaCteSerCosto { get; set; }
        public string cPerUseCodigo { get; set; }
        public DateTime  dCtaCTeSerFecEff { get; set; }
        public string cIntJerarquia { get; set; }
        public string cCtaCteSerKeyWord { get; set; }
        public string Flag { get; set; }
    }
}
