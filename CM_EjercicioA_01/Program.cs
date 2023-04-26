namespace CM_EjercicioA_01
{
    internal class Program
    {
        /*El factorial de un número es una operación que consiste en multiplicar un numero “n” 
         por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
         En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.*/
        static void Main(string[] args)
        {
            Console.WriteLine($"El factorial de 10 es {Factorial.CalcularFactorial(10)}");
        }
    }
}