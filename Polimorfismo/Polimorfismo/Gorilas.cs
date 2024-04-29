using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Gorilas : Mamifero
    {
        public Gorilas(string nombre) : base(nombre)
        {
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento de Gorila");
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
