using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.Documento ;
using Integration.DAService.Documento ;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.Documento
{
    public class BL_FondoMortorio
    {
        //Store Procedure para Constante (Insert y Update)
        public bool InsFondoMortorio(BE_FondoMortorio Request)
        {
            DA_FondoMortorio Obj = new DA_FondoMortorio();
            return Obj.InsFondoMortorio(Request);
        }
        
        //aprendiendo a manejar TransactionScope
        public bool InsEnBloque(List<BE_FondoMortorio> lst)
        {
            bool exito = false;
            DA_FondoMortorio da = new DA_FondoMortorio();
            BE_FondoMortorio newItem = new BE_FondoMortorio();
            newItem.cDocCodigo= "";
            lst.Add(newItem);

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    foreach (BE_FondoMortorio item in lst)
                    {
                        exito = da.InsFondoMortorio(item);
                        if (!exito) break;
                    }
                    if (exito) tx.Complete();
                }
            }
            catch (Exception)
            {                
                throw;
            }
            return exito;
        }

        //[usp_Get_Doc_Afiliacion_for_cDocCodigo]
        public DataTable Get_Doc_Afiliacion_for_cDocCodigo(string cDocCodigo)
        {

            BE_Get_Doc_Afiliacion_for_cDocCodigo Request = new BE_Get_Doc_Afiliacion_for_cDocCodigo();
            Request.cDocCodigo = cDocCodigo;

            DA_FondoMortorio DA = new DA_FondoMortorio();

            return DA.Get_Doc_Afiliacion_for_cDocCodigo(Request);

        }

        //[Del_Beneficiario_for_cDocCodigo_and_cPerCodigo]
        public bool Del_Beneficiario_for_cDocCodigo_and_cPerCodigo(string cDocCodigo, string cPerCodigo)
        {
            BE_Del_Beneficiario_for_cDocCodigo Request = new BE_Del_Beneficiario_for_cDocCodigo();
            DA_FondoMortorio DA = new DA_FondoMortorio();

            Request.cDocCodigo = cDocCodigo;
            Request.cPerCodigo = cPerCodigo;

            return DA.Del_Beneficiario_for_cDocCodigo_and_cPerCodigo(Request); ;
        }

        public bool Get_Beneficiario_for_cDocCodigo_and_cPerCodigo(string cDocCodigo, string cPerCodigo)
        {
            BE_Get_Beneficiario_for_cDocCodigo Request = new BE_Get_Beneficiario_for_cDocCodigo();
            DA_FondoMortorio DA = new DA_FondoMortorio();

            Request.cDocCodigo = cDocCodigo;
            Request.cPerCodigo = cPerCodigo;

            return DA.Get_Beneficiario_for_cDocCodigo_and_cPerCodigo(Request);
        }

        //[Ins_Beneficiario_for_cDocCodigo]
        public bool Ins_Beneficiario_for_cDocCodigo(List<BE_Ins_Beneficiario_for_cDocCodigo> Lista) 
        {
            bool exito = false;
            DA_FondoMortorio DA = new DA_FondoMortorio();

            try
            {
                using (TransactionScope tx = new TransactionScope(TransactionScopeOption.Required))
                {
                    foreach (BE_Ins_Beneficiario_for_cDocCodigo item in Lista)
                    {
                        //aqui verificar si ya existe
                        //if (Get_Beneficiario_for_cDocCodigo_and_cPerCodigo(item.cDocCodigo,item.cPerCodigo))
                        //{ 
                            //insert
                            exito = DA.Ins_Beneficiario_for_cDocCodigo(item);
                            if (!exito) break;
                        //}
                    }
                    if (exito) tx.Complete();
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
