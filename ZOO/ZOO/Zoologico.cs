using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Zoologico
    {

        public List<IAnimal> listaAnimales = new List<IAnimal>();
        public List<Cuidador> listaCuidadores = new List<Cuidador>();

        public Zoologico(List<IAnimal> listaAnimales, List<Cuidador> listaCuidadores)
        {
            this.listaAnimales = listaAnimales;
            this.listaCuidadores = listaCuidadores;
        }

        public void agregarAnimal(IAnimal animal)
        {
            listaAnimales.Add(animal);
        }

        public void agregarCuidador(Cuidador cuidador)
        {
            listaCuidadores.Add(cuidador);
        }

        public void asignarCuidador(Animal animal, Cuidador cuidador)
        {
            cuidador.AnimalesACargo.Add(animal);
        }
    }
}
