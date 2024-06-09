using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_V1._0
{
    public partial class Form1 : Form
    {
        string Snum1;
        int Inum1;

        bool num1 = true;

        string Snum2;
        int Inum2;

        int resultado;

        string simbolo;

        List<int> numerosG = new List<int>();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "1";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "1";
                label1.Text = Snum2;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "2";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "2";
                label1.Text = Snum2;
            }

        }

        private void B3_Click_1(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "3";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "3";
                label1.Text = Snum2;
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "4";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "4";
                label1.Text = Snum2;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "5";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "5";
                label1.Text = Snum2;
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "6";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "6";
                label1.Text = Snum2;
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "7";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "7";
                label1.Text = Snum2;
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "8";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "8";
                label1.Text = Snum2;
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "9";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "9";
                label1.Text = Snum2;
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (num1 == true)
            {
                Snum1 += "0";
                label1.Text = Snum1;
            }
            else
            {
                Snum2 += "0";
                label1.Text = Snum2;
            }
        }


        private void Enter_Click(object sender, EventArgs e)
        {

            if (num1 == true)
            {
                Inum1 = Convert.ToInt32(Snum1);
                num1 = false;

            }
            else
            {
                Inum2 = Convert.ToInt32(Snum2);
                num1 = true;
            }



        }

        private void SUMA_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);
            simbolo = "+";


        }

        private void RESTA_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);
            simbolo = "-";

        }

        private void MULTIPLICACION_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);
            simbolo = "*";
        }

        private void DIVISON_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);
            simbolo = "/";
        }

        private void MODULO_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);
            simbolo = "%";
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            Enter_Click(sender, e);

            switch (simbolo)
            {
                case "+":
                    resultado = Inum1 + Inum2;
                    break;
                case "-":
                    resultado = Inum1 - Inum2;
                    break;
                case "*":
                    resultado = Inum1 * Inum2;
                    break;
                case "/":
                    resultado = Inum1 / Inum2;
                    break;
                case "%":
                    resultado = Inum1 % Inum2;
                    break;
            }
            label1.Text = resultado.ToString();
            numerosG.Add(resultado);

            Snum1 = "";
            Snum2 = "";

            Inum1 = 0;
            Inum2 = 0;

            num1 = true;

            simbolo = "";



            // Limpiar los elementos actuales en el ComboBox
            HISTORIAL.Items.Clear();

            // Agregar todos los números guardados en la lista al ComboBox
            foreach (int num in numerosG)
            {
                HISTORIAL.Items.Add(num);
            }

            Snum1 = "";
            Snum2 = "";

            Inum1 = 0;
            Inum2 = 0;

            num1 = true;

            simbolo = "";

        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void HISTORIAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HISTORIAL.SelectedItem != null)
            {
                label1.Text = HISTORIAL.SelectedItem.ToString();
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void COLOR1_Click(object sender, EventArgs e)
        {
            splitContainer1.BackColor = Color.MistyRose;
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.PeachPuff;
                    button.ForeColor = Color.Black;
                }
            }
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.PeachPuff;
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void COLOR2_Click(object sender, EventArgs e)
        {
            splitContainer1.BackColor = Color.Green;
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.LightGreen;
                    button.ForeColor = Color.Black;
                }
            }
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.LightGreen;
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void COLOR3_Click(object sender, EventArgs e)
        {
            splitContainer1.BackColor = Color.Lavender;
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.Thistle;
                    button.ForeColor = Color.Black;
                }
            }
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.Thistle;
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.BackColor = Color.FromKnownColor(KnownColor.ScrollBar);  // Color original del splitContainer
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SystemColors.Control;  // Restablecer al color de control predeterminado
                    button.ForeColor = SystemColors.ControlText;  // Restablecer al color de texto de control predeterminado
                }
            }
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SystemColors.Control;  // Restablecer al color de control predeterminado
                    button.ForeColor = SystemColors.ControlText;  // Restablecer al color de texto de control predeterminado
                }
            }
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
