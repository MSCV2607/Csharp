using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class ZOO
    {
        public List<IAnimal> listaAnimales = new List<IAnimal>();
        public List<Cuidador> listaCuidadoress = new List<Cuidador>();

        public ZOO(List<IAnimal> listaAnimales, List<Cuidador> listaCuidadoress)
        {
            this.listaAnimales = listaAnimales;
            this.listaCuidadoress = listaCuidadoress;
        }

        public void mostrarCuidadoress()
        {
            Console.WriteLine("----LOS ENCARGADOS SON----");
            for (int i = 0; i < listaCuidadoress.Count; i++)
            {
                //ACA ESTA NO TE OLVIDES .nombre
                Console.WriteLine(listaCuidadoress[i].nombre);
            }
        }

        //MIRA ESTO MOSTRAR ANIMAL
        public void mostrarAnimales()
        {
            Console.WriteLine("----LOS ANIMALES SON----");
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                //ACA ES DONDE CONECTO
                Animal animal = (Animal)listaAnimales[i];
                Console.WriteLine("Nombre: " + animal.nombre + "\nEspecie: " + animal.especie + "\nComida: " + animal.comida);
                Console.WriteLine("---------------------------------------");
            }
        }


        //METODO PARA AGREGAR ANIMAL 
        public void agregarAnimal(IAnimal aAnimal)
        {
            listaAnimales.Add(aAnimal);
        }


        //METODO PARA AGREGAR CUIDADOR
        public void agregarCuidador(Cuidador cuidador)
        {
            listaCuidadoress.Add(cuidador);
        }

        //METODO PARA ASIGNAR CUIDADOR A ANIMAL -- fijate que lo hago con cuidador y no con Cuidador
        public void asignarCuidadorAnimal(IAnimal aAnimal,Cuidador cuidador) {
            cuidador.animalesACargo.Add(aAnimal);
        }

    }
}
