using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Alquiler_de_Vehículos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rta;
            int dias;

            Moto moto1 = new Moto("Honda", "CBR500R", 2021, 180, 50, DateTime.Now, "Negro", 16);
            Moto moto2 = new Moto("Yamaha", "MT-07", 2020, 200, 40, DateTime.Now, "Blanco", 14);
            Moto moto3 = new Moto("Kawasaki", "Ninja ZX-6R", 2022, 250, 60, DateTime.Now, "Verde", 17);

            Auto auto1 = new Auto("Toyota", "Corolla", 2022, 180, 70, DateTime.Now, 4, "Gris");
            Auto auto2 = new Auto("Ford", "Mustang", 2023, 250, 100, DateTime.Now, 2, "Rojo");
            Auto auto3 = new Auto("Volkswagen", "Golf", 2021, 200, 80, DateTime.Now, 5, "Azul");

            Console.WriteLine("BIENVENIDO AL SISTEMA DE ALQUILER DE VEHICULOS");
            Console.WriteLine("\n\nCuantos dias alquilara alguno de nuestros vehiculos: ");
            dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione un vehiculo: ");
            Console.WriteLine("1-AUTO");
            Console.WriteLine("2-MOTO");
            rta = Convert.ToInt32(Console.ReadLine());

            switch(rta)
            {
                case 1: Console.WriteLine("----AUTOS----");
                    Console.WriteLine($"Actualmente tenemos para ofrecerle: \n1){auto1.Marca + auto1.Modelo} \n2){auto2.Marca + auto2.Modelo} \n3){auto3.Marca + auto3.Modelo}");
                    rta = Convert.ToInt32(Console.ReadLine());

                    switch(rta)
                    {
                        case 1:
                            auto1.CalcularCostoAlquiler(dias);
                            auto1.impresion();
                            break;
                        case 2:
                            auto2.CalcularCostoAlquiler(dias);
                            auto2.impresion();
                            break;
                        case 3:
                            auto3.CalcularCostoAlquiler(dias);
                            auto3.impresion();
                            break;
                    }


                    break;
                    case 2: Console.WriteLine("----MOTOS----");
                    Console.WriteLine($"Actualmente tenemos para ofrecerle: \n1){moto1.Marca + moto1.Modelo} \n2){moto2.Marca + moto2.Modelo}  \n3){moto3.Marca + moto3.Modelo}");
                    rta = Convert.ToInt32(Console.ReadLine());

                    switch (rta)
                    {
                        case 1:
                            moto1.CalcularCostoAlquiler(dias);
                            moto1.impresion();
                            break;
                        case 2:
                            moto2.CalcularCostoAlquiler(dias);
                            moto2.impresion();
                            break;
                        case 3:
                            moto3.CalcularCostoAlquiler(dias);
                            moto3.impresion();
                            break;
                    }
                    break;


            }
            Console.WriteLine("\nMUCHAS GRACIAS POR UTILIZAR EL SISTEMA QUE TENGA UN MUY BUEN DIA");
            Console.ReadKey();
        }
    }
}
