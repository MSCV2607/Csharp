using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Cuidador
    {
        public String nombre;
        public List<Animal> AnimalesACargo = new List<Animal>();

        public Cuidador(string nombre, List<Animal> animalesACargo)
        {
            this.nombre = nombre;
            AnimalesACargo = animalesACargo;
        }

        public void alimentarAnimales()
        {
            foreach (Animal animal in AnimalesACargo)
            {
                Console.WriteLine("El cuidador " + nombre + " alimenta a " + animal.nombre + " con " + animal.comida);
            }
        }


    }
}
