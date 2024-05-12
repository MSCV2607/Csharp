using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona jugador1 = new Persona("Coco", 123456, 100, new DateTime(2000, 7, 7));
            Persona jugador2 = new Persona("Ramos", 654321, 100, new DateTime(2000, 7, 7));

            // El programa se termina si la persona es menor de edad
            if (jugador1.edad() < 18)
            {
                Console.WriteLine($"El jugador {jugador1.nombre} es menor de edad. NO PUEDE JUGAR");
                return;
            }
            if (jugador2.edad() < 18)
            {
                Console.WriteLine($"El jugador {jugador2.nombre} es menor de edad. NO PUEDE JUGAR");
                return;
            }

            Casino casino = new Casino();

            int numJ1, numJ2, apsJ1, apsJ2, cont,mjue1,mjue2;
            Dado dado = new Dado();

            do
            {

                if (jugador1.cartera <= 0 || jugador2.cartera <= 0)
                {
                    Console.WriteLine("\nJuego terminado, uno de los dos jugadoresno posee fondos suficientes para seguir");
                    break;
                }

                //------------------------datos Jugador 1------------------------
                do
                {
                    Console.WriteLine("Jugador 1:");
                    Console.WriteLine("A que numero decide apostar");
                    numJ1 = Convert.ToInt32(Console.ReadLine());
                    if (numJ1 < 1 || numJ1 > 12)
                    {
                        Console.WriteLine("ERROR: EL NUMERO DEBE SER ENTRE 1 Y 12 (INCLUIDOS) [vuelva a intentar]");
                    }
                    
                } while (numJ1 < 1 || numJ1 > 12);
                do
                {
                    Console.WriteLine("¿Cuánto decide apostar?");
                    apsJ1 = Convert.ToInt32(Console.ReadLine());

                    if (apsJ1 > jugador1.cartera)
                    {
                        Console.WriteLine("ERROR: NO POSEE ESA SUMA DE DINERO EN LA CARTERA, VUELVA A INTENTAR");
                    }

                } while (apsJ1 > jugador1.cartera);

                do
                {
                    Console.WriteLine("Cual de los 3 modos quiere jugar: \n1)MODO CONSERVADOR\n2)MODO ARRIESGADO\n3)MODO DESESPERADO");
                    mjue1 = Convert.ToInt32(Console.ReadLine());
                } while (mjue1 < 1 && mjue1 > 3);

                //------------------------datos Jugador 2------------------------
                do
                {
                    Console.WriteLine("\nJugador 2:");
                    Console.WriteLine("A que numero decide apostar");
                    numJ2 = Convert.ToInt32(Console.ReadLine());
                    if (numJ2 < 1 || numJ2 > 12)
                    {
                        Console.WriteLine("ERROR: EL NUMERO DEBE SER ENTRE 1 Y 12 (INCLUIDOS) [vuelva a intentar]");
                    }
                } while (numJ2 < 1 || numJ2 > 12);

                do
                {
                    Console.WriteLine("¿Cuánto decide apostar?");
                    apsJ2 = Convert.ToInt32(Console.ReadLine());

                    if(apsJ2 > jugador2.cartera)
                    {
                        Console.WriteLine("ERROR: NO POSEE ESA SUMA DE DINERO EN LA CARTERA, VUELVA A INTENTAR");
                    }

                } while (apsJ2 > jugador2.cartera);
                do
                {
                    Console.WriteLine("Cual de los 3 modos quiere jugar: \n1)MODO CONSERVADOR\n2)MODO ARRIESGADO\n3)MODO DESESPERADO");
                    mjue2 = Convert.ToInt32(Console.ReadLine());
                } while (mjue2 < 1 && mjue2 > 3);



                casino.ModoJuego(numJ1, apsJ1, mjue1, jugador1, dado);
                

                casino.ModoJuego(numJ2, apsJ2, mjue2, jugador2, dado);
                

                
                Console.WriteLine("¿Desea continuar? (1-SI / 2-NO)");
                cont = Convert.ToInt32(Console.ReadLine());

                if (casino.fondosCasino() == 0)
                {
                    return;
                }

            } while (cont == 1);
            Console.WriteLine("\nMuchas gracias por jugar con nosotros");
            jugador1.Imprimir();
            jugador2.Imprimir();
        }
    }
}
