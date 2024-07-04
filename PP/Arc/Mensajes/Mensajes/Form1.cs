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
    public partial class Form1 : Form, Interface1
    {
        Form3 registro = new Form3 ();
        Form2 sesion = new Form2 ();

        

        public List<string> usuario = new List<string> ();
        public List<string> contrasena = new List<string> ();

        bool errorU = false;
        bool errorC = false;

        bool usuarioEncontrado = false;
        bool contraEncontrada = false;

        string nombreU;
        

        public Form1()
        {
            InitializeComponent();
            escribirT();
            
        }

        private void InicioSesion_Click(object sender, EventArgs e)
        {
            nuevoUsuario();
            nombreU = USUARIOX.Text;

            sesion.nombreU = USUARIOX.Text;


            foreach (var lista in usuario)
            {
                if(lista == USUARIOX.Text)
                {
                    foreach(var contraseña in contrasena)
                    {
                        if (contraseña == CONTRASENA.Text)
                        {
                            contraEncontrada = true;
                            
                        } 
                    }
                } else { usuarioEncontrado = true;  }
            } 

            if(contraEncontrada && usuarioEncontrado)
            {
                
                sesion.Show();
                

            } else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            registro.Show();
        }

        private void USUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void CONTRASENA_TextChanged(object sender, EventArgs e)
        {

        }

        private void escribirT()
        {
            /* ESTO ES PARA CREAR LOS ARCHIVOS PERO YA NO NECESITO
            TextWriter textoU = new StreamWriter("USUARIO.txt");
            TextWriter textoC = new StreamWriter("CONTRASENA.txt");
            */

            TextReader textoLU = new StreamReader("USUARIO.txt");
            TextReader textoLC = new StreamReader("CONTRASENA.txt");

            string linea;

            while((linea = textoLU.ReadLine()) != null)
            {
                usuario.Add(linea);
               
            }

            while ((linea = textoLC.ReadLine()) != null)
            {
                contrasena.Add(linea);
                
            }

            textoLU.Close();
            textoLC.Close();
        }

        private void nuevoUsuario()
        {
            usuario.Add(registro.nombre);
            contrasena.Add(registro.contrasena);
        }

        public void cerrar()
        {
            Close();
        }

        private void CIERRA_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
