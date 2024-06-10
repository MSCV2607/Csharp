using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();

        }

        //IMPORTANTE
        private void InitializeTimer()
        {
            // Inicializar la hora de inicio
            startTime = DateTime.Now;
            // Iniciar el Timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Calcular el tiempo transcurrido y actualizar el Label
            TimeSpan elapsedTime = DateTime.Now - startTime;
            label1.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            form2.nombre = textBox1.Text;

        }
        string nombre;
        
        Form2 form2 = new Form2();
        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + nombre);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void WF2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
