using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjetosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Crear instancia de clase: tipo identificador = new 
            // Bicicleta Bicicleta1 = new Bicicleta();

            // // Acceder y asignar valores a los atributos 
            // // Objeto.atributo 
            // Bicicleta1.marca = "Factor";
            // Bicicleta1.modelo = "X45";
            // Bicicleta1.color = "Negro";
            // Bicicleta1.rodada = 23;
            // Bicicleta1.velocidades = 4;

            // // Acceder a los metodos 
            // // Objeto.Metodo() 
            // Bicicleta1.Acelerar();
            // Bicicleta1.CambioVelocidades();
            // Bicicleta1.Frenar();
            // Bicicleta1.Info();

            // Console.WriteLine("\nObjeto 2: ");

            // // Crear un segundo objeto 
            // Bicicleta Bicicleta2 = new Bicicleta();

            // // Asignar valores a los atributos 
            // Bicicleta2.marca = "Factor";
            // Bicicleta2.modelo = "X65";
            // Bicicleta2.color = "Vino";
            // Bicicleta2.rodada = 25;
            // Bicicleta2.velocidades = 7;

            // // Metodos
            // Bicicleta2.Acelerar();
            // Bicicleta2.Info();


            // Instancia de la clase 
            Calculadora Calculadora1 = new Calculadora();

            // Asignar valores a los atributos  
            Console.WriteLine("Ingresar el primer valor: ");
            Calculadora1.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor: ");
            Calculadora1.num2 = Convert.ToInt32(Console.ReadLine());

            // Llamar a los metodos
            Calculadora1.Suma();
            Calculadora1.ImprimirResultado();
        }
    }
}