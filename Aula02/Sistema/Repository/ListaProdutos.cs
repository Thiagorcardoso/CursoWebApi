using System.Collections.Generic;
using Sistema.Model.Domain;

namespace Sistema.Repository
{
    public class ListaProduto
    {
        static ListaProduto()
        {
            _popularListaProduto();
        }

        public static List<Produto> _listaProduto = new List<Produto>();

        private static List<Produto> _popularListaProduto()
        {
            _listaProduto.Add(new Produto { idProduto = 1, descricao = "Água 500ml", valorProduto = 1.50M, estoqueTotal = 20, estoqueMinimo = 5 });
            _listaProduto.Add(new Produto { idProduto = 2, descricao = "Coxinha", valorProduto = 3.50M, estoqueTotal = 5, estoqueMinimo = 20 });
            _listaProduto.Add(new Produto { idProduto = 3, descricao = "Cerveja 1l", valorProduto = 5.00M, estoqueTotal = 299, estoqueMinimo = 20 });
            _listaProduto.Add(new Produto { idProduto = 4, descricao = "Barra de Chocolate", valorProduto = 4.55M, estoqueTotal = 545, estoqueMinimo = 100 });
            _listaProduto.Add(new Produto { idProduto = 5, descricao = "Bala", valorProduto = 0.50M, estoqueTotal = 200, estoqueMinimo = 5 });
            _listaProduto.Add(new Produto { idProduto = 6, descricao = "Doce", valorProduto = 1.10M, estoqueTotal = 213, estoqueMinimo = 20 });
            _listaProduto.Add(new Produto { idProduto = 7, descricao = "Bolachas", valorProduto = 10.00M, estoqueTotal = 45, estoqueMinimo = 10 });
            _listaProduto.Add(new Produto { idProduto = 8, descricao = "Suco 300ml", valorProduto = 2.50M, estoqueTotal = 48, estoqueMinimo = 1 });
            _listaProduto.Add(new Produto { idProduto = 9, descricao = "Coca-Cola 2l", valorProduto = 5.15M, estoqueTotal = 49, estoqueMinimo = 3 });
            _listaProduto.Add(new Produto { idProduto = 10, descricao = "Caixa de Chocolate", valorProduto = 7.25M, estoqueTotal = 35, estoqueMinimo = 5 });

            return _listaProduto;
        }
    }
}