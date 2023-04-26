namespace Ejercicio_I08
{
    internal class Program
    {

        /*Escribir un programa que imprima por consola un triángulo como el siguiente:
         *
         ***
         *****
         *******
         *********
        El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
        Para el ejemplo anterior, la altura ingresada fue de 5.*/

        static void Main(string[] args)
        {
            int altura;
            string alturaRecibida;
            bool comprobar;
            string dibujo = "*";

            Console.WriteLine("Ingrese la altura del triangulo: ");
            alturaRecibida = Console.ReadLine();
            comprobar = int.TryParse(alturaRecibida, out altura);

            while (!comprobar || altura < 1) 
            {
                Console.WriteLine("Error, Ingrese la altura del triangulo: ");
                alturaRecibida = Console.ReadLine();
                comprobar = int.TryParse(alturaRecibida, out altura);
            }           

            for(int i = 0; i < altura; i++) 
            {
                Console.WriteLine(dibujo);
                dibujo = dibujo + "*" + "*";
            }
            
        }
    }
}