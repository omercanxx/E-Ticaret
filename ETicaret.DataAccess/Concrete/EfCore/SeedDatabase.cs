using ETicaret.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if(context.Database.GetPendingMigrations().Count() == 0)
            {
                if(context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if(context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category() {Name="Telefon"},
            new Category() {Name="Bilgisayar"}
        };
        private static Product[] Products =
        {
            new Product() {Name="Samsung S5", Price = 2000, ImageUrl="Samsung_S5.jpg"},
            new Product() {Name="Samsung S6", Price = 2500, ImageUrl="Samsung_S6.jpg"},
            new Product() {Name="Samsung S7", Price = 3000, ImageUrl="Samsung_S7.jpg"},
            new Product() {Name="Samsung S8", Price = 3500, ImageUrl="Samsung_S8.jpg"},
            new Product() {Name="Iphone 6", Price = 3000, ImageUrl="Iphone6.jpg"},
            new Product() {Name="Iphone 7", Price = 3500, ImageUrl="Iphone7.jpg"},
        };
    }
}
