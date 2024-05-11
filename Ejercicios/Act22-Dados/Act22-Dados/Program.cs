using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act22_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mirar DataTime
            Persona jugador1 = new Persona("Mauro", 42456912, 1000, new DateTime(2000,7,7));
            
            //El programa se termina si la persona es menor de edad
            if (jugador1.edad()<18)
            {
                Console.WriteLine("Usted es menor de edad vuelva en unos años");
                return;
                Console.ReadKey();
            }

            int num;
            do
            {
                Console.WriteLine("Que numero decide apostar");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 6)
                {
                    Console.WriteLine("ERROR: EL NUMERO DEBE SER ENTRE 1 Y 6 (INCLUIDOS) [vuelva a intentar]");
                }
            } while (num < 0 || num > 6);



            int aps;
            do
            {
                Console.WriteLine("Cuanto decide apostar");
                aps = Convert.ToInt32(Console.ReadLine());
                if (aps > jugador1.cartera)
                {
                    Console.WriteLine("Su apuesta excede el limite de su cartera");
                }
            } while (aps > jugador1.cartera);

            //3- dentro de la creacion de objeto pongo el otro objeto en este caso jugador 1
            Dado dado = new Dado(aps,num,jugador1);
            dado.TirarDado();
            jugador1.imprimir();

            

        }
    }
}
