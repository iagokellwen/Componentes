using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_DateTimePick : Form
    {
        public F_DateTimePick()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;
            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }

        private void btn_setarData_Click_1(object sender, EventArgs e)
        {
            int d, m, a;
            d = Convert.ToInt32(tb_dia.Text);
            m = Convert.ToInt32(tb_mes.Text);
            a = Convert.ToInt32(tb_ano.Text);



            DateTime dt = new DateTime(a, m, d);
            dtp_data.Value = dt;
        }
    }
}
