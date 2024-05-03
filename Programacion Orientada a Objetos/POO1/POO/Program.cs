using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SE USA CON LA CLASS circulo
            circulo miCirculo; //Creacion de objeto de tipo circulo
            miCirculo = new circulo(); //Iniciacion de variable objeto de tipo circulo. Instanciar una clase

            Console.WriteLine(miCirculo.calcularArea(5));

            circulo miCirculo2 = new circulo();
            Console.WriteLine(miCirculo2.calcularArea(12));
            */

            conversorDolarPeso dolar = new conversorDolarPeso();
            
            Console.WriteLine(dolar.convierte(1));

            dolar.cambiarValorPeso(1000);

            Console.WriteLine(dolar.convierte(1));

        }
    }

    class circulo
    {
        private const double pi = 3.1416; //Propiedad de circulo. Campo de clase. Encapsulado con private



        public double calcularArea(int radio) //Metodo de clase. ¿Que pueden hacer los objetos circulos?
        {
            return pi * radio * radio;
        }


    }

    class conversorDolarPeso
    {
        private double dolar = 1000.60;

        public double convierte(double cantidad) {

            return cantidad * dolar;

        }

        public void cambiarValorPeso(double nuevoValor)
        {
            if(nuevoValor < 0) { dolar = 1000.6; }
            else dolar = nuevoValor;


           
        }

    }

}
