using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2._0
{
    internal class Casino
    {

        private Random rnd = new Random();
        int plataCasino = 10000;
        int dado;
        
        public int pozoCasino()
        {
            return plataCasino;
        }

        public int resDado()
        {
            return dado;
        } 

        public void tirarDado()
        {
            // Creamos una instancia de la clase Random
            

            dado = rnd.Next(1, 7);

            switch (dado)
            {
                case 1:
                    Console.WriteLine("  +-------+\r\n  |       |\r\n  |   *   |\r\n  |       |\r\n  +-------+");
                    break;
                case 2:
                    Console.WriteLine("  +-------+\r\n  | *     |\r\n  |       |\r\n  |     * |\r\n  +-------+");
                    break;
                case 3:
                    Console.WriteLine("  +-------+\r\n  | *     |\r\n  |   *   |\r\n  |     * |\r\n  +-------+");
                    break;
                case 4:
                    Console.WriteLine("   +-------+\r\n  | *   * |\r\n  |       |\r\n  | *   * |\r\n  +-------+");
                    break;
                case 5:
                    Console.WriteLine("  +-------+\r\n  | *   * |\r\n  |   *   |\r\n  | *   * |\r\n  +-------+");
                    break;
                case 6:
                    Console.WriteLine("  +-------+\r\n  | * * * |\r\n  |       |\r\n  | * * * |\r\n  +-------+");
                    break;
                default: Console.WriteLine("---"); break;

            }
           
        }
       

        


    }
}
