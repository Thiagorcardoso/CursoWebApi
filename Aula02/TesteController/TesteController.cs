using System.Web.Http;

namespace Sistema
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    [RoutePrefix("Api")]
    public class TesteController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 

        [Route("")]
        public string Get()
        {
            return "Isso ai meu jovem, tá funcionando!";
        }
    }
}