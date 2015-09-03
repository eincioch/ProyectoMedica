using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Persona;
using Integration.BE.CtasCtes;
using Integration.DAService;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCteServicioFacturacion
    {
        //Get_CtaCteServicioFacturacion
        public DataTable Get_CtaCteServicioFacturacion(BE_CtaCteServicioFacturacion Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteServicioFacturacion Obj = new DA_CtaCteServicioFacturacion();
            return Obj.Get_CtaCteServicioFacturacion(Request);
        }

        //Get_TipoDocporNroCaja
        public DataTable Get_TipoDocporNroCaja(BE_TipoDocporNroCaja Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteServicioFacturacion Obj = new DA_CtaCteServicioFacturacion();
            return Obj.Get_TipoDocporNroCaja(Request);
        }

        //para llenar Combox para los banco y tarjetas
        public DataTable Get_EntidadFinaciera_Tarjetas(BE_ReqBuscarEntidadFinanciera Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteServicioFacturacion Obj = new DA_CtaCteServicioFacturacion();
            return Obj.Get_EntidadFinaciera_Tarjetas(Request);
        }

        #region GenerarCargoSolicitud
        //-----------------------------------
        //Genera Cargo Solicitud Colegiado
        //-----------------------------------
        public bool Ins_GenerarCargoSolicitud(string CodEmpresa, long TipoPrograma,long TipoSolicitud, string cPerCodigo, int nPeriodo, DateTime dFechaSys, string NroSolicitud)
        {
            bool exito = false;

            string NroRecibo = "";
            long nLinea = 0;
            //double nImporte = 0;

            //para Tipo de cambio
            double nTC = 0;
            BL_Sistema daTC = new BL_Sistema();

            //para CtaCteItem
            BL_CtaCteItem blCCItem = new BL_CtaCteItem();
            BL_CtaCteIteLine blCCItemLine = new BL_CtaCteIteLine();
            BL_CtaCteIteLinRetencion blCCRetencion = new BL_CtaCteIteLinRetencion();
            BL_ImpuestoServicio blImpServ = new BL_ImpuestoServicio();

            //para Obtener Serv. Configurado
            BE_ReqCtaCteSysConfigParamterServicio ReqServConfig = new BE_ReqCtaCteSysConfigParamterServicio();
            BL_CtaCteSysConfigParamterServicio daServConfig = new BL_CtaCteSysConfigParamterServicio();

            //actuliza solicitud con el recibo de cargo
            BL_Solicitud DaSolAdm = new BL_Solicitud();

            //----------------------
            //CommittableTransaction
            //----------------------
            Transaction oldAmbient = Transaction.Current;
            CommittableTransaction committableTransaction;
            committableTransaction = oldAmbient as CommittableTransaction;

            if (committableTransaction == null)
            {
                committableTransaction = new CommittableTransaction();
                Transaction.Current = committableTransaction;
            }

            try
            {
                //using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                //{
                //
                ReqServConfig.cPerJurCodigo = CodEmpresa;
                ReqServConfig.nSisModulo = 7001; //default aun falta definir interface
                ReqServConfig.nParCodigo_nProCodigo = TipoSolicitud; //CLng(CboPrograma.SelectedValue)
                ReqServConfig.cFLag = "FEC";

                if (daServConfig.Get_SysConfParametrosServ(ReqServConfig).Rows.Count > 0)
                {
                    DataRow row = daServConfig.Get_SysConfParametrosServ(ReqServConfig).Rows[0];
                    //--------------
                    //Tipo de cambio
                    //--------------
                    if (Convert.ToInt32(row["nMonCodigo"]) == 2) //Dolar
                    {
                        if (daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows.Count > 0)
                        {
                            //DataRow row = daTC.Get_TipodeCambio(ReqTC).Rows[0];
                            nTC = Convert.ToDouble(daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows[0]["nCompra"]);
                        }
                        else throw new ApplicationException("No se ha registrado el Tipo de Cambio del dia: " + String.Format("{0:ddd, MMM d, yyyy}", dFechaSys));
                    }
                    else nTC = 1.0;

                    //----------
                    //CtaCteItem 
                    //----------
                    //se comente esto porque la Actualizacion 28/01/2014 no se necesita esta variable
                    //foreach (DataRow fila in daServConfig.Get_SysConfParametrosServ(ReqServConfig).Rows)
                    //{
                    //    //Obteniendo el total del importe de recibo (cabezera)
                    //    nImporte = nImporte + Convert.ToDouble(fila["nSysValor"]);
                    //}

                    //Actualizacion 28/01/2014:
                    //porque necesitan que cada concepto salga en diferente recibo
                    //NroRecibo = blCCItem.Ins_CtaCteItem(CodEmpresa, cPerCodigo, nPeriodo, row["nCtaCteTipoCta"].ToString(), dFechaSys.Year, nImporte, dFechaSys, 1);

                    //--------------
                    //CtaCteIteLine
                    //--------------
                    //Recorro SysConfParametrosServ
                    foreach (DataRow fila in daServConfig.Get_SysConfParametrosServ(ReqServConfig).Rows)
                    {
                        //aqui se cambio Actualizacion 28/01/2014:
                        NroRecibo = blCCItem.Ins_CtaCteItem(CodEmpresa, cPerCodigo, nPeriodo, row["nCtaCteTipoCta"].ToString(), dFechaSys.Year, Convert.ToDouble(fila["nSysValor"]), dFechaSys, 1);

                        nLinea = blCCItemLine.Ins_CtaCteIteLine(CodEmpresa, cPerCodigo, NroRecibo, Convert.ToInt32(fila["nParCodigo_nCtaCteSerCodigo"]), Convert.ToInt32(fila["nMonCodigo"]), 1, Convert.ToDouble(fila["nSysValor"]), Convert.ToDouble(fila["nSysValor"]), nTC, 1);

                        if (nLinea != 0)
                        {
                            //---------------------
                            //CtaCteIteLinRetencion
                            //---------------------
                            foreach (DataRow posicion in blImpServ.Get_ImpuestoServicio(CodEmpresa, cPerCodigo, NroRecibo, Convert.ToInt32(fila["nParCodigo_nCtaCteSerCodigo"]), 9256).Rows) //9256.- Perú
                            {
                                if (!blCCRetencion.Ins_CtaCteIteLinRetencion(CodEmpresa, cPerCodigo, NroRecibo, nLinea, Convert.ToInt32(posicion["nSysTasCodigo"]), Convert.ToDouble(fila["nSysValor"]), Convert.ToInt32(posicion["fSysTasValor"]), dFechaSys))
                                {
                                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLinRetencion.!");
                                }
                            }
                        }
                        else throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLine.!");
                    }

                    //------------------------------------------------------------------------------
                    //update AdmSolicitud (cCtaCteRecibo) - Referenciando recibo en "AdmSolicitud" ?
                    //------------------------------------------------------------------------------
                    if (!DaSolAdm.Upd_AdmSol_cCtaCteRecibo(CodEmpresa, TipoPrograma, NroSolicitud, NroRecibo))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: AdmSolicitud.! " + CodEmpresa + ' ' + TipoPrograma + ' ' + NroSolicitud + ' ' + NroRecibo);
                    }

                    //exito = true;
                    //tx.Complete();

                    /* Perform transactional work here */
                    //No errors - commit transaction
                    committableTransaction.Commit();
                    exito = true;
                }

                else throw new ApplicationException("Configuracion de parametros no establecida.!");
            }
            //}
            catch (Exception)
            {
                committableTransaction.Rollback();
                throw;
            }
            finally
            {
                committableTransaction.Dispose();
                //Restore the ambient transaction
                Transaction.Current = oldAmbient;
            }

            return exito;
        }

        #endregion

        #region RealizarPago
        //--------------
        //Realizar Pago
        //---------------
        public bool Ins_RealizarPago(string cPerJurCodigo, string cPerCodigo, long nPrdCodigo, string cTipCtaCodigo, string cCtaCteRecCargo, Dictionary<string, double> ListRecibo, string cPerUserCodigo, long nCajCodigo, long nCtaCteComCodigo, string cCtaCteComNumero, DateTime dFecRegistro, double ImporteTotal, double ImportePago, double ImporteAmortizado, string cCtaCteObserv, List<BE_ReqCtaCteDetalle> ReqCCDetalle) 
        {
            bool exito = false;
            long nCtaCtaPagCodigo = 0;
            string cCtaCteRecAbono="";
            //double PagImporte=0;
            //DateTime sFecTrans = new DateTime() ;

            //CtaCtePago
            BL_CtaCtePago blCCPago = new BL_CtaCtePago();

            //CtaCteComprobante
            BL_CtaCteComprobante BLComp = new BL_CtaCteComprobante();

            //CtaCteDetalle
            DA_CtaCteDetalle daCCDet = new DA_CtaCteDetalle();

            //CtaCteItem
            BL_CtaCteItem blCCItem = new BL_CtaCteItem();

            //CtaCteIteLine
            BL_CtaCteIteLine blCCIteLine = new BL_CtaCteIteLine();

            //CtaCteReferencia
            BL_CtaCteReferencia blCCRefe = new BL_CtaCteReferencia();

            //Update CtaCteItem
            BL_CtaCteItem daCCItem = new BL_CtaCteItem();

            //Update Correlativo
            BL_CtaCteNumeracion blCCNumeracion = new BL_CtaCteNumeracion();

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    //Genera nuevo recibo pero en Negativo(-) en la tabla [CtaCteItem]
                    cCtaCteRecAbono = blCCItem.Ins_CtaCteItem(cPerJurCodigo, cPerCodigo, nPrdCodigo, cTipCtaCodigo, dFecRegistro.Year, -ImportePago, dFecRegistro, 1);
                    if (cCtaCteRecAbono == null)
                    {
                        throw new ApplicationException("Se encontro Nro. Recibo que va a cancelar: [Get_CtaCteItem].!");
                    }

                    //-----------------/
                    //CtaCteComprobante
                    //-----------------/
                    if (ImporteAmortizado == 0)
                    {
                        if (nCtaCteComCodigo == 3005) //Recibo Ingreso
                        {
                            long nCtaCteComCodigoComp = 0;
                            string cCtaCteComNumeroComp = "";

                            BL_CtaCteNumeracion BLCorrelativo = new BL_CtaCteNumeracion();

                            //Genera Recibo (99) en CtaCteComprobante
                            nCtaCteComCodigoComp = 3006; //RECIBO (REC)
                            cCtaCteComNumeroComp = BLCorrelativo.Get_CtaCteNumCorrelativo(cPerJurCodigo, 0, nCtaCteComCodigoComp);

                            if (!BLComp.Ins_CtaCteComprobante(cPerJurCodigo, cPerCodigo, cCtaCteRecAbono, nCajCodigo, nCtaCteComCodigoComp, cCtaCteComNumeroComp, dFecRegistro, ImporteTotal, cPerUserCodigo))
                            {
                                throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteComprobante].!");
                            }

                            //Update Correlativo si pasa por este bucle Recibo 3006
                            BL_CtaCteNumeracion BLUpdCorrelativo = new BL_CtaCteNumeracion();

                            int valor = cCtaCteComNumeroComp.Length - 8;
                            string resultCorre = cCtaCteComNumeroComp.Substring(valor, 8);

                            long NumeroNew = 0;
                            NumeroNew = Convert.ToInt32(resultCorre);

                            if (!BLUpdCorrelativo.Upd_CtaCteNumeracion_nCtaCteNumero(cPerJurCodigo, 0, nCtaCteComCodigoComp, NumeroNew))
                            {
                                throw new ApplicationException("Se encontraron errores en la transaccion a Update nCtaCteComCodigo-3006: [Upd_CtaCteNumeracion_nCtaCteNumero].!");
                            }
                        }
                        else
                        {
                            if (!BLComp.Ins_CtaCteComprobante(cPerJurCodigo, cPerCodigo, cCtaCteRecAbono, nCajCodigo, nCtaCteComCodigo, cCtaCteComNumero, dFecRegistro, ImporteTotal, cPerUserCodigo))
                            {
                                throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteComprobante].!");
                            }
                        }
                    }
                    //<-
                    

                    //--------------
                    //Ins_CtaCtePago
                    //--------------
                    nCtaCtaPagCodigo = blCCPago.Ins_CtaCtePago(cPerJurCodigo, cPerCodigo, cCtaCteRecAbono, nCajCodigo , nCtaCteComCodigo, cCtaCteComNumero, cPerUserCodigo,cCtaCteObserv); //OUTPUT inserted.nCtaCtaPagCodigo (cm.ExecuteScalar()) 

                    //-----------------
                    //Ins_CtaCteDetalle
                    //-----------------
                    foreach (BE_ReqCtaCteDetalle Item in ReqCCDetalle)
                    {
                        Item.nCtaCtePagCodigo = nCtaCtaPagCodigo; //paso el autogenerado de CtaCtePago(nCtaCtePagCodigo)
                        exito = daCCDet.Ins_CtaCteDetalle(Item);
                        //PagImporte = PagImporte + Item.nCtaCtePagImporte;
                        //sFecTrans = Item.dCtaCteFecTransacion;
                        if (!exito)
                        {
                            break;
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteDetalle].!");
                        }
                    }

                    //Nuevo Cambio
                    if (ListRecibo.Count == 0) /*Pago Simple*/
                    {   
                        //----------------
                        //CtaCteReferencia 
                        //----------------
                        if (!blCCRefe.Ins_CtaCteReferencia(cPerJurCodigo, cPerCodigo, cCtaCteRecCargo, cCtaCteRecAbono, nCtaCtaPagCodigo, ImportePago, "", dFecRegistro)) //PagImporte
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteReferencia].!");
                        }

                        //------------------------------------
                        // Actualizar campo nCtaCteImpAplicado
                        //------------------------------------
                        if (!daCCItem.Upd_CtaCteItem_nCtaCteImpAplicado(cPerJurCodigo, cCtaCteRecCargo, ImportePago, "CANCELA")) //PagImporte
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteItem_nCtaCteImpAplicado].!");
                        }
                    }
                    else
                    { 
                        //Aqui tengo que recorrer los recibos seleccionados *Pago Multiple*
                        foreach (KeyValuePair<string, double> pair in ListRecibo)
                        {
                            //----------------
                            //CtaCteReferencia
                            //----------------
                        
                            if (!blCCRefe.Ins_CtaCteReferencia(cPerJurCodigo, cPerCodigo, pair.Key, cCtaCteRecAbono, nCtaCtaPagCodigo, pair.Value, "", dFecRegistro)) //PagImporte
                            {
                                throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteReferencia].!");
                            }

                            //------------------------------------
                            // Actualizar campo nCtaCteImpAplicado
                            //------------------------------------
                            //if (!daCCItem.Upd_CtaCteItem_nCtaCteImpAplicado(cPerJurCodigo, cCtaCteRecCargo, ImportePago, "CANCELA")) //PagImporte
                            if (!daCCItem.Upd_CtaCteItem_nCtaCteImpAplicado(cPerJurCodigo, pair.Key, pair.Value, "CANCELA")) //PagImporte
                            {
                                throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteItem_nCtaCteImpAplicado].!");
                            }

                        }
                        ListRecibo.Clear();
                    }
                    
                    //-------------------------------------------
                    // Actualizar CtaCteNumeracion(nCtaCteNumero)
                    //-------------------------------------------
                    int value = cCtaCteComNumero.Length - 8;
                    string result = cCtaCteComNumero.Substring(value, 8);

                    long Numeracion = 0;
                    Numeracion = Convert.ToInt32(result);

                    if (!blCCNumeracion.Upd_CtaCteNumeracion_nCtaCteNumero(cPerJurCodigo, nCajCodigo, nCtaCteComCodigo, Numeracion))
                    {
                        throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteItem_nCtaCteImpAplicado].!");
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

        #region AgregarNuevoServicio

        //----------------------
        //Agregar Nuevo Servicio
        //----------------------
        public bool Ins_AgregarNuevoServicio(string cPerJurCodigo,string cPerCodigo,int nPeriodo,DateTime dFechaSys,long nCtaCteSerCodigo,long nCantidad,double nPrecioUnit,double nImporte)
        {
            bool exito = false;
            long nLinea = 0;
            string NroRecibo = "";

            //para Tipo de cambio
            double nTC = 0;
            BL_Sistema daTC = new BL_Sistema();

            //para CtaCteItem
            BL_CtaCteItem blCCItem = new BL_CtaCteItem();

            //para CtaCteIteLIne
            BL_CtaCteIteLine blCCItemLine = new BL_CtaCteIteLine();

            BL_ImpuestoServicio blImpServ = new BL_ImpuestoServicio();
            BL_CtaCteIteLinRetencion blCCRetencion = new BL_CtaCteIteLinRetencion();
            
            //para Obtener Serv. 
            BE_ReqCtaCteServBusca ReqServ = new BE_ReqCtaCteServBusca();
            BL_CtaCtaServicio daServ = new BL_CtaCtaServicio();

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    ReqServ.cPerJurCodigo = cPerJurCodigo;
                    ReqServ.nCtaCteSerCodigo =nCtaCteSerCodigo;
                    ReqServ.nFlag = "SERV";

                    //
                    if (daServ.Get_CtaCteServicio(ReqServ).Rows.Count > 0)
                    {
                        DataRow row = daServ.Get_CtaCteServicio(ReqServ).Rows[0];
                        //--------------
                        //Tipo de cambio
                        //--------------
                        if (Convert.ToInt32(row["nMonCodigo"]) == 2) //Dolar
                        {
                            if (daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows.Count > 0)
                            {
                                //DataRow row = daTC.Get_TipodeCambio(ReqTC).Rows[0];
                                nTC = Convert.ToDouble(daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows[0]["nCompra"]);
                            }
                            else throw new ApplicationException("No se ha registrado el Tipo de Cambio del dia: " + String.Format("{0:ddd, MMM d, yyyy}", dFechaSys));
                        }
                        else nTC = 1.0;

                        //----------
                        //CtaCteItem
                        //----------
                        NroRecibo = blCCItem.Ins_CtaCteItem(cPerJurCodigo, cPerCodigo, nPeriodo, row["nCtaCteTipoCta"].ToString(), dFechaSys.Year, nImporte, dFechaSys, 1);

                        //--------------
                        //CtaCteIteLine
                        //--------------
                        nLinea = blCCItemLine.Ins_CtaCteIteLine(cPerJurCodigo, cPerCodigo, NroRecibo, Convert.ToInt32(row["nCtaCteSerCodigo"]), Convert.ToInt32(row["nMonCodigo"]), nCantidad, nPrecioUnit, nImporte, nTC, 1);
                        if (nLinea != 0)
                        {
                            //---------------------
                            //CtaCteIteLinRetencion
                            //---------------------
                            foreach (DataRow posicion in blImpServ.Get_ImpuestoServicio(cPerJurCodigo, cPerCodigo, NroRecibo, Convert.ToInt32(row["nCtaCteSerCodigo"]), 9256).Rows) //9256.- Perú
                            {
                                if (!blCCRetencion.Ins_CtaCteIteLinRetencion(cPerJurCodigo, cPerCodigo, NroRecibo, nLinea, Convert.ToInt32(posicion["nSysTasCodigo"]), Convert.ToDouble(row["nCtaCteSerImpDef"]), Convert.ToInt32(posicion["fSysTasValor"]), dFechaSys))
                                {
                                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLinRetencion.!");
                                }
                            }
                        }
                        else throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLine.!");

                        exito = true;
                        tx.Complete();
                    }
                    else throw new ApplicationException("Configuracion de parametros no establecida.!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
            return exito;
        }

        #endregion

        #region AgregarItemRecibo_Servicio
        //----------------------
        //Agregar Item Recibo
        //----------------------
        public bool Ins_AgregarItemRecibo(string cPerJurCodigo, string cPerCodigo, string NroRecibo, long nCtaCteSerCodigo,DateTime dFechaSys, long nCantidad,double nPrecioUnit, double nImporte)
        {
            bool exito = false;
            long nLinea = 0;
            //para Tipo de cambio
            double nTC = 0;
            BL_Sistema daTC = new BL_Sistema();

            //para CtaCteIteLIne
            BL_CtaCteIteLine blCCItemLine = new BL_CtaCteIteLine();

            //para Obtener Serv. 
            BE_ReqCtaCteServBusca ReqServ = new BE_ReqCtaCteServBusca();
            BL_CtaCtaServicio daServ = new BL_CtaCtaServicio();

            BL_ImpuestoServicio blImpServ = new BL_ImpuestoServicio();
            BL_CtaCteIteLinRetencion blCCRetencion = new BL_CtaCteIteLinRetencion();

            //Update CtaCteItem
            BL_CtaCteItem daCCItem = new BL_CtaCteItem();

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    ReqServ.cPerJurCodigo = cPerJurCodigo;
                    ReqServ.nCtaCteSerCodigo = nCtaCteSerCodigo;
                    ReqServ.nFlag = "SERV";

                    //
                    if (daServ.Get_CtaCteServicio(ReqServ).Rows.Count > 0)
                    {
                        DataRow row = daServ.Get_CtaCteServicio(ReqServ).Rows[0];
                        //--------------
                        //Tipo de cambio
                        //--------------
                        if (Convert.ToInt32(row["nMonCodigo"]) == 2) //Dolar
                        {
                            if (daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows.Count > 0)
                            {
                                //DataRow row = daTC.Get_TipodeCambio(ReqTC).Rows[0];
                                nTC = Convert.ToDouble(daTC.Get_TipodeCambio(Convert.ToInt32(row["nMonCodigo"]), "TCD", String.Format("{0:dd/MM/yyyy}", dFechaSys), 0, 0).Rows[0]["nCompra"]);
                            }
                            else throw new ApplicationException("No se ha registrado el Tipo de Cambio del dia: " + String.Format("{0:ddd, MMM d, yyyy}", dFechaSys));
                        }
                        else nTC = 1.0;

                        //--------------
                        //CtaCteIteLine
                        //--------------
                        nLinea = blCCItemLine.Ins_CtaCteIteLine(cPerJurCodigo, cPerCodigo, NroRecibo, Convert.ToInt32(row["nCtaCteSerCodigo"]), Convert.ToInt32(row["nMonCodigo"]), nCantidad,nPrecioUnit , nImporte, nTC, 1);
                        if (nLinea != 0)
                        {
                            //---------------------
                            //CtaCteIteLinRetencion
                            //---------------------
                            foreach (DataRow posicion in blImpServ.Get_ImpuestoServicio(cPerJurCodigo, cPerCodigo, NroRecibo, Convert.ToInt32(row["nCtaCteSerCodigo"]), 9256).Rows) //9256.- Perú
                            {
                                if (!blCCRetencion.Ins_CtaCteIteLinRetencion(cPerJurCodigo, cPerCodigo, NroRecibo, nLinea, Convert.ToInt32(posicion["nSysTasCodigo"]), Convert.ToDouble(row["nCtaCteSerImpDef"]), Convert.ToInt32(posicion["fSysTasValor"]), dFechaSys))
                                {
                                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLinRetencion.!");
                                }
                            }
                        }
                        else throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLine.!");
                        
                        //-----------------------------------
                        // Actulizar campo "nCtaCteImporte"
                        //-----------------------------------
                        if (!daCCItem.Upd_CtaCteItem_nCtaCteImpAplicado(cPerJurCodigo, NroRecibo, nImporte, "ADDITEM"))
                        {
                            throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteItem_nCtaCteImpAplicado].!");
                        }

                        exito = true;
                        tx.Complete();
                    }
                    else throw new ApplicationException("Configuracion de parametros no establecida.!");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return exito;
        }
        #endregion

        #region RegistraCtaCteComprobante

        //-------------------------
        //Agregar CtaCteComprobante
        //-------------------------
        //public bool Ins_RegistrarComprobante(string cPerJurCodigo, string cPerCodigo, string NroRecibo, long nCajCodigo, long nCtaCteComCodigo,string cCtaCteComNumero, DateTime dFechaSys, double nImporte,string cPerUserCodigo)
        //{
        //    bool exito = false;

        //    //para CtaCteComprobante
        //    BL_CtaCteComprobante blCCComprobante = new BL_CtaCteComprobante();

        //    try
        //    {
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            //-----------------
        //            //CtaCteComprobante
        //            //-----------------
        //            if (!blCCComprobante.Ins_CtaCteComprobante(cPerJurCodigo, cPerCodigo,NroRecibo,nCajCodigo,nCtaCteComCodigo,cCtaCteComNumero, dFechaSys,nImporte,cPerUserCodigo))
        //            {
        //                throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLine.!");
        //            }

        //            exito = true;
        //            tx.Complete();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return exito;
        //}
        #endregion

    }
}
