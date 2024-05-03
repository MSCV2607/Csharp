using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class PlantaCarnivora : IAnimal
    {

        String nombre;
        String tipo;
        String tipoCarnivoro;

        public PlantaCarnivora(string nombre, string tipo, string tipoCarnivoro) 
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.tipoCarnivoro = tipoCarnivoro;
        }



        public void getNombre()
        {
            Console.WriteLine("El nombre de la planta carnivora es: " + nombre);
        }

        public void getTipo()
        {
            Console.WriteLine("El tipo de la planta carnivora es: " + tipo);
        }

        public void getTipoCarnivoro()
        {
            Console.WriteLine("El tipo carnivoro de la planta carnivora es: " + tipoCarnivoro);
        }


        public void comer()
        {
            Console.WriteLine("La planta carnivora come");
        }
    }

}
