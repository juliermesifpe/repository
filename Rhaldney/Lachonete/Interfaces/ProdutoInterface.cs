namespace Lachonete.Interfaces
{
    public interface ProdutoInterface<Produto>
    {
        int GerarId();
        void Salvar(Produto produto);
        IEnumerable<String> Listar();
        Task PegarId(int id);
        void Atualizar(int id, Produto produto);
        void Excluir(int id);
    }
}
