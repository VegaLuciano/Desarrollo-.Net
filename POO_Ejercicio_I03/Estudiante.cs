using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public int NotaPrimeraParcial { set { this.notaPrimerParcial = value; } }
        public int NotaSegundoParcial { set { this.notaSegundoParcial = value; } }

        private float CalcularPromedio()
        {
            int promedio = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10 + 1);
            }
            else
            {
                notaFinal = 1;
            }

            return notaFinal;
        }
        public string Mostrar()
        {
            double notaFinal = CalcularNotaFinal();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo:{this.nombre} {this.apellido}, legajo : {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} - nota segundo parcial {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if (notaFinal == 1)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else 
            {
                sb.AppendLine($"La nota final es {notaFinal}");
            }

            return sb.ToString();
        }
    }

}
