using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPORTANTE PARA NO PONER MATH A CADA RATO
using static System.Math;

using static System.Console; //EN VEZ DE ESCRIBIR "Consol.WriteLine("")" ESCRIBIMOS "WriteLine("")"

namespace CONCEPTOSPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            double raiz = Sqrt(9);
            double potencia = Math.Pow(3, 4);

            Console.WriteLine(raiz);
            Console.WriteLine(potencia);

            //ESTO ES UNA CLASE ANONIMA 
            var MiVariable = new { Nombre = "Juan", Edad = 18 };
            Console.WriteLine(MiVariable.Nombre + " " + MiVariable.Edad);

        }

        static void realizarTarea()
        {
            PUNTO origen = new PUNTO();
            PUNTO destino = new PUNTO(150, 90);
            
            double distancia = origen.distancia(destino);
            Console.WriteLine($"La distancia entre dos puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {PUNTO.contadorObj()}");

            //TODO: 
            //con todo indiacmos que hay que continuar desde aca el codigo
        }

    }
}
