using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtasCtesMedica
{
    public class DA_CtaCteDetalle
    {
        //----------------------
        // Insert CtaCteDetalle
        //----------------------
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
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nSerCodigo", Request.nSerCodigo); //servicios de CtaCteServicios
                        cm.Parameters.AddWithValue("nCtaCteCantidad", Request.nCtaCteCantidad);
                        cm.Parameters.AddWithValue("nMoneda", Request.nMoneda);
                        cm.Parameters.AddWithValue("fCtaCteTC", Request.fCtaCteTC);
                        cm.Parameters.AddWithValue("fCtaCteIGV", Request.fCtaCteIGV);
                        cm.Parameters.AddWithValue("fCtaCteDetimporte", Request.fCtaCteDetimporte);
                        cm.Parameters.AddWithValue("dCtaCteDetRegistro", Request.dCtaCteDetRegistro);
                        cm.Parameters.AddWithValue("nCtaCtedetEstado", Request.nCtaCtedetEstado);
                        
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0){
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error procedimiento almacenado: [usp_Ins_CtaCteDetalle]; Consulte al administrador del sistema");
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
