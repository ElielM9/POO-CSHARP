using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjetosClases
{
    class Calculadora
    {
        // Atributos
        public int num1;
        public int num2;
        public int resultado;

        // Metodos
        public void Suma()
        {
            resultado = num1 + num2;
        }
        public void ImprimirResultado()
        {
            Console.WriteLine($"Resultado {num1} + {num2} = {resultado}");
        }
    }
}