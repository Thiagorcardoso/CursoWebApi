using Sistema.Model.Domain;
using System.Collections.Generic;

namespace Sistema.Repository
{
    public static class ListaPedido
    {
        static ListaPedido()
        {
            _insereItemPedido();
            _popularListaPedido();
        }

        public static List<Pedido> _listaPedido = new List<Pedido>();
        public static List<ItemPedido> _listaItemPedido = new List<ItemPedido>();

        private static void _insereItemPedido()
        {
            _listaItemPedido.Add(new ItemPedido { idItemPedido = 1, idProduto = 1, quantidadeComprada = 2, valorProduto = 1.50M});
        }

        private static List<Pedido> _popularListaPedido()
        {
            _listaPedido.Add(new Pedido { idPedido = 1, dataEmissao = ("31-10-2017"), total = 3.00M, idCliente = 1, listaPedido = _listaItemPedido});

            return _listaPedido;
        }
    }
}