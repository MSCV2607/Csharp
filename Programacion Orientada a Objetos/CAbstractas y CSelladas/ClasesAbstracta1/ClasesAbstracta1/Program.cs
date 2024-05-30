using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstracta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano("Mauro");
            Caballo caballo = new Caballo("Rolo");

            //Como el numPatas() dejo de ser publico debemos crear un objeto con la interfaz igual a caballo
            IMamiferosTerrestres Icaballo = caballo; //Un caballo es un mamifero terrestre

            Gorilas KingKong = new Gorilas("Kin-Kong");


            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = KingKong;

            for (int i = 0; i < almacenAnimales.Length; i++)
            {
                almacenAnimales[i].pensar();
            }

            Ballena ballena = new Ballena("Wally");
            ballena.nadar();

            //Aca tambien se cambia
            Console.WriteLine("NUMERO DE PATAS DEL CABALLO: " + Icaballo.numPatas());


            Console.WriteLine("-----------------");
            Lagartija lagartija = new Lagartija("Juancho");

            lagartija.getNombre();
            lagartija.respirar();
            Console.WriteLine(" ");
            humano.getNombre();
            humano.respirar();
            


        }
    }

    //Para crear una clase abstracta: abstract + class + nombre
    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        //Como queremos que se implemente un metodo pero va a ser diferente enntre las clases se hace una clase abstracta:
        public abstract void getNombre();
        //[ES COMO UNA INTERFAZ]
    }

    internal interface IAnimalesDeportes
    {
        string tipoDeporte();
        Boolean esOlimpico();
    }

    internal interface IMamiferosTerrestres
    {
        int numPatas();
    }

    internal interface ISaltoConPatas
    {
        int numPatas();
    }

    internal class Mamifero : Animales
    {
        private String nombre;

        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }


        public virtual void pensar()
        {
            Console.WriteLine("PENSAMIENTOS INSTINTIVOS");
        }

        /* YA NO HACE FALTA PORQUE HEREDA DE LA CLASE ABSTRACTA Y ESTE METODO YA LO TENEMOS AHI
        public void respirar()
        {
            Console.WriteLine("SOY CAPAZ DE RESPIRAR");
        }
        */

        public void criarCrias()
        {
            Console.WriteLine("CUIDO A MIS CRIAS HASTA QUE SE PUEDAN CUIDAR SOLOS");
        }

        //NOS OBLIGA A PONER OVERRIDE PARA SOBRESCRIBIR EL METODO ABSTRACTO DE LA CLASE ABSTRACTA HEREDADA 
        public override void getNombre()
        {
            Console.WriteLine("EL NOMBRE DEL MAMIFERO ES: " + nombre);
        }
    }


    internal class Ballena : Mamifero
    {
        public Ballena(string nombre) : base(nombre)
        {
        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }

    internal class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
    {
        public Caballo(string nombre) : base(nombre)
        {
        }

        int IMamiferosTerrestres.numPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numPatas()
        {
            return 2;
        }


        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }


    }
    internal class Gorilas : Mamifero, IMamiferosTerrestres
    {
        public Gorilas(string nombre) : base(nombre)
        {
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento de Gorila");
        }

        public int numPatas()
        {
            return 2;
        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

    internal class Humano : Mamifero
    {

        public Humano(string nombre) : base(nombre)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }



    }

    class Lagartija : Animales
    {
        private string nombreReptil;

        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }

        public override void getNombre()
        {
            Console.WriteLine("EL NOMBRE DEL REPTIL ES: " + nombreReptil);
        }
    }
}
