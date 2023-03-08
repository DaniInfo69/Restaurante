using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteLaIndita
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Descripcion = txtDescripcion.Text;
            string Unidad = cboUnidad.Text;


            string cadena = "insert into Insumos (Descripcion, Existencias, Maximo, Minimo, Costo, Unidad) values ('" + Descripcion + "' , '" + txtExistencias.Text + "' , '" + txtMaximo.Text + "' , '" + txtMinimo.Text + "' , '" + txtCosto.Text + "' , '" + Unidad + "' )";

            MessageBox.Show(cadena);


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtDescripcion.Text = "";
            txtExistencias.Text = "";
            txtMaximo.Text = "";
            txtMinimo.Text = "";
            txtCosto.Text = "";
            cboUnidad.Text = "";

            comando.CommandText = "Select * from Insumos";
            SqlDataReader lector;

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Insumos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdInsumo.Text = Convert.ToString(total);
            dgvInsumos.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvInsumos.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString());

            conexion.Close();
        }

        private void Insumos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from Insumos", conexion);
            SqlDataReader lector;
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Insumos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdInsumo.Text = Convert.ToString(total);
            dgvInsumos.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvInsumos.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString());
            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * From Insumos Where  IdInsumo =" + Convert.ToInt32(txtIdInsumo2.Text), conexion);
            SqlDataReader lector;

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtDescripcion2.Text = lector[1].ToString();
                txtExistencias2.Text = lector[2].ToString();
                txtMaximo2.Text = lector[3].ToString();
                txtMinimo2.Text = lector[4].ToString();
                txtCosto2.Text = lector[5].ToString();
                cboUnidad2.Text = lector[6].ToString();
            }
            conexion.Close();

            btnModificar.Enabled = true;
            txtDescripcion2.Enabled = true;
            txtExistencias2.Enabled = true;
            txtMaximo2.Enabled = true;
            txtMinimo2.Enabled = true;
            txtCosto2.Enabled = true;
            cboUnidad2.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Update Insumos set Descripcion ='" + txtDescripcion2.Text + "', Existencias ='" + txtExistencias2.Text +
                "', Maximo ='" + txtMaximo2.Text + "', Minimo = '" + txtMinimo2.Text + "', Costo = '" + txtCosto2.Text +
                "', Unidad = '" + cboUnidad2.Text + "' WHERE IdInsumo =" + Convert.ToInt32(txtIdInsumo2.Text);
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se modificaron correctamente");
            dgvInsumos.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Insumos", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();
            while (lector.Read())
                dgvInsumos.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2), lector.GetValue(3),
                lector.GetValue(4), lector.GetValue(5), lector.GetValue(6));

            conexion.Close();
        }
    }
}
