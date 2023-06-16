using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor
{
    class Automovil
    {
        public string? modelo, color;
        public int numPuertas;
        public float velocidad;


        // Crear el constructor para la clase
        public Automovil(string modeloPa, string colorPa, int numPuertasPa)
        {
            Console.WriteLine("Se invoca al constructor");

            modelo = modeloPa;
            color = colorPa;
            numPuertas = numPuertasPa;

        }

        // Sobrecarga del constructor 
        public Automovil(string modeloPa, string colorPa)
        {

            modelo = modeloPa;
            color = colorPa;

        }

        public Automovil(string modeloPa, int numPuertasPa, float velocidadPa, string colorPa)
        {
            modelo = modeloPa;
            color = colorPa;
            numPuertas = numPuertasPa;
            velocidad = velocidadPa;

        }


        // Finalizador / Destructor
        ~Automovil(){
            Console.WriteLine("El finalizador fue ejecutado");

            modelo = ""; 
            color = "";
            numPuertas = 0;
            velocidad = 0.0f; 

        }

    }
}