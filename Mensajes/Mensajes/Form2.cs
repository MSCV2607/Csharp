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

namespace Mensajes
{
    public partial class Form2 : Form
    {
        List<string> cuerpos = new List<string>();
        List<string> personasE = new List<string>();

        public string nombreU;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cambioTexto();
        }

        private void cambioTexto()
        {
            Bienvenida.Text = "Bienvenido al sistema de correspondencia " + nombreU;
        }

        private void Bienvenida_Click(object sender, EventArgs e)
        {
            
        }
        int i = 0;
        int J = 1;
        private void ACEPTARE_Click(object sender, EventArgs e)
        {
            

            personasE.Add(PERSONAEN.Text);
            cuerpos.Add(CUERPO.Text);


            CORREOSENVIADOS.Items.Add("-------------");
            CORREOSENVIADOS.Items.Add("CORREO: " + J);
            CORREOSENVIADOS.Items.Add("Enviado hacia: " + personasE[i]);
            CORREOSENVIADOS.Items.Add("Cuerpo: ");
            CORREOSENVIADOS.Items.Add(cuerpos[i]);
            CORREOSENVIADOS.Items.Add("ENVIADO: " + DateTime.Now);
            CORREOSENVIADOS.Items.Add("-------------");
            i++;
            J++;

        }

        private void CORREOSENVIADOS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void GUARDAR_Click(object sender, EventArgs e)
        {
            i = 0;

            TextWriter guardado = new StreamWriter("Guardadoo.txt");
            
            foreach (var personas in personasE)
            {
                guardado.WriteLine("--------MENSAJE--------");
                guardado.WriteLine("Persona enviada: " + personas);
                guardado.WriteLine("CUERPO: " + cuerpos[i]);
                guardado.WriteLine("\n");

                i++;
            }

            guardado.Close();
            

            
        }
    }
}
