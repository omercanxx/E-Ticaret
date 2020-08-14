using ETicaret.DataAccess.Abstract;
using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ETicaret.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
