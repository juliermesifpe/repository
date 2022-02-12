namespace Lachonete.Models
{
    public class ProdutoModel
    {
        public int Codigo { get; set; }
        public string? Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        public IFormFile? FileImagem { get; set; }

        public int retornarCodigo()
        {
            return this.Codigo;
        }

        public string retornarProduto()
        {
            return this.Produto;
        }

        public double retornarPreco()
        {
            return this.Preco;
        }

        public int retornarQuantidade()
        {
            return this.Quantidade;
        }

        public string retornarDescricao()
        {
            return this.Descricao;
        }

        public string retornarImagem()
        {
            return this.Imagem;
        }
    }
}
