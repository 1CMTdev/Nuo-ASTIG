using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Voucher
    {
        public string Id { get; set; }
        public string Type { get; set; }
       
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }
        public bool Usage { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Who { get; set; }

    }
}
