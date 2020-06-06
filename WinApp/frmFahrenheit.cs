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
    public partial class frmFahrenheit : Form
    {
        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double conta = (Convert.ToInt32(txtFahrenheit.Text) - 32) / 1.8;
            txtCelsius.Text = Math.Round(conta, 2).ToString();
        }

        private void btnNovoCalculo_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Text = String.Empty;
            txtCelsius.Text = String.Empty;
        }
    }
}
