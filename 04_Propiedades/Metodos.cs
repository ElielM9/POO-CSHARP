using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propiedades
{
     class Metodos
    {
        private double num1, num2, resultado;

        // Metodos
        public void Suma()
        {
            Console.WriteLine($"Ingresa el primer valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ingresa el segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine($"El resultado es: {resultado}");
        }

        public void Resta(double num1, double num2)
        {
            resultado = num1 - num2;
            Console.WriteLine($"El resultado es: {resultado}");
        }

        public double Multiplicacion()
        {
            Console.WriteLine($"Ingresa el primer valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ingresa el segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 * num2;

            // Termina la ejecucion del codigo
            return resultado;
        }

    }
}