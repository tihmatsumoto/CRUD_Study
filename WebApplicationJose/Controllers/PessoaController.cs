using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationJose.Models;

namespace WebApplicationJose.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index(Guid? id)
        {
            #region nao existe
            #endregion

            if (id != null)
            {
                return View(PessoasSingle.Pessoas.Where(x => x.Id == id).ToList());
            }

            return View(PessoasSingle.Pessoas);
        }

        public IActionResult Create(Pessoa? formulario)
        {
            return View(formulario);
        }

        [HttpPost]
        public IActionResult CreatePessoa(Pessoa? formulario)
        {
            if (formulario.Name != null)
            {
                formulario.Id = Guid.NewGuid();
                PessoasSingle.Pessoas.Add(formulario);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["erro"] = "Faltou o nome";
                return RedirectToAction("Create", formulario);
            }
        }



    }
}