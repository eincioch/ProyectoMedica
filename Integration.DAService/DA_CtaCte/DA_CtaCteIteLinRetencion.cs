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
    public class DA_CtaCteIteLinRetencion
    {
        //--------------------------
        // INSERT CtaCteComprobante
        //--------------------------
        public bool Ins_CtaCteIteLinRetencion(BE_ReqCtaCteIteLinRetencion Request)
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
                        cm.CommandText = "[usp_Ins_CtaCteIteLinRetencion]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nCtaCteRecLine", Request.nCtaCteRecLine);
                        cm.Parameters.AddWithValue("nCtaCteRecLinTipo", Request.nCtaCteRecLinTipo);
                        cm.Parameters.AddWithValue("nCtaCteRecLinImpote", Request.nCtaCteRecLinImpote);
                        cm.Parameters.AddWithValue("nCtaCteRecLinPorce", Request.nCtaCteRecLinPorce);
                        cm.Parameters.AddWithValue("dCtaCteRecLinFecha", Request.dCtaCteRecLinFecha);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteIteLinRetencion]; Consulte al administrador del sistema");
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
