using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propiedades
{
    public class ClasePropiedades
    {
        // Propiedades

        // Atributo privado
        private int numero1;
        // private string? nombre;

        // Propiedad
        // modificador tipo Nombre {}
        public int Numero1
        {
            // get
            // {
            //     return numero1 = 24;
            // }
            get; set; 
        }
        // public string Nombre
        // {
        //     set
        //     {
        //         nombre = value;
        //     }
        //     get
        //     {
        //         return nombre;
        //     }
        // }

        // Propiedades autoimplementadas
        public string? Nombre { get; set; }


    }
}