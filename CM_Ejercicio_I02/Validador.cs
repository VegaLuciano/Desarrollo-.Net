﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool retorno = false; 

            if (respuesta == "S") 
            {
                retorno = true;
            }

            return retorno;
        }   
    }
}
