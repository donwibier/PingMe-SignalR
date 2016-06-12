using DXServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DXServer.ViewModels
{
    public class MenuItem
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool Selected { get; set; }
        public string NavigateUrl
        {
            get
            {
                List<string> result = new List<string>();
                if (!String.IsNullOrEmpty(Controller))
                    result.Add(Controller);
                if (!String.IsNullOrEmpty(Action))
                    result.Add(Action);
                return String.Format("/{0}", String.Join("/", result.ToArray()));
            }
        }
    }
    public abstract class ViewModelBase<TModel>        
    {
        public virtual IEnumerable<MenuItem> MainNavigationItems { get; set; }
        public abstract void Assign(TModel source);
    }

    public class ProductGroupViewModel : ViewModelBase<ProductGroup>
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Description { get; set; }

        public override void Assign(ProductGroup source)
        {
            Id = source.Id;
            Description = source.Description;
        }
    }

    public class ProductViewModel : ViewModelBase<Product>
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        //public ProductGroup Group { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public Decimal Price { get; set; }

        public IEnumerable<ProductGroup> LookupGroups { get; set; }

        public override void Assign(Product source)
        {
            Id = source.Id;
            GroupId = source.GroupId;
            Description = source.Description;
            Price = source.Price;
        }
    }
}

