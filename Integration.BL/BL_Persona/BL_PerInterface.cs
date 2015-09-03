using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Persona;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_PerInterface
    {
        //----------------
        //Ins_PerInterface
        //----------------
        public bool Ins_PerInterface(string cPerCodigo, long nPerIntCodigo, long nPerIntClase, DateTime dPerIntFecha, string cPerIntJerarquia, string cPerIntDescripcion, long nPerIntTipo)
        {
            bool exito = false;
            //para CtaCteIteLine
            BE_ReqPerInterface Request = new BE_ReqPerInterface();
            DA_PerInterface Da = new DA_PerInterface();

            try
            {
                Request.cPerCodigo = cPerCodigo;
                Request.nPerIntCodigo = nPerIntCodigo;
                Request.nPerIntClase = nPerIntClase;
                Request.dPerIntFecha = dPerIntFecha;
                Request.cPerIntJerarquia = cPerIntJerarquia;
                Request.cPerIntDescripcion = cPerIntDescripcion;
                Request.nPerIntTipo = nPerIntTipo;

                if (!Da.Ins_PerInterface(Request))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: Ins_PerInterface.!");
                }
                else exito = true;
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }


        //----------------
        //Upd_PerInterface
        //----------------
        public bool Upd_PerInterface(string cPerCodigo, long nPerIntCodigo, long nPerIntClase, string cPerIntJerarquia, string cPerIntDescripcion, long nPerIntTipo)
        {
            bool exito = false;
            //para CtaCteIteLine
            BE_ReqPerInterface Request = new BE_ReqPerInterface();
            DA_PerInterface Da = new DA_PerInterface();

            try
            {
                Request.cPerCodigo = cPerCodigo;
                Request.nPerIntCodigo = nPerIntCodigo;
                Request.nPerIntClase = nPerIntClase;
                Request.cPerIntJerarquia = cPerIntJerarquia;
                Request.cPerIntDescripcion = cPerIntDescripcion;
                Request.nPerIntTipo = nPerIntTipo;

                if (!Da.Upd_PerInterface(Request))
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: Upd_PerInterface.!");
                }
                else exito = true;
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //----------------
        //Get_PerInterface
        //----------------
        public DataTable Get_PerInterface()
        {
            DA_PerInterface DA = new DA_PerInterface();
            return DA.Get_PerInterface();
        }
    }
}
