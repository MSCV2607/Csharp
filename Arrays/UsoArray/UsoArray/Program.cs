using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] edades = new int[4];
            
            edades[0] = 15;
            edades[1] = 10;
            edades[2] = 20;
            edades[3] = 30;
            

            //Inicializar y poner datos -- int[] edades = { 15, 16, 17, 18};

            //Accede al lugar 2 del array (20)
            //Console.WriteLine(edades[2]);

            //Array implicito, no indicamos ni tipos ni lugares
            var datos = new[] { "Mauro", "Sebastian", "Argentina" };
            //C# sabe que es un String de 3 espacios 


            //Arrays de objetos
            empleados[] arrayEmpleados = new empleados[2];
            //Creo objeto en el array
            arrayEmpleados[0] = new empleados("Sara", 18);

            //Creo Objeto
            empleados Anna = new empleados("Ana", 27);
            //Almaceno objeto en Array
            arrayEmpleados[1] = Anna;



            //Arrays de tipos anonimos -- el objeto es anonimo solo sabe que va por lo que le pasamos
            var personas = new[]
            {
                new{Nombre="Juan", edad=19},
                new{Nombre="Maria", edad = 20},
                new{Nombre="Dian", edad = 35}
            };
            //Asi puedo acceder a los datos anonimos 
            //Console.WriteLine("La persona se llama: " + personas[0].Nombre + " \ny tiene: " + personas[0].edad);


            //RECORRIDO DEL ARRAY EDADES
            for(int i =0;  i < edades.Length; i++) {
                Console.WriteLine(edades[i]);
            }

            //RECORRIDO DEL ARRAY EMPLEADOS
            for(int i = 0; i < arrayEmpleados.Length;i++)
            {
                Console.WriteLine("Los nombres de los empleados son: "+arrayEmpleados[i].decirNombre());
            }


            //foreach + (objeto + variable [cualquier nombre] + in + el nombre del array)
            foreach(empleados variable in arrayEmpleados)
            {
                //variable de abajo es lo musmo que el de arriba y lo ponemos nosotros al nombre
                Console.WriteLine(variable.decirNombre());
            }

        }
    }

    //Objeto empleados
    class empleados
    {
        private String nombre { get; set; }
        int edad { get; set; }

        public empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String decirNombre()
        {
            return nombre;
        }

    }
}
