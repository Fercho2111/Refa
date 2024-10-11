using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using LinxAdmo.Forms;

namespace LinxAdmo
{
    public partial class smClientes : Form
    {
        public smClientes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
            sqlcon.Open();

            try
            {

                string Nombre = txtNombre.Text;
                string Direccion = txtDireccion.Text;
                string Telefono = txtTelefono.Text;
                decimal LCredito = Convert.ToDecimal(txtLCredito.Text);
                txtLCredito.Text = LCredito.ToString("N2");
             



                string consulta = "INSERT INTO Clientes(Nombre,Direccion,Telefono,LimCredito) VALUES ('" + Nombre + "','" + Direccion + "','" + Telefono + "','" + LCredito + "') ";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente guardado correctamente");
                sqlcon.Close();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtLCredito.Clear();

            }catch(Exception l)
            {
                MessageBox.Show("El Cliente no fue registrado correctamentes" + l);
            }
            
        }

        private void smClientes_Load(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;

        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            FrmEdiClientes smeditaCliente = new FrmEdiClientes();
            smeditaCliente.ShowDialog();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            FrmEliClientes EliClientes = new FrmEliClientes();
            EliClientes.ShowDialog();
        }
    }
}
