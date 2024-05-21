using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();
            aviso1.mostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("Ciudad Corrientes", "Sancion de $50.000", DateTime.Now);
            aviso2.mostrarAviso();

         

            Console.WriteLine(aviso2.getFecha());

        }
    }
}
