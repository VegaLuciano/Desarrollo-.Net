namespace CM_Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(5);
            Console.WriteLine($"El area del cuadrado es {areaCuadrado} centimetros cuadrados, con lado de 5cm.");

            double areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(6, 8);
            Console.WriteLine($"El area del triangulo es {areaTriangulo} centimetros cuadrados, con base 6cm y altura 8cm");

            double areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(5);
            Console.WriteLine($"El area del circulo es {areaCirculo} centimetros cuadrados, con radio de 5cm.");
        }   
    }
}