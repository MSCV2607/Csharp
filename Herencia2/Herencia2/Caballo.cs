using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Caballo:Mamifero
    {
        public Caballo(string nombre) : base(nombre)
        {
        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }
}
