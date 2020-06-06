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
    public partial class frmNomeEmail : Form
    {
        public frmNomeEmail()
        {
            InitializeComponent();
            
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            this.Height = 176;

            if (tbxNomeCompleto.Text != String.Empty) {
                tbxNomeCompleto.Text = String.Empty;
            }

            lblTxtNome.Text = String.Empty;
            lblTxtEmail1.Text = String.Empty;
            lblTxtEmail2.Text = String.Empty;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Height = 352;

            lblTxtNome.Text = Util.Funcoes.NomeCurto(tbxNomeCompleto.Text);
            lblTxtEmail1.Text = Util.Funcoes.Email(tbxNomeCompleto.Text);
            lblTxtEmail2.Text = Util.Funcoes.EmailAlternativo(tbxNomeCompleto.Text);
        }

        //private string nomeCurto(string nomeCompleto)
        //{
        //    string primParteNome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
        //    string ultParteNome = nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ") + 1);

        //    return String.Concat(primParteNome, " ", ultParteNome);
        //}

        //private string Email(string nomeCompleto)
        //{
        //    return nomeCompleto.Substring(0, nomeCompleto.IndexOf(" ")).ToLower() + "." + nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ")+1).ToLower() + "@xpto.pt";
        //}

        //private string EmailAlternativo(string nomeCompleto)
        //{
        //    return nomeCompleto.Substring(0, 1).ToLower() + nomeCompleto.Substring(nomeCompleto.LastIndexOf(" ") + 1).ToLower() + "@xpto.pt";
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inicializarFormulario();
        }
    }
}
