using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Ejercicio_I07
{
    internal class Hipotenusa
    {
        public static double CalcularHipotenusa(double _base, double altura) 
        {
            double hipotenusa;

            hipotenusa = Math.Pow(_base, 2) + Math.Pow(altura, 2);
            hipotenusa = Math.Sqrt(hipotenusa);

            return hipotenusa;
        }
    }
}
