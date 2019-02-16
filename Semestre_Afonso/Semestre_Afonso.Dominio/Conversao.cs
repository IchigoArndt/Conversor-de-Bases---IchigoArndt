﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestre_Afonso.Dominio
{
   public class Conversao
    {
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
    }
}