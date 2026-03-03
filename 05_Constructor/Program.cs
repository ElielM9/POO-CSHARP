using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Sobrecarga de metodos 
            // int resultadoInt;
            // double resultadoDou;

            // Matematicas Calculadora = new Matematicas();

            // resultadoInt = Calculadora.Suma(4, 5);
            // resultadoDou = Calculadora.Suma(4.5, 5.3);

            // Console.WriteLine($"El resultado es: {resultadoInt}");
            // Console.WriteLine($"El resultado es: {resultadoDou}");


            // Constructor


            // Crear el objeto
            Automovil BMW = new Automovil("Serie X", "Blanco", 5);

            Console.WriteLine($"\nModelo: {BMW.modelo}, Color: {BMW.color}, Puertas: {BMW.numPuertas},");


            // Sobrecarga del constructor
            Automovil Ford = new Automovil("Mustang", "Azul");
            Console.WriteLine($"\nModelo: {Ford.modelo}, Color: {Ford.color}");


            Automovil Nissan = new Automovil("Versa", 4, 180.5f, "Negro");
            Console.WriteLine($"\nModelo: {Nissan.modelo}, Color: {Nissan.color}, Puertas: {Nissan.numPuertas}, Velocidad: {Nissan.velocidad}KM/H");




        }
    }
}