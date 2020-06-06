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
    public partial class frmArvore : Form
    {
        public frmArvore()
        {
            InitializeComponent();

            lblArvore.Text = "";
            redimensionarJanela(157, 108);
        }

        private void btnArvore_Click(object sender, EventArgs e)
        {
            decimal cont = nudValor.Value;
            redimensionarJanela(368, 260);

            while(cont > 0)
            {
                for(decimal i = 0; i <= (nudValor.Value - cont); i++)
                {
                    lblArvore.Text = lblArvore.Text + "*";
                }
                lblArvore.Text = lblArvore.Text + "\n";

                cont--;
            }
            lblArvore.Text = "\n" + lblArvore.Text + "||\n||"; 
        }

        private string constroiNo(string texto, int nivel, int max)
        {
            string novoTexto = "*";

            // coloca os espaços antes dos asteriscos
            for (int i = 0; i <= (max - nivel); i++)
            {
                novoTexto = novoTexto + " ";
            }

            // coloca os asteriscos
            for (int i = 0; i < nivel; i++)
            {
                novoTexto = novoTexto + "*";
            }

            // coloca os espaços depois dos asteriscos
            for (int i = 0; i <= (max - nivel); i++)
            {
                novoTexto = novoTexto + " ";
            }

            return novoTexto + "\n";
        }

        private void redimensionarJanela(int comprimento, int largura)
        {
            this.Width = comprimento;
            this.Height = largura;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblArvore.Text = "";
            redimensionarJanela(157, 108);
        }
    }
}
