using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ta_Te_Ti
{
    public partial class Form1 : Form
    {

        string jugador1 = "JUGADOR 1";
        string jugador2 = "JUGADOR 2";
        int victoriasJ1 = 0;
        int victoriasJ2 = 0;
        bool turno = true;
        bool victoria = false;
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
        }

        //IMPORTANTE
        private void InitializeTimer()
        {
            // Inicializar la hora de inicio
            startTime = DateTime.Now;
            // Iniciar el Timer
            tiempoJuego.Start();
            label1.Visible=true;
        }

        



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jugador1 = J1.Text;
            jugador2 = J2.Text;

            Ju1.Text = jugador1 + ": " + victoriasJ1.ToString();
            Ju2.Text = jugador2 + ": " + victoriasJ2.ToString();

            InitializeTimer();

        }

        private void actualziacion()
        {
            Ju1.Text = jugador1 + ": " + victoriasJ1.ToString();
            Ju2.Text = jugador2 + ": " + victoriasJ2.ToString();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B1.Text = "X";
                turno = false;
                
                B1.BackColor = Color.Red;
                victoriaMagistral();
            } else
            {
                B1.Text = "O";
                turno = true;
                
                B1.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B2.Text = "X";
                turno = false;
                victoriaMagistral();
                B2.BackColor = Color.Red;
            }
            else
            {
                B2.Text = "O";
                turno = true;
                victoriaMagistral();
                B2.BackColor = Color.Green;

            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B3.Text = "X";
                turno = false;
                
                B3.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B3.Text = "O";
                turno = true;
                
                B3.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B4.Text = "X";
                turno = false;
                
                B4.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B4.Text = "O";
                turno = true;
                
                B4.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B5.Text = "X";
                turno = false;
                
                B5.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B5.Text = "O";
                turno = true;
                
                B5.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B6.Text = "X";
                turno = false;
                
                B6.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B6.Text = "O";
                turno = true;
                
                B6.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B7.Text = "X";
                turno = false;
                
                B7.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B7.Text = "O";
                turno = true;
                
                B7.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B8.Text = "X";
                turno = false;
                
                B8.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B8.Text = "O";
                turno = true;
                
                B8.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (turno)
            {
                B9.Text = "X";
                turno = false;
                
                B9.BackColor = Color.Red;
                victoriaMagistral();
            }
            else
            {
                B9.Text = "O";
                turno = true;
                
                B9.BackColor = Color.Green;
                victoriaMagistral();
            }
        }

        private void victoriaMagistral()
        {
            if (B1.Text == "X" && B1.Text == B2.Text && B2.Text == B3.Text
                || B4.Text == "X" && B4.Text == B5.Text && B5.Text == B6.Text
                || B7.Text == "X" && B7.Text == B8.Text && B8.Text == B9.Text
                || B1.Text == "X" && B1.Text == B5.Text && B5.Text == B9.Text
                || B3.Text == "X" && B3.Text == B5.Text && B5.Text == B7.Text
                || B1.Text == "X" && B1.Text == B4.Text && B4.Text == B7.Text
                || B2.Text == "X" && B2.Text == B5.Text && B5.Text == B8.Text) 
            {
                victoria = true;
                
                victoriasJ1++;
                MessageBox.Show("Ganador: " + jugador1);
                reinicio();
                actualziacion();

            } else if (B1.Text == "O" && B1.Text == B2.Text && B2.Text == B3.Text
                || B4.Text == "O" && B4.Text == B5.Text && B5.Text == B6.Text
                || B7.Text == "O" && B7.Text == B8.Text && B8.Text == B9.Text
                || B1.Text == "O" && B1.Text == B5.Text && B5.Text == B9.Text
                || B3.Text == "O" && B3.Text == B5.Text && B5.Text == B7.Text
                || B1.Text == "O" && B1.Text == B4.Text && B4.Text == B7.Text
                || B2.Text == "O" && B2.Text == B5.Text && B5.Text == B8.Text)
            {
                victoria = true;
                
                victoriasJ2++;
                MessageBox.Show("Ganador: " + jugador2);
                reinicio();
                actualziacion();
            }

        }

        private void reinicio()
        {
            B1.Text = "";
            B1.BackColor = Color.White;

            B2.Text = "";
            B2.BackColor = Color.White;

            B3.Text = "";
            B3.BackColor = Color.White;

            B4.Text = "";
            B4.BackColor = Color.White;

            B5.Text = "";
            B5.BackColor = Color.White;

            B6.Text = "";
            B6.BackColor = Color.White;

            B7.Text = "";
            B7.BackColor = Color.White;

            B8.Text = "";
            B8.BackColor = Color.White;

            B9.Text = "";
            B9.BackColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ju1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void tiempoJuego_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            label1.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }
    }
}
