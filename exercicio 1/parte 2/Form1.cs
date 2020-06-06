using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parte_2
{
    public partial class Fahrenheit : Form
    {
        public Fahrenheit()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string resposta = textBox1.Text;
            double valor = Convert.ToDouble(resposta);

            double temp = 0;

            temp = (valor - 32) / 1.8;
            textBox2.Text = Convert.ToString(temp);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
