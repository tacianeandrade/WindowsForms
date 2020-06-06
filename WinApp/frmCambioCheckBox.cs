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
    public partial class frmCambioCheckBox : Form
    {
        public frmCambioCheckBox()
        {
            InitializeComponent();

            lblResultado.Text = String.Empty;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
            // Secção de uma moeda selecionada
            if (chkDollar.Checked == true && chkLibra.Checked == false && chkIene.Checked == false && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text;
            }

            if (chkDollar.Checked == false && chkLibra.Checked == true && chkIene.Checked == false && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text;
            }

            if (chkDollar.Checked == false && chkLibra.Checked == false && chkIene.Checked == true && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text;
            }

            if (chkDollar.Checked == false && chkLibra.Checked == false && chkIene.Checked == false && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }


            //Secção de duas moedas selecionadas

            //dolar e libra
            if (chkDollar.Checked == true && chkLibra.Checked == true && chkIene.Checked == false && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                + "\n" + 
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text;
            }

            //dolar e iene
            if (chkDollar.Checked == true && chkLibra.Checked == false && chkIene.Checked == true && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text;
            }

            //dolar e SEK
            if (chkDollar.Checked == true && chkLibra.Checked == false && chkIene.Checked == false && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //libra e iene
            if (chkDollar.Checked == false && chkLibra.Checked == true && chkIene.Checked == true && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text;
            }

            //libra e sek
            if (chkDollar.Checked == false && chkLibra.Checked == true && chkIene.Checked == false && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //sek e iene
            if (chkDollar.Checked == false && chkLibra.Checked == false && chkIene.Checked == true && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //Secção de três moedas selecionadas

            //dolar, libra, iene
            if (chkDollar.Checked == true && chkLibra.Checked == true && chkIene.Checked == true && chkSek.Checked == false)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text;
            }

            //dolar, libra, sek
            if (chkDollar.Checked == true && chkLibra.Checked == true && chkIene.Checked == false && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //dolar, iene, sek
            if (chkDollar.Checked == true && chkLibra.Checked == false && chkIene.Checked == true && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //libra, iene, sek
            if (chkDollar.Checked == false && chkLibra.Checked == true && chkIene.Checked == true && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                 + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }

            //Secção de quatro moedas selecionadas
            if (chkDollar.Checked == true && chkLibra.Checked == true && chkIene.Checked == true && chkSek.Checked == true)
            {
                lblResultado.Text = Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.dollar)), 3).ToString() + " " + chkDollar.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.libra)), 3).ToString() + " " + chkLibra.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.iene)), 3).ToString() + " " + chkIene.Text
                + "\n" +
                Math.Round((double.Parse(tbxValor.Text) * double.Parse(Properties.Resources.sek)), 3).ToString() + " " + chkSek.Text;
            }
        }
    }
}
