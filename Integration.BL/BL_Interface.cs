using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Interface;
using Integration.BE;
using Integration.BL;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_Interface
    {
        //----------------
        // Get_Interface
        //----------------
        //para buscar Interface
        public DataTable Get_Interface(long nIntClase, long nIntTipo, string cFlag)
        {
            BE_ReqInterface Request = new BE_ReqInterface();
            DA_Interface da = new DA_Interface();

            Request.nIntClase =nIntClase;
            Request.nIntTipo = nIntTipo;
            Request.cFlag = cFlag;

            return da.Get_Interface(Request);

        }

        //---------------------------------
        // Get_Interface and cIntJerarquia
        //---------------------------------
        //para buscar Interface
        public DataTable Get_Interface_and_cIntJerarquia(BE_ReqInterface Request)
        {
            DA_Interface Obj = new DA_Interface();
            return Obj.Get_Interface_and_cIntJerarquia(Request);

        }

        //para Insert Interface
        public BE_ResGenerico InsInterface(BE_ReqInterface Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Interface Obj = new DA_Interface();

            Item = Obj.InsInterface(Request);
            return Item;
        }

        //para Update Interface
        public BE_ResGenerico UpdInterface(BE_ReqInterface Request)
        {

            BE_ResGenerico Item = new BE_ResGenerico();
            DA_Interface Obj = new DA_Interface();

            Item = Obj.UpdInterface(Request);
            return Item;
        }


        //-----------------------------------------------
        // en SqlDataReader: Interface por (nIntClase and nIntTipo)
        //-----------------------------------------------
        public IList<BE_Res_Interface> Get_InterfaceDR(BE_ReqInterface Request)
        {

            DA_Interface Obj = new DA_Interface();
            return Obj.Get_InterfaceDR(Request);

        }
        public DataTable Get_Interface_Datareader(BE_ReqInterface Request)
        {
            DataTable dt; 
            DA_Interface Obj = new DA_Interface();
            dt=Obj.Get_Interface_DataTable(Request);
            return dt;

        }

        //Genera nuevo Codigo servicio
        public string Get_NewIdcIntJerarquia(BE_ReqInterface Request) //BE_ReqSolCorrelativo Request)
        {
            DA_Interface Obj = new DA_Interface();
            return Obj.Get_NewIdcIntJerarquia(Request);

        }

        //-------------------------------------------
        //Interface . Configuration nIntClase = 1009
        //-------------------------------------------
        public string Get_Interface_CFG(long nIntClase, long nIntCodigo)
        {
            BE_Req_Interface Request = new BE_Req_Interface();
            DA_Interface DA = new DA_Interface();
            
            Request.nIntClase = Convert.ToInt32(nIntClase);
            Request.nIntCodigo = Convert.ToInt32(nIntCodigo);

            return DA.Get_Interface_CFG(Request);
        }
    }
}
