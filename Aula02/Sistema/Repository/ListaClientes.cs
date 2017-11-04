using Sistema.Model.Domain;
using System.Collections.Generic;

namespace Sistema.Repository
{
    public static class ListaCliente
    {
        static ListaCliente()
        {
            _popularListaCliente();
        }
        public static List<Cliente> _listaCliente = new List<Cliente>();

        private static List<Cliente> _popularListaCliente()
        {
            _listaCliente.Add(new Cliente() { idCliente = 1, nome = "João", sexo = 'M', ativo = true });
            _listaCliente.Add(new Cliente() { idCliente = 2, nome = "Ana", sexo = 'F', ativo = true });
            _listaCliente.Add(new Cliente() { idCliente = 3, nome = "Paula", sexo = 'F', dataNascimento = "22-09-1994", ativo = false });
            _listaCliente.Add(new Cliente() { idCliente = 4, nome = "André", sexo = 'M', ativo = false });
            _listaCliente.Add(new Cliente() { idCliente = 5, nome = "José", sexo = 'M', dataNascimento = "01-01-2000", ativo = true });

            return _listaCliente;
        }
    }
}