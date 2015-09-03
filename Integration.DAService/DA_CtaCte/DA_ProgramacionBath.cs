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
    public class DA_ProgramacionBath
    {
        //-----------------------------------------------
        // Procedimiento: usp_Set_ProgramarCuotaOrdinaria
        //------------------------------------------------
        public long Set_ProgramarCuotaOrdinaria(BE_ReqProgramacionBath Request)
        {
            long nRowCount = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Set_ProgramarCuotaOrdinaria]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandTimeout = 0;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("nPrdCodigo", Request.nPrdCodigo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nMesProceso", Request.nMesProceso);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cPerColeFalle", Request.cPerColeFalle);
                        cm.Parameters.AddWithValue("dFecFallece", Request.dFecFallece);
                        cm.Connection = cn;
  
                        SqlParameter nParametro = new SqlParameter();
                        nParametro.ParameterName = "nEstado";
                        nParametro.DbType = DbType.Int32;
                        nParametro.Direction = ParameterDirection.Output;

                        cm.Parameters.Add(nParametro);
                        cm.ExecuteNonQuery();
                        nRowCount = Convert.ToInt32(cm.Parameters["nEstado"].Value);

                        if (nRowCount == 0)
                        {
                            throw new ApplicationException("No se encontraron Colegiado para crear cronograma.");
                        }
                        //OJO hay que corregir esto para futuras actulizacion colocar la logica en el BL 
                        //para verificar si exito o no registro para luego insertar
                        //else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Set_ProgramarCuotaOrdinaria]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nRowCount;
        }
    }
}
