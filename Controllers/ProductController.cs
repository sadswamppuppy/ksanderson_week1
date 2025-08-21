/*Kasey Sanderson SPC ID 2506815
 COP 2839 - Week 1 Assignment
8/20/2025
Collaborators: learn.microsoft.com, 
"Architecting Modern Web Applications.." by
Steve "Ardalis" Smith*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ksanderson_week1.Models;
using System.Collections.Generic;

namespace ksanderson_week1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("You have accessed the Product Index page.");

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Nintendo Switch", Price = 399.99m },
                new Product { Id = 2, Name = "XBOX", Price = 600.00m },
                new Product { Id = 3, Name = "PS5", Price = 699.99m }
            };

            return View(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _logger.LogInformation("A new product has been added:" +
                " {Name} at a price of {Price}", product.Name, product.Price);
            return RedirectToAction("Index");
        }
    }
}
