using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SIMON
{
    public partial class SIMON : Form
    {

        int controlSecuencia = 0;
        Random numeroAleatorio;

        List<int> SimonDice = new List<int>();
        bool hablando = false;

        public SIMON()
        {
            InitializeComponent();
            numeroAleatorio = new Random();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void IniciarJuego()
        {
            Thread.Sleep(200);
            hablando = true;

            foreach (int ParteActiva in SimonDice)
            {
                switch (ParteActiva)
                {
                    case 0:
                        B0.BackColor = Color.White;
                        Thread.Sleep(500);
                        B0.BackColor = Color.Red;
                        break;
                    case 1:
                        B1.BackColor = Color.White;
                        Thread.Sleep(500);
                        B1.BackColor = Color.Blue;
                        break;
                    case 2:
                        B2.BackColor = Color.White;
                        Thread.Sleep(500);
                        B2.BackColor = Color.Yellow;
                        break;
                    case 3:
                        B3.BackColor = Color.White;
                        Thread.Sleep(500);
                        B3.BackColor = Color.Green;
                        break;
                }
                Thread.Sleep(200);
            }
            hablando = false;
        }

        public void verificarPresionado(int valor)
        {
            if (hablando || SimonDice.Count == 0)
            {
                return;
            }
            if (controlSecuencia < SimonDice.Count && SimonDice[controlSecuencia] == valor)
            {
                controlSecuencia++;
            }
            else
            {
                MessageBox.Show("\tPerdiste \nTu puntuación fue de: " + SimonDice.Count);
                controlSecuencia = 0;
                SimonDice = new List<int>();
            }
            if (controlSecuencia >= SimonDice.Count)
            {
                controlSecuencia = 0;
                SimonDice.Add(numeroAleatorio.Next(0, 4));
                new Thread(IniciarJuego).Start();
            }
            lbl_puntos.Text = "Puntos: " + SimonDice.Count.ToString();
        }

        private void Star_Click(object sender, EventArgs e)
        {
            SimonDice.Clear();
            controlSecuencia = 0;
            SimonDice.Add(numeroAleatorio.Next(0, 4));
            new Thread(IniciarJuego).Start();
        }

        private void B0_Click(object sender, EventArgs e)
        {
            verificarPresionado(0);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            verificarPresionado(1);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            verificarPresionado(2);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            verificarPresionado(3);
        }

        private void SIMON_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void B0_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void B0_MouseHover(object sender, EventArgs e)
        {

        }

        private void B0_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

