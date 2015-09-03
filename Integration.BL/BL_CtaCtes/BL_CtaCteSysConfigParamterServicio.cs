using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Interface;
using Integration.BE.CtasCtes;
using Integration.DAService;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_CtaCteSysConfigParamterServicio
    {
        //-----------------------------
        //Insert SysConfParametrosServ
        //-----------------------------
        public bool Ins_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
        {
            bool exito = false;
            DA_CtaCteSysConfigParamterServicio daCtaCteConfServ = new DA_CtaCteSysConfigParamterServicio();

            try
            {
                //TransactionScope
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    // doble aperson && evalua y no sigue la siguiente si encuentra errores
                    if (daCtaCteConfServ.Ins_SysConfParametrosServ(Request))
                    {
                        exito = true;
                        tx.Complete();
                    }
                    else throw new ApplicationException("Se encontraron errores al insertar registro.!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------------
        //Update SysConfParametrosServ
        //-----------------------------
        public bool Upd_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
        {
            bool exito = false;
            DA_CtaCteSysConfigParamterServicio daCtaCteConfServ = new DA_CtaCteSysConfigParamterServicio();

            try
            {
                //TransactionScope
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    // doble aperson && evalua y no sigue la siguiente si encuentra errores
                    if (daCtaCteConfServ.Ins_SysConfParametrosServ(Request))
                    {
                        exito = true;
                        tx.Complete();
                    }
                    else throw new ApplicationException("Se encontraron errores al actulizar registro.!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //-----------------------------
        //select SysConfParametrosServ
        //-----------------------------
        public DataTable Get_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteSysConfigParamterServicio Obj = new DA_CtaCteSysConfigParamterServicio();
            return Obj.Get_SysConfParametrosServ(Request);

        }

        ////-----------------------------
        ////Insert SysConfParametrosServ
        ////-----------------------------
        //public bool Ins_SysConfParametrosServ(BE_ReqCtaCteSysConfigParamterServicio Request, BE_ReqInterface RequestInterface)
        //{
        //    bool exito = false;
        //    //long Resultado;

        //    //Interface
        //    BE_ResGenerico Item = new BE_ResGenerico();
        //    DA_Interface daInterface = new DA_Interface();
        //    //SysConfParametrosServ
        //    DA_CtaCteSysConfigParamterServicio daCtaCteConfServ = new DA_CtaCteSysConfigParamterServicio();
            
        //    try
        //    {
        //        // Exelente " TransactionScope " aun hay mucho para averiguar .- Enrique INCIO CHAPILLIQUEN
        //        using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
        //        {
        //            // doble aperson && evalua y no sigue la siguiente si encuentra errores
        //            if ((daInterface.InsInterface(RequestInterface).Resultado > 0) && daCtaCteConfServ.Ins_SysConfParametrosServ(Request))
        //            {
        //                exito = true;
        //                tx.Complete();
        //            }
        //            else throw new ApplicationException("Se encontraron errores al insertar registros.!");
        //            //---------------------------------------------------------------------------------------
        //            //es si quiero manejar mejor la transaccion paso por paso y saber en que Insert hay error
        //            //---------------------------------------------------------------------------------------
        //            //Item = daInterface.InsInterface(RequestInterface);
        //            //Resultado = Item.Resultado;
        //            //if (Resultado > 0)
        //            //{ 

        //            //}
        //            //else throw new ApplicationException("no se realizo la operacion");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return exito;
        //}
    }
}
