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
    public partial class frmCambioDropDown : Form
    {
        public frmCambioDropDown()
        {
            InitializeComponent();

            lblResultado.Text = String.Empty;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            switch (cmbxMoeda.Text.ToLower())
            {
                case "dollar":
                    lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + cmbxMoeda.Text;
                    break;
                case "libra":
                    lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + cmbxMoeda.Text;
                    break;
                case "iéne":
                    lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + cmbxMoeda.Text;
                    break;
                case "sek":
                    lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + cmbxMoeda.Text;
                    break;
                default:
                    lblResultado.Text = "";
                    break;
            }
        }
    }
}
