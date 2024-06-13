using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMEr
{
    public partial class Form1 : Form
    {
        private int segundos;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++; // Incrementa el contador de segundos
            label1.Text = $"Segundos transcurridos: {segundos}"; // Actualiza el texto del label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            segundos = 0;
        }
    }
}
