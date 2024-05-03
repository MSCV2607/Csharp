using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //ESTA CLASE SI IMPLEMENTA INTERFACE
    //ASI SE HACE CON LA , Y CON EL NOMBRE DE LA INTERFACE DESPUES DE LA CLASE HEREDADA VA
    internal class Caballo : Mamifero , IMamiferosTerrestres
    {
        public Caballo(string nombre) : base(nombre)
        {
        }

        //METODO DE LA INTERFAZ
        public int numPatas()
        {
            return 4;
        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
