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
    public partial class Restaurante : Form
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frmclientes = new Clientes();
            frmclientes.ShowDialog();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas frmMesas = new Mesas();
            frmMesas.ShowDialog();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insumos frmInsumos = new Insumos();
            frmInsumos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores frmProveedores = new Proveedores();
            frmProveedores.ShowDialog();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puestos frmPuestos = new Puestos();
            frmPuestos.ShowDialog();
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comandas frmComandas = new Comandas();
            frmComandas.ShowDialog();
        }
    }
}
