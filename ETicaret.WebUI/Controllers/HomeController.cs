using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Business.Abstract;
using ETicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            }); ;
        }
    }
}