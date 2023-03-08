using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteLaIndita
{
    public partial class Comandas : Form
    {
        public Comandas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaComandas frmConsultaComandas = new ConsultaComandas();
            frmConsultaComandas.ShowDialog();
        }
    }
}
