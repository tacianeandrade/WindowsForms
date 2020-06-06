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
using Microsoft.VisualBasic;

namespace WinApp
{
    public partial class frmHobbies : Form
    {
        ArrayList arrlHhobbies = new ArrayList(); // inicializa e instancia um ArrayList
        public frmHobbies()
        {
            InitializeComponent();           
        }

        private void btnHobbies_Click(object sender, EventArgs e)
        {
            rtbHobbies.Enabled = false;

            // acidiona cada um dos hobbies no ArrayList
            arrlHhobbies.AddRange(rtbHobbies.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
        }

        private void btnSumario_Click(object sender, EventArgs e)
        {
            string hobbies = "Inseriu um total de " + arrlHhobbies.Count + " hobbies" + Environment.NewLine + Environment.NewLine;

            foreach (string hobby in arrlHhobbies)
            {
                hobbies = hobbies + hobby + Environment.NewLine;
            }
            MessageBox.Show(hobbies);
        }
    }
}
