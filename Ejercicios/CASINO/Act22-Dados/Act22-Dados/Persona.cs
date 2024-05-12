using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act22_Dados
{
    internal class Persona
    {
        public string nombre {  get; set; }
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

        public Persona()
        {
        }

        private int edadJ;
        public int edad ()
        {
            return edadJ = fechaA.Year - nacimiento.Year;
        } 

        public void MayorEdad()
        {
            if( edadJ < 18 )
            {
                Console.WriteLine("Usted es menor de edad y no puede apostar. Vuelva en unos años");
                return;
            }
        }

        public void imprimir()
        {
            Console.WriteLine(cartera);
        }



       

        


    }
}
