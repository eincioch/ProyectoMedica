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
    public class BL_CtaCteIteLinRetencion
    {
        //-------------------------
        //Ins_CtaCteIteLinRetencion
        //-------------------------
        public bool Ins_CtaCteIteLinRetencion(string cPerJurCodigo, string cPerCodigo, string cCtaCteRecibo, long nCtaCteRecLine, long nCtaCteRecLinTipo, double nCtaCteRecLinImpote, double nCtaCteRecLinPorce, DateTime dCtaCteRecLinFecha)
        {
            bool exito = false;
            BE_ReqCtaCteIteLinRetencion ReqCCRetencion = new BE_ReqCtaCteIteLinRetencion();
            DA_CtaCteIteLinRetencion daCCRetencion = new DA_CtaCteIteLinRetencion();

            try
            {
                ReqCCRetencion.cPerJurCodigo = cPerJurCodigo;
                ReqCCRetencion.cPerCodigo = cPerCodigo;
                ReqCCRetencion.cCtaCteRecibo = cCtaCteRecibo;
                ReqCCRetencion.nCtaCteRecLine = nCtaCteRecLine;
                ReqCCRetencion.nCtaCteRecLinTipo = nCtaCteRecLinTipo;
                ReqCCRetencion.nCtaCteRecLinImpote = nCtaCteRecLinImpote;
                ReqCCRetencion.nCtaCteRecLinPorce = nCtaCteRecLinPorce;
                ReqCCRetencion.dCtaCteRecLinFecha = dCtaCteRecLinFecha;

                if (!daCCRetencion.Ins_CtaCteIteLinRetencion(ReqCCRetencion))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: CtaCteComprobante.!");
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
