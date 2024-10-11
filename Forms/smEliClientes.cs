using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LinxAdmo.Forms
{
    public partial class smEliClientes : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public smEliClientes()
        {
            
            InitializeComponent();
        }

        public void limpiar()
        {

            txtIdCliente.Clear();
            txtNombreC.Clear();
            txtDirecc.Clear();
            txtTelefon.Clear();
            txtLCredi.Clear();

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                int idClientes = Convert.ToInt32(txtIdCliente.Text);

                string consulta = "SELECT * FROM Clientes WHERE Id_Cliente=('" + txtIdCliente.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                SqlDataReader registros = comando.ExecuteReader();

                if (registros.Read())
                {

                    txtNombreC.Text = registros["Nombre"].ToString();
                    txtTelefon.Text = registros["Telefono"].ToString();
                    txtLCredi.Text = registros["LimCredito"].ToString();
                    txtDirecc.Text = registros["Direccion"].ToString();
                    btnEliminar.Enabled = true;
                    sqlcon.Close();
                   
                }
                else
                {
                    MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo.");
                    txtDirecc.Enabled = false;
                    txtNombreC.Enabled = false;
                    txtTelefon.Enabled = false;
                    txtLCredi.Enabled = false;
                    btnBusca.Enabled = true;
                    btnEliminar.Enabled = false;
                    limpiar();
                    sqlcon.Close();

                }

            }
            catch (Exception l)
            {
                MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo." + " " + l);
                btnEliminar.Enabled = false;
                sqlcon.Close();

            }

        }

        private void smEliClientes_Load(object sender, EventArgs e)
        {
            txtTelefon.Enabled = false;
            txtLCredi.Enabled = false;
            txtDirecc.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreC.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                    string MensajeBox = "¿Realmente desea eliminar este cliente?";
                    string Titulo = "Linx Systems| Confirmacion de Eliminacion";
                    MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                if (Respuesta == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    sqlcon.Open();
                    int IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    string consulta = "DELETE FROM Clientes WHERE IdCliente='" + IdCliente + "'";
                    SqlCommand comando = new SqlCommand(consulta, this.sqlcon);
                    int cant;
                    cant = comando.ExecuteNonQuery();

                    if (cant == 1)
                    {
                        MessageBox.Show("La información del cliente se elimino correctamente.");
                        limpiar();
                        btnEliminar.Enabled = false;
                        btnBusca.Enabled = true;
                        txtIdCliente.Enabled = true;
                        txtDirecc.Enabled = false;
                        txtNombreC.Enabled = false;
                        txtTelefon.Enabled = false;
                        txtLCredi.Enabled = false;
                        this.sqlcon.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se elimino el cliente.");
                        this.sqlcon.Close();
                    }

                }
                else
                {
                    MessageBox.Show("No se elimino el cliente.");
                    sqlcon.Close();
                }

            }catch(Exception l)
            {
                MessageBox.Show("Ocurrio un error al eliminar al cliente" + " " + l);
                sqlcon.Close();
            }
        }
    }
}
