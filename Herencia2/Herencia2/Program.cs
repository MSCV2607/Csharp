using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Con su nuevo constructor en cada uno me pide el nombre en todos
            Humano humano = new Humano("Mauro");
            Caballo caballo = new Caballo("Rolo");
            Gorilas gorilas = new Gorilas("Kin-Kong");

            Console.WriteLine("\n----EL CABALLO:----");
            caballo.galopar();
            caballo.criarCrias();
            caballo.respirar();
            caballo.getNombre();

            Console.WriteLine("\n----EL HUMANO:----");
            humano.respirar();
            humano.pensar();
            humano.criarCrias();
            humano.getNombre();

            Console.WriteLine("\n----EL GORILA:----");
            gorilas.criarCrias();
            gorilas.respirar();
            gorilas.trepar();
            gorilas.getNombre();


        }
    }
}
