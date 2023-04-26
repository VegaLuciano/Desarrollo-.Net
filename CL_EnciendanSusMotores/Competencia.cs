using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EnciendanSusMotores
{
    /*El constructor privado será el único capaz de inicializar la lista de competidores.
    La sobrecarga del operador + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores)
    y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
    Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero,
    la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia
    y se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible.*/

    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;

        private Competencia()
        {
            _competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder competidores = new StringBuilder();

            foreach (AutoF1 competidor in _competidores)
            {
                competidores.AppendLine(competidor.MostrarDatos());
            }

            sb.AppendLine($"La cantidad de competidores es: {_cantidadCompetidores}");
            sb.AppendLine($"La cantidad de vueltas es: {_cantidadVueltas}");
            sb.AppendLine($"La lista de competidores es:\n");
            sb.AppendLine(competidores.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a) 
        {
            bool retorno = false;
            foreach (AutoF1 competidor in c._competidores)
            {
                if (competidor == a)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a) 
        {
            bool retorno = false;
            Random random = new Random();

            if (c._cantidadCompetidores > c._competidores.Count && c != a) 
            {
                c._competidores.Add(a);
                a.VueltasRestantes = c._cantidadVueltas;
                a.EnCompetencia = true;
                a.CantidadCombustible = (short)random.Next(15, 100 + 1);
                retorno = true;
            } 

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if ( c == a)
            {
                c._competidores.Remove(a);
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
            }

            return retorno;
        }
    }
}
