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
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();

            // definir limites máximos e mínimos no calendário
            mCalendarMin.MaxDate = DateTime.Now.AddDays(-1);
            mCalendarMax.MinDate = DateTime.Now.AddDays(1);
        }

        private void mCalendarMin_DateChanged(object sender, DateRangeEventArgs e)
        {
            calcularData(mCalendarMin);
        }

        private void mCalendarMax_DateChanged(object sender, DateRangeEventArgs e)
        {
            calcularData(mCalendarMax);
        }

        private void calcularData(MonthCalendar m)
        {
            int dias = mCalendarMax.SelectionStart.Day - mCalendarMin.SelectionStart.Day;
            int meses = mCalendarMax.SelectionStart.Month - mCalendarMin.SelectionStart.Month;
            int anos = (mCalendarMax.SelectionStart.Year - mCalendarMin.SelectionStart.Year - 1) +
                       (((mCalendarMax.SelectionStart.Month > mCalendarMin.SelectionStart.Month) ||
                       ((mCalendarMax.SelectionStart.Month == mCalendarMin.SelectionStart.Month) && (mCalendarMax.SelectionStart.Day >= mCalendarMin.SelectionStart.Day))) ? 1 : 0);

            DateTime a = m.SelectionStart;

            if (dias < 0) { // se a diferença dos dias é negativa 
                dias = dias + DateTime.DaysInMonth(m.SelectionStart.Year, m.SelectionStart.Month); // devolve o número de dias
                meses = meses - 1; // e depois retira 1 ao valor dos meses

                if (meses < 0)
                { // se depois de retirar 1 ao valor dos meses, der um valor negativo
                    meses = 0; // o valor de mês é igual a 0
                }
            }

            if (meses < 0) { // se a diferença dos meses é negativa 
                meses = meses + 12;
                anos = anos - 1;

                if (anos < 0) { // se a diferença dos anos é negativa 
                    anos = 0;
                }
            }

            lblDias.Text = dias.ToString() + " dias";
            lblMeses.Text = meses.ToString() + " meses";
            lblanos.Text = anos.ToString() + " anos";            
        }
    }
}
