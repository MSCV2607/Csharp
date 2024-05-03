using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IMamiferosTerrestres
    {
        //SOLO LLEVA ESTO, ASI VAMOS A OBLIGAR A LOS CLASES QUE TENGAN ANIMALES CON PATAS A QUE DESAROLLEN UN METODO QUE SE LLAME "numPatas()"
        int numPatas();
    }
}
