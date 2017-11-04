using Sistema.Model.Interface;

namespace Sistema.Model.Domain
{
    public class Produto : IProduto
    {
        public int idProduto { get; set; }
        public string descricao { get; set; }
        public decimal valorProduto { get; set; }
        public int estoqueTotal { get; set; }
        public int estoqueMinimo { get; set; }       
    }
}