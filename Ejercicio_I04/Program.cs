namespace Ejercicio_I04
{
    internal class Program
    {

        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
        (excluido el mismo) que son divisores del número.
        El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
        Escribir una aplicación que encuentre los 4 primeros números perfectos.
        */
        static void Main(string[] args)
        {
            int numero = 2;
            int numerosPerfectos = 0;
            int divisores;

            while (numerosPerfectos <= 3)
            {
                divisores = 0;

                for (int i = 1; i <= (numero / 2); i++)
                {
                    if (numero % i == 0)
                    {
                        divisores += i;
                    }
                }
                if (divisores == numero)
                {
                    Console.WriteLine($"Es un numero perfecto: {numero}");
                    numerosPerfectos++;
                }
                
                numero++;
            }
        }
    }
}
