using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Gorilas:Mamifero
    {
        public Gorilas(string nombre) : base(nombre)
        {
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
