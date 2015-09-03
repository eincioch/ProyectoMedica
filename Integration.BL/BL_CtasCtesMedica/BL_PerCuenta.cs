using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_PerCuenta
    {
        //-------------------
        // Insert PerCuenta
        //-------------------
        public bool Ins_PerCuenta(string cPerCodigo, int nPerCtaTipo, string cPerJurCodigo)
        {
            BE_ReqPerCuenta Request = new BE_ReqPerCuenta();
            DA_PerCuenta Obj = new DA_PerCuenta();

            Request.cPerCodigo = cPerCodigo;
            Request.cNroCuenta=""; 
            Request.nPerCtaTipo=nPerCtaTipo; //Constante(1015) [16]-Cliente
            Request.cPerJurCodigo=cPerJurCodigo;
            Request.nMonCodigo=1; //Constante(1001) [1]-Soles
            Request.nPerCtaEstado = 1;
            Request.cNroCuentaOpera = "";

            return Obj.Ins_PerCuenta(Request);
        }

        //-------------------
        // Get PerCuenta
        //-------------------
        public DataTable Get_PerCuenta(string cPerCodigo, string cPerJurCodigo)
        {
            BE_ReqPerCuenta Request = new BE_ReqPerCuenta();
            DA_PerCuenta Obj = new DA_PerCuenta();
            Request.cPerCodigo = cPerCodigo;
            Request.cPerJurCodigo = cPerJurCodigo;
            return Obj.Get_PerCuenta(Request);

        }

    }
}
