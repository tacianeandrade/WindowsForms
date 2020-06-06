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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            //para iniciar o formulário a ocupar a janela completa
            WindowState = FormWindowState.Maximized;
        }

        private void cumprimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCumprimentos fc = new frmCumprimentos();
            fc.MdiParent = this;
            fc.Show();
        }

        private void fahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFahrenheit fh = new frmFahrenheit();
            fh.MdiParent = this;
            fh.Show();
        }

        private void calcularNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaFinal fn = new frmNotaFinal();
            fn.MdiParent = this;
            fn.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que quer sair?", "A Encerrar...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nomeEEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomeEmail fn = new frmNomeEmail();
            fn.MdiParent = this;
            fn.Show();
        }

        private void queHorasSãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueHorasSao fn = new frmQueHorasSao();
            fn.MdiParent = this;
            fn.Show();
        }

        private void quantoTempoPassouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantoTempoPassou fn = new frmQuantoTempoPassou();
            fn.MdiParent = this;
            fn.Show();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioRadioButton fn = new frmCambioRadioButton();
            fn.MdiParent = this;
            fn.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioCheckBox fn = new frmCambioCheckBox();
            fn.MdiParent = this;
            fn.Show();
        }

        private void dropDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioDropDown fn = new frmCambioDropDown();
            fn.MdiParent = this;
            fn.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuada fn = new frmTabuada();
            fn.MdiParent = this;
            fn.Show();
        }

        private void árvoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArvore fn = new frmArvore();
            fn.MdiParent = this;
            fn.Show();
        }

        private void hobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHobbies fn = new frmHobbies();
            fn.MdiParent = this;
            fn.Show();
        }

        private void meusHobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusHobbies fn = new frmMeusHobbies();
            fn.MdiParent = this;
            fn.Show();
        }

        private void exercício10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx10 fn = new frmEx10();
            fn.MdiParent = this;
            fn.Show();
        }
    }
}
