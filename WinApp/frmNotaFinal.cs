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
    public partial class frmNotaFinal : Form
    {
        public frmNotaFinal()
        {
            InitializeComponent();
            carregaRecursos();
        }

        /// <summary>
        /// Carrega o texto de todos os elementos a apresentar 
        /// </summary>
        private void carregaRecursos()
        {
            gbTestes.Text = Properties.Resources.gbTestes;
            gbTrabPraticos.Text = Properties.Resources.gbTrabPraticos;

            lblTeste1.Text = Properties.Resources.lblTeste1;
            lblTeste2.Text = Properties.Resources.lblTeste2;

            lblTrab1.Text = Properties.Resources.lblTrab1;
            lblTrab2.Text = Properties.Resources.lblTrab2;

            lblTrabFinal.Text = Properties.Resources.lblTrabFinal;

            btnCalcular.Text = Properties.Resources.btnCalcular;
            btnLimpar.Text = Properties.Resources.btnLimpar;
        }

        /// <summary>
        /// Método para calcular e apresentar a média final
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double notaTestes = Convert.ToDouble(Properties.Resources.peso1) * ((Convert.ToInt32(txtTeste1.Text) + Convert.ToInt32(txtTeste2.Text))/2);
            double notaTrabalhos = Convert.ToDouble(Properties.Resources.peso2) * ((Convert.ToInt32(txtTrab1.Text) + Convert.ToInt32(txtTrab2.Text)) / 2);
            double notaTrabFinal = Convert.ToDouble(Properties.Resources.peso3) * Convert.ToInt32(txtTrabFinal.Text);
            double notaFinal        = notaTestes + notaTrabalhos + notaTrabFinal;

            lblMediaFinal.Text = Properties.Resources.lblMediaFinal +  Math.Round(notaFinal, 2).ToString();
            lblMediaFinal.Visible = true;

            btnLimpar.Visible = true;
        }
        /// <summary>
        /// Método para colocar o formulário no seu estado inicial
        /// </summary>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCaixasTexto();

            lblMediaFinal.Text = String.Empty;
            btnLimpar.Visible = false;
        }

        /// <summary>
        /// Limpa todas as caixas de texto do formulário
        /// </summary>
        private void limparCaixasTexto()
        {
            //limpa as caixas de texto do formulário-base
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = String.Empty;
            }

            //limpa as caixas de texto do groupbox dos testes
            foreach (Control ctrl in gbTestes.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = String.Empty;
            }

            //limpa as caixas de texto do groupbox dos trabalhos
            foreach (Control ctrl in gbTrabPraticos.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = String.Empty;
            }
        }
    }
}
