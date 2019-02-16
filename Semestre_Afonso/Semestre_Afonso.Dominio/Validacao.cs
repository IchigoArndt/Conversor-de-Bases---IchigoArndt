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

            if(!string.IsNullOrEmpty(ApenasNumeros(texto)) && TamanhoNumerico(texto))
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
//Valida se o texto informado pelo usario tem o tamanho estaelecido (min e max)
        private bool TamanhoNumerico(string texto)
        {
            if (texto.Length <= 6 && texto.Length >= 3)
                return true;
            else
                return false;
        }

    }
}
