﻿using Semestre_Afonso.Dominio;
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
        //Faz a validação dos campos
        public bool validacao(string texto)
        {
            return cl.Validacaos(texto);
        }
        //Verifica Base e realiza a conversão adequada
        public string organizaConversao(int baseDesejada,List<int>NumerosDesejados,string numeroDesejado)
        {
            string resultado = string.Empty;
          if(numeroDesejado != null && NumerosDesejados == null)
            {
                if (baseDesejada == 2 || baseDesejada == 8 || baseDesejada == 16)
                    resultado = realizaConversaoDecimal(baseDesejada, numeroDesejado);
            }else if(numeroDesejado == null && NumerosDesejados != null)
            {
                switch (baseDesejada)
                {
                   case 4:
                   {
                     resultado = realizaConversaoBinarioDecimal(NumerosDesejados);
                     break;
                   }
                }
            }

            return resultado;
        }
        //Faz a conversão de Decimal para qualquer base
        private string realizaConversaoDecimal(int numeroBaseConversao,string numeroConverter)
        {
            int NumeroConvertido = Convert.ToInt32(numeroConverter);

            string resultadoConversao = "";

            if(numeroBaseConversao != 16)
                resultadoConversao = cv.resultadoConversao(cv.conversao(NumeroConvertido, numeroBaseConversao));
            else
                resultadoConversao = cv.resultadoConversaoHexa(cv.conversao(NumeroConvertido, numeroBaseConversao));

            return resultadoConversao;
        }
        //Faz a conversão de Binario para Decimal
        private string realizaConversaoBinarioDecimal(List<int>Binario)
        {
            return cv.resultadoConversaoBinarioDecimal(Binario);
        }
        //Retorna a base a qual vai ser usada para a conversão
        public int BaseNumerica(string texto)
        {        
            int baseParaConversao = 0;

            /* Retorna:
             * 2 = para Conversão de Decimal em Binario
             * 4 = para Conversão de Binario em Decimal
             * 8 =  para Conversão de Decimal em Octal
             * 18 = para Conversão de Octal em Decimal
             * 16 = para Conversão de Decimal em Hexadecimal
             * 32 = para Conversão de Hexadecimal em Decimal
             */
            switch (texto)
            {
                #region Binario
                case "Decimal para Binário":
                    {
                        baseParaConversao = 2;
                        break;
                    }
                case "Binario para Decimal":
                    {
                        baseParaConversao = 4;
                        break;
                    }
                #endregion
                #region Octal
                case "Decimal para Octal":
                    {
                        baseParaConversao = 8;
                        break;
                    }
                #endregion
                #region Hexadecimal
                case "Decimal para Hexadecimal":
                    {
                        baseParaConversao = 16;
                        break;
                    }
                #endregion
                #region Conversão ASCII
                case "Texto para Binario":
                    {
                        baseParaConversao = 0;
                        break;
                    }
                    #endregion
            }
            return baseParaConversao;
        }
        //Retorna a Lista de numeros para conversão de binaraio para Decimal
        public List<int> ConversaoLista(string numeroBinario)
        {
            List<string> binario = new List<string>();
            List<int> binarioNumerico = new List<int>();
            foreach (var item in numeroBinario.ToList())
            {
                binario.Add(item.ToString());
            }
            for (int i = 0; i < binario.Count; i++)
            {
                binarioNumerico.Add(Convert.ToInt32(binario[i]));
            }
            return binarioNumerico;
        }

    }
}
