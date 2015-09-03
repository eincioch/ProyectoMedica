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
    public class DA_CtaCteDetalle
    {
        //-------------------
        // INSERT CtaCtePago
        //-------------------
        public bool Ins_CtaCteDetalle(BE_ReqCtaCteDetalle Request)
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
                        cm.CommandText = "[usp_Ins_CtaCteDetalle]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaCtePagCodigo", Request.nCtaCtePagCodigo);
                        cm.Parameters.AddWithValue("nCtaCteForPago", Request.nCtaCteForPago);
                        cm.Parameters.AddWithValue("nPerCtaCodigo", Request.nPerCtaCodigo);
                        cm.Parameters.AddWithValue("cPerjurCodigoFin", Request.cPerjurCodigoFin);
                        cm.Parameters.AddWithValue("dCtaCteFecTransacion", Request.dCtaCteFecTransacion);
                        cm.Parameters.AddWithValue("cCtaCtePagTracer", Request.cCtaCtePagTracer);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("nCtaCtePagImpMon", Request.nCtaCtePagImpMon);
                        cm.Parameters.AddWithValue("nTC", Request.nTC);
                        cm.Parameters.AddWithValue("nCtaCtePagImporte", Request.nCtaCtePagImporte);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteDetalle]; Consulte al administrador del sistema");
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
