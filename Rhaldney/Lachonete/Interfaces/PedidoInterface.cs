namespace Lachonete.Interfaces
{
    public interface PedidoInterface<PedidoModel>
    {
        List<PedidoModel> Listar();
        void Adicionar(PedidoModel pedidoModel);
        void Remover(int codigo);
        void Salvar(PedidoModel pedidoModel);
    }
}
