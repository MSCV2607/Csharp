using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class Ave: Animal , IAnimal
    {
        public Ave(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }

        public void volar()
        {
            Console.WriteLine("PUEDO VOLAR");
        }

    }
}
