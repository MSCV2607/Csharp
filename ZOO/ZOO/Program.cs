using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear animales
            Mamifero leon = new Mamifero("León", "Felino", "Carne");
            Pez tiburon = new Pez("Tiburón", "Escualo", "Peces");
            Ave paloma = new Ave("Paloma", "Columbidae", "Lombrices");
            PlantaCarnivora planta = new PlantaCarnivora("Venus atrapamoscas", "Carnívora", "Insectos");

            // Crear cuidadores
            Cuidador cuidador1 = new Cuidador("Juan", new List<Animal>());
            Cuidador cuidador2 = new Cuidador("María", new List<Animal>());

            // Crear zoológico
            Zoologico zoo = new Zoologico(new List<IAnimal>(), new List<Cuidador>());

            // Agregar animales al zoológico
            zoo.agregarAnimal(leon);
            zoo.agregarAnimal(tiburon);
            zoo.agregarAnimal(paloma);
            zoo.agregarAnimal(planta);

            // Agregar cuidadores al zoológico
            zoo.agregarCuidador(cuidador1);
            zoo.agregarCuidador(cuidador2);

            // Asignar cuidadores a los animales
            zoo.asignarCuidador(leon, cuidador1);
            zoo.asignarCuidador(tiburon, cuidador2);
            zoo.asignarCuidador(paloma, cuidador1);
            
            

            // Alimentar a los animales por parte de los cuidadores
            cuidador1.alimentarAnimales();
            cuidador2.alimentarAnimales();

            // Mostrar información de la planta carnivora
            Console.WriteLine("\nInformación de la planta carnivora:");
            planta.getNombre();
            planta.getTipo();
            planta.getTipoCarnivoro();
        }
    }
}
