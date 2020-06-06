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
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblCumprimento.Text = txtCumprimento.Text + " " + txtNome.Text;
            lblCumprimento.Visible = true;

            btnLimpar.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblCumprimento.Text = String.Empty;

            txtCumprimento.Text = String.Empty;
            txtNome.Text = String.Empty;

            lblCumprimento.Visible = false;
            btnLimpar.Visible = false;
        }
    }
}
