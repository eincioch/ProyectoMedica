using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Asientos;
using Integration.DAService.DA_Asiento;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_Asiento
{
    public class BL_ConAsiento
    {
        #region Tabla ConAsiento
        //------------------
        // Insert ConAsiento
        //------------------
        public bool Ins_ConAsiento(int nAsiCodigo, int nOrigen, int nPrdCodigo, int nAsiCorrelativo, int nUniOrgCodigo, string cDocCodigo, DateTime dAsiFecha, string cAsiGlosa, int nAsiEstado)
        {
            bool exito = false;

            try
            {
                BE_ReqConAsiento ReqConAsiento = new BE_ReqConAsiento();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.nAsiCodigo = nAsiCodigo;
                ReqConAsiento.nOrigen = nOrigen;
                ReqConAsiento.nPrdCodigo = nPrdCodigo;
                ReqConAsiento.nAsiCorrelativo = nAsiCorrelativo;
                ReqConAsiento.nUniOrgCodigo = nUniOrgCodigo;
                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.dAsiFecha = dAsiFecha;
                ReqConAsiento.cAsiGlosa = cAsiGlosa;
                ReqConAsiento.nAsiEstado = nAsiEstado; //1-Activo

                if (!ObjConAsiento.Ins_ConAsiento(ReqConAsiento)){
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_ConAsiento].!");
                }
                else { 
                    exito = true; 
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla ConAsiDetalle
        //----------------------
        // Insert ConAsiDetalle
        //---------------------
        public bool Ins_ConAsiDetalle(int nAsiCodigo, int nCorrelativo, int nConCtaCodigo, int nMoneda, int nDestino, double fMonto, DateTime dFecha, double fTC, string cGlosa, int nEstado, string cDocCodigo = "")
        {
            bool exito = false;

            try
            {
                BE_ReqConAsiDetalle ReqConAsiento = new BE_ReqConAsiDetalle();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.nAsiCodigo = nAsiCodigo;
                ReqConAsiento.nCorrelativo = nCorrelativo;
                ReqConAsiento.nConCtaCodigo = nConCtaCodigo;
                ReqConAsiento.nMoneda = nMoneda;
                ReqConAsiento.nDestino = nDestino;
                ReqConAsiento.fMonto = fMonto;
                ReqConAsiento.dFecha = dFecha;
                ReqConAsiento.fTC = fTC;
                ReqConAsiento.cGlosa = cGlosa;
                ReqConAsiento.nEstado = nEstado;
                ReqConAsiento.cDocCodigo = cDocCodigo; 

                if (!ObjConAsiento.Ins_ConAsiDetalle(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_ConAsiento].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla ConAsiDetInt
        //----------------------
        // Insert ConAsiDetInt
        //---------------------
        public bool Ins_ConAsiDetInt(int nCtaConCodigo, int nCorrelativo, int nAsiCodigo, int nIntCodigo, int nIntClase, int nMonCodigo, double fMonto, double fTC)
        {
            bool exito = false;

            try
            {
                BE_ReqConAsiDetInt ReqConAsiento = new BE_ReqConAsiDetInt();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.nCtaConCodigo = nCtaConCodigo;
                ReqConAsiento.nCorrelativo = nCorrelativo;
                ReqConAsiento.nAsiCodigo = nAsiCodigo;
                ReqConAsiento.nIntCodigo = nIntCodigo;
                ReqConAsiento.nIntClase = nIntClase;
                ReqConAsiento.nMonCodigo = nMonCodigo;
                ReqConAsiento.fMonto = fMonto;
                ReqConAsiento.fTC = fTC;
               

                if (!ObjConAsiento.Ins_ConAsiDetInt(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_ConAsiDetInt].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla Documentos
        //----------------------
        // Insert Documentos
        //---------------------
        public bool Ins_Documentos(string cDocCodigo, DateTime dDocFecha,string cDocObserv="", int nDocTipo=3001, int nEstado=3003)
        {
            bool exito = false;

            try
            {
                BE_ReqDocumentos ReqConAsiento = new BE_ReqDocumentos();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.dDocFecha = dDocFecha;
                ReqConAsiento.cDocObserv = cDocObserv;
                ReqConAsiento.nDocTipo = nDocTipo;
                ReqConAsiento.nEstado = nEstado;

                if (!ObjConAsiento.Ins_Documentos(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_Documentos].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocInterface
        //----------------------
        // Insert DocInterface
        //---------------------
        public bool Ins_DocInterface(string cDocCodigo, int nIntCodigo, int nIntClase, DateTime dDocIntReg)
        {
            bool exito = false;

            try
            {
                BE_ReqDocInterface ReqConAsiento = new BE_ReqDocInterface();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.nIntCodigo = nIntCodigo;
                ReqConAsiento.nIntClase = nIntClase;
                ReqConAsiento.dDocIntReg = dDocIntReg;

                if (!ObjConAsiento.Ins_DocInterface(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocInterface].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocIdentifica
        //----------------------
        // Insert DocIdentifica
        //---------------------
        public bool Ins_DocIdentifica(string cDocCodigo, int nDocTipoNum, string cDocNDoc)
        {
            bool exito = false;

            try
            {
                BE_ReqDocIdentifica ReqConAsiento = new BE_ReqDocIdentifica();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.nDocTipoNum = nDocTipoNum;
                ReqConAsiento.cDocNDoc = cDocNDoc;

                if (!ObjConAsiento.Ins_DocIdentifica(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocIdentifica].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocComprobante
        //----------------------
        // Insert DocComprobante
        //----------------------
        public bool Ins_DocComprobante(string cDocCodigo, int nTipo, int nMoneda, double fMonto)
        {
            bool exito = false;

            try
            {
                BE_ReqDocComprobante ReqConAsiento = new BE_ReqDocComprobante();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.nTipo = nTipo;
                ReqConAsiento.nMoneda = nMoneda;
                ReqConAsiento.fMonto = fMonto;

                if (!ObjConAsiento.Ins_DocComprobante(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocComprobante].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocPersona
        //----------------------
        // Insert DocPersona
        //----------------------
        public bool Ins_DocPersona(string cDocCodigo, int nDocPerTipo, string cPerCodigo, int nPerRelacion, int nDocTipo)
        {
            bool exito = false;

            try
            {
                BE_ReqDocPersona ReqConAsiento = new BE_ReqDocPersona();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.nDocPerTipo = nDocPerTipo;
                ReqConAsiento.cPerCodigo = cPerCodigo;
                ReqConAsiento.nPerRelacion = nPerRelacion;
                ReqConAsiento.nDocTipo = nDocTipo;

                if (!ObjConAsiento.Ins_DocPersona(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocPersona].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocVigencia
        //----------------------
        // Insert DocVigencia
        //----------------------
        public bool Ins_DocVigencia(string cDocCodigo, DateTime dFechaIni, DateTime dFechaFin)
        {
            bool exito = false;

            try
            {
                BE_ReqDocVigencia ReqConAsiento = new BE_ReqDocVigencia();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.dFechaIni = dFechaIni;
                ReqConAsiento.dFechaFin = dFechaFin;

                if (!ObjConAsiento.Ins_DocVigencia(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocVigencia].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Tabla DocRef
        //----------------------
        // Insert DocRef
        //----------------------
        public bool Ins_DocRef(string cDocCodigo, string cDocRefCodigo, DateTime dDocRefFecReg)
        {
            bool exito = false;

            try
            {
                BE_ReqDocRef ReqConAsiento = new BE_ReqDocRef();
                DA_ConAsiento ObjConAsiento = new DA_ConAsiento();

                ReqConAsiento.cDocCodigo = cDocCodigo;
                ReqConAsiento.cDocRefCodigo = cDocRefCodigo;
                ReqConAsiento.dDocRefFecReg = dDocRefFecReg;

                if (!ObjConAsiento.Ins_DocRef(ReqConAsiento))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_DocRef].!");
                }
                else
                {
                    exito = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion

        #region Obtener (nIntCodigo) de Interface segun 7001(PlanContable)-7002(Origen)-7003(CentroCostos) Periodo Actual

        public int Get_nIntCodigo_Interface(string cPerJurCodigo, int nIntTipo = 7001, string cIntJerarquia="40111")
        {
            int nIntCodigo = 0;
            try
            {
                BE_ReqParametros ReqOrigen = new BE_ReqParametros();
                DA_ConAsiento ObjAsiento = new DA_ConAsiento();
    
                ReqOrigen.cPerJurCodigo = cPerJurCodigo;
                ReqOrigen.nIntTipo = nIntTipo; //Origen
                ReqOrigen.cIntJerarquia = cIntJerarquia; //Ventas
                nIntCodigo = ObjAsiento.usp_Get_Interface_nIntCodigo_by_cPerJurCodigo_and_nIntTipo_and_cIntJerarquia(ReqOrigen);

                if (nIntCodigo == 0)
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Get_nIntCodigo_Interface].!");
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nIntCodigo;
        }
        #endregion

        #region *** Generando Asiento de Ventas ***

        public bool Ins_GenerandoAsientoVta(string cPerJurCodigo, string cPerCodigo, DateTime dAsiFecha, string cGlosa, string CtaX, string CtaIgv, string CtaSub, string CentroCosto, string cDocObserv, int nDocTipo = 3001, int nEstado = 3003, string cDocRefCodigo="", string cDocNDoc = "", int nMoneda = 1, double fTC = 0, double fMonto = 0.0)
        {
            bool exito = false;
            int nOrigen = 0;
            int nUniOrgCodigo = 0;
            int nPrdCodigo = 0;
            int nAsiCorrelativo = 0;
            int nAsiCodigo=0;

            string cDocCodigo="";

            double nSubTotal = 0.0;
            double nIgv = 0.0;
                        
            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    DA_ConAsiento ObjAsiento = new DA_ConAsiento();

                    #region Obtener Origen Contable "Ventas"
                    //BE_ReqParametros ReqOrigen = new BE_ReqParametros();
                    //ReqOrigen.cPerJurCodigo = cPerJurCodigo;
                    //ReqOrigen.nIntTipo = 7002; //Origen
                    //ReqOrigen.cIntJerarquia = "402"; //Ventas
                    //nOrigen = ObjAsiento.usp_Get_Interface_nIntCodigo_by_cPerJurCodigo_and_nIntTipo_and_cIntJerarquia(ReqOrigen);

                    nOrigen = Get_nIntCodigo_Interface(cPerJurCodigo, 7002, "402");
                    #endregion

                    #region Obtener Codigo Unidad Organizacional
                    BE_ReqParametros ReqUniOrg = new BE_ReqParametros();
                    ReqUniOrg.cPerJurCodigo = cPerJurCodigo;
                    nUniOrgCodigo = ObjAsiento.Get_UnidadOrganizacional_by_cPerJuridica(ReqUniOrg);
                    #endregion

                    #region Obtener Periodo Contable
                    BE_ReqParametros ReqPeriodo = new BE_ReqParametros();
                    ReqPeriodo.cPerJurCodigo = cPerJurCodigo;
                    nPrdCodigo = ObjAsiento.Get_Periodo_by_cPerJurCodigo(ReqPeriodo);
                    #endregion

                    #region Obtener nAsiCorrelativo by nUniOrgCodigo, nPrdCodigo y nOrigen
                    BE_ReqParametros ReqnAsiNumero = new BE_ReqParametros();
                    ReqnAsiNumero.nUniOrgCodigo = nUniOrgCodigo;
                    ReqnAsiNumero.nPrdCodigo = nPrdCodigo;
                    ReqnAsiNumero.nOrigen = nOrigen;

                    nAsiCorrelativo = ObjAsiento.Get_nAsiCorrelativo_by_nUniOrgCodigo_and_nPrdCodigo_and_nOrigen(ReqnAsiNumero);
                    #endregion

                    #region Obteniendo NewID "nAsiCodigo"

                    BE_ReqGetConAsientoNewId ReqNewIDnAsiento = new BE_ReqGetConAsientoNewId();
                    ReqNewIDnAsiento.cPerJurCodigo = cPerJurCodigo;
                    ReqNewIDnAsiento.nUniOrgCodigo = null;
                    nAsiCodigo = ObjAsiento.Get_NewID_ConAsiento(ReqNewIDnAsiento);

                    #endregion 
                    
                    //-----------
                    //ConAsiento
                    //-----------
                    if (!Ins_ConAsiento(nAsiCodigo, nOrigen, nPrdCodigo, nAsiCorrelativo, nUniOrgCodigo, "", dAsiFecha, "", 1)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: ConAsiento].!");
                    }

                    #region Generando nuevo Dcoumento(cDocCodigo)
                    BE_ReqGetDocumentoNewId ReqcDocu = new BE_ReqGetDocumentoNewId();
                    ReqcDocu.cPerJurCodigo = cPerJurCodigo;
                    cDocCodigo = ObjAsiento.Get_NewID_Documento(ReqcDocu);
                    #endregion
                    
                    //--------------
                    //ConAsiDetalle
                    //--------------
                    nSubTotal = fMonto / 1.18;
                    nIgv = (fMonto / 1.18) * 0.18;

                    if (nDocTipo == 3001)
                    { //factura
                        if (!Ins_ConAsiDetalle(nAsiCodigo, 10, Get_nIntCodigo_Interface(cPerJurCodigo,7001,CtaX), nMoneda, 7001, fMonto, dAsiFecha, fTC, cGlosa, 1, cDocCodigo)
                                & !Ins_ConAsiDetalle(nAsiCodigo, 20, Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), nMoneda, 7003, nIgv, dAsiFecha, fTC, cGlosa, 1)
                                & !Ins_ConAsiDetalle(nAsiCodigo, 30, Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), nMoneda, 7003, nSubTotal, dAsiFecha, fTC, cGlosa, 1)
                            )
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: ConAsiDetalle].!");
                        }

                        //-------------
                        //ConAsiDetInt
                        //-------------
                        if (!Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX),10,nAsiCodigo,2222,1105,nMoneda,0,fTC) //2222-saldo(constante)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 10, nAsiCodigo, 1, 7005, nMoneda, fMonto, fTC) //libro(interface)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 10, nAsiCodigo, nPrdCodigo, 1007, nMoneda, 0, fTC)  //nPeriodo
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 10, nAsiCodigo, 7010, 1105, nMoneda, fMonto, fTC)  //7010-Equivalente(constante)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), 20, nAsiCodigo, 1, 7005, nMoneda, nIgv, fTC)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), 20, nAsiCodigo, 7010, 1105, nMoneda, nIgv, fTC)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), 30, nAsiCodigo, 7010, 1105, nMoneda, nSubTotal, fTC) //7010-Equivalente(constante)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), 30, nAsiCodigo, 1, 7005, nMoneda, nSubTotal, fTC)  //libro(interface)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), 30, nAsiCodigo, Get_nIntCodigo_Interface(cPerJurCodigo, 7003, CentroCosto), 7003, nMoneda, nSubTotal, fTC) //centro de costos
                                )
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: Documentos].!");
                        }
                    }
                    else {
                        if (!Ins_ConAsiDetalle(nAsiCodigo, 10, Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), nMoneda, 7001, nSubTotal, dAsiFecha, fTC, cGlosa, 1)
                                & !Ins_ConAsiDetalle(nAsiCodigo, 11, Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), nMoneda, 7003, nIgv, dAsiFecha, fTC, cGlosa, 1, cDocCodigo)
                                & !Ins_ConAsiDetalle(nAsiCodigo, 12, Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), nMoneda, 7003, fMonto, dAsiFecha, fTC, cGlosa, 1, cDocCodigo)
                            )
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: ConAsiDetalle].!");
                        }

                        //-------------
                        //ConAsiDetInt
                        //-------------
                        if (!Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), 10, nAsiCodigo, Get_nIntCodigo_Interface(cPerJurCodigo, 7003, CentroCosto), 7003, nMoneda, nSubTotal, fTC) //centro costos
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaSub), 10, nAsiCodigo, 7010, 1105, nMoneda, nSubTotal, fTC)  //7010-Equivalente(constante)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), 11, nAsiCodigo, 3, 7005, nMoneda, nIgv, fTC) //Libro(3-ventas)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaIgv), 11, nAsiCodigo, 7010, 1105, nMoneda, nIgv, fTC)  //7010-Equivalente(constante)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 12, nAsiCodigo, 2222, 1105, nMoneda, fMonto, fTC) //2222-Saldo
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 12, nAsiCodigo, 1, 7005, nMoneda, fMonto, fTC)  //libro(interface)
                                & !Ins_ConAsiDetInt(Get_nIntCodigo_Interface(cPerJurCodigo, 7001, CtaX), 12, nAsiCodigo, 7010, 1105, nMoneda, fMonto, fTC) //7010-Equivalente(constante)
                                )
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: Documentos].!");
                        }

                    }
                    
                    //-----------
                    //Documentos
                    //-----------
                    if (!Ins_Documentos(cDocCodigo,dAsiFecha,cDocObserv,nDocTipo,nEstado)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: Documentos].!");
                    }

                    //--------------
                    //DocInterface
                    //--------------
                    if (!Ins_DocInterface(cDocCodigo,nAsiCodigo,7009, dAsiFecha) 
                            & !Ins_DocInterface(cDocCodigo,3, 7005,dAsiFecha) //7005-Ventas (Tipo de Libro
                            & !Ins_DocInterface(cDocCodigo,7003,1070, dAsiFecha)) // 7003-Haber (Destino)
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: Documentos].!");
                    }

                    //--------------
                    //DocIdentifica
                    //--------------
                    if (!Ins_DocIdentifica(cDocCodigo,1,cDocNDoc)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: DocIdentifica].!");
                    }

                    //--------------
                    //DocComprobante
                    //--------------
                    //if (nDocTipo == 3001)
                    //{ //factura
                    if (!Ins_DocComprobante(cDocCodigo,1000,nMoneda,fMonto) //1000-Total
                            & !Ins_DocComprobante(cDocCodigo, 1001, nMoneda, nSubTotal) //1001-Sub-Total
                            & !Ins_DocComprobante(cDocCodigo, 1050, nMoneda, fTC) //1050-Tipo Cambio del dia
                            & !Ins_DocComprobante(cDocCodigo, 2001, nMoneda, nIgv) //2001-IGV
                        )
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: DocComprobante].!");
                    }
                    //}

                    //----------
                    //DocPersona
                    //----------
                    if (nDocTipo == 3001){ //factura
                        nDocTipo=11;
                    }else{
                        nDocTipo=25;
                    }

                    if (!Ins_DocPersona(cDocCodigo,1,cPerCodigo ,16,nDocTipo)  //Cliente
                            & !Ins_DocPersona(cDocCodigo, 2,cPerJurCodigo,16, 0) //Empresa (medica)
                            & !Ins_DocPersona(cDocCodigo, 7001, cPerCodigo, 16, nDocTipo)
                            & !Ins_DocPersona(cDocCodigo, 7002, cPerCodigo, 16, nDocTipo)
                            & !Ins_DocPersona(cDocCodigo, 7003, cPerCodigo, 16, nDocTipo)
                            & !Ins_DocPersona(cDocCodigo, 7004, cPerCodigo, 16, nDocTipo)
                            & !Ins_DocPersona(cDocCodigo, 7005, cPerCodigo, 16, nDocTipo)
                        )
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: DocPersona].!");
                    }

                    //-----------
                    //DocVigencia
                    //-----------
                    if (!Ins_DocVigencia(cDocCodigo,dAsiFecha,dAsiFecha)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: DocVigencia].!");
                    }

                    //------
                    //DocRef
                    //------
                    if (!Ins_DocRef(cDocCodigo, cDocRefCodigo, dAsiFecha)){
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Insert: DocRef].!");
                    }
                    else {
                        exito = true;
                    }

                    tx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
        #endregion 
    }
}
