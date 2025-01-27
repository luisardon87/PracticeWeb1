using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebPractice_2.Models;

namespace WebPractice_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["MensajeBienvenida"] = _configuration["MensajeBienvenida"];
            return View();
        }
    }
}
