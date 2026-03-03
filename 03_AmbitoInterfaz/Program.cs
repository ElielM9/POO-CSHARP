using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbitoInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ambito a nivel de metodo 

            // Variable local 
            double numero1;
            Console.WriteLine("Ingresa un valor");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Numero 1: {numero1}");

            // Crear una instancia de la clase 
            Ambito a = new Ambito();
            a.Suma();
            a.Informacion();


            // Ambito a nivel de clase: 
            /*
            1- Los miembros de la clase pueden acceder a los atributos siempre que estos estén por fuera de los metodos. 
            2- Podemos acceder a un atributo con ambito de clase desde los metodos, siempre y cuando los metodos no esten como estaticos. 
            3- El modificador de acceso de los atributos no afecta su alcance dentro de la clase. 
            */

            // Tratar de imprimir un campo declarado en otra clase
            // Console.WriteLine($"Campo {z}");



            // Modificadores de acceso

            // Instancia de la clase
            Modificadores ObjetoPrueba = new Modificadores(); //

            ObjetoPrueba.a = 10;
            // ObjetoPrueba.b = 20; 



            // Interfaces
            Interfaz OperacionesUno = new Interfaz();
            // Llamar al metodo
            OperacionesUno.Multiplicacion();


        }

    }
}