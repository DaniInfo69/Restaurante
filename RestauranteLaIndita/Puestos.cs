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
    public partial class Puestos : Form
    {
        public Puestos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from Puestos", conexion);
            SqlDataReader lector;
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Puestos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdPuesto.Text = Convert.ToString(total);

            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvPuestos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString());
            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * From Puestos Where  IdPuesto =" + Convert.ToInt32(txtIdPuesto2.Text), conexion);
            SqlDataReader lector;

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtPuesto2.Text = lector[1].ToString();

            }
            conexion.Close();

            btnModificar.Enabled = true;
            txtPuesto2.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Update Puestos set Puesto ='" + txtPuesto2.Text + "' WHERE IdPuesto =" + Convert.ToInt32(txtIdPuesto2.Text);
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se modificaron correctamente");
            dgvPuestos.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Puestos", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();
            while (lector.Read())
                dgvPuestos.Rows.Add(lector.GetValue(0),
                lector.GetValue(1));

            conexion.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Puesto = txtPuesto.Text;

            string cadena = "insert into Puestos (Puesto) values ('" + Puesto + "' )";

            MessageBox.Show(cadena);


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtPuesto.Text = "";
            comando.CommandText = "Select * from Puestos";
            SqlDataReader lector;

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Puestos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdPuesto.Text = Convert.ToString(total);
            dgvPuestos.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvPuestos.Rows.Add(lector.GetValue(0),
                lector.GetValue(1));

            conexion.Close();
        }
    }
}
