using Microsoft.AspNetCore.Mvc;
using SQLServer.Interfaces;
using System.Diagnostics;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepo _productRepo;

        public HomeController(ILogger<HomeController> logger,IProductRepo productRepo)
        {
            _logger = logger;
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            _productRepo.GetProductsByCustomerID(2);
            return View();
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
