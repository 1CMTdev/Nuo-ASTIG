using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shopname { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; } = "NOPE";
        public string Address { get; set; }
        public string Adresscavite { get; set; }
        public string IG { get; set; } = "instagram.com";
        public bool Allowed { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
    }
}
