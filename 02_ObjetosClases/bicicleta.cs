using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjetosClases
{
    class Bicicleta
    {
        // Declarar un atributo 
        // acceso tipo identificador
        public string? marca;
        public string? modelo;
        public string? color;
        public int rodada;
        public int velocidades;

        // Declarar metodos 
        // acceso modificador tipo identificador (parametros){} 
        public void Acelerar()
        {
            Console.WriteLine("Acelerar");
        }
        public void Frenar()
        {
            Console.WriteLine("La bicicleta se detuvo");
        }
        public void CambioVelocidades()
        {
            Console.WriteLine("Cambio de velocidad");
        }

        // Mostrar la informacion del objeto
        public void Info()
        {
            Console.WriteLine($"Informacion de la bicicleta: ");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Rodada: {rodada}");

        }
    }
}