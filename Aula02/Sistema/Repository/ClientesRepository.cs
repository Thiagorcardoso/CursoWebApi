using Sistema.Model.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Sistema.Repository
{
    public class ClientesRepository
    {
        public List<Cliente> getClienteAscending()
        {
            var listaSearch = new List<Cliente>();

            listaSearch.AddRange(ListaCliente._listaCliente.OrderBy(x => x.nome));

            return listaSearch;
        }

        public List<Cliente> getClienteBySexo(char sexo)
        {
            var listaSearch = new List<Cliente>();

            listaSearch.AddRange(ListaCliente._listaCliente.Where(x => x.sexo == sexo));

            return listaSearch;
        }

        public List<Cliente> getClienteAtivo()
        {
            var listaSearch = new List<Cliente>();

            listaSearch.AddRange(ListaCliente._listaCliente.Where(x => x.ativo == true));

            return listaSearch;
        }

        public List<Cliente> getClienteAniversariante(string datanasc)
        {
            var listaSearch = new List<Cliente>();

            listaSearch.AddRange(ListaCliente._listaCliente.Where(x => x.dataNascimento == datanasc));

            return listaSearch;
        }

        public Cliente getById(int id)
        {
            if (id > 0)
                return ListaCliente._listaCliente.Where(x => x.idCliente == id).FirstOrDefault();

            return null;
        }

        public void insertCliente(Cliente cliente)
        {
            ListaCliente._listaCliente.Add(cliente);
        }

        public void trocaStatusCliente(int id, bool ativo)
        {
            var upCliente = getById(id);

            if (upCliente != null && ativo == true)
            {
                upCliente = (from x in ListaCliente._listaCliente where x.idCliente == id select x).SingleOrDefault();
                upCliente.ativo = true;
            }
            else if (upCliente != null && ativo == false)
            {
                upCliente = (from x in ListaCliente._listaCliente where x.idCliente == id select x).SingleOrDefault();
                upCliente.ativo = false;
            }
        }
        
        public void updateCliente(int id, Cliente cliente)
        {
            var upCliente = getById(id);

            if (upCliente != null)
                ListaCliente._listaCliente.Remove(upCliente);
                ListaCliente._listaCliente.Add(cliente);
        }

        public void deleteCliente(int id)
        {
            var deleteCliente = getById(id);


            if (deleteCliente != null)
                ListaCliente._listaCliente.Remove(deleteCliente);
        }
    }
}