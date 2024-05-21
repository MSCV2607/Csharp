using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano("Mauro");
            Caballo caballo = new Caballo("Rolo");

            //Como el numPatas() dejo de ser publico debemos crear un objeto con la interfaz igual a caballo
            IMamiferosTerrestres Icaballo = caballo; //Un caballo es un mamifero terrestre

            Gorilas KingKong = new Gorilas("Kin-Kong");

            
            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = KingKong;

            for (int i = 0; i < almacenAnimales.Length; i++)
            {
                almacenAnimales[i].pensar();
            }

            Ballena ballena = new Ballena("Wally");
            ballena.nadar();

            //Aca tambien se cambia
            Console.WriteLine("NUMERO DE PATAS DEL CABALLO: " + Icaballo.numPatas());
        }
    }
}
