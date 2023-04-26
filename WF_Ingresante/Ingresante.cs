using System.Text;

namespace WF_Ingresante
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad) 
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.edad = edad;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine("Cursos: ");
            foreach (var curso in cursos) 
            {
                if (curso!= "") 
                {
                    sb.AppendLine(curso);
                }
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}