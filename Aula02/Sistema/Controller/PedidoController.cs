using Sistema.Model.Domain;
using Sistema.Repository;
using Sistema.Service;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sistema.Controller
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    [RoutePrefix ("Api/Sistema")]
    public class PedidoController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route ("SearchOrder/ById/{id}")]
        public Pedido getById(int id)
        {
            var pedidoRepository = new PedidoRepository();

            return pedidoRepository.getById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        [Route ("NewOrder")]
        public HttpResponseMessage insertPedido([FromBody]Pedido pedido)
        {
            var pedidoService = new PedidoService();
            pedidoService.isProductInStock(pedido);

            if (getById(pedido.idPedido) != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, pedido);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UpdateOrder/{id}")]
        public HttpResponseMessage updatePedido(int id,[FromBody]Pedido pedido)
        {
            var pedidoRepository = new PedidoRepository();

            if (id > 0 || pedido.idCliente > 0)
            {
                    pedidoRepository.updatePedido(id, pedido);
                    return Request.CreateResponse(HttpStatusCode.OK, pedido);                
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public HttpResponseMessage deletePedido(int id)
        {
            var pedidoRepository = new PedidoRepository();

            if (id > 0)
            {
                pedidoRepository.deletePedido(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Pedido Excluido com Sucesso!!");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");
        }
    }
}