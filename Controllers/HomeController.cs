using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EntityFramework_exercicio.Models;

namespace APIEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Json(Cliente.Busca(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(Cliente.Busca().Where(c => c.Id == id).First(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Criar()
        {
            var cliente = new Cliente();
            cliente.Nome = Request["Nome"];
            cliente.Telefone = Convert.ToInt32(Request["Telefone"]);
            cliente.Salvar();
            return Json(cliente);
        }


        [HttpPut]
        public ActionResult Alterar(int id)
        {
            var cliente = Cliente.Busca().Where(c => c.Id == id).First();
            // Request.QueryString
            // Request.Params["nome"]
            cliente.Nome = Request["Nome"];
            cliente.Telefone = Convert.ToInt32(Request["Telefone"]);
            return Json(cliente);
        }

    }
}