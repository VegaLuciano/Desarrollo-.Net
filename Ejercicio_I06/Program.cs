namespace Ejercicio_I06
{
    internal class Program
    {
        /* Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
        salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
        static void Main(string[] args)
        {
            int añoMin;
            int añoMax;

            string año;
            bool comprobacion;
            
            Console.WriteLine("-------- AÑOS BISIESTOS --------");
            Console.WriteLine("Ingrese el año de inicio");
            año = Console.ReadLine();
            comprobacion = int.TryParse(año, out añoMin);
            
            while (!comprobacion || añoMin <= 0) 
            {
                Console.WriteLine("Error, Ingrese el año de inicio valido");
                año = Console.ReadLine();
                comprobacion = int.TryParse(año, out añoMin);
            }

            Console.WriteLine("Ingrese el año final");
            año = Console.ReadLine();
            comprobacion = int.TryParse(año, out añoMax);

            while (!comprobacion || añoMax <= 0)
            {
                Console.WriteLine("Error, Ingrese el año de final valido");
                año = Console.ReadLine();
                comprobacion = int.TryParse(año, out añoMax);
            }

            for (int i = añoMin; i <= añoMax; i++) 
            {
                bool esBiciesto = false;

                if (i % 4 == 0)
                {
                    esBiciesto = true;
                }
                else
                {
                    if (i % 10 == 0 && i % 400 == 0)
                    {
                        esBiciesto = true;
                    }
                }

                if (esBiciesto) 
                {
                    Console.WriteLine($"{i} es año biciesto");
                }
            }

        }
    }
}