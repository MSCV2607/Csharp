using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Juego_de_la_Memoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            crearListaArchivo();



            foreach (var animales  in animales)
            {
                listBox1.Items.Add(animales);
            }

            
        }

        Random random = new Random();
        List<string> animales = new List<string>();

        String nombreR;


        /*
        private void crearLista()
        {
            animales.Add("Leon");
            animales.Add("Leon");
            animales.Add("Jirafa");
            animales.Add("Jirafa");
            animales.Add("Leopardo");
            animales.Add("Leopardo");
            animales.Add("Hipopotamo");
            animales.Add("Hipopotamo");
            animales.Add("Aguila");
            animales.Add("Aguila");
            animales.Add("Lemur");
            animales.Add("Lemur");
            animales.Add("Pinguino");
            animales.Add("Pinguino");
            animales.Add("Cebra");
            animales.Add("Cebra");
            animales.Add("Carpincho");
            animales.Add("Carpincho");
            animales.Add("Nutria");
            animales.Add("Nutria");
        }
        */
        string linea;
        private void crearListaArchivo()
        {
            TextReader Leer = new StreamReader("Animales.txt");
            
            while ((linea  = Leer.ReadLine()) != null)
            {
                animales.Add(linea);
            }

            Leer.Close();
        }

        private void asignacion()
        {
            random.Next(0,19);
            //nombreR = animales.IndexOf(random);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
