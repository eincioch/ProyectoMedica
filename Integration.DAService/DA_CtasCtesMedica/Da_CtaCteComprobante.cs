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
    public class Da_CtaCteComprobante
    {
        //--------------------------
        // Insert CtaCteComprobante
        //-------------------------
        public bool Ins_CtaCteComprobante(BE_ReqCtaCteComprobante Request)
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
                        cm.CommandText = "[usp_Ins_CtaCteComprobante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);     
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);  //Constante (1063) Tipo Docu. BOL-FACT-TICK
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);  //SERIE+CORRELATIVO
                        cm.Parameters.AddWithValue("nCtaCteTipoPago", Request.nCtaCteTipoPago);    //Constante (3002) 1 - Al Contado
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);  //Persona (Cliente)

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error procedimiento almacenado: [usp_Ins_CtaCteComprobante]; Consulte al administrador del sistema");
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
 