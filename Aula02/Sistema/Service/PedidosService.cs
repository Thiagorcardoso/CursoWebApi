
using Sistema.Model.Domain;
using Sistema.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema.Service
{
    public class PedidoService
    {

        public void isProductInStock(Pedido pedido)
        {
            List<ItemPedido> temp = new List<ItemPedido>();

            temp = pedido.listaPedido;


            foreach (var item in temp)
            {
                var estoque = ListaProduto._listaProduto.Where(x => x.idProduto == item.idProduto).Select(x => x.estoqueTotal).SingleOrDefault();
                if (item.quantidadeComprada > estoque)
                {
                    throw new Exception("Quantidade Indisponível em Estoque");
                }
            }
            var pedidoRepository = new PedidoRepository();
            pedidoRepository.insertPedido(pedido);
        }
    }
}