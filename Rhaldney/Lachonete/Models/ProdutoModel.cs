namespace Lachonete.Models
{
    public class ProdutoModel
    {
        public int Codigo { get; set; }
        public string? Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
        public IFormFile? Imagem { get; set; }

        public int retornarCodigo()
        {
            return this.Codigo;
        }
        public string? retornarProduto()
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
        public string? retornarDescricao()
        {
            return this.Descricao;
        }
        public IFormFile? retornarImagem()
        {
            return this.Imagem;
        }

        public int GerarId()
        {
            return File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", "produto.txt")).Count();
        }
        public string GerarImagem()
        {
            var memoryStream = new MemoryStream();
            this.Imagem.OpenReadStream().CopyTo(memoryStream);
            return "data:"+this.Imagem.ContentType+";base64,"+Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}
