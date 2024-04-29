using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Pez: Animal
    {
        public Pez(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void nadar()
        {
            Console.WriteLine("El pez nada");
        }
    }
   
}
