using System.Collections.Generic;

namespace Sistema
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    public class PalindromoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// 

        public bool isPalindromo(string texto)
        {           
            return texto == texto.revert();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listatexto"></param>
        /// <returns></returns>
        /// 
        public List<string> showPalindromo(List<string> listatexto)
        {
           var listaRetorno = new List<string>();
            foreach (var item in listatexto)
            {
                if (isPalindromo(item.revert()))
                    listaRetorno.Add(item);
            }
            return listaRetorno;
        }
    }
}