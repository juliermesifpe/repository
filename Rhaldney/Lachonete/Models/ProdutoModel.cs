namespace Lachonete.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        List<ProdutoModel>produtoModelsList = new List<ProdutoModel>();

        public int RetornarId()
        {
            return this.Id;
        }
        public double RetornarPreco()
        {
            return this.Preco;
        }
        public int RetornarQuantidade()
        {
            return this.Quantidade;
        }
        public string RetornarDescricao()
        {
            return this.Descricao;
        }
        public string RetornarImagem()
        {
            return this.Imagem;
        }
    }
}
