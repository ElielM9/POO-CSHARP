using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia
{
    // Clase derivada : clase base
    class Mutante : Humano
    {
        public bool genX;
        public string? alias, clasificacion;

        public Mutante(bool genXPa, string aliasPa, string clasificacionPa, string nombrePa, string nacionalidadPa) : base(nombrePa, nacionalidadPa)
        {
            genX = genXPa;
            alias = aliasPa;
            clasificacion = clasificacionPa;

        }


    }


}
