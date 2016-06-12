namespace DXServer.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DXServer.Models.DXServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

           protected override void Seed(DXServerContext context)
        {
            var groups = new List<ProductGroup>()
            {
                new ProductGroup { Id = 1, Description = "Drinks" },
                new ProductGroup { Id = 2, Description = "Snacks" },
                new ProductGroup { Id=3,Description = "Popcorn" }
            };
            groups.ForEach(g => context.ProductGroups.AddOrUpdate(p => p.Description, g));
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product { Description="Cola", Price=2, GroupId = 1 },
                new Product { Description="Sprite", Price=2, GroupId = 1 },
                new Product { Description="Beer", Price=2, GroupId = 1},
                new Product { Description="Water", Price=1, GroupId = 1 },
                new Product { Description="M & Ms", Price=2, GroupId =2 },
                new Product { Description="Twix", Price=2, GroupId =  2},
                new Product { Description="Nacho's", Price=2, GroupId = 2 },
                new Product { Description="Chips", Price=1, GroupId =  3},
                new Product { Description="Salted Popcorn", Price=2, GroupId= 3},
                new Product { Description="Sweet Popcorn", Price=1, GroupId= 3}
            };
            products.ForEach(g => context.Products.AddOrUpdate(p => p.Description, g));
            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
