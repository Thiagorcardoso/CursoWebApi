using System.Collections.Generic;
using System.Web.Http;

namespace Sistema
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    [RoutePrefix("Api/Palindromo")]
    public class PalindromoController : ApiController
    {
        /// <summary>
        /// Retorna se é palindromo
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// 

        [HttpGet]
        [Route("IsPalindromo/{texto}")]
        public bool getIsPalindromo(string texto)
        {
            var palavra = new PalindromoService();            
            return palavra.isPalindromo(texto);
        }

        /// <summary>
        /// Retorna a lista de palavras que são palindromos
        /// </summary>
        /// <param name="listatexto"></param>
        /// <returs></returs>
        /// 

        [HttpPost]
        [Route("ShowPalindromo")]
        public List<string> getShowPalindromo([FromBody]List<string> listatexto)
        {
            var palavra = new PalindromoService();
            return palavra.showPalindromo(listatexto);
        }
    }
}