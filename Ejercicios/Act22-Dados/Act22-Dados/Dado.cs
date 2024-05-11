using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act22_Dados
{
    internal class Dado
    {
        //RANDOM
        private Random rnd = new Random();
        private int dado;
        public int apostado {  get; set; }
        int numApos {  get; set; }

        //1-Aca instancio la clase persona dentro de mi clase random
        private Persona persona;

        //2-Lo sumo al constructor [anda a program]
        public Dado(int apostado, int numApos, Persona persona)
        {
            this.apostado = apostado;
            this.numApos = numApos;
            this.persona = persona;
        }

        public int TirarDado()
        {
           dado = rnd.Next(1,7);

            if (dado == numApos)
            {
                Console.WriteLine($"Salio el numero {dado}");
                Console.WriteLine("FELICIDADES GANOOOO!!!!");
                return persona.cartera += apostado*2;
            } else
            {
                Console.WriteLine($"Salio el numero {dado}");
                Console.WriteLine("Siga participando :C");
                return persona.cartera -= apostado;
            }

        }        


    }
}
