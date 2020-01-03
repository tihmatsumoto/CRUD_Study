using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tiemi.Models;

namespace Tiemi.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index(Guid? id)
        {
            if(id != null)
            {
                return View(Cadastros.Pessoas.Where(x => x.Id == id).ToList());
            }

            return View(Cadastros.Pessoas);
        }

        public IActionResult Create(Pessoa? formulario)
        {
            return View(formulario);
        }

        [HttpPost]
        public IActionResult CreatePessoa(Pessoa? formulario)
        {

            if(ValidaForm(formulario))
            {
                if(formulario.Id == Guid.Empty)
                {
                    formulario.Id = Guid.NewGuid();
                    Cadastros.Pessoas.Add(formulario);
                    return RedirectToAction("Index");
                }
                else
                {
                    Cadastros.Pessoas.RemoveAll(x => x.Id == formulario.Id);
                    Cadastros.Pessoas.Add(formulario);
                    return RedirectToAction("Index");
                }

            }
            else
            {
                return RedirectToAction("Create", formulario);
            }

            
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            Cadastros.Pessoas.RemoveAll(x => x.Id == id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            return RedirectToAction("Create", Cadastros.Pessoas.Find(x => x.Id == id));
        }

        private bool ValidaForm(Pessoa form)
        {
            if (form.Nome != null)
            {
                return true;                
            }
            else
            {
                TempData["erro"] = "Campos obrigatórios não completos!";
                return false;
            }
        }

    }
}