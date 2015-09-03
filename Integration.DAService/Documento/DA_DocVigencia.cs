using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Integration.BE;
using Integration.BE.Documento;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.Documento
{
    public class DA_DocVigencia
    {
        public bool InsDocVigencia(BE_ReqDocVigencia Request)
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
                        cm.CommandText = "[usp_Ins_DocVigencia]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dFechaIni", Request.dFechaIni);
                        cm.Parameters.AddWithValue("dFechaFin", Request.dFechaFin);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocVigencia]; Consulte al administrador del sistema");
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
