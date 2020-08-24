using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetailst(int id);
        List<Product> GetAll();
        List<Product> GetPopularProducts();
        List<Product> GetProductsByCategory(string category);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

    }
}
