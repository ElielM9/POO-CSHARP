using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbitoInterfaz
{
    class Interfaz
    {
        // Atributos
        private double numero1, numero2;
        private double resultado;
        // Metodos
        public void Multiplicacion()
        {
            PedirValores();
            resultado = numero1 * numero2;
            // Mandar a llamar el metodo info 
            Info();
        }
        private void Info()
        {
            Console.WriteLine($"{numero1} * {numero2} = {resultado}");
        }
        private void PedirValores()
        {
            Console.WriteLine("Ingresa un primer valor: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa un segundo valor: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}