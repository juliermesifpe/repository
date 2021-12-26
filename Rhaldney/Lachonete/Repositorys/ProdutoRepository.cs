using Lachonete.Interfaces;
using Lachonete.Models;

namespace Lachonete.Repository
{
    public class ProdutoRepository : ProdutoInterface<ProdutoModel>
    {
        /* private List<ProdutoModel> produtoModelList = new List<ProdutoModel>();

        public List<produtoModelList> Listar()
        {
            return produtoModelList;
        }*/

        public int GerarId()
        {
            var produtoModelList = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"));
            return produtoModelList.Count();
        }

        public void Salvar(ProdutoModel produtoModel)
        {
            // gera um Id
            produtoModel.Id = GerarId();

            /* adiciona produtoModel em produtoModelList
            produtoModelList.Add(produtoModel);*/

            // cria uma pasta File
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Files"));

            // cria um arquivo Produto.txt na pasta File
            File.AppendAllText(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"),
                $"{DateTime.Now}#{produtoModel.Id}#{produtoModel.Produto}#{produtoModel.Preco}#{produtoModel.Quantidade}#{produtoModel.Descricao}#{produtoModel.Imagem}{Environment.NewLine}"
            );
        }

        public IEnumerable<string> Listar()
        {
            var produtoModelList = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"));

            return produtoModelList;
        }

        public void Atualizar(int id, ProdutoModel produtoModel)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task PegarId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
