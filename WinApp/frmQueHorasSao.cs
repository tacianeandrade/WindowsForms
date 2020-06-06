using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinApp
{
    public partial class frmQueHorasSao : Form
    {
        Timer timer = new Timer();
		
        public frmQueHorasSao()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.t_Tick);
            timer.Start();


            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            rdbAutomatico.Checked = true;
            btnAtualizar.Enabled = false;

        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            pgbHoras.Value = hh;
            pgbMinutos.Value = mm;
            pgbSegundos.Value = ss;

            lblHoras.Text = hh.ToString() + " horas";
            lblMinutos.Text = mm.ToString() + " minutos";
            lblSegundos.Text = ss.ToString() + " segundos";
        }

        private void rdbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;
            timer.Start();
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            timer.Stop();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(timer.Enabled == false)
            {
                timer.Start();

                int hh = DateTime.Now.Hour;
                int mm = DateTime.Now.Minute;
                int ss = DateTime.Now.Second;

                pgbHoras.Value = hh;
                pgbMinutos.Value = mm;
                pgbSegundos.Value = ss;

                lblHoras.Text = hh.ToString() + " horas";
                lblMinutos.Text = mm.ToString() + " minutos";
                lblSegundos.Text = ss.ToString() + " segundos";

                timer.Stop();
            }
        }
    }
}
