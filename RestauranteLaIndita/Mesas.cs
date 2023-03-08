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
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");

        private void Mesas_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from Mesas", conexion);
            SqlDataReader lector;
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Mesas", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdMesa.Text = Convert.ToString(total);

            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvMesas.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString());
            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string nombre = txtNombre.Text;

            string cadena = "insert into Mesas (Nombre) values ('" + nombre + "' )";

            MessageBox.Show(cadena);


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtNombre.Text = "";
            comando.CommandText = "Select * from Mesas";
            SqlDataReader lector;

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Mesas", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdMesa.Text = Convert.ToString(total);
            dgvMesas.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvMesas.Rows.Add(lector.GetValue(0),
                lector.GetValue(1));

            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * From Mesas Where  IdMesa =" + Convert.ToInt32(txtIdMesa2.Text), conexion);
            SqlDataReader lector;

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtNombre2.Text = lector[1].ToString();

            }
            conexion.Close();

            btnModificar.Enabled = true;
            txtNombre2.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Update Mesas set Nombre ='" + txtNombre2.Text + "' WHERE IdMesa =" + Convert.ToInt32(txtIdMesa2.Text);
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se modificaron correctamente");
            dgvMesas.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Mesas", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();
            while (lector.Read())
                dgvMesas.Rows.Add(lector.GetValue(0),
                lector.GetValue(1));

            conexion.Close();
        }
    }
}
