using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbitoInterfaz
{
    class Ambito
    {
        // Este atributo es conocido solo por los elementos de la clase
        private double z = 3;

        // Atributo con ambito de clase
        double x = 100;

        public void Informacion()
        {
            // Intentar imprimir variable local de Main 
            // Console.WriteLine($"Numero 1: {numero1}");
            // numero1 = 40;

            // Variable local de el metodo
            double x = 30;
            Console.WriteLine($"Variable local informacion: {x}");


            // Atributo a nivel de clase
            Console.WriteLine($"Campo a nivel de clase: {z}");

            // This: Hace referencia a la instancia de la clase, lo que hace que podamos mostrar un miembro oculto para el metodo por llevar un nombre similar a uno que tengamos con ambito a nivel de clase. 
            // this.variable
            Console.WriteLine($"Variable a nivel clasex x: {this.x}");
        }

        public void Suma()
        {
            // Variables locales a nivel de metodo
            double y = 20;
            double resultado;
            double x = 10;
            resultado = x + y + z;
            Console.WriteLine($"La suma de {x} + {y} + {z} = {resultado}");
        }
    }
}