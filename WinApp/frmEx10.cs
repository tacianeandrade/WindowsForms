using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmEx10 : Form
    {
        public frmEx10()
        {
            InitializeComponent();

            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Retira Espaços: " + Util.Funcoes.RetiraEspacos(textBox1.Text);

            label2.Text = "Substitui: " + Util.Funcoes.RetiraEspacos(Util.Funcoes.Substitui(textBox1.Text));

            //label3.Text = "Hobbie Moda: " + Util.Funcoes.HobbieModa("a","a","b","c","c","c","c","d","d","d");
        }
    }
}
