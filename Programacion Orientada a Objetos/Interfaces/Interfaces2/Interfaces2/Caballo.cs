using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2

{//Hereda una clase (solo una clase se puede en C#) pero si puedo heredar varias interfaces
    internal class Caballo : Mamifero, IMamiferosTerrestres , IAnimalesDeportes , ISaltoConPatas
    {
        public Caballo(string nombre) : base(nombre)
        {
        }

        //Para solucionar la ambiguedad que existe al tener dos interfaces con el mismo metodo realizamos lo siguiente
        //Sacamos el modificador de acceso
        //Dato + nombre interfaz + . + su metodo
        int IMamiferosTerrestres.numPatas() {
            return 4;
        }

        int ISaltoConPatas.numPatas()
        {
            return 2;
        }


        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        //Si en la interfaz se define un tipo es el mismo tipo que hereda en este caso string
        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }

        
    }
}
