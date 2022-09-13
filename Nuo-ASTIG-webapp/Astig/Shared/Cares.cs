using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Cares
    {
        public string Caresid { get; set; }
        public string Message { get; set; }
        public string Cx { get; set; }
        public string Contact { get; set; }
    }
}
