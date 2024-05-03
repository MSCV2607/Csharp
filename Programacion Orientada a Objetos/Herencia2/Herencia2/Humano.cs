using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Humano:Mamifero
    {
        //--> CREO UN NUEVO COSNTRUCTOR PARA QUE NO SE ROMPA
        public Humano(string nombre) : base(nombre)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        

    }
}
