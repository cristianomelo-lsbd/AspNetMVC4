using AspNetMVC_aula01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_aula01.Controllers
{
    public class CadastroAlunoController : Controller
    {
        public ActionResult CadastroAluno()
        {
            ModAluno aluno = new ModAluno();
            return View(aluno);
        }

        // Form colletion is one way to pass a value from a VIEW to the CONTROLLER
        [HttpPost] // this method collects the data from the browser. it MUST BE declared
        public ActionResult ExibeCadastroAluno(FormCollection form)
        {
            ViewBag.idAluno = form["idAluno"];
            ViewBag.nome = form["nome"];
            ViewBag.email = form["email"];

            return View();
        }
        
    }
}