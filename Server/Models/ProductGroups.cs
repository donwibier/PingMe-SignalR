using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class ProductGroup
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
