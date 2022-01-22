using Lachonete.Models;

namespace Lachonete.Interfaces
{
    public interface ProdutoInterface<ProdutoModel>
    {
        void Salvar(ProdutoModel produtoModel);
        string Consultar(int produtoCodigo);
        void Atualizar(int produtoCodigo, ProdutoModel produtoModel);
        void Excluir(int produtoCodigo);
        IEnumerable<String> Enumerar();

        List<ProdutoModel> Listar();
        void Adicionar(ProdutoModel produtoModel);
        void Remover(ProdutoModel produtoModel);
    }
}
