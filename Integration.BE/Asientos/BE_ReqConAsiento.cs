using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Asientos
{
    public class BE_ReqConAsiento
    {
        public int nAsiCodigo { get; set; }
        public int nOrigen { get; set; }
        public int nPrdCodigo { get; set; }
        public int nAsiCorrelativo { get; set; }
        public int nUniOrgCodigo { get; set; }
        public string cDocCodigo { get; set; }
        public DateTime dAsiFecha { get; set; }
        public string cAsiGlosa { get; set; }
        public int nAsiEstado { get; set; }
    }

    public class BE_ReqConAsiDetalle{
        public int nAsiCodigo { get; set; }
        public int nCorrelativo { get; set; }
        public int nConCtaCodigo { get; set; }
        public int nMoneda { get; set; }
        public int nDestino { get; set; }
        public double fMonto { get; set; }
        public DateTime dFecha { get; set; }
        public double fTC	 { get; set; }
        public string cGlosa { get; set; }
        public int nEstado { get; set; }
        public string cDocCodigo { get; set; }
    }

    public class BE_ReqConAsiDetInt
    {
        public int nCtaConCodigo { get; set; }
        public int nCorrelativo { get; set; }
        public int nAsiCodigo { get; set; }
        public int nIntCodigo { get; set; }
        public int nIntClase { get; set; }
        public int nMonCodigo { get; set; }
        public double fMonto { get; set; }
        public double fTC { get; set; }
    }

    public class BE_ReqDocumentos
    {
        public string cDocCodigo { get; set; }
        public DateTime dDocFecha { get; set; }
        public string cDocObserv { get; set; }
        public int nDocTipo { get; set; }
        public int nEstado { get; set; }
    }

    public class BE_ReqDocInterface
    {
        public string cDocCodigo { get; set; }
        public int nIntCodigo { get; set; }
        public int nIntClase { get; set; }
        public DateTime dDocIntReg { get; set; }
    }

    public class BE_ReqDocIdentifica
    {
        public string cDocCodigo { get; set; }
        public int nDocTipoNum { get; set; }
        public string cDocNDoc { get; set; }
    }

    public class BE_ReqDocComprobante
    {
        public string cDocCodigo { get; set; }
        public int nTipo { get; set; }
        public int nMoneda { get; set; }
        public double fMonto { get; set; }
    }

    public class BE_ReqDocPersona
    {
        public string cDocCodigo { get; set; }
        public int nDocPerTipo { get; set; }
        public string cPerCodigo { get; set; }
        public int nPerRelacion { get; set; }
        public int nDocTipo { get; set; }
    }

    public class BE_ReqDocVigencia
    {
        public string cDocCodigo { get; set; }
        public DateTime dFechaIni { get; set; }
        public DateTime dFechaFin { get; set; }
    }

    public class BE_ReqDocRef
    {
        public string cDocCodigo { get; set; }
        public string cDocRefCodigo { get; set; }
        public DateTime dDocRefFecReg { get; set; }
    }

    public class BE_ReqGetDocumentoNewId
    {
        public string cPerJurCodigo { get; set; }
        public string newcdoccodigo { get; set; }
    }

    public class BE_ReqGetConAsientoNewId
    {
        public string cPerJurCodigo { get; set; }
        public string nUniOrgCodigo { get; set; }
    }

    public class BE_ReqParametros
    {
        public string cPerJurCodigo { get; set; }
        public int nIntTipo { get; set; }
        public string cIntJerarquia { get; set; }
        public int nUniOrgCodigo { get; set; }
        public int nPrdCodigo { get; set; }
        public int nOrigen { get; set; }
    }
}
