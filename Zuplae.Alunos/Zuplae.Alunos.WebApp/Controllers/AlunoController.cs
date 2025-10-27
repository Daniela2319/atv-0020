using Microsoft.AspNetCore.Mvc;
using Zuplae.Alunos.WebApp.Models;

namespace Zuplae.Alunos.WebApp.Controllers
{
    public class AlunoController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            alunos.Add(aluno);
            ViewBag.Mensagem = $"Cadastro realizado com sucesso para {aluno.Nome}";
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(alunos);
        }
    }
}
