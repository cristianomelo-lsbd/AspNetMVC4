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
            // ViewBag receives attributes by HttpPost and save them to uses on ExibeCadastroAluno.cshtml
            ViewBag.idAluno = form["idAluno"];
            ViewBag.nome = form["nome"];
            ViewBag.email = form["email"];

            return View();
        }

        // Form colletion is one way to pass a value from a VIEW to the CONTROLLER
        [HttpPost] // this method collects the data from the browser. it MUST BE declared
        public ActionResult ExibeCadastroAlunoTipado(ModAluno aluno)
        {
            // Validation
            if ( aluno.idAluno <= 0 )
            {
                ModelState.AddModelError("idAluno", "student code must be >0");
            }
            if( aluno.nome == null || aluno.nome.Trim().Length == 0)
            {
                ModelState.AddModelError("nome", "name must be filled");
            } 


            // validade works because is activated in Global.asax
            if( ModelState.IsValid == false)
            {
                return View("CadastroAluno", aluno); // calls Cadastro Aluno if occurs some problem and returns the node
            }


            return View(aluno);
        }

    }
}