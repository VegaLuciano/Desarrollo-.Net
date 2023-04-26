using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public static float? Calcular(float operando, float operando2, string operacion)
        {
            float? result = null;

            switch (operacion)
            {
                case "+":
                    result = operando + operando2;
                    break;
                case "-":
                    result = operando - operando2;
                    break;
                case "/":
                    if (Validar(operando2))
                    {
                        result = operando / operando2;
                    }
                    break;
                case "*":
                    result = operando * operando2;
                    break;
            }

            return result;
        }
        public static bool Validar(float operando2)
        {
            bool validacion = true;

            if (operando2 == 0.0f)
            {
                validacion = false;
            }
            return validacion;
        }
    }
}
