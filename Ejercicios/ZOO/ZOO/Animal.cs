using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Animal : IAnimal
    {
        public string nombre;
        public string especie;
        public string comida;

        public Animal(string nombre, string especie, string comida)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
        }
        public void comer()
        {
            Console.WriteLine("El animal come");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del animal es: " + nombre);
        }

        public void getEspecie()
        {
            Console.WriteLine("La especie del animal es: " + especie);
        }

        public void getComida()
        {
            Console.WriteLine("La comida del animal es: " + comida);
        }

        public void setComida(string comida)
        {
            this.comida = comida;
        }

    }
}
