using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    //NO AGREGO LA INTERFAZ PORQUE LA BALLENA NO TIENE PATAS
    internal class Ballena : Mamifero
    {
        public Ballena(string nombre) : base(nombre)
        {
        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }
}
