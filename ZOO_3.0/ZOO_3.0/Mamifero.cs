using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class Mamifero:Animal , IAnimal
    {
        public Mamifero(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void amamantar()
        {
            Console.WriteLine("PUEDO AMAMANTAR");
        }

    }
}
