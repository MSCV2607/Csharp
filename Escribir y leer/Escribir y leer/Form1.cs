using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//IMPORTANTE
using System.IO;

namespace Escribir_y_leer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Escribir_Click(object sender, EventArgs e)
        {
            //Aca escribo -- TextWriter y StreanWriter necesitan de using.IO;
            TextWriter Escribe = new StreamWriter("Test.txt");
            Escribe.WriteLine("Hola mundo");
            Escribe.Close();

            //Agregar nueva linea
            StreamWriter agregar = File.AppendText("Test.txt");
            agregar.WriteLine("Linea 2");
            agregar.Close();

        }
        List<string> lineas = new List<string>();
        private void Leer_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("Test.txt");

            //Este lee solo una linea
            //MessageBox.Show(Leer.ReadLine());

            //LEE TODO EL ARCHIVO
            //MessageBox.Show(Leer.ReadToEnd());


            

            //LISTA
            string linea;
            while ((linea = Leer.ReadLine()) != null)
            {
                lineas.Add(linea);
            }
            Leer.Close();
        }

        private void LISTA_Click(object sender, EventArgs e)
        {
            foreach(var  item in lineas)
            {
                MessageBox.Show(item);
            }
        }
    }
}
