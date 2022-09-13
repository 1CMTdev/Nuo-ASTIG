using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Transchunk
    {//pertrans
        public string Id { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Cx { get; set; }
        public string Products { get; set; }
        public string Voucher { get; set; } = "None";
        public string Mode { get; set; } 
        public string Address { get; set; } 
        public string Status { get; set; } = "Processing";
        [Column(TypeName = "decimal(18,2)")]
        public decimal OverallTotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal WithoutShipping { get; set; }
    }
}
