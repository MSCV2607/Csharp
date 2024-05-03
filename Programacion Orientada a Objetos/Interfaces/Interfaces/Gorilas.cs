using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Gorilas : Mamifero,IMamiferosTerrestres
    {
        public Gorilas(string nombre) : base(nombre)
        {
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento de Gorila");
        }

        public int numPatas()
        {
            return 2;
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
