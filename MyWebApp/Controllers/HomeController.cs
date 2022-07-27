using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using OrderCloud.SDK;
using OrderCloudLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            APIClientLibrary apiClient = new APIClientLibrary();

            var client = apiClient.Get();
            var products = await client.Products.ListAsync();
            return View(products.Items.ToList());
        }

        [HttpPost]
        public async Task<ActionResult> IndexAsync(string name, string desc,int count, decimal width, decimal height, decimal length, decimal weight)
        {
            APIClientLibrary apiClient = new APIClientLibrary();

            var client = apiClient.Get();
            Product product = new Product
            {
                Description = desc,
                Name = name,
                SpecCount=count,
                ShipWeight = weight,
                ShipWidth = width,
                ShipHeight = height,
                ShipLength = length
            };
            var result = await client.Products.CreateAsync(product);

            var products = await client.Products.ListAsync();
            products.Items.Add(product);
            return View(products.Items.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
