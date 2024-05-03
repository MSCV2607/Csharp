using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Alquiler_de_Vehículos
{
    internal class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public float Velocidad { get; set; }
        public float Precio { get; set; }
        public DateTime FechaHora { get; set; }

        public Vehiculo(string marca, string modelo, int año, float velocidad, float precio, DateTime fechaHora)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Velocidad = velocidad;
            Precio = precio;
            FechaHora = fechaHora;
        }

        public float CalcularCostoAlquiler(int dias)
        {
            Precio = Precio * dias;
            return Precio;
        }
    }
}

