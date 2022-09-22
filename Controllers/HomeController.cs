using Microsoft.AspNetCore.Mvc;
using Projeto_quinto_semestre.Models;
using System.Diagnostics;

namespace Projeto_quinto_semestre.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Agendamento(Agendamento dados)
        {
            Dados.Cadastrar(dados);
            return View("Confirmaçao");
        }

        public IActionResult Confirmaçao()
        {
            Agendamento agendado = Dados.Listar();
            return View(agendado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}