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
    public class DA_CuentaCorriente
    {
        //------------------------
        // Insert CuentaCorriente
        //------------------------
        public bool Ins_CuentaCorriente(BE_ReqCuentaCorriente Request)
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
                        cm.CommandText = "[usp_Ins_CuentaCorriente]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nPerCtaCodigo", Request.nPerCtaCodigo);
                        cm.Parameters.AddWithValue("nCtaCteTipo", Request.nCtaCteTipo);  //Constante (1015) [16]-Cliente
                        cm.Parameters.AddWithValue("fCtaCteImporte", Request.fCtaCteImporte);
                        cm.Parameters.AddWithValue("nCtaCteCuota", Request.nCtaCteCuota);
                        cm.Parameters.AddWithValue("nCtaCteEstado", Request.nCtaCteEstado);
                        cm.Parameters.AddWithValue("dCtaCteFecVence", Request.dCtaCteFecVence);
                        //cm.Parameters.AddWithValue("dCtaCteFecPago", Request.dCtaCteFecPago);
                        cm.Parameters.AddWithValue("dCtaCteFecEmis", Request.dCtaCteFecEmis);
                        cm.Parameters.AddWithValue("cCtaCteGlosa", Request.cCtaCteGlosa);
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("nMonCodigo", Request.nMonCodigo);
                        cm.Parameters.AddWithValue("fCtaCteIgv", Request.fCtaCteIgv);
                        cm.Parameters.AddWithValue("dCtaCteFecProg", Request.fCtaCteIgv);
                        cm.Parameters.AddWithValue("cSerDescripcion", Request.fCtaCteIgv);
                        cm.Parameters.AddWithValue("fCtaCteSaldo", Request.fCtaCteIgv);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error en procedimiento almacenado: [usp_Ins_CuentaCorriente]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //------------------------
        // Update CuentaCorriente
        //------------------------
        public bool Upd_CuentaCorriente(BE_ReqCuentaCorriente Request)
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
                        cm.CommandText = "[usp_Upd_CuentaCorriente_set_dCtaCteFecPago_nCtaCteEstado]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("dCtaCteFecPago", Request.dCtaCteFecPago);
                        cm.Parameters.AddWithValue("nTipoOperacion", Request.nTipoOperacion);

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error en procedimiento almacenado: [usp_Upd_CuentaCorriente_set_dCtaCteFecPago_nCtaCteEstado]; Consulte al administrador del sistema");
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
