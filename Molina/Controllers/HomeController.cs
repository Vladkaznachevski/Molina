using Data;
using Microsoft.AspNetCore.Mvc;
using Molina.Models;
using Services.ClothSer;
using System.Diagnostics;

namespace Molina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IClothService _ClothService;

        public HomeController(ILogger<HomeController> logger,IClothService clothService)
        {
            _logger = logger;
            _ClothService = clothService;
        }

        public IActionResult Index()
        {
            List<Cloth> Clothes = _ClothService.GetCloths();
            return View(Clothes);
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