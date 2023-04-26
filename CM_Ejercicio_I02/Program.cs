namespace CM_Ejercicio_I02
{
    using Validador;
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            string respuesta;
            bool validarRespuesta;

            do
            {
                Console.WriteLine("Ingresar cualquier numero: ");
                numero = Console.ReadLine();    

                Console.WriteLine("Desea continuar?(S/N)");
                respuesta = Console.ReadLine();
                validarRespuesta = Validador.ValidarRespuesta(respuesta);

            } while (validarRespuesta);

            Console.WriteLine("Se salio del programa");
        }
    }
}