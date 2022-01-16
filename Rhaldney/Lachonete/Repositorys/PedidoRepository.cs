using Lachonete.Interfaces;
using Lachonete.Models;

namespace Lachonete.Repositorys
{
    public class PedidoRepository : PedidoInterface<PedidoModel>
    {
        private List<PedidoModel> listPedidoModel = new List<PedidoModel>();
        public List<PedidoModel> Listar()
        {
            return listPedidoModel;
        }
        public void Adicionar(PedidoModel pedidoModel)
        {
            listPedidoModel.Add(pedidoModel);
        }
        public void Remover(int codigo)
        {
            throw new NotImplementedException();
        }
        public int GeraIdSalvar()
        {
            return listPedidoModel.Count;
        }
        public void Salvar(PedidoModel produto)
        {
            throw new NotImplementedException();
        }
    }
}
