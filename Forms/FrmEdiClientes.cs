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

namespace LinxAdmo.Forms
{
    public partial class FrmEdiClientes : Form
    {
        public FrmEdiClientes()
        {
            InitializeComponent();
        }

        private void smEdiClientes_Load(object sender, EventArgs e)
        {
            txtTelefon.Enabled = false;
            txtLCredi.Enabled = false;
            txtDirecc.Enabled = false;
            btnactualiza.Enabled = false;
            txtNombreC.Enabled = false;
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
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                sqlcon.Open();

                int idClientes =Convert.ToInt32(txtIdCliente.Text);
             

                string consulta= "SELECT * FROM Clientes WHERE IdCliente=('"+txtIdCliente.Text+"')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                SqlDataReader registros = comando.ExecuteReader();

                if (registros.Read())
                {

                    txtNombreC.Text = registros["Nombre"].ToString();
                    txtTelefon.Text = registros["Telefono"].ToString();
                    txtLCredi.Text = registros["LimCredito"].ToString();
                    txtDirecc.Text = registros["Direccion"].ToString();
                    txtDirecc.Enabled = true;
                    txtNombreC.Enabled = true;
                    txtTelefon.Enabled = true;
                    txtLCredi.Enabled = true;
                    btnactualiza.Enabled = true;
                    btnBusca.Enabled = false;
                    txtIdCliente.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo.");
                    txtDirecc.Enabled = false;
                    txtNombreC.Enabled = false;
                    txtTelefon.Enabled = false;
                    txtLCredi.Enabled = false;
                    btnactualiza.Enabled = false;
                    btnBusca.Enabled = true;
                    sqlcon.Close();

                }

            }catch(Exception l)
            {
                MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo." + " " + l);
            }
            

        }

        private void btnactualiza_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeBox = "¿Realmente desea actualizar la informacion de este cliente?";
                string Titulo = "Linx Systems| Confirmacion de Actualizacion";
                MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                DialogResult Respuesta;
                Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                    sqlcon.Open();

                    int IdCLiente = Convert.ToInt32(txtIdCliente.Text);
                    string Nombre = txtNombreC.Text;
                    string Direccion = txtDirecc.Text;
                    string Telefono = txtTelefon.Text;
                    decimal LCredito = Convert.ToDecimal(txtLCredi.Text);
                    txtLCredi.Text = LCredito.ToString("N2");

                    string consulta = "UPDATE Clientes SET  Nombre='" + Nombre + "', Direccion='" + Direccion + "',Telefono='" + Telefono + "',LimCredito='" + LCredito + "' WHERE IdCliente='" + IdCLiente + "' ";
                    SqlCommand comando = new SqlCommand(consulta, sqlcon);
                    int cant;
                    cant = comando.ExecuteNonQuery();

                    if (cant == 1)
                    {

                        MessageBox.Show("La información del cliente se actualizo correctamente.");
                        limpiar();
                        btnactualiza.Enabled = false;
                        btnBusca.Enabled = true;
                        txtIdCliente.Enabled = true;
                        txtDirecc.Enabled = false;
                        txtNombreC.Enabled = false;
                        txtTelefon.Enabled = false;
                        txtLCredi.Enabled = false;
                        sqlcon.Close();

                    }
                    else
                    {
                        MessageBox.Show("La informacion del cliente no fue actualizada.");
                        btnactualiza.Enabled = false;
                        btnBusca.Enabled = true;
                        txtIdCliente.Enabled = true;
                        sqlcon.Close();
                    }
                 
                }
                else
                {

                    MessageBox.Show("La informacion del cliente no fue actualizada.");
                    btnactualiza.Enabled = false;
                    btnBusca.Enabled = true;
                    txtIdCliente.Enabled = true;
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("La informacion del cliente no fue actualizada." + l);
             
            }

        }
    }
}
