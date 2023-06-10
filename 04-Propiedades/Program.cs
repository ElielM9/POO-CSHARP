using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Meetodos
            double num1Ar, num2Ar, res;
            int opcion;

            // Menu
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion ");

            Console.Write("Elige una opcion");

            opcion = Convert.ToInt32(Console.ReadLine());


            // Instanciando la clase
            Metodos Calculadora1 = new Metodos();

            if (opcion == 1)
            {
                Calculadora1.Suma();
            }
            else if (opcion == 2)
            {
                Console.WriteLine($"Ingresa el primer valor: ");
                num1Ar = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine($"Ingresa el segundo valor: ");
                num2Ar = Convert.ToDouble(Console.ReadLine());

                Calculadora1.Resta(num1Ar, num2Ar);
            }
            else
            {
                res = Calculadora1.Multiplicacion();
                Console.WriteLine($"El resultado es: {res}");
            }



            // Propiedades
            ClasePropiedades ObjetoUno = new ClasePropiedades();

            // string nombreAr;

            Console.WriteLine("Dime tu edad: ");
            ObjetoUno.Numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Cual es tu nombre?");
            // nombreAr = Console.ReadLine();
            ObjetoUno.Nombre = Console.ReadLine();

            // Get
            Console.WriteLine($"El valor del campo privado es: {ObjetoUno.Numero1}");

            // Set
            // ObjetoUno.Nombre = nombreAr;

            // Ver si el set fue correcto
            Console.WriteLine($"El valor del campo privado nombre es: {ObjetoUno.Nombre}");


            // Ejercicio
            int opcion1;

            // Menu
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicacion");
            Console.WriteLine("4- Division");
            Console.Write("\nElige una opcion: ");
            opcion1 = Convert.ToInt32(Console.ReadLine());

            // Instanciar a la clase
            Matematicas Calculadora = new Matematicas();

            Console.WriteLine("Ingresa el primer valor: ");
            Calculadora.Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor: ");
            Calculadora.Num2 = Convert.ToDouble(Console.ReadLine());

            if (opcion1 == 1)
            {
                Calculadora.Suma();
                Console.WriteLine($"Resultado: {Calculadora.Resultado}");
            }
            else if (opcion1 == 2)
            {
                Calculadora.Resta();
                Console.WriteLine($"Resultado: {Calculadora.Resultado}");
            }
            else if (opcion1 == 3)
            {
                Calculadora.Multiplicacion();
                Console.WriteLine($"Resultado: {Calculadora.Resultado}");
            }
            else
            {
                Calculadora.Division();
                Console.WriteLine($"Resultado: {Calculadora.Resultado}");
            }


        }
    }
}