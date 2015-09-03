using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.SeuConAssetModelo
{
    public class BE_ReqSeuConAssetModelo
    {
        public long nSeuCodigo {get; set;}
        public long nSeuEstado {get; set;}
        public DateTime dSeuEFFDT {get; set;}
        public long nModCodigo  {get; set;}
        public string cSeusName	 {get; set;}
        public string cPerJurCodigo { get; set; }
    }
}
