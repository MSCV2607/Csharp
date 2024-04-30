using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class Animal : IAnimal
    {

        public String nombre {  get; set; }
        public String especie { get; set; }
        public String comida {  get; set; }

        public Animal(string nombre, string especie, string comida)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.comida = comida;
        }

        public String getNombre()
        {
            Console.WriteLine("¿Que animal es?");
            nombre = Console.ReadLine();
            return nombre;
        }

        public String getEspecie()
        {
            Console.WriteLine("¿A que especie pertenece?");
            nombre = Console.ReadLine();
            return especie;
        }

        public String getComida()
        {
            Console.WriteLine("¿Que come el animal?");
            comida = Console.ReadLine();
            return nombre;
        }

        public void comer()
        {
            Console.WriteLine("El animal come: " + comida);
        }


    }
}
