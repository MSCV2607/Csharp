using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Con su nuevo constructor en cada uno me pide el nombre en todos
            Humano humano = new Humano("Mauro");
            Caballo caballo = new Caballo("Rolo");
            Gorilas KingKong = new Gorilas("Kin-Kong");

            //Array de Mamiferos [puedo poner cualquier clase que herede de mamiferos]
            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = KingKong;

            for(int i = 0; i  < almacenAnimales.Length; i++)
            {
                //POLIMORFISMO -- Capacidad de los objetos a tener diferente forma dependiendo del contexto [pensar() cambia de forma 3 veces]
                almacenAnimales[i].pensar();
            }
            

        }
    }
}
