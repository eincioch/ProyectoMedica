using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.BE;
using Integration.DAService.DA_CtaCte ;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCtaServicio
    {
        //------------------------
        //Insert CtaCteServicio
        //------------------------
        public bool Ins_CtaCteServicio(List<BE_ReqCtaCteServicio> ListRequest)
        {
            bool exito = false;
            DA_CtaCteServicio Obj = new DA_CtaCteServicio();

            foreach (BE_ReqCtaCteServicio Item in ListRequest)
            {
                //Item.cDocCodigo= ""; 'si necesitas pasar un valor antes a un atributo
                if (!Obj.Ins_CtaCteServicio(Item))
                {
                    break;
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCteServicio].!");
                }
                else { 
                    exito = true; 
                }
            }

            return exito;
            //return Obj.Ins_CtaCteServicio(Item);
        }

        //------------------------
        //Update CtaCteServicio
        //------------------------
        public bool Upd_CtaCteServicio(List<BE_ReqCtaCteServicio> ListRequest)
        {
            bool exito = false;
            DA_CtaCteServicio Obj = new DA_CtaCteServicio();

            foreach (BE_ReqCtaCteServicio Item in ListRequest)
            {
                //Item.cDocCodigo= ""; 'si necesitas pasar un valor antes a un atributo
                if (!Obj.Upd_CtaCteServicio(Item))
                {
                    break;
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Upd_CtaCteServicio].!");
                }
                else
                {
                    exito = true;
                }
            }

            return exito;
        }

        //------------------------
        //select CtaCteServicio
        //------------------------
        public DataTable Get_CtaCteServicio(BE_ReqCtaCteServBusca Request)
        {
            DA_CtaCteServicio Obj = new DA_CtaCteServicio();
            return Obj.Get_CtaCteServicio(Request);
        }

        //-----------------------------------
        //Obtener Servicio por Tipo de Cuenta
        //-----------------------------------
        public DataTable Get_ServicioporTipoCta(BE_ReqServicioporTipoCta Request)
        {
            DA_CtaCteServicio Obj = new DA_CtaCteServicio();
            return Obj.Get_ServicioporTipoCta(Request);

        }

        //Get_CtaCteServicio_nCtaCteSerImpDef.- Obtener precio for Servicio
        public double Get_CtaCteServicio_nCtaCteSerImpDef(string cPerJurCodigo, long nCtaCteSerCodigo)
        { 
            BE_ReqCtaCteSerImpDefault Request = new BE_ReqCtaCteSerImpDefault();
            DA_CtaCteServicio da = new DA_CtaCteServicio();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.nCtaCteSerCodigo = nCtaCteSerCodigo;

            return da.Get_CtaCteServicio_nCtaCteSerImpDef(Request);
        }
    }
}
