using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia
{
    class Humano
    {
        public string? nombre, genero, nacionalidad, ocupacion;
        public double estatura;
        public int edad;


        public Humano(string nombrePa, string nacionalidadPa)
        {
            nombre = nombrePa;
            nacionalidad = nacionalidadPa;
        }


    }
}