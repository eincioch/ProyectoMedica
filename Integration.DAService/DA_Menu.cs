using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Integration.BE.Menu;
using Integration.Conection;

namespace Integration.DAService
{
   public class DA_Menu
    {
       public DataTable GetMenu_By_Persona_Clase(BE_ReqMenu Request)

       { 
            long Resultado=0;
           DataTable Item = new DataTable();
            try
        { 
             clsConection Obj = new clsConection();
             string Cadena = Obj.GetConexionString("Naylamp");
             
             using (SqlConnection cn = new SqlConnection(Cadena))
             {
                cn.Open();

                using (SqlCommand cm = new SqlCommand())
                {
                    cm.CommandText = "usp_Web_Get_Permisos";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("cPerCodigo",Request.cPerCodigo);
                    cm.Parameters.AddWithValue("cPerJurCodigo",Request.cPerJurCodigo);
                    cm.Parameters.AddWithValue("nIntClase",Request.nIntClase);
                    cm.Parameters.AddWithValue("nSisGruTipo",Request.nSisGruTipo);
                    cm.Parameters.AddWithValue("nSisGruCodigo",Request.nSisGruCodigo);
                    
                   cm.Connection = cn;
                     using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            Item.Load(dr);
                        }
                }
             }

        }
        catch (Exception )
        {
            throw ;
        }
        return Item;
        }
               }
       }

