using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sistema.Repository;
using Sistema.Model.Domain;

namespace Sistema.Controller
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    [RoutePrefix("Api/Sistema")]
    public class ClienteController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchClient")]
        public List<Cliente> getClienteAscending()
        {
            var clienteRepository = new ClientesRepository();

            return clienteRepository.getClienteAscending();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchClient/Gender/{sexo}")]
        public List<Cliente> getClienteBySexo(char sexo)
        {
            var clienteRepository = new ClientesRepository();

            return clienteRepository.getClienteBySexo(sexo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchClient/IsActive")]
        public List<Cliente> getClienteAtivo()
        {
            var clienteRepository = new ClientesRepository();

            return clienteRepository.getClienteAtivo();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datanasc"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchClient/Anniversary/{datanasc}")]
        public List<Cliente> getClienteAniversariante(string datanasc)
        {
            var clienteRepository = new ClientesRepository();

            return clienteRepository.getClienteAniversariante(datanasc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("SearchClient/ById/{id}")]
        public Cliente GetById(int id)
        {
            var clienteRepository = new ClientesRepository();

            return clienteRepository.getById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        [Route("NewClient")]
        public HttpResponseMessage insertCliente([FromBody]Cliente cliente)
        {
            var clienteRepository = new ClientesRepository();

            if (cliente.idCliente <= 0)
            {
                clienteRepository.insertCliente(cliente);
                return Request.CreateResponse(HttpStatusCode.OK, cliente);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("UpdateClient/{id}")]
        public HttpResponseMessage updateCliente(int id, [FromBody]Cliente cliente)
        {
            var clienteRepository = new ClientesRepository();

            if (id > 0)
            {
                clienteRepository.updateCliente(id, cliente);
                return Request.CreateResponse(HttpStatusCode.OK, clienteRepository.getById(id));
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        /// 

        [HttpPut]
        [Route("ChangeStatusClient/{id}")]
        public HttpResponseMessage trocaStatusCliente(int id, [FromBody]bool ativo)
        {
            var clienteRepository = new ClientesRepository();

            if (id > 0)
            {
                clienteRepository.trocaStatusCliente(id, ativo);
                return Request.CreateResponse(HttpStatusCode.OK, clienteRepository.getById(id));
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
        [Route("DeleteClient/{id}")]
        public HttpResponseMessage deleteCliente(int id)
        {
            var clienteRepository = new ClientesRepository();

            if (id > 0)
            {
                clienteRepository.deleteCliente(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Registro Excluído com Sucesso");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um Erro Inesperado!!");
        }
    }
}