using MvcPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Description = "Descrição index view";

            return View();
        }

        public ActionResult Cadastrar(Produto produto)
        {
            if(produto.Nome != null)
            {
                produto.addProduto();
            }

            return View();
        }

        public ActionResult Buscar() 
        {
            var produtos = ProdutoCollection.GetAllProducts();
            return View();
        }

        public PartialViewResult DefinicaoArquitetura()
        {
            return PartialView();
        }
    }
}
