using Sistema.Model.Interface;

namespace Sistema.Model.Domain
{
    public class Cliente : ICliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public char sexo { get; set; }
        public bool ativo { get; set; }       
    }
}