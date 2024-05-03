using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Alquiler_de_Vehículos
{
    internal class Moto : Vehiculo, IRapido
    {
       
        public string Color { get; set; }
        public float Tanque { get; set; }

        public Moto(string marca, string modelo, int año, float velocidad, float precio, DateTime fechaHora, string color, float tanque) : base(marca, modelo, año, velocidad, precio, fechaHora)
        {
            Color = color;
            Tanque = tanque;
        }

        public void potencia()
        {
            Console.WriteLine($"La moto viaja a: {Velocidad} km por hora");
        }

        public void impresion()
        {
            Console.WriteLine("\nMUY BUENA ELECCION");
            Console.WriteLine("Vehiculo: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año del vehiculo: " + Año);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tiene un tanque de: " + Tanque);
            potencia();
            Console.WriteLine("Dia de alquilado: " + DateTime.Now);
            Console.WriteLine("TOTAL A PAGAR: $" + Precio);
        }
    }
}
