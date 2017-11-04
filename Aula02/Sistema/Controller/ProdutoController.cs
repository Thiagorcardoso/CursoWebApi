using Sistema.Model.Domain;
using Sistema.Repository;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistema.Controller
    {/// <summary>
     /// 
     /// </summary>
     /// 

    [RoutePrefix("Api/Sistema")]
    public class ProdutoController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchProduto/LowStock")]
        public List<Produto> getProdutoLow()
        {
            var produtoRepository = new ProdutoRepository();
            return produtoRepository.getProdutoLow();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchProduto/ById/{Id}")]
        public Produto getById(int id)
        {
            var produtoRepository = new ProdutoRepository();
            return produtoRepository.getById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        [Route("NewProduct")]
        public HttpResponseMessage insertProduto([FromBody]Produto produto)
        {
            var produtoRepository = new ProdutoRepository();

            if (produto.idProduto > 0)
            {
                produtoRepository.insertProduto(produto);
                return Request.CreateResponse(HttpStatusCode.OK, produto);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado!!");


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="produto"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UpdateProduto/{id}")]
        public HttpResponseMessage updateProduto(int id, [FromBody]Produto produto)
        {
            var produtoRepository = new ProdutoRepository();

            if (id > 0)
            {
                produtoRepository.updateProduto(id, produto);
                return Request.CreateResponse(HttpStatusCode.OK, produto);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado!!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpDelete]
        [Route("DeleteProduto/{id}")]
        public HttpResponseMessage deleteProduto(int id)
        {
            var produtoRepository = new ProdutoRepository();

            if (id > 0)
            {
                produtoRepository.deleteProduto(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Registro Excluído com Sucesso");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado!!");
        }
    }
}