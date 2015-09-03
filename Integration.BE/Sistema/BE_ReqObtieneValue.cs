using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.Sistema
{
    public class BE_ReqObtieneValue
    {
        public string CampoSelect { get; set; }
        public string  NameTabla { get; set; }
        public string CampoWhere { get; set; }
        public int nFlag { get; set; }
        public string Condicion { get; set; }
    } 
}
