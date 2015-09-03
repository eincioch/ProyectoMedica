using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Constante;
using Integration.BE;
using Integration.BL;
using Integration.DAService;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL
{
    public class BL_Constante
    {
        public DataTable ListarConstantes(BE_Req_Constante Request)
        {

            DAConstante ObjConstantes = new DAConstante();
            return ObjConstantes.ListarConstantes(Request);

        }

        public IList<BE_Res_Constante> Get_ConstantesBynConValor(BE_Req_Constante Request)
        {

            DAConstante ObjConstantes = new DAConstante();
            return ObjConstantes.Get_ConstantesBynConValor(Request);

        }


        public DataTable GetConstante(BE_Req_Constante Request)
        {
            DAConstante ObjConstantes = new DAConstante();
            return ObjConstantes.GetConstante(Request);
        }


        //-----------
        //Constante
        //-----------
        //para obterner Constante por nConCodigo
        public DataTable Get_Constante(string flag, long nConCodigo)
        {
            BE_ReqConstante Request = new BE_ReqConstante();
            DA_Constante da = new DA_Constante();
           
            Request.flag = flag;
            Request.nConCodigo = nConCodigo;

            return da.Get_Constante(Request);
        }

		//Store Procedure para Constante (Insert y Update)
        public BE_ResGenerico ExecInsUpdConstante(BE_ReqInsUpdConstante Request)
        {
            DAConstante Obj = new DAConstante();
            BE_ResGenerico Item = new BE_ResGenerico();
            Item = Obj.ExecInsUpdConstante(Request);
            return Item;
        }
    }
}
