using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Business.Abstract;
using ETicaret.Entities;
using ETicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
        public ShopController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetailst((int) id);
            if(product== null)
            {
                return NotFound();
            }
            return View(new ProductDetailsModel() { 
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList(),
            });
        }

        public IActionResult List(string category)
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetProductsByCategory(category),
            });
        }
    }
}