using Lachonete.Models;
using Lachonete.Repositorys;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lachonete.Controllers
{   
    
    public class ProdutoController : Controller
    {
        static ProdutoRepository produtoRepository = new ProdutoRepository();
        static PedidoRepository pedidoRepository = new PedidoRepository();

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            ViewBag.produtoModelList = produtoRepository.Enumerar();
            return View(ViewBag);
        }

        public IActionResult Carrinho()
        {
            ViewBag.produtoModelList = produtoRepository.Listar();
            return View(ViewBag);
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoModel produtoModel)
        {
            produtoModel.Codigo = produtoRepository.GerarId();
            produtoModel.Imagem = produtoRepository.GerarImagem(produtoModel.FileImagem);
            produtoRepository.Salvar(produtoModel);
            return View("Cadastro");
        }
        [HttpPost]
        public IActionResult Consultar(ProdutoModel produtoModel)
        {
            ViewBag.produtoModel = produtoRepository.Consultar(produtoModel.Codigo);
            return View("Cadastro", ViewBag);
        }

        //[HttpGet("[controller]/[action]/{codigo:int}/{produto}/{preco:double}/{quantidade:int}/{descricao}/{imagem}")]
        [HttpGet("[controller]/[action]/{produtoCodigo:int}")]
        public void Adicionar(int produtoCodigo)
        {
            //string produto = produtoRepository.Consultar(produtoCodigo);
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Codigo = produtoCodigo;
            produtoRepository.Adicionar(produtoModel);
        }

        [HttpGet("[controller]/[action]/{produtoCodigo:int}")]
        public void Remover(int produtoCodigo)
        {
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Codigo = produtoCodigo;
            produtoRepository.Remover(produtoModel);
        }

    }
}