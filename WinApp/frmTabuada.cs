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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();

            nudTabuada.Value = 1;
            lblResultado.Text = String.Empty;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            redimensionarJanela(300, 313);

            if (lblResultado.Text != null || lblResultado.Text != String.Empty)
            {
                lblResultado.Text = String.Empty;
            }

            for (int i = 1; i <= 10; i++)
            {
                lblResultado.Text = lblResultado.Text + nudTabuada.Value.ToString() + " x " + i.ToString() +  " = " + (i * double.Parse(nudTabuada.Value.ToString())).ToString() + "\n";
            }
        }

        private void redimensionarJanela(int comprimento, int altura)
        {
            this.Width = comprimento;
            this.Height = altura;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = String.Empty;
            nudTabuada.Value = 1;
            redimensionarJanela(300, 126);
        }
    }
}
