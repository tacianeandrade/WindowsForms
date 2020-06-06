using System;
using System.Collections;
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
    public partial class frmMeusHobbies : Form
    {
        Form frmHobbiesConfirm = new Form();
        Label lblHobbiesConfirm = new Label();
        RichTextBox rtbHobbiesConfirm = new RichTextBox();
        Button btnHobbiesConfirm = new Button();

        public frmMeusHobbies()
        {
            InitializeComponent();
        }

        private void frmMeusHobbies_Load(object sender, EventArgs e)
        {
            rtbHobbies.ReadOnly = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Form
            frmHobbiesConfirm.Text = "Meus Hobbies - Confirmação";
            frmHobbiesConfirm.Controls.Add(lblHobbiesConfirm);
            frmHobbiesConfirm.Controls.Add(rtbHobbiesConfirm);
            frmHobbiesConfirm.Controls.Add(btnHobbiesConfirm);

            // Label
            lblHobbiesConfirm.AutoSize = true;
            lblHobbiesConfirm.Location = new System.Drawing.Point(13, 15);
            lblHobbiesConfirm.Name = "lblHobbiesConfirm";
            lblHobbiesConfirm.Text = "Os seus Hobbies são:";

            // RichTextBox
            rtbHobbiesConfirm.Location = new System.Drawing.Point(13, 30);
            rtbHobbiesConfirm.Name = "rtbHobbiesConfirm";
            rtbHobbiesConfirm.Size = new System.Drawing.Size(259, 178);
            rtbHobbiesConfirm.ReadOnly = true;

            // Botão
            btnHobbiesConfirm.Location = new System.Drawing.Point(12, 220);
            btnHobbiesConfirm.Name = "btnHobbiesConfirm";
            btnHobbiesConfirm.Size = new System.Drawing.Size(260, 23);
            btnHobbiesConfirm.TabIndex = 0;
            btnHobbiesConfirm.Text = "Confirmar";

            // Associar um evento ao botão
            btnHobbiesConfirm.Click += new System.EventHandler(btnHobbiesConfirm_Click);

            // escrever o texto na textBox
            rtbHobbiesConfirm.Text = escrever();

            frmHobbiesConfirm.Show();
        }

        private string escrever()
        {
            string texto = "";

            foreach (Control c in this.Controls) //percorre todos os controlos do formulário
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked) // verifica se as checkboxes estão selecionadas
                {
                    texto = texto + c.Text + Environment.NewLine; // coloca o texto das texboxes numa string
                }
                else
                {
                    texto = texto + "";
                }
            }

            return texto;
        }

        private void btnHobbiesConfirm_Click(object sender, EventArgs e)
        {
            frmHobbiesConfirm.Hide();
        }
    }
}