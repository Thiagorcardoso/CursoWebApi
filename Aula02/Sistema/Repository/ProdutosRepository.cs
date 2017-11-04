using System.Collections.Generic;
using System.Linq;
using Sistema.Model.Domain;

namespace Sistema.Repository
{
    public class ProdutoRepository
    {
        public List<Produto> getProdutoLow()
        {
            var ListaSearch = new List<Produto>();

            ListaSearch.AddRange(ListaProduto._listaProduto.Where(x => x.estoqueTotal < x.estoqueMinimo));

            return ListaSearch;
        }
        
        public Produto getById(int id)
        {
            if (id > 0)
                return ListaProduto._listaProduto.Where(x => x.idProduto == id).FirstOrDefault();

            return null;
        }

        public void insertProduto(Produto produto)
        {
            ListaProduto._listaProduto.Add(produto);
        }

        public void updateProduto(int id, Produto produto)
        {
            var updateProduto = getById(id);

            if (updateProduto != null)
                ListaProduto._listaProduto.Remove(updateProduto);
                ListaProduto._listaProduto.Add(produto);
        }

        public void deleteProduto(int id)
        {
            var deleteProduto = getById(id);


            if (deleteProduto != null)
                ListaProduto._listaProduto.Remove(deleteProduto);
        }
    }
}