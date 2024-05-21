using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Mamifero
    {
        private String nombre;

        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }


        public virtual void pensar()
        {
            Console.WriteLine("PENSAMIENTOS INSTINTIVOS");
        }


        public void respirar()
        {
            Console.WriteLine("SOY CAPAZ DE RESPIRAR");
        }

        public void criarCrias()
        {
            Console.WriteLine("CUIDO A MIS CRIAS HASTA QUE SE PUEDAN CUIDAR SOLOS");
        }

        public void getNombre()
        {
            Console.WriteLine("EL NOMBRE DEL SER VIVO: " + nombre);
        }
    }
}
