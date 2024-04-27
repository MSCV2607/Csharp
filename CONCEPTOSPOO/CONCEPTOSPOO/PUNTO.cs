using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCEPTOSPOO
{
    internal class PUNTO
    {

        public PUNTO(int x, int y)
        {
            //Console.WriteLine($"Cordenada x: {x}, cordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public PUNTO()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double distancia(PUNTO otroPunto)
        {

            int xDif = this.x - otroPunto.x;
            int ydif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2)+Math.Pow(ydif, 2));

            return distanciaPuntos;

        }

        private int x, y;

        private static int contadorDeObjetos = 0;

        public static int contadorObj()
        {
            return contadorDeObjetos;
        }

    }
}
