﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RPARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string texto = "HOLA";
        string palabraX;

        int palabras = 0;
        int caracteresSE = 0;
        int caracteresCE = 0;

        //ARRAY STRING para las palabras encontradas
        string[] palabrasEncontradas;


        //APRENDER
        private void Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opemFile = new OpenFileDialog();
            opemFile.ShowDialog();
            string path = opemFile.FileName;
            textBox1.Text = File.ReadAllText(path);
            texto = textBox1.Text;
            
        }

        private void contarPyC()
        {
            for (int i = 0; i < texto.Length; i++)
            {

                
                if (texto[i] == ' ')
                {
                    palabras++;
                } 
                caracteresCE++;
                

            }
            caracteresSE = caracteresCE - palabras;
        }


        List<int> numVe;
        int numR = 0;
        private void contarPal()
        {
            palabrasEncontradas = Regex.Split(texto.ToLower(), @"\W+");

            Dictionary<string, int> conteo = new Dictionary<string, int>();

            foreach (string palabra in palabrasEncontradas)
            {
                if (palabra != "")
                {
                    if (conteo.ContainsKey(palabra))
                    {
                        conteo[palabra]++;
                    }
                    else
                    {
                        conteo[palabra] = 1;
                    }
                }
            }

            var palabraMasRepetida = conteo.OrderByDescending(x => x.Value).FirstOrDefault();

            listBox1.Items.Clear();
            foreach (var item in conteo)
            {
                listBox1.Items.Add($"{item.Key}: {item.Value}");
            }

            MessageBox.Show($"La palabra más repetida es '{palabraMasRepetida.Key}' con {palabraMasRepetida.Value} repeticiones.");
        }

        

        private void INFO_Click(object sender, EventArgs e)
        {
            contarPyC();
            contarPal();
            

            

            dataGridView1.Rows.Add(palabras,caracteresSE,caracteresCE);

            //MessageBox.Show(palabrasEncontradas[1]);

            palabras = 0;
            caracteresCE = 0;
            caracteresSE = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
