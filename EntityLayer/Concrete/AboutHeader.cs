﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutHeader
    {
        public int AboutHeaderID { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderDescription { get; set; }
        public bool HeaderStatus { get; set; }
    }
}
