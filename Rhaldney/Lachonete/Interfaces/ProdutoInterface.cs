namespace Lachonete.Interfaces
{
    public interface ProdutoInterface<Produto>
    {
        int GerarId();
        void Salvar(Produto produto);
        List<Produto> Listar();
        void EscreverFileAdicionar(Produto produto);
        IEnumerable<String> LerFileAdicionar();
        IEnumerable<String> LerFileCadastrar();
        Task PegarId(int id);
        void Atualizar(int id, Produto produto);
        void Excluir(int id);
    }
}
