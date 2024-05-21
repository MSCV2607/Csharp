using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Humano : Mamifero
    {
       
        public Humano(string nombre) : base(nombre)
        {

        }

        //OCULTA LA HERENCIA "pensar()" DE MAMIFEROS -- con el new sigue siendo lo mismo pero no marca advertencia [new public void pensar()]
        //CON LA PALABRA RESERVADA "override" DEJA DE SER UN METODO DIFERENTE Y PASA A SER UN METODO QUE MODIFICA EL METODO DE MAMIFERO
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }



    }
}
