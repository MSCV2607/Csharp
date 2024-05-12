using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino3._0
{
    internal class Casino
    {
        public int apostado { get; set; }
        public int numApos { get; set; }
        public int nModoJuego = 1;

        public int pozo = 10000;

        public void ModoJuego(int numApos, int aps, int nModoJuego, Persona persona, Dado dado)
        {
            int resultado = dado.TirarDado();

            Console.WriteLine($"Resultado del dado: {resultado}");

            if (resultado == numApos)
            {
                switch (nModoJuego)
                {
                    case 1:
                        persona.cartera += aps * 2;
                        pozo -= aps * 2;
                        Console.WriteLine("¡FELICIDADES! Has ganado.");
                        break;
                    case 2:
                        persona.cartera += aps * 5;
                        pozo -= aps * 5;
                        Console.WriteLine("¡FELICIDADES! Has ganado.");
                        break;
                    case 3:
                        persona.cartera += aps * 15;
                        pozo -= aps * 15;
                        Console.WriteLine("¡FELICIDADES! Has ganado.");
                        break;
                }
            }
            else
            {
                switch (nModoJuego)
                {
                    case 1:
                        persona.cartera -= aps;
                        pozo += aps;
                        Console.WriteLine("Lo siento, has perdido.");
                        break;
                    case 2:
                        persona.cartera -= aps * 2;
                        pozo += aps * 2;
                        Console.WriteLine("Lo siento, has perdido.");
                        break;
                    case 3:
                        persona.cartera -= aps * 4;
                        pozo += aps * 4;
                        Console.WriteLine("Lo siento, has perdido.");
                        break;
                }
            }
        }

        public int fondosCasino()
        {
            if (pozo <= 0)
            {
                Console.WriteLine("El juego se termino, no hay mas dinero en el casino");

            }
            return pozo;
        }
    }
}




