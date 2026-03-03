using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Static
{
    class Celular
    {
        double pantalla;
        string color, marca, sisOp;
        int bateria;
        bool cargaRapida;


        // Declarar un campo estatico que valdra lo mismo para todos los objetos. 
        static string? procesador;


        public Celular(double pantallaPa, string colorPa, string marcaPa, string sisOpPa, int bateriaPa, bool cargaRapidaPa)
        {
            Console.WriteLine("Constructor de instancia");
            pantalla = pantallaPa;
            color = colorPa;
            marca = marcaPa;
            sisOp = sisOpPa;
            bateria = bateriaPa;
            cargaRapida = cargaRapidaPa;


        }

        public string Procesador { set { procesador = value; } }

        public void Info()
        {

            Console.WriteLine($"Tamaño de pantalla: {pantalla}");
            Console.WriteLine($"\nColor: {color}");
            Console.WriteLine($"\nMarca: {marca}");
            Console.WriteLine($"\nSistema Operativo: {sisOp}");
            Console.WriteLine($"\nBateria: {bateria}mAh");
            Console.WriteLine($"\nCarga Rapida: {cargaRapida}");
            Console.WriteLine($"\nProcesador: {procesador}");

        }

        // Metodo estatico
        public static void Prueba()
        {
            Console.WriteLine($"Procesador: {procesador} v2022");
        }

        // Constructor estatico
        static Celular()
        {
            Console.WriteLine("Constructor estatico");
        }

    }
}