using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino3._0
{
    internal class Dado
    {
        public Random rnd = new Random();
        public int dado;

        public int TirarDado()
        {
            return dado = rnd.Next(1, 13);
        }
    }
}
