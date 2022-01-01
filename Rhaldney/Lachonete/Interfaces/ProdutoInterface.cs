
namespace Lachonete.Interfaces
{
    public interface ProdutoInterface<Produto>
    {
        void Salvar(Produto produto);
        IEnumerable<String> Listar();
        string Consultar(int codigo);
        void Atualizar(int codigo, Produto produto);
        void Excluir(int codigo);
    }
}
