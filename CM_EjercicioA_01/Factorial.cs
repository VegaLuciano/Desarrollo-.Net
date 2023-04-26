using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_EjercicioA_01
{
    internal class Factorial
    {
        public static int CalcularFactorial(int numero)
        {
            int retorno;

            if (numero == 1)
            {
                retorno = numero;
            }
            else 
            {
                retorno = numero * CalcularFactorial(numero - 1);
            }

            return retorno;
        }

    }
}
