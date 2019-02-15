using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_De_Base.Apresentacao
{
   public class Conversao
    {
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

            if(resto < baseNumerica &&  resto != 0)
            {
                binario.Add(1);
            }

            binario.Reverse();

            return binario.ToList();
        }
    }
}
