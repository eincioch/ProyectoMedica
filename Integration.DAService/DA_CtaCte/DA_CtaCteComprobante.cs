using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtes;
using Integration.Conection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Integration.DAService.DA_CtaCte
{
    public class DA_CtaCteComprobante
    {
        //--------------------------
        // INSERT CtaCteComprobante
        //--------------------------
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
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecAbono", Request.cCtaCteRecAbono);
                        cm.Parameters.AddWithValue("nCajCodigo", Request.nCajCodigo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);
                        cm.Parameters.AddWithValue("dCtaCteComFecEmision", Request.dCtaCteComFecEmision);
                        cm.Parameters.AddWithValue("nCtaCteComImporte", Request.nCtaCteComImporte);
                        cm.Parameters.AddWithValue("cPerUserCodigo", Request.cPerUserCodigo);
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteComprobante]; Consulte al administrador del sistema");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return exito;
        }

        //--------------------------
        // SELECT CtaCteComprobante
        //--------------------------
        public DataTable Get_CtaCteComprobante(BE_Req_Get_CtaCteComprobante Request)
        {
            DataTable dt = new DataTable();
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Get_CtaCteComprobante]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteComCodigo", Request.nCtaCteComCodigo);
                        cm.Parameters.AddWithValue("cCtaCteComNumero", Request.cCtaCteComNumero);
                        cm.Connection = cn;

                        using (SqlDataReader dr = cm.ExecuteReader())
                            dt.Load(dr);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
    }
}
