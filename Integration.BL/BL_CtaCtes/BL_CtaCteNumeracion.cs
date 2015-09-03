using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.BE;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_CtaCteNumeracion
    {
        //------------------------
        //Insert CtaCteNumeracion
        //------------------------
        public BE_ResGenerico InsCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            Item = Obj.InsCtaCteNumeracion(Request);
            return Item;
        }

        //UpdCtaCteNumeracion
        public BE_ResGenerico UpdCtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            Item = Obj.UpdCtaCteNumeracion(Request);
            return Item;
        }

        //Get_CtaCteNumeracion
        public DataTable Get_CtaCteNumeracion(BE_ReqCtaCteNumeracion Request)
        {
            //Recuperando registros 
            DataTable dt = new DataTable();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();
            return Obj.Get_CtaCteNumeracion(Request);

        }

        //Obtener Correlativo "CtaCteNumeracion" por tipo docu.
        public string Get_CtaCteNumCorrelativo(string StrcPerJuridica, long nCajCodigo, long nComCodigo)
        {
            BE_ReqCtaCteNumeracion Request = new BE_ReqCtaCteNumeracion();
            DA_CtaCteNumeracion Obj = new DA_CtaCteNumeracion();

            Request.cPerJurCodigo = StrcPerJuridica;
            Request.nCajCodigo = nCajCodigo;
            Request.nComCodigo = nComCodigo;

            return Obj.Get_CtaCteNumCorrelativo(Request);

        }

        public bool Upd_CtaCteNumeracion_nCtaCteNumero(string cPerJurCodigo, long nCajCodigo, long nCtaCteComCodigo, long cCtaCteComNumero)
        {
            BE_ReqUpdCtaCteNumeracion Request = new BE_ReqUpdCtaCteNumeracion();
            DA_CtaCteNumeracion da = new DA_CtaCteNumeracion();

            Request.cPerJurCodigo = cPerJurCodigo;
            Request.nCajCodigo = nCajCodigo;
            Request.nCtaCteComCodigo = nCtaCteComCodigo;
            Request.cCtaCteComNumero = cCtaCteComNumero;

            return da.Upd_CtaCteNumeracion_nCtaCteNumero(Request);
        }
    }
}
