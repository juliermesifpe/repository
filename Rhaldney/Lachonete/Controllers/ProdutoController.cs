using Lachonete.Models;
using Lachonete.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lachonete.Controllers
{
    public class ProdutoController : Controller
    {
        static ProdutoRepository produtoRepository = new ProdutoRepository();

        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Produto()
        {
            ViewBag.produtoModelList = produtoRepository.Listar();
            return View("Produto", ViewBag);
        }

        public IActionResult Compras()
        {
            return View();
        }

        public IActionResult Salvar(ProdutoModel produtoModel)
        {
            produtoRepository.Salvar(produtoModel);
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}