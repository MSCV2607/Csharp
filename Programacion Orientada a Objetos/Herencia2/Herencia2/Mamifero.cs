using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Mamifero
    {
        
        private String nombre;
        //Al crear un constructor propio el codigo de las clases que heredan se rompen salvo que se haga --> {IR A HUAMNO}
        public Mamifero(string nombre)
        {
            this.nombre = nombre;
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
            Console.WriteLine("El nombre del ser vivo es: " + nombre);
        }

    }
}
