using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.SeuConAssetModelo;
using Integration.DAService.SeuConAssetModelo;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.BL.BL_SeuConAssetModelo
{
    public class BL_SeuConAssetModelo
    {
        //----------------------------
        //select Get_SeuConAssetModelo
        //----------------------------
        public DataTable Get_SeuConAssetModelo(string cPerJurCodigo)
        {
            DataTable dt = new DataTable();
            BE_ReqSeuConAssetModelo Request = new BE_ReqSeuConAssetModelo();
            DA_SeuConAssetModelo DA = new DA_SeuConAssetModelo();

            Request.cPerJurCodigo = cPerJurCodigo;

            return DA.Get_SeuConAssetModelo(Request);
        }
    }
}
