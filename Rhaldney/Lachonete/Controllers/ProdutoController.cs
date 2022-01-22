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
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoModel produtoModel)
        {
            produtoRepository.Salvar(produtoModel);
            return View("Cadastro");
        }
        public IActionResult Consultar(ProdutoModel produtoModel)
        {
            ViewBag.produtoModel = produtoRepository.Consultar(produtoModel.Codigo);
            return View("Cadastro", ViewBag);
        }

        [HttpGet("[controller]/[action]/{codigo:int}/{produto}/{preco:double}/{quantidade:int}/{descricao}/{imagem}")]
        public void Adicionar(int codigo, string produto, double preco, int quantidade, string descricao, IFormFile imagem)
        {
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Codigo = codigo;
            produtoModel.Produto = produto;
            produtoModel.Preco = preco;
            produtoModel.Quantidade = quantidade;
            produtoModel.Descricao = descricao;
            produtoModel.Imagem = imagem;

            PedidoModel pedidoModel = new PedidoModel();
            pedidoModel.ProdutoModel = produtoModel;
            pedidoRepository.Adicionar(pedidoModel);
        }
    }
}