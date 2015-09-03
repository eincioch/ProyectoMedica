using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Integration.DAService.DA_CtaCte
{
    public class DA_CtaCteReferencia
    {
        //--------------------------
        // INSERT CtaCteComprobante
        //--------------------------
        public bool Ins_CtaCteReferencia(BE_ReqCtaCteReferencia Request)
        {
            bool exito = false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_CtaCteReferencia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecCargo", Request.cCtaCteRecCargo);
                        cm.Parameters.AddWithValue("cCtaCteRecAbono", Request.cCtaCteRecAbono);
                        cm.Parameters.AddWithValue("nCtaCtePagCodigo", Request.nCtaCtePagCodigo);
                        cm.Parameters.AddWithValue("nCtaCtePagImporte", Request.nCtaCtePagImporte);
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dCtaCteFecRegistro", Request.dCtaCteFecRegistro);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteReferencia]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }
    }
}
