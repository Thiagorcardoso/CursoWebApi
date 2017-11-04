using Sistema.Model.Interface;

namespace Sistema.Model.Domain
{
    public class ItemPedido : IProduto
    {
        public int idItemPedido { get; set; }
        public int idProduto { get; set; }
        public int quantidadeComprada { get; set; }
        public decimal valorProduto { get; set; }
    }
}