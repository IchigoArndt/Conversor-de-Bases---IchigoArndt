using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Semestre_Afonso.Dominio
{
    public class Validacao
    {

        public bool Validacaos(List<char>texto)
        {
            bool result = false;

            if(!string.IsNullOrEmpty(ApenasNumeros(texto)))
            {
                result = true;
            }

            return result;
        }
//Valida se o texto informado pelo usario é somente Números
        private string ApenasNumeros(List<char> texto)
        {
            string resultString = string.Empty;
            Regex regexObj = new Regex(@"[^\d]");
            for (int i = 0; i < texto.Count; i++)
            {
                resultString = regexObj.Replace(texto[i].ToString(), "");
                if(resultString.Equals(""))
                {
                    resultString = null;
                    break;
                }
            }
            return resultString;
        }
    }
}
