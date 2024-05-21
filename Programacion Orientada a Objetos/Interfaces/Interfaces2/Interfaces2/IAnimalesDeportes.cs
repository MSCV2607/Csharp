using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal interface IAnimalesDeportes
    {
        string tipoDeporte();
        //Puede tener mas de un metodo la interfaz en este caso un string y un booleano 
        Boolean esOlimpico();
    }
}
