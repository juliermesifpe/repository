using Lachonete.Interfaces;
using Lachonete.Models;

namespace Lachonete.Repositorys
{
    public class ProdutoRepository : ProdutoInterface<ProdutoModel>
    {
        private List<ProdutoModel> produtoModelList = new List<ProdutoModel>();

        public void Salvar(ProdutoModel produtoModel)
        {
            
            // cria uma pasta file
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files"));

            // cria um arquivo Produto.txt na pasta file
            File.AppendAllText(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"),
                $"{DateTime.Now}#{produtoModel.}#{produtoModel.produto()}#{produtoModel.preco()}#{produtoModel.quantidade()}#{produtoModel.descricao()}#{produtoModel.GerarImagem()}{Environment.NewLine}");

        }

        public IEnumerable<string> Enumerar()
        {
            var produtoModelList = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"));
            return produtoModelList;
        }

        public string Consultar(int codigo)
        {
            var produtoModelList = Enumerar();

            foreach (var produtoModel in produtoModelList)
            {
                string[] produto = produtoModel.Split('#');

                if (produto[1].Equals(Convert.ToString(codigo)))
                {
                    return produtoModel;
                }
            }
            return "";
        }

        public void Atualizar(int codigo, ProdutoModel produtoModel)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoModel> Listar()
        {
            return produtoModelList;
        }

        public void Adicionar(ProdutoModel produtoModel)
        {
            produtoModelList.Add(produtoModel);
        }

        public void Remover(ProdutoModel produtoModel)
        {
            produtoModelList.Remove(produtoModel);
        }
    }
}
