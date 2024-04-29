using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Mamifero
    {

        private String nombre;
        //Al crear un constructor propio el codigo de las clases que heredan se rompen salvo que se haga --> {IR A HUAMNO}
        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }

        //Con la palabra reservada "virtual" todas las clases hijas van a tener pensar pero todas las clases tienen que agregarle algo
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
