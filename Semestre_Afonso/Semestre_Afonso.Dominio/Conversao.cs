using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Afonso.Dominio
{
   public class Conversao
    {
        #region de Decimal para todas as outras bases
        //Metodo que faz a conversão de decimal, para octal,binario e hexadecimal
        public List<int> conversao(int numero , int baseNumerica)
        {

            int resto = 0;

            List<int> binario = new List<int>();

            while (numero >= baseNumerica)
            {
                resto = numero % baseNumerica;

                numero = numero / baseNumerica;

                binario.Add(resto);
            };

            if(numero < baseNumerica && numero >= 0)
            {
                binario.Add(numero);
            }

            binario.Reverse();

            return binario.ToList();
        }
        //Metodo que faz a conversão de letra em numero
        public string conversaoASCII(string texto, int baseNumerica)
        {
            byte[] codigosAscii = System.Text.Encoding.ASCII.GetBytes(texto);

            int numeroLetra = 0;

            for (int i = 0; i < codigosAscii.Length; ++i)
                numeroLetra += Convert.ToInt32(codigosAscii[i]);

            return numeroLetra.ToString();
        }
        //Retorna o resultado das conversões de decimal para binario e de decimal para octal
        public string resultadoConversao(List<int> conversao)
        {
            string resultado = "";
            foreach (var item in conversao)
            {
                resultado = resultado + item;
            }

            return resultado;
        }
        //Retorna o resultado da conversão de decimal para Hexadecimal
        public string resultadoConversaoHexa(List<int> conversao)
        {
            string resultado = "";
            foreach (var item in conversao)
            {
                switch (item)
                {
                    case 10:
                        {
                            resultado = resultado + "A";
                            break;
                        }
                    case 11:
                        {
                            resultado = resultado + "B";
                            break;
                        }
                    case 12:
                        {
                            resultado = resultado + "C";
                            break;
                        }
                    case 13:
                        {
                            resultado = resultado + "D";
                            break;
                        }
                    case 14:
                        {
                            resultado = resultado + "E";
                            break;
                        }
                    case 15:
                        {
                            resultado = resultado + "F";
                            break;
                        }
                    default:
                        resultado = resultado + item;
                        break;
                }
            }

            return resultado;
        }
        #endregion

        #region de Todas as bases para decimal
        public string binarioDecimal(List<int>binario)
        {
            List<int> calculoElevados = new List<int>();
            List<int> multiReal = new List<int>();

            double aux = 0;
            int auxInt = 0;
            int resultado = 0;

            foreach (var item in binario)
            {
                aux = Convert.ToDouble(item);
                auxInt = Convert.ToInt32(Math.Pow(aux, 2));
                calculoElevados.Add(auxInt);
            }
            for (int i=0;i<calculoElevados.Count;i++)
            {
                multiReal.Add(calculoElevados[i] * binario[i]);
            }
            foreach (var item in multiReal)
            {
                resultado += item;
            }

            return resultado.ToString();
        }
        #endregion
    }
}
