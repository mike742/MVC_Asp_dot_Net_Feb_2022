﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Models
{
    public class Vendor
    {
        [Key]
        public int V_code { get; set; }
        public string V_name { get; set; }
        public string V_contact { get; set; }
        public int V_AreaCode { get; set; }
        public string V_phone { get; set; }
        public string V_state { get; set; }
        public string V_order { get; set; }
    }
}

