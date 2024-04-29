using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Ave: Animal
    {
        public Ave(string nombre, string especie, string comida) : base(nombre, especie, comida)
        {
        }
        
        public void volar()
        {
            Console.WriteLine("El ave vuela");
        }
    }
   
}
