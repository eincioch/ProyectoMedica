using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Documento
{
    public class BE_FondoMortorio
    {
        public string cDocCodigo { get; set; }
        public long nDocPerTipo { get; set; }
        public string cPerCodigo { get; set; }
        public long nPerRelacion { get; set; }
        public long nDocTipo { get; set; }
        //--DocIdentifica
        public long nDocTipoNum { get; set; }
        public string cDocNDoc { get; set; }
        //--DocFecTramite
        public string dFecInicial { get; set; }
        public string dFecFinal { get; set; }
        public long nMvoCodigo { get; set; }
        //--DocContenido
        public long nDocConTipo { get; set; }
        public string tDocConContenido { get; set; }
        //--DocVigencia
        public string dFechaIni { get; set; }
        public string dFechaFin { get; set; }
    }

    public class BE_Get_Doc_Afiliacion_for_cDocCodigo
    {
        public string cDocCodigo { get; set; }
    }

    public class BE_Del_Beneficiario_for_cDocCodigo
    {
        public string cDocCodigo { get; set; }
        public string cPerCodigo { get; set; }
    }

    public class BE_Get_Beneficiario_for_cDocCodigo
    {
        public string cDocCodigo { get; set; }
        public string cPerCodigo { get; set; }
    }

    public class BE_Ins_Beneficiario_for_cDocCodigo
    {
        public string cDocCodigo { get; set; }
        public long nDocPerTipo { get; set; }
        public string cPerCodigo { get; set; }
        public long nPerRelacion { get; set; }
        public long nDocTipo { get; set; }

    }
}
