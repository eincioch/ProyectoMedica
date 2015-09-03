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
    public class DA_CtaCtePagDatos
    {
        //-----------------------
        // Insert CtaCtePagDatos
        //-----------------------
        public bool Ins_CtaCtePagDatos(BE_ReqCtaCtePagDatos Request)
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
                        cm.CommandText = "[usp_Ins_CtaCtePagDatos]";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("nCtaCtePagcodigo", Request.nCtaCtePagcodigo);  //Correlativo CtaCtePago(nCtaCtePagCodigo)
                        cm.Parameters.AddWithValue("cCtaCtePagDatPerJurCodigo", Request.cCtaCtePagDatPerJurCodigo); //PerJurCodigo (Banco)
                        cm.Parameters.AddWithValue("cCtaCtePagDatBanco", Request.cCtaCtePagDatBanco);  //Nonmbre banco
                        cm.Parameters.AddWithValue("cCtaCtePagDatNroCuenta", Request.cCtaCtePagDatNroCuenta); //Nro. Tarjeta y/o numero de cuenta
                        cm.Parameters.AddWithValue("cCtaCtePagDatNroOperacion", Request.cCtaCtePagDatNroOperacion); //Nro. Operacion (voucher)
                        cm.Parameters.AddWithValue("fCtaCtePagDatImporte", Request.fCtaCtePagDatImporte); 

                        cm.Connection = cn;

                        if (cm.ExecuteNonQuery() > 0)
                        {
                            exito = true;
                        }
                        else throw new ApplicationException("Se ha producido error procedimiento almacenado: [Ins_CtaCtePagDatos]; Consulte al administrador del sistema");
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
