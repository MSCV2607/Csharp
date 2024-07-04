using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorTextoLorem2._0
{
    public partial class Form1 : Form
    {
        int pal;
        int parr;
        int orac = 4;

        Random rand = new Random();

        List<string> palabras = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string path = openFile.FileName;
            TextReader leer = new StreamReader(path);

            //Escribo lo que esta en el archivo en una lista

            string linea;
            while ((linea = leer.ReadLine()) != null)
            {
                palabras.Add(linea);
            }

            foreach (string palabras in palabras)
            {
                listPalaabras.Items.Add(palabras);
            }
        }

        private void generar_Click(object sender, EventArgs e)
        {
            if(palabra.Checked)
            {
                generarPal();
            }

            if (parrafo.Checked) { 
                generarParr();
            }
        }

        private void generarPal()
        {
            //int valor = (int)numericUpDown1.Value;
            pal = int.Parse(cant.Text);
            string txt = "";
            

            for (int i = 0; i < pal; i++)
            {
                int randomIndex = rand.Next(1, palabras.Count);

                if(i==0)
                {
                    if (lorem.Checked)
                    {
                        txt += "Lorem ipsum dolor sit amet consectetur adipiscing elit";
                        i = 8;
                    }
                }

                if (i == 0)
                {
                    string palabra = palabras[randomIndex];
                    if (palabra.Length > 0)
                    {
                        txt = char.ToUpper(palabra[0]) + palabra.Substring(1);
                    }
                }

                if (i != 0)
                {
                    txt += " " + palabras[randomIndex];
                    if (i == pal - 1)
                    {
                        txt += ".";
                    }
                }


            }

            textoGenerado.Text = txt;
        }

        private void generarParr()
        {
            
            parr = int.Parse(cant.Text);

            //int randomIndex = rand.Next(1, palabras.Count);
            int randomOra = rand.Next(5, 30);
            string txt = " ";

            //ORACION
            for (int j = 0; j < parr; j++)
            {
                txt += " \n";
                for (int i = 0; i < randomOra; i++)
                {

                    
                    int randomIndex = rand.Next(1, palabras.Count);


                    if (i == 0)
                    {
                        string palabra = palabras[randomIndex];
                        if (palabra.Length > 0)
                        {
                            txt += char.ToUpper(palabra[0]) + palabra.Substring(1);
                        }
                    }

                    if (i != 0)
                    {
                        txt += " " + palabras[randomIndex];
                        if (i == randomOra - 1)
                        {
                            txt += ".\r\n";
                        }
                    }
                    

                }
            }
            textoGenerado.Text = txt;


        }

        private void guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text File|*.txt"; // Filtro para archivos de texto
            saveFile.Title = "Guardar texto generado"; // Título del cuadro de diálogo
            saveFile.ShowDialog();

            // Si el usuario seleccionó una ubicación y un nombre de archivo
            if (saveFile.FileName != "")
            {
                // Escribir el contenido del TextBox en el archivo seleccionado
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    writer.Write(textoGenerado.Text);
                }
            }
        }

        private void parrafo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void informacion_Click(object sender, EventArgs e)
        {
            int contadorC = 0;
            int contadorP = 0;
            int contadorParr = 0;

            string txt = " ";

            txt = textoGenerado.Text;

            foreach(char texto in txt)
            {
                contadorC++;

                if (texto == ' ' || texto == '.')
                {
                    contadorP++;
                }
            }

            
            

            if (parrafo.Checked)
            {
                contadorParr = int.Parse(cant.Text);      
            } else
            {
                contadorParr = 1;
            }


            MessageBox.Show("En el texto generado hay: " + contadorC + " \ncaracteres" + " En el texto generado hay: " + contadorP + " palabras" + "\nY hay " + contadorParr);
        }
    }

}

