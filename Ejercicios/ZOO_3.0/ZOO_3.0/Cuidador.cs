using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class Cuidador
    {
        public String nombre {  get; set; }

        //palabra List + <dato> + nombre de la lista + "=" + new List + <dato> + "();"
        public List<IAnimal> animalesACargo = new List<IAnimal>();

        public Cuidador(string nombre, List<IAnimal> animalesACargo)
        {
            this.nombre = nombre;
            this.animalesACargo = animalesACargo;
        }


        


        //METODO PARA ALIMENTAR ANIMALES A CARGO -- no te olvides de conectar aca seria [Animal animal]
        public void alimentar() {
            
            for (int i=0; i<animalesACargo.Count; i++)
            {
                Animal animal = (Animal)animalesACargo[i];
                Console.WriteLine("El cuidador " + nombre + " alimenta a: " + animal.nombre + " con: " + animal.comida);
            }
        }


    }
}
