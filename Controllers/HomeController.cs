using Microsoft.AspNetCore.Mvc;
using Projeto_quinto_semestre.Models;
using System.Diagnostics;

namespace Projeto_quinto_semestre.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "otavio";
            home.Email = "otavio@gmail.com";


            return View(home);
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