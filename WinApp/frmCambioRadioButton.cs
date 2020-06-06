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
    public partial class frmCambioRadioButton : Form
    {
        public frmCambioRadioButton()
        {
            InitializeComponent();

            tbxValor.Text = "0";
            lblResultado.Text = "";
            rdbDollar.Checked = true;
            rdbIene.Checked = false;
            rdbLibra.Checked = false;
            rdbSek.Checked = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rdbDollar.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + rdbDollar.Text;                
            }
            else if (rdbIene.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + rdbIene.Text;
            }
            else if (rdbLibra.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + rdbLibra.Text;
            }
            else if (rdbSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + rdbSek.Text;
            }
        }
    }
}
