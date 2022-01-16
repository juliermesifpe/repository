namespace Lachonete.Models
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public string? Observacao { get; set; }
        public ProdutoModel? ProdutoModel { get; set; }

        public int retornarIdPedido()
        {
            return this.IdPedido;
        }
        public string retornarObservacao()
        {
            return this.Observacao;
        }
        public ProdutoModel retornarProdutoModel()
        {
            return this.ProdutoModel;
        }
    }
}
