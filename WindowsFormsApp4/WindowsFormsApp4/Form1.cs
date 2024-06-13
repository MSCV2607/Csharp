using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<String> nombres = new List<String>();

        public void agregarLsita()
        {
            nombres.Add("Mato");
            nombres.Add("Pal");
        }

        public Form1()
        {
            InitializeComponent();
            //Agrego a comboBox
            comboBox1.Items.Add("Pal");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
