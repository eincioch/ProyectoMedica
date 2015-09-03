using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.DAService;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCteIteLine
    {
        //-----------------
        //Ins_CtaCteIteLine
        //-----------------
        public long Ins_CtaCteIteLine(string cPerJurCodigo, string cPerCodigo, string NroRecibo, long nCtaCteSerCodigo, long nCtaCteLinMoneda, long nCtaCteLinCantidad,double nCtaCteLinPrecioUnit, double nCtaCteLinImporte, double nCtaCteLinTC, long nCtaCteLinEstado)
        {
            long nLine = 0;
            //para CtaCteIteLine
            BE_ReqCtaCteIteLine ReqCCIteLine = new BE_ReqCtaCteIteLine();
            DA_CtaCteIteLine daCCIteline = new DA_CtaCteIteLine();

            try
            {
                ReqCCIteLine.cPerJurCodigo = cPerJurCodigo;
                ReqCCIteLine.cPerCodigo = cPerCodigo;
                ReqCCIteLine.cCtaCteRecibo = NroRecibo;
                ReqCCIteLine.nCtaCteSerCodigo = nCtaCteSerCodigo;
                ReqCCIteLine.nCtaCteLinMoneda = nCtaCteLinMoneda;
                ReqCCIteLine.nCtaCteLinCantidad = nCtaCteLinCantidad;
                ReqCCIteLine.nCtaCteLinPrecioUnit = nCtaCteLinPrecioUnit;
                ReqCCIteLine.nCtaCteLinImporte = nCtaCteLinImporte;
                ReqCCIteLine.nCtaCteLinTC = nCtaCteLinTC;
                ReqCCIteLine.nCtaCteLinIGV = 0;
                ReqCCIteLine.nCtaCteLinEstado = nCtaCteLinEstado; //1-Activo ; 0-Anulado

                nLine = daCCIteline.Ins_CtaCteIteLine(ReqCCIteLine);

                //if (nLine == 0)
                //{
                //    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_CtaCteIteLine.!");
                //}
            }
            catch (Exception)
            {
                throw;
            }
            return nLine;
        }

        //---------------------
        //Del_CtaCteIteLine
        //---------------------
        public bool Del_CtaCteIteLine(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo, long nCtaCteRecLine, long nCtaCteSerCodigo)
        {
            bool exito = false;

            BE_ReqCtaCteIteLine Request = new BE_ReqCtaCteIteLine();
            DA_CtaCteIteLine da = new DA_CtaCteIteLine();

            try
            {
                Request.cPerJurCodigo = cPerJurCodigo;
                Request.cPerCodigo = cPerCodigo;
                Request.cCtaCteRecibo = cCtaCteRecibo;
                Request.nCtaCteRecLine = nCtaCteRecLine;
                Request.nCtaCteSerCodigo = nCtaCteSerCodigo;

                if (!da.Del_CtaCteIteLine(Request))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion DELETE: CtaCteIteLine.!");
                }
                else exito = true;
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
