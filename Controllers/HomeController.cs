using System.Web.Mvc;
using EntityFramework_exercicio.Models;

namespace APIEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
           var novocliente = new Cliente() {  Nome = "Emanuelle", Telefone= 558845455, Endereco="Rua dos bobos, n0" }.Salvar();

            var clientes = Cliente.Lista();
                      

            ViewBag.Title = "Home Page";
            ViewBag.clientes = clientes;

            return View();
        }
    }
}