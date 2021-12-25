using Lachonete.Interfaces;
using Lachonete.Models;

namespace Lachonete.Repository
{
    public class ProdutoRepository : ProdutoInterface<ProdutoModel>
    {
        public void Atualizar(int id, ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public void EscreverFileAdicionar(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int GerarId()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> LerFileAdicionar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> LerFileCadastrar()
        {
            throw new NotImplementedException();
        }

        public List<ProdutoModel> Listar()
        {
            throw new NotImplementedException();
        }

        public Task PegarId(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }
    }
}
