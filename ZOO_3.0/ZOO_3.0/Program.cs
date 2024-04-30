using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ZOO_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String rtaCont;
            //CREO Y CONECTO CON ZOO
            ZOO zoo = new ZOO(new List<IAnimal>(), new List<Cuidador>());
            
            Console.WriteLine("Por favor introduzca el nombre del primer cuidador: ");
            String nombre = Console.ReadLine();
            Cuidador cuidadro1 = new Cuidador(nombre,new List<IAnimal>());
            zoo.agregarCuidador(cuidadro1);

            Console.WriteLine("Por favor introduzca el nombre del segundo cuidador: ");
            nombre = Console.ReadLine();
            Cuidador cuidadro2 = new Cuidador(nombre, new List<IAnimal>());
            zoo.agregarCuidador(cuidadro2);
            
            do
            {
                Console.WriteLine("Por favor introduzca si quiere agregar un MAMIFERO(1), UN PEZ(2) O UN AVE(3) ");
                int rtaA = Convert.ToInt32(Console.ReadLine());

                switch (rtaA)
                {
                    case 1:
                        Console.WriteLine("¿Que animal desea agregar?");
                        string nombreAnimal = Console.ReadLine();

                        Console.WriteLine("¿Que especie es este animal?");
                        string especieAnimal = Console.ReadLine();
                        Console.WriteLine("¿Que come este animal?");
                        string comidaAnimal = Console.ReadLine();
                        Mamifero nuevoMamifero = new Mamifero(nombreAnimal, especieAnimal, comidaAnimal);
                        zoo.agregarAnimal(nuevoMamifero);
                        zoo.asignarCuidadorAnimal(nuevoMamifero, cuidadro1);
                        break;

                    case 2:
                        Console.WriteLine("¿Que animal desea agregar?");
                        nombreAnimal = Console.ReadLine();

                        Console.WriteLine("¿Que especie es este animal?");
                        especieAnimal = Console.ReadLine();
                        Console.WriteLine("¿Que come este animal?");
                        comidaAnimal = Console.ReadLine();
                        Pez nuevoPez = new Pez(nombreAnimal, especieAnimal, comidaAnimal);
                        zoo.agregarAnimal(nuevoPez);
                        zoo.asignarCuidadorAnimal(nuevoPez, cuidadro2);
                        break;
                    case 3:
                        Console.WriteLine("¿Que animal desea agregar?");
                        nombreAnimal = Console.ReadLine();

                        Console.WriteLine("¿Que especie es este animal?");
                        especieAnimal = Console.ReadLine();
                        Console.WriteLine("¿Que come este animal?");
                        comidaAnimal = Console.ReadLine();
                        Ave nuevoAve = new Ave(nombreAnimal, especieAnimal, comidaAnimal);
                        zoo.agregarAnimal(nuevoAve);
                        zoo.asignarCuidadorAnimal(nuevoAve, cuidadro1);
                        break;
                    default:
                        Console.WriteLine("No selecciono ninguno"); break;


                }
                Console.WriteLine("¿Desea continuar?");
                rtaCont = Console.ReadLine();
            } while (rtaCont == "SI");
            
            zoo.mostrarCuidadoress();

            zoo.mostrarAnimales();

            cuidadro1.alimentar();
            cuidadro2.alimentar();









        }
    }
}
