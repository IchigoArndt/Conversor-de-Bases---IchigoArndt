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

        public bool Validacaos(string texto)
        {
            bool result = false;

            if(!string.IsNullOrEmpty(ApenasNumeros(texto)))
            {
                result = true;
            }

            return result;
        }
//Valida se o texto informado pelo usario é somente Números
        private string ApenasNumeros(string texto)
        {
            string resultString = string.Empty;
            Regex regexObj = new Regex(@"[^\d]");
            resultString = regexObj.Replace(texto, "");
            return resultString;
        }
    }
}
