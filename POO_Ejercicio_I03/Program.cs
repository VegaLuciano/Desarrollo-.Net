namespace POO_Ejercicio_I03
{
    using Estudiante;
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Estudiante primerEstudiante = new Estudiante("Ramirez", "2222", "Juan");
            Estudiante segundoEstdiante = new Estudiante("Romero", "3348", "Matias");
            Estudiante tercerEstudiante = new Estudiante("Marquez", "1150", "Jose");

            primerEstudiante.NotaPrimeraParcial = 8;
            primerEstudiante.NotaSegundoParcial = 8;

            segundoEstdiante.NotaPrimeraParcial = 9;
            segundoEstdiante.NotaSegundoParcial = 7;

            tercerEstudiante.NotaPrimeraParcial = 2;
            tercerEstudiante.NotaSegundoParcial = 4;
                    
            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(segundoEstdiante.Mostrar());
            Console.WriteLine(tercerEstudiante.Mostrar());


        }
    }
}