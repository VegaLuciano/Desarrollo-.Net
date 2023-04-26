using CL_EnciendanSusMotores;

namespace CL_Ejercicio_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 competidor1 = new AutoF1(72, "Alpine");
            AutoF1 competidor2 = new AutoF1(45, "McLaren");
            AutoF1 competidor3 = new AutoF1(30, "Aston Martin");
            AutoF1 competidor4 = new AutoF1(29, "AlphaTauri");
            AutoF1 competidor5 = new AutoF1(2, "Red Bull.");

            AutoF1 competidor6 = new AutoF1(1, "Haas");
            AutoF1 competidor7 = new AutoF1(99, "Ferrari");
            AutoF1 competidor8 = new AutoF1(15, "Alfaromeo");

            Competencia copaPiston = new Competencia(7, 50);

            bool comprobar = copaPiston + competidor1;
            comprobar = copaPiston + competidor2;
            comprobar = copaPiston + competidor3;
            comprobar = copaPiston + competidor4;
            comprobar = copaPiston + competidor5;

            Console.WriteLine("=========================================================");
            Console.WriteLine($"Competencia Copa Piston");
            Console.WriteLine(copaPiston.MostrarDatos());
            Console.WriteLine("=========================================================");


            Competencia lasMilVueltas = new Competencia(3, 100);

            comprobar = copaPiston - competidor2;
            comprobar = lasMilVueltas + competidor2;
            comprobar = lasMilVueltas + competidor6;
            comprobar = lasMilVueltas + competidor8;
            comprobar = lasMilVueltas + competidor7;

            Console.WriteLine("=========================================================");
            Console.WriteLine($"Competencia Las mil Vueltas");
            Console.WriteLine(lasMilVueltas.MostrarDatos());
            Console.WriteLine("=========================================================");

            Console.WriteLine($"El competidor no pudo entrar:");
            Console.WriteLine(competidor7.MostrarDatos());
            

            

            
            
        }
    }
}