using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.Reportes;
using Integration.DAService.DA_Reportes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_Reportes
{
    public class BL_CtaCte_Get_Colegiadohabil_By_Servicio
    {
        //Get_CtaCteNumeracion
        public DataTable CtaCte_Get_Colegiadohabil_By_Servicio(string cPerCodigo, string cperideNumero, string fechaCorte, long nintCodigo)
        {
            //Recuperando registros 
            BE_ReqCtaCte_Get_Colegiadohabil_By_Servicio Request = new BE_ReqCtaCte_Get_Colegiadohabil_By_Servicio();

            Request.cPerCodigo = cPerCodigo;
            Request.cperideNumero = cperideNumero;
            Request.fechaCorte = fechaCorte;
            Request.nintCodigo = nintCodigo;

            DA_CtaCte_Get_Colegiadohabil_By_Servicio Obj = new DA_CtaCte_Get_Colegiadohabil_By_Servicio();

            return Obj.CtaCte_Get_Colegiadohabil_By_Servicio(Request);

        }
    }
}
