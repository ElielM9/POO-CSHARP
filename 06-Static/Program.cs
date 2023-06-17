using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clases estaticas

            // No podemos instanciar una clase estatica
            // ClaseEstatica ObjetoUno = new ClaseEstatica();

            ClaseEstatica.saludo = "Hola";
            Console.WriteLine($"Clase Estatica: {ClaseEstatica.saludo}");


            // Campos estaticos

            // Instanciar la clase 
            Celular CelularUno = new Celular(5.4f, "Blanco", "LG", "Android", 4300, true);

            // Darle valor al campo estatico
            CelularUno.Procesador = "SnapDragon 8Gen1";
            CelularUno.Info();

            // Instanciar clase por segunda vez
            Console.WriteLine("------------------");
            Celular CelularDos = new Celular(6.3f, "Negro", "Samsung", "Android", 4500, true);
            CelularDos.Info();

            // Instanciar clase por tercera vez
            Console.WriteLine("------------------");
            Celular CelularTres = new Celular(6.5f, "Gris", "Huawei", "Android", 4500, false);
            CelularTres.Info();



            // Metodos estaticos
            Console.WriteLine("------------------");
            // Llamando al metodo estatico
            Celular.Prueba();



            // Constructores estaticos
            
        }

    }
}