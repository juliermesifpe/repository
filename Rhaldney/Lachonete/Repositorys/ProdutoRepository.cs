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

        public void Salvar(ProdutoModel produtoModel)
        {
            // gera um Id "poderia seru um método GerarId"
            var produtoModelList = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"));
            produtoModel.Codigo = produtoModelList.Count();

            // cria uma pasta File
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files"));

            // cria um arquivo Produto.txt na pasta File
            File.AppendAllText(
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"),
                $"{DateTime.Now}#{produtoModel.Codigo}#{produtoModel.Produto}#{produtoModel.Preco}#{produtoModel.Quantidade}#{produtoModel.Descricao}#{produtoModel.Imagem}{Environment.NewLine}"
            );

        }

        public IEnumerable<string> Listar()
        {
            var produtoModelList = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt"));
            return produtoModelList;
        }

        public string Consultar(int codigo)
        {
           

           var produtoModelList = Listar();

            foreach(var produtoModel in produtoModelList)
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

       
    }
}
