using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2._0
{
    internal class Persona
    {
        public String Nombre { get; set; }
        public int edad {  get; set; }
        public int cartera { get; set; }

        public Persona(string nombre, int edad, int cartera)
        {
            Nombre = nombre;
            this.edad = edad;
            this.cartera = cartera;
        }

        

        public void datos()
        {
            Console.WriteLine("El nombre de la persona es: " + Nombre + "\nSu edad es: "+edad);
        }

        

    }
}
