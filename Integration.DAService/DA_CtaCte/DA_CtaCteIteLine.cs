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
    public class DA_CtaCteIteLine
    {
        //----------------------
        // INSERT CtaCteIteLine
        //----------------------
        public long Ins_CtaCteIteLine(BE_ReqCtaCteIteLine Request)
        {
            long nLine = 0;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Ins_CtaCteIteLine]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        cm.Parameters.AddWithValue("nCtaCteLinMoneda", Request.nCtaCteLinMoneda);
                        cm.Parameters.AddWithValue("nCtaCteLinCantidad", Request.nCtaCteLinCantidad);
                        cm.Parameters.AddWithValue("nCtaCteLinPrecioUnit", Request.nCtaCteLinPrecioUnit);
                        cm.Parameters.AddWithValue("nCtaCteLinImporte", Request.nCtaCteLinImporte);
                        cm.Parameters.AddWithValue("nCtaCteLinTC", Request.nCtaCteLinTC);
                        cm.Parameters.AddWithValue("nCtaCteLinIGV", Request.nCtaCteLinIGV);
                        cm.Parameters.AddWithValue("nCtaCteLinEstado", Request.nCtaCteLinEstado);
                        cm.Connection = cn;

                        nLine = Convert.ToInt32(cm.ExecuteScalar());
                        if (nLine == 0)
                        {
                            throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteIteLine]; Consulte al administrador del sistema");
                        }

                        //if (cm.ExecuteNonQuery() > 0)
                        //{
                        //    exito = true;
                        //}
                        //else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Ins_CtaCteIteLine]; Consulte al administrador del sistema");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nLine;
        }

        //----------------------
        // DELETE CtaCteIteLine
        //----------------------
        public bool Del_CtaCteIteLine(BE_ReqCtaCteIteLine Request)
        {
            bool exito=false;
            try
            {
                clsConection Obj = new clsConection();
                string Cadena = Obj.GetConexionString("Naylamp");

                using (SqlConnection cn = new SqlConnection(Cadena))
                {
                    cn.Open();

                    using (SqlCommand cm = new SqlCommand())
                    {
                        cm.CommandText = "[usp_Del_CtaCteIteLine]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("cPerJurCodigo", Request.cPerJurCodigo);
                        cm.Parameters.AddWithValue("cPerCodigo", Request.cPerCodigo);
                        cm.Parameters.AddWithValue("cCtaCteRecibo", Request.cCtaCteRecibo);
                        cm.Parameters.AddWithValue("nCtaCteRecLine", Request.nCtaCteRecLine);
                        cm.Parameters.AddWithValue("nCtaCteSerCodigo", Request.nCtaCteSerCodigo);
                        
                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("se ha producido un error procedimiento almacenado: [usp_Del_CtaCteIteLine]; Consulte al administrador del sistema");
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
