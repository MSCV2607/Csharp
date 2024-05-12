using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino3._0
{
    internal class Persona
    {
        public string nombre { get; set; }
        public int DNI { get; set; }
        public int cartera { get; set; }
        public DateTime nacimiento { get; set; }

        private DateTime fechaA = DateTime.Now;

        public Persona(string nombre, int dNI, int cartera, DateTime nacimiento)
        {
            this.nombre = nombre;
            DNI = dNI;
            this.cartera = cartera;
            this.nacimiento = nacimiento;
        }

        private int edadJ;
        public int edad()
        {
            return edadJ = fechaA.Year - nacimiento.Year;
        }


        public void Imprimir()
        {
            Console.WriteLine($"\n--TICKET {DateTime.Now}--" );
            Console.WriteLine($"JUGADOR: {nombre}");
            Console.WriteLine($"DNI: {DNI}");
            Console.WriteLine($"EDAD: {edad()}");
            Console.WriteLine($"SALDO: {cartera}");

        }
    }
}
