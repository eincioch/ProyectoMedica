﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integration.BE.PerUsuGruAcc
{
    public class BE_Req_PerUsuGruAcc
    {
        public string cPerCodigo { get; set; }
        public int nSisGruTipo { get; set; }
        public int nObjTipo { get; set; }
    }

    public class BE_Req_PermisosMenu
    {
        public string cPerCodigo { get; set; }
        public int cModulo { get; set; }
    }
}
