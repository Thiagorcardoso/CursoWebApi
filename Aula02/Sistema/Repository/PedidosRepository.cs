using Sistema.Model.Domain;
using System.Linq;

namespace Sistema.Repository
{
    public class PedidoRepository
    {

        public Pedido getById(int id)
        {
            if (id > 0)
                return ListaPedido._listaPedido.Where(x => x.idPedido == id).FirstOrDefault();

            return null;
        }

        public void insertPedido(Pedido pedido)
        {
            ListaPedido._listaPedido.Add(pedido);
        }

        public void updatePedido(int id, Pedido pedido)
        {
            var updatePedido = getById(id);

            if (updatePedido != null)
            {
                ListaPedido._listaPedido.Remove(updatePedido);
                ListaPedido._listaPedido.Add(pedido);
            }
        }

        public void deletePedido(int id)
        {
            var deletePedido = getById(id);

            if (deletePedido != null)
                ListaPedido._listaPedido.Remove(deletePedido);
        }
    }
}