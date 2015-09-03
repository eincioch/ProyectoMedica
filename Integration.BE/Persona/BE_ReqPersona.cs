using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Persona
{
    public class BE_ReqPersona
    {
        public string cPerCodigo {get; set;}
        //cPerJurCodigo.- para generar codigo persona por sucursal
        public string cPerJurCodigo { get; set; }

        public long nPerIdeTipo {get; set;}  
        public string cPerIdeNumero {get; set;}  
        public string cPerApellPaterno {get; set;} 
        public string cPerApellMaterno {get; set;} 
        public string cPerPriNombre {get; set;} 
        public string cPerSegNombre {get; set;}  
        public string cPerTerNombre {get; set;}  
        public string dPerNacimiento {get; set;} 
        public long nPerTipo {get; set;} 
        public string cUbiGeoCodigo {get; set;}  
        public long nPerTratamiento {get; set;}  
        public long nPerNatSexo {get; set;}  
        public long nPerNatEstCivil {get; set;}  
        public long nPerNatTipResidencia {get; set;} 
        public long nPerNatSitLaboral {get; set;}  
        public long nPerNatOcupacion {get; set;} 
        public long nPerNatCondicion {get; set;}  
        public string cPerJurRepCodigo {get; set;}
        public long nPerJurTipInversion {get; set;}
        public long nPerJurSecEconomico { get; set; } 

        public long nCarCodigo {get;set;}
        public string cCarValor { get; set; }
        public DateTime dFecha { get; set; }

        //PerRelacion
        public int nPerRelTipo { get; set; }
    }
}
