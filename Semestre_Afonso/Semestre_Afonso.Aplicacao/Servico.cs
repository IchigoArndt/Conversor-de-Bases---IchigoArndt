using Semestre_Afonso.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Afonso.Aplicacao
{
    public class Servico
    {
        Validacao cl = new Validacao();
        Conversao cv = new Conversao();
        public bool validacao(string texto)
        {
            return cl.Validacaos(texto);
        }

        public string realizaConversao(string texto,string Numero)
        {
            int NumeroBase = BaseNumerica(texto);

            int NumeroConvertido = Convert.ToInt32(Numero);

            string resultadoConversao = "";

            if(NumeroBase != 16)
                resultadoConversao = cv.resultadoConversao(cv.conversao(NumeroConvertido, NumeroBase));
            else
                resultadoConversao = cv.resultadoConversaoHexa(cv.conversao(NumeroConvertido, NumeroBase));

            return resultadoConversao;
        }

        private int BaseNumerica(string texto)
        {        
            int Numerico = 0;

            if (texto.Equals("Decimal para Binário"))
            {
                Numerico = 2;
            }
            else if (texto.Equals("Decimal para Octal"))
            {
                Numerico = 8;
            }
            else if (texto.Equals("Decimal para Hexadecimal"))
            {
                Numerico = 16;
            }
            return Numerico;
        }

    }
}
