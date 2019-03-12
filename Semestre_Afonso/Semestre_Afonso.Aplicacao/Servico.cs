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
        #region Variaveis Globais
        Validacao cl = new Validacao();
        Conversao cv = new Conversao();
        #endregion

        #region Validaçoes Gerais 
        public bool validacao(string texto)
        {
            return cl.Validacaos(texto);
        }
        #endregion

        #region Decimal para todas as bases
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
        #endregion

        #region Converte Letra para numero via tabela ASCII
        public string realizaConversaoLetra(string texto,string numero)
        {

            int NumeroConvertido = Convert.ToInt32(numero);

            string resultadoConversao = "";

            resultadoConversao = cv.conversaoASCII(texto, NumeroConvertido);

            return resultadoConversao;

            return null;
        }
        #endregion

        #region Converte o combo box para a base selecionada
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
        #endregion

        #region Converte de alguma base para Decimal

        public string baseDecimal(string texto,string baseNumerica)
        {
            List<int> binario = new List<int>();
            List<char> textoConvert = new List<char>();
            texto.Reverse();
            textoConvert = texto.ToList();

            string resultado = string.Empty;

            for (int i = 0; i < texto.Count(); i++)
            {
                binario.Add(Convert.ToInt32(texto[i]));
            }
           
            binario.Reverse();

            resultado = cv.binarioDecimal(binario);

            return resultado;
        }

        #endregion
    }
}
