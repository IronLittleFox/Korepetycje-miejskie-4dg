using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShowProduct()
        {
            Product product = new Product()
            {
                Name="Mleko",
                Price = 2,
                Description = "Pij mleko, będziesz wielki"
            };

            return View(product);
        }

        public IActionResult ShowProduct(Product product)
        {
            return View(product);
        }

        public IActionResult EditProduct()
        {
            Product product = new Product()
            {
                Name = "Golf",
                Price = 88,
                Description = "Można na części"
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult SaveProduct(Product product)
        {
            //zapis produktu do bazy danych
            return View("ShowProduct", product);
        }

    }
}
