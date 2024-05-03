using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sistema_de_Gestión_de_Alquiler_de_Vehículos
{
    internal class Auto:Vehiculo,IRapido
    {
        public int Puertas { get; set; }
        public string Color { get; set; }

        public Auto(string marca, string modelo, int año, float velocidad, float precio, DateTime fechaHora, int puertas, string color) : base(marca, modelo, año, velocidad, precio, fechaHora)
        {
            Puertas = puertas;
            Color = color;
        }

        public void potencia()
        {
            Console.WriteLine($"El auto viaja a: {Velocidad} km por hora");
        }

        public void impresion()
        {
            Console.WriteLine("\nMUY BUENA ELECCION");
            Console.WriteLine("Vehiculo: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año del vehiculo: " + Año);
            Console.WriteLine("Color: " + Color);
            potencia();
            Console.WriteLine("Dia de alquilado: " + DateTime.Now);
            Console.WriteLine("TOTAL A PAGAR: $" + Precio);
        }
    }
}
