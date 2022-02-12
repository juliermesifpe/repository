using Lachonete.Models;

namespace Lachonete.Interfaces
{
    public interface ProdutoInterface<ProdutoModel>
    {
        int GerarId();
        string GerarImagem(IFormFile produtoFileImagem);
        void Salvar(ProdutoModel produtoModel);
        string Consultar(int produtoCodigo);
        void Excluir(int produtoCodigo);
        void Atualizar(int produtoCodigo, ProdutoModel produtoModel);
        IEnumerable<String> Enumerar();

        List<ProdutoModel> Listar();
        void Adicionar(ProdutoModel produtoModel);
        void Remover(ProdutoModel produtoModel);
    }
}
