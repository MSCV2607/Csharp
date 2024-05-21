using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    internal class AvisosTrafico : IAvisos
    {
        public string getFecha()
        {
            return $"{DateTime.Now}";
        }

        public void mostrarAviso()
        {
            Console.WriteLine($"El mensaje: {mensaje} \nFue enviado por: {remitente} \nEl dia {fecha}");
        }

        private string remitente;
        private string mensaje;
        private DateTime fecha;

        //Mensaje por defecto
        public AvisosTrafico()
        {
            remitente = "Direccion general de trafico";
            mensaje = $"Pague antes de estos proximos 3 dias y tendra reduccion del 52%";
            fecha = DateTime.Now;
        }

        public AvisosTrafico(string remitente, string mensaje, DateTime fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
    }
}
