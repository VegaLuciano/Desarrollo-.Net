    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Cuenta
    {
        /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
        Deberá tener los atributos:
        titular que contendrá la razón social del titular de la cuenta.
        cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.*/
        internal class Cuenta
        {
            private string? titular;
            private double monto;

            public Cuenta(string? titular, int monto)
            {
                this.titular = titular;
                this.monto = monto;
            }
        
            public string? Titular { get { return this.titular; } }

            public double Monto { get { return this.monto; } }

            public string Mostrar() 
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"El titular de la cuenta es {this.titular}");
                sb.AppendLine($"El monto de la cuenta es {this.monto}");

                return sb.ToString();
            }

            public void Ingresar(double montoAIngresar) 
            {
                if (montoAIngresar > 0)
                {
                    this.monto += montoAIngresar;
                }
            }

            public void Retirar(double MontoARetirar) 
            {
                this.monto -= MontoARetirar;
            }
        }
    }
