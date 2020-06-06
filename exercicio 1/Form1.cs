using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            Limpar.Visible = false;
        }

        private void Clique_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " " + textBox2.Text;
            label1.Visible = true;
            Limpar.Visible = true;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Text = " ";
            textBox2.Text = " ";
            Limpar.Visible = false;
        }
    }
}
