using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Models
{
    public class Product
    {
        [Key]
        public string P_code { get; set; }
        [DisplayName("Descrition")]
        public string P_descript { get; set; }
        [DisplayName("Date")]
        public DateTime P_InDate { get; set; }
        [DisplayName("QOH")]
        public int P_QOH { get; set; }
        [DisplayName("Min")]
        public int P_Min { get; set; }
        [DisplayName("Price, $")]
        public double P_Price { get; set; }
        [DisplayName("Discount")]
        public double P_Discount { get; set; }

        [ForeignKey("Vendor")]
        public int? V_code { get; set; }
        public Vendor Vendor { get; set; }
    }
}
