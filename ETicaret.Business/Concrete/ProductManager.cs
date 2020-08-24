using ETicaret.Business.Abstract;
using ETicaret.DataAccess.Abstract;
using ETicaret.DataAccess.Concrete.EfCore;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetPopularProducts()
        {
            return _productDal.GetPopularProducts().ToList();
        }

        public Product GetProductDetailst(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _productDal.GetProductsByCagetory(category);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
