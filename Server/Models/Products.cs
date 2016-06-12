using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public ProductGroup Group {get; set;}
        [StringLength(100)]
        public string Description { get; set; }
        public Decimal Price { get; set; }

    }

    public class ProductViewModel: Product
    {
        public IEnumerable<SelectListItem> LookupGroups { get; set; }
    }
}
