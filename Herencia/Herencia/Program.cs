using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Caballo caballo = new Caballo();
            Gorilas gorilas = new Gorilas();

            Console.WriteLine("\n----EL CABALLO:----");
            caballo.galopar();
            caballo.criarCrias();
            caballo.respirar();

            Console.WriteLine("\n----EL HUMANO:----");
            humano.respirar();
            humano.pensar();
            humano.criarCrias();

            Console.WriteLine("\n----EL GORILA:----");
            gorilas.criarCrias();
            gorilas.respirar();
            gorilas.trepar();


        }
    }
}
