using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Casino2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            String nombre;
            int edad;
            int cartera;
            int apuestaC;
            int apuestaD;
            int pozoCasino = 10000;

            //JUGADOR1
            Console.WriteLine("Por favor ingrese el nombre del jugador 1:");
            nombre = Console.ReadLine();
            Console.WriteLine("Que edad tiene el jugador 2: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad < 18)
            {
                Console.WriteLine("USTED NO PUEDE PARTICIPAR DE APUESTAS.");
                return; // Esto terminará la ejecución del programa.
            }

            do
            {
                Console.WriteLine("Cuanto dinero tiene el jugador 1: [minimo debe de tener 100 fichas]");
                cartera = Convert.ToInt32(Console.ReadLine());
            } while (cartera < 100);

            Persona jugador1 = new Persona (nombre, edad,cartera);

            /*
            //JUGADOR 2
            Console.WriteLine("Por favor ingrese el nombre del jugador 2:");
            nombre = Console.ReadLine();
            Console.WriteLine("Que edad tiene el jugador 2: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("USTED NO PUEDE PARTICIPAR DE APUESTAS.");
                return; // Esto terminará la ejecución del programa.
            }

            do
            {
                Console.WriteLine("Cuanto dinero tiene el jugador 1: [minimo debe de tener 100 fichas]");
                cartera = Convert.ToInt32(Console.ReadLine());
            } while (cartera < 100);

            Persona jugador2 = new Persona(nombre, edad, cartera);
            */


            
            int resultado = 0;

            Casino dado1 = new Casino();
            

            Thread.Sleep(500); //--> para darle pausa al programa

            Casino dado2 = new Casino();
            

            

            //APUESTAS JUG1
            Console.WriteLine("Cuanto desea apostar el jugador 1: ");
            apuestaC = Convert.ToInt32(Console.ReadLine());
            if(jugador1.cartera>apuestaC)
            {
                Console.WriteLine("Elija un numero entre 2 y 12");
                apuestaD = Convert.ToInt32(Console.ReadLine());

                dado1.tirarDado();
                resultado += dado1.resDado();
                Thread.Sleep(500); //--> para darle pausa al programa
                dado2.tirarDado();
                resultado += dado2.resDado();
                Console.WriteLine("El resultado del lanzamiento fue de: " + resultado);

                if (apuestaD == resultado)
                {
                    Console.WriteLine("FELICIDADES GANOOOO!!!!!");
                    jugador1.cartera += apuestaC;
                } else
                {
                    Console.WriteLine("Mas suerte la proxima");
                    jugador1.cartera -= apuestaC;
                }

            } else
            {
                Console.WriteLine("NO POSEE SUFICIENTE CANTIDAD DE DINERO EN LA CARTERA");
            }
            Console.WriteLine(jugador1.cartera);


        }
    }
}
