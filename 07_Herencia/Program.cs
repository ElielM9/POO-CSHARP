using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // La clase object
            Program Objeto1 = new Program();
            // Objeto1.Equals();


            // Herencia unica
            Mutante Mutante1 = new Mutante(true, "Wolverine", "Beta", "James", "Canada");
            Console.WriteLine($"Mutante 1 {Mutante1.genX}");


            // Herencia multinivel
            // Clase derivada C
            Husky Husky1 = new Husky();

            Husky1.oxigeno = true;
            Console.WriteLine($"Husky 1: {Husky1.oxigeno}");

            // Valor a la clase derivada B
            Husky1.nombre = "Lobo";
            Console.WriteLine($"Husky 1: {Husky1.nombre}");



            // Herencia jerarquica
            Salchicha Teckel1 = new Salchicha();

            Teckel1.acondroplacia = true;
            Teckel1.nombre = "Rojo";




        }
    }
}