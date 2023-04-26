using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Ejercicio_I06
{
    /*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
    public double CalcularAreaCuadrado(double longitudLado) {}
    public double CalcularAreaTriangulo(double base, double altura) {}
    public double CalcularAreaCirculo(double radio) {}*/
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double area = longitudLado * longitudLado;

            return area;
        }

        public static double CalcularAreaTriangulo(double base_, double altura) 
        {
            double area = (base_ * altura) / 2;

            return area;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double area = 3.1416 * (radio * radio);

            return area;
        }
    }
}
