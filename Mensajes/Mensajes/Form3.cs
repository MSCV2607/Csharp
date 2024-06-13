using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensajes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        public string nombre;
        public string contrasena;

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = USUARIO.Text;
            contrasena = CONTRASENA.Text;

            Close();
        }

        private void CONTRASENA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void USUARIO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
