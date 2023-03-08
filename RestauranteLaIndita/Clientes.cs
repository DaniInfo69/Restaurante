using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestauranteLaIndita
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string colonia = txtColonia.Text;
            string domicilio = txtDomicilio.Text;
            string cp = txtCP.Text;

            string cadena = "insert into Clientes (Nombre, Apellidos, Telefono, Colonia, DomicilioCliente, CP) values ('" + nombre + "' , '" + apellidos + "' , '" + telefono + "' , '" + colonia + "' , '" + domicilio + "' , '" + cp + "' )";

            MessageBox.Show(cadena);


            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtColonia.Text = "";
            txtDomicilio.Text = "";
            txtCP.Text = "";
            comando.CommandText = "Select * from Clientes";
            SqlDataReader lector;

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdCliente.Text = Convert.ToString(total);
            dgvClientes.Rows.Clear();
            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString());

            conexion.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * from Clientes", conexion);
            SqlDataReader lector;
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdCliente.Text = Convert.ToString(total);

            lector = comando.ExecuteReader();
            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString());
            conexion.Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * From Clientes Where  IdCliente =" + Convert.ToInt32(txtIdCliente2.Text), conexion);
            SqlDataReader lector;

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtNombre2.Text = lector[1].ToString();
                txtApellidos2.Text = lector[2].ToString();
                txtTelefono2.Text = lector[3].ToString();
                txtColonia2.Text = lector[4].ToString();
                txtDomicilio2.Text = lector[5].ToString();
                txtCP2.Text = lector[6].ToString();
            }
            conexion.Close();

            btnModificar.Enabled = true;
            txtTelefono2.Enabled = true;
            txtColonia2.Enabled = true;
            txtDomicilio2.Enabled = true;
            txtCP2.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Update Clientes set Nombre ='" + txtNombre2.Text + "', Apellidos ='" + txtApellidos2.Text + 
                "', Telefono ='" + txtTelefono2.Text + "', Colonia = '" + txtColonia2.Text + "', DomicilioCliente = '" + txtDomicilio2.Text + 
                "', CP = '" + txtCP2.Text + "' WHERE IdCliente =" + Convert.ToInt32(txtIdCliente2.Text);
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se modificaron correctamente");
            dgvClientes.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Clientes", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();
            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2), lector.GetValue(3),
                lector.GetValue(4), lector.GetValue(5), lector.GetValue(6));

            conexion.Close();

        }
    }
}

