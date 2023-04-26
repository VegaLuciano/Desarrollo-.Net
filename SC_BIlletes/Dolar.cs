namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        static private double contzRespectoDolar;

        private Dolar() 
        {
            cantidad = 0;
            contzRespectoDolar = 1; 
        }

        Dolar(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public double Cantidad { get { return this.cantidad; } }

        public double GetCantidad() 
        {
            return Cantidad;
        }
        static double GetCotizacion() 
        {
            return contzRespectoDolar;            
        }




    }
}