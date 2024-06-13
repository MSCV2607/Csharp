using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        //CUENTA TIEMPO
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
