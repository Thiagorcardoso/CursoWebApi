using Sistema.Model.Interface;
using System.Collections.Generic;

namespace Sistema.Model.Domain
{
    public class Pedido : ICliente
    {
        public int idPedido { get; set; }
        public string dataEmissao { get; set; }
        public decimal total { get; set; }
        public int idCliente { get; set; }
        public List<ItemPedido> listaPedido { get; set; }
    }
}