using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restapropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resta RESTA = new resta();
            RESTA.V1 = double.Parse(textBox1.Text);
            RESTA.V2 = double.Parse(textBox2.Text);

            textBox3.Text = RESTA.restar().ToString();
        }
    }
}
