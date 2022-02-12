namespace Lachonete.Models
{
    public class PedidoModel
    {
        public int Pedido { get; set; }
        public string? Observacao { get; set; }
        public ProdutoModel? ProdutoModel { get; set; }

        public int retornarPedido()
        {
            return this.Pedido;
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
