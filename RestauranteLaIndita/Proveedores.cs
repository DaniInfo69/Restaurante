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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");


        private void Proveedores_Load(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * from Proveedores", conexion);
            SqlDataReader lector;
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Proveedores", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdCliente.Text = Convert.ToString(total);

            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvProveedores.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString());
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
            string contacto = txtContacto.Text;
            string cp = txtCP.Text;
            string ciudad = txtCiudad.Text;
            string colonia = txtColonia.Text;
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;

            string cadena = "insert into Proveedores (Nombre, Contacto, CP, Ciudad, Colonia, Domicilio, Telefono) values ('" + nombre + "' , '" + contacto + "' , '" + cp + "' , '" + ciudad + "' , '" + colonia + "' , '" + domicilio + "' , '" + telefono + "')";

            MessageBox.Show(cadena);


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtNombre.Text = "";
            txtContacto.Text = "";
            txtCP.Text = "";
            txtCiudad.Text = "";
            txtColonia.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            comando.CommandText = "Select * from Proveedores";
            SqlDataReader lector;

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Proveedores", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdCliente.Text = Convert.ToString(total);
            dgvProveedores.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvProveedores.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString());

            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * From Proveedores Where  IdProveedor =" + Convert.ToInt32(txtIdProveedor2.Text), conexion);
            SqlDataReader lector;

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtNombre2.Text = lector[1].ToString();
                txtContacto2.Text = lector[2].ToString();
                txtCP2.Text = lector[3].ToString();
                txtCiudad2.Text = lector[4].ToString();
                txtColonia2.Text = lector[5].ToString();
                txtDomicilio2.Text = lector[6].ToString();
                txtTelefono2.Text = lector[7].ToString();
            }
            conexion.Close();

            btnModificar.Enabled = true;
            txtNombre2.Enabled = true;
            txtContacto2.Enabled = true;
            txtCP2.Enabled = true;
            txtCiudad2.Enabled = true;
            txtColonia2.Enabled = true;
            txtDomicilio2.Enabled = true;
            txtTelefono2.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Update Proveedores set Nombre ='" + txtNombre2.Text + "', Contacto ='" + txtContacto2.Text +
                "', CP ='" + txtCP2.Text + "', Ciudad = '" + txtCiudad2.Text + "', Colonia = '" + txtColonia2.Text +
                "', Domicilio = '" + txtDomicilio2.Text + "', Telefono = '" + txtTelefono2.Text + "' WHERE IdProveedor =" + Convert.ToInt32(txtIdProveedor2.Text);
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se modificaron correctamente");
            dgvProveedores.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Proveedores", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();
            while (lector.Read())
                dgvProveedores.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2), lector.GetValue(3),
                lector.GetValue(4), lector.GetValue(5), lector.GetValue(6),
                lector.GetValue(7));

            conexion.Close();
        }
    }
}
