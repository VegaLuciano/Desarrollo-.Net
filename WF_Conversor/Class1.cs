using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranformarBinarios
{
    public static class Conversor
    {
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroString = numeroEntero.ToString();
            char[] numeroArray = numeroString.ToCharArray();
            int acumulador = 0;

            Array.Reverse(numeroArray);

            for (int i = 0; i < numeroArray.Length; i++)
            {
                if (numeroArray[i] == '1')
                {
                    acumulador = acumulador + (int)Math.Pow(2, i);
                }
            }

            return acumulador;
        }


        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";

            if (numeroEntero == 0)
            {
                numeroBinario = "0";
            }
            else
            {
                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    numeroEntero = numeroEntero / 2;
                }
            }
            return numeroBinario;
        }
    }
}

