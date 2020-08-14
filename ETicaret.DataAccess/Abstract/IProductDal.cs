﻿using ETicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}