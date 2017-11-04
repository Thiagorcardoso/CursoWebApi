
namespace Sistema
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    public static class CustomExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        /// 

        public static string revert(this string texto)
        {            
            var conjunto = texto.ToCharArray();
            
            var revertString = string.Empty;
            
            for (int i = conjunto.Length - 1; i >= 0; i--)
                revertString += conjunto[i].ToString();
            
            return revertString;
        }
    }
}