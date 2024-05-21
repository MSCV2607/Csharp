using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //La clase caballo hereda de la clase Mamifero de la siguiente forma CLASEHIJA : CLASEPADRE
    internal class Caballo:Mamifero
    {
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
