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
    public class DA_DocFecTramite
    {
        public bool InsDocFecTramite(BE_ReqDocFecTramite Request)
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
                        cm.CommandText = "[usp_Ins_DocFecTramite]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cDocCodigo", Request.cDocCodigo);
                        cm.Parameters.AddWithValue("dFecInicial", Request.dFecInicial);
                        cm.Parameters.AddWithValue("dFecFinal", Request.dFecFinal);
                        cm.Parameters.AddWithValue("nMvoCodigo", Request.nMvoCodigo);
                        cm.Connection = cn;
                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_DocFecTramite]; Consulte al administrador del sistema");
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
