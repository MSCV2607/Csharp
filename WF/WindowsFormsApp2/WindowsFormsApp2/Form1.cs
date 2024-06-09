using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int a = 0;
        private int elapsedSeconds = 0;
        public Form1()
        {
            InitializeComponent();
            // Configurar Timer
            timer1.Interval = 1000; // 1 segundo
            timer1.Enabled = false;

            // Configurar Button
            button3.Text = "Start Timer";

            // Configurar Label
            label1.Text = "0";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Incrementar el contador de segundos
            elapsedSeconds++;
            // Actualizar el Label con el tiempo transcurrido en segundos
            label1.Text = elapsedSeconds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button3.Text = "Start";
            }
            else
            {
                timer1.Start();
                button3.Text = "Stop";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        
    }
}
