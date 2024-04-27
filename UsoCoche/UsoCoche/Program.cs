using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoche
{
    internal class Program
    {
        static void Main(string[] args)
        {

            auto auto1 = new auto(); //Creo un objeto o instancia. Da un estado inicial al coche
            auto auto2 = new auto();
            auto auto3 = new auto(4500.25,1200.35);

            Console.WriteLine(auto1.getRuedas());
            Console.WriteLine(auto2.informacion());
            Console.WriteLine(auto3.informacion());

            auto3.setExtras(true, "CUERO");
            Console.WriteLine(auto3.getExtra());


        }
    }

    class auto
    {
        private int rueda;
        private double largo;
        private double ancho;

        private bool climatizador;
        private string tapiceria;

        //CONSTRUCTOR DA EL ESTADO INICIAL DE UN OBJETO
        public auto()
        {
            rueda = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "tela";
        }
        //CONSTRUCTOR DA EL ESTADO INICIAL DE UN OBJETO
        public auto(double largoCoche, double anchoCoche)
        {
            rueda = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";
        }

        //GET --> DAR -- DA EL NUMERO DE RUEDAS
        public int getRuedas()
        {
            return rueda;
        }

        //SER --> METODO SETTER PARA ESTABLECER. NO DEVOLVER NADA. DA VALOR A LAS PROPIEDADES
        public void setExtras(bool paramClimatizador, String paramTapiceria)
        {
            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
        }

        public String getExtra()
        {
            return "Extras del coche: \n" + "Tapiceria: " + tapiceria + "\nClimatizador" + climatizador;
        }

        public String informacion()
        {
            return "Informacion del coche:\n" + "Ruedas: " +rueda+ "\nLargo: " + largo + "\nAncho: " + ancho;
        }



    }

}
