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
                    context.AddRange(ProductCategory);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
        {
            new Category() {Name="Telefon"},
            new Category() {Name="Bilgisayar"},
            new Category() {Name="Elektronik"}
        };
        private static Product[] Products =
        {
            new Product() {Name="Samsung S5", Price = 2000, ImageUrl="Samsung_S5.jpg", Description="<p>Samsung S5'e ait açıklama</p>"},
            new Product() {Name="Samsung S6", Price = 2500, ImageUrl="Samsung_S6.jpg", Description="<p>Samsung S6'ya ait açıklama</p>"},
            new Product() {Name="Samsung S7", Price = 3000, ImageUrl="Samsung_S7.jpg", Description="<p>Samsung S7'ye ait açıklama</p>"},
            new Product() {Name="Samsung S8", Price = 3500, ImageUrl="Samsung_S8.jpg", Description="<p>Samsung S8'e ait açıklama</p>"},
            new Product() {Name="Iphone 6", Price = 3000, ImageUrl="Iphone6.jpg", Description="<p>Iphone6'ya ait açıklama</p>"},
            new Product() {Name="Iphone 7", Price = 3500, ImageUrl="Iphone7.jpg", Description="<p>Iphone7'ye ait açıklama</p>"},

            new Product() {Name="Huawei Matebook D 15", Price = 4500, ImageUrl="Huawei_Matebook.jpg", Description="<p>Huawei Matebook D 15'e ait açıklama</p>"},
            new Product() {Name="Dell Inspiron 3593", Price = 4000, ImageUrl="Dell_Inspiron.jpg", Description="<p>Dell Inspiron 3593'e ait açıklama</p>"},
            new Product() {Name="Apple MacBook Air", Price = 3000, ImageUrl="Apple_Macbook_Air.jpg", Description="<p>Apple MacBook Air'e ait açıklama</p>"},
        };
        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory()
            {
                Product = Products[0], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[0], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[1], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[1], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[2], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[2], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[3], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[3], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[4], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[4], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[5], Category = Categories[0]
            },
            new ProductCategory()
            {
                Product = Products[5], Category = Categories[2]
            },


            new ProductCategory()
            {
                Product = Products[6], Category = Categories[1]
            },
            new ProductCategory()
            {
                Product = Products[6], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[7], Category = Categories[1]
            },
            new ProductCategory()
            {
                Product = Products[7], Category = Categories[2]
            },
            new ProductCategory()
            {
                Product = Products[8], Category = Categories[1]
            },
            new ProductCategory()
            {
                Product = Products[8], Category = Categories[2]
            },
        };
    }
}
