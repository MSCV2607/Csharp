using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Mamifero: Animal
    {
        public Mamifero(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void amamantar()
        {
            Console.WriteLine("El mamifero amamanta a sus crias");
        }
    }
    
    
}
