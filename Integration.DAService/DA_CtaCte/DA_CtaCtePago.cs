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
    public class DA_CtaCtePago
    {
        //-------------------
        // INSERT CtaCtePago
        //-------------------
        public int Ins_CtaCtePago(BE_ReqCtaCtePago Request)
        {
            //bool exito = false;
            int Identidad = 0;
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
                        //cm.Parameters.AddWithValue("nCtaCtaPagCodigo", Request.nCtaCtaPagCodigo);
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecAbono", Request.cCtaCteRecAbono);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);
                        cm.Parameters.AddWithValue("cPerUseCodigo", Request.cPerUseCodigo);
                        cm.Parameters.AddWithValue("cCtaCteObserv", Request.cCtaCteObserv);
                        cm.Connection = cn;

                        Identidad = Convert.ToInt32(cm.ExecuteScalar());
                        if (Identidad == 0)
                        {
                            throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCtePago]; Consulte al administrador del sistema");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Identidad;
        }      
    }
}
