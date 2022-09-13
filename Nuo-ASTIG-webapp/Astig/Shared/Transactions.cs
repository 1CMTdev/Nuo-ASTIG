using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Transactions
    {
        //this is per product
        public string Id { get; set; }
        public string TransID { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Cx { get; set; }
        public string Sx { get; set; }
        public string Px { get; set; }
     
        // 
        public string Retur { get; set; } = "Available";
        public string Status { get; set; } = "Processing";
        public string Deliverymode { get; set; } = "";

        //raw price = pure seller price
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        //total = with commision
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        //comi = developer commish
        [Column(TypeName = "decimal(18,2)")]
        public decimal Comi { get; set; }
        public bool Rated { get; set; }

    }


}
