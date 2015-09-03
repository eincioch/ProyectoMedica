using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE;
using Integration.BE.CtasCtes;
using Integration.DAService;
using Integration.DAService.DA_CtaCte;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Integration.BL.BL_CtaCtes
{
    public class BL_ProgramacionBath
    {
        //-----------------
        //usp_Set_ProgramarCuotaOrdinaria
        //-----------------
        public bool  Set_ProgramarCuotaOrdinaria(string cPerJurCodigo, long nPrdCodigo, long nCtaCteSerCodigo, long nMesProceso, string cPerCodigo, string cPerColeFalle, DateTime dFecFallece)
        {
            bool nRowCount = false;
            long nResultado = 0;
            //para CtaCteIteLine
            BE_ReqProgramacionBath ReqProgBath= new BE_ReqProgramacionBath();
            DA_ProgramacionBath daProgBath = new DA_ProgramacionBath();

            try
            {
                ReqProgBath.cPerJurCodigo = cPerJurCodigo;
                ReqProgBath.nPrdCodigo = nPrdCodigo;
                ReqProgBath.nCtaCteSerCodigo = nCtaCteSerCodigo;
                ReqProgBath.nMesProceso = nMesProceso;
                ReqProgBath.cPerCodigo = cPerCodigo;
                ReqProgBath.cPerColeFalle = cPerColeFalle;
                ReqProgBath.dFecFallece = dFecFallece;

                nResultado = daProgBath.Set_ProgramarCuotaOrdinaria(ReqProgBath);

                if (nResultado == 0)
                {
                    throw new ApplicationException("Se encontraron errores en la transaccion: Set_ProgramarCuotaOrdinaria.!");
                }
                else
                    nRowCount = true ;

            }
            catch (Exception)
            {
                throw;
            }
            return nRowCount;
        }
    }
}
