using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integration.BE.CtasCtesMedica;
using Integration.DAService.DA_CtasCtesMedica;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Integration.BL.BL_CtasCtesMedica
{
    public class BL_CtaCtePago
    {
        public int Ins_CtaCtePago(string cCtaCteRecibo, string cPerCodigo, int nPerCtaCodigo, int nTurno, int nForPago, string cCtaCtePagNroOperacion, DateTime dCtaCtePagfecha, string CtaCtePagGlosa, double fCtaCtePagImporte)
        {
            int nCtaCtePagcodigo = 0;

            try
            {
                BE_ReqCtaCtePago Request = new BE_ReqCtaCtePago();
                DA_CtaCtePago DAPago = new DA_CtaCtePago();

                Request.cCtaCteRecibo = cCtaCteRecibo;
                Request.cPerCodigo = cPerCodigo;
                Request.nPerCtaCodigo = nPerCtaCodigo;
                Request.nTurno = nTurno;
                Request.nForPago = nForPago;
                Request.cCtaCtePagNroOperacion = cCtaCtePagNroOperacion;
                Request.dCtaCtePagfecha = dCtaCtePagfecha;
                Request.CtaCtePagGlosa = CtaCtePagGlosa;
                Request.fCtaCtePagImporte = fCtaCtePagImporte;

                nCtaCtePagcodigo = DAPago.Ins_CtaCtePago(Request);

                if (nCtaCtePagcodigo == 0) {
                    throw new ApplicationException("Se encontraron errores en la transaccion: [Ins_CtaCtePago].!");
                }

            }
            catch (Exception)
            {
                throw;
            }
            return nCtaCtePagcodigo;
        }
    }
}
