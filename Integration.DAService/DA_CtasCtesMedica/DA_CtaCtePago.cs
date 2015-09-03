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
    public class DA_CtaCtePago
    {
        //-------------------
        // Insert CtaCtePago.- me devuelve a la vez el 
        //-------------------
        public int Ins_CtaCtePago(BE_ReqCtaCtePago Request)
        {
            int nCtaCtePagCodigo = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_CtaCtePago]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nPerCtaCodigo", Request.nPerCtaCodigo);  //PerCuenta
                        cm.Parameters.AddWithValue("nTurno", Request.nTurno);               //Nro. Caja Constante (7202)
                        cm.Parameters.AddWithValue("nForPago", Request.nForPago);           //Forma de Pago (1086) 
                        cm.Parameters.AddWithValue("cCtaCtePagNroOperacion", Request.cCtaCtePagNroOperacion);
                        cm.Parameters.AddWithValue("CtaCtePagGlosa", Request.CtaCtePagGlosa);
                        cm.Parameters.AddWithValue("fCtaCtePagImporte", Request.fCtaCtePagImporte);

                        cm.Connection = cn;

                        //recuperando el "nCtaCtePagCodigo" correlativo decuencia
                        nCtaCtePagCodigo = Convert.ToInt32(cm.ExecuteScalar());

                        if (nCtaCtePagCodigo == 0){
                            throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCtePago]; Consulte al administrador del sistema");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return nCtaCtePagCodigo;
        }
    }
}
