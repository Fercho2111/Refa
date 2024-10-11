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
    public partial class FrmEdiUsuarios : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public FrmEdiUsuarios()
        {
            InitializeComponent();
        }

        private void smEdiUsuarios_Load(object sender, EventArgs e)
        {
            txtNombreU.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefon.Enabled = false;
            txtDirecc.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            txtTUsuario.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void limpiar()
        {

            txtNombreU.Clear();
            txtApellidos.Clear();
            txtTelefon.Clear();
            txtDirecc.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtIdUsuario.Clear();
            txtTUsuario.Items.Clear();
            txtNombreU.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefon.Enabled = false;
            txtDirecc.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            txtTUsuario.Enabled = false;
            btnEditar.Enabled = false;

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            try
            {

                sqlcon.Open();

                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);


                string consulta = "SELECT * FROM Usuarios WHERE Id=('" + idUsuario + "')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                SqlDataReader registros = comando.ExecuteReader();

                if (registros.Read())
                {

                    txtNombreU.Text = registros["Nombre"].ToString();
                    txtApellidos.Text = registros["Apellido"].ToString();
                    txtDirecc.Text = registros["Domicilio"].ToString();
                    txtTelefon.Text = registros["Telefono"].ToString();
                    txtUsuario.Text = registros["Usuario"].ToString();
                    txtContra.Text = registros["Contra"].ToString();
                    txtTelefon.Text = registros["Telefono"].ToString();
                    txtTUsuario.Text = registros["tUsuario"].ToString();

                    txtNombreU.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtTelefon.Enabled = true;
                    txtDirecc.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContra.Enabled = true;
                    txtTUsuario.Enabled = true;
                    btnEditar.Enabled = true;
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo.");
                    limpiar();
                    sqlcon.Close();

                }

            }
            catch (Exception l)
            {
                MessageBox.Show("No existe un cliente con ese Id o Nombre, Intente de nuevo." + " " + l);
                sqlcon.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeBox = "¿Realmente desea actualizar la informacion de este usuario?";
                string Titulo = "Linx Systems| Confirmacion de Actualizacion";
                MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                DialogResult Respuesta;
                Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question);

                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                if (idUsuario == 10)
                {
                    MessageBox.Show("NO PUEDE EDITAR ESTE USUARIO,CONTACTE A SISTEMAS");
                
                    limpiar();
                }
                else
                {

                    if (Respuesta == DialogResult.Yes)
                    {
                        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                        sqlcon.Open();

                        int IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                        string Nombre = txtNombreU.Text;
                        string Apellido = txtApellidos.Text;
                        string Domicilio = txtDirecc.Text;
                        string Telefono = txtTelefon.Text;
                        string Usuario = txtUsuario.Text;
                        string Contra = txtContra.Text;
                        int tUsuario = Convert.ToInt32(txtTUsuario.Text);

                        string consulta = "UPDATE Usuarios SET  Nombre='" + Nombre + "', Apellido='" + Apellido + "', Domicilio='" + Domicilio + "',Telefono='" + Telefono + "',Usuario='" + Usuario + "',Contra='" + Contra + "',tUsuario='" + tUsuario + "' WHERE Id='" + IdUsuario + "' ";
                        SqlCommand comando = new SqlCommand(consulta, sqlcon);
                        int cant;
                        cant = comando.ExecuteNonQuery();

                        if (cant == 1)
                        {

                            MessageBox.Show("La información del cliente se actualizo correctamente.");
                            limpiar();
                            sqlcon.Close();

                        }
                        else
                        {
                            MessageBox.Show("La informacion del cliente no fue actualizada.");
                            btnEditar.Enabled = false;
                            btnBusca.Enabled = true;
                            txtIdUsuario.Enabled = true;
                            sqlcon.Close();
                        }

                    }
                    else
                    {

                        MessageBox.Show("La informacion del cliente no fue actualizada.");
                        btnEditar.Enabled = false;
                        btnBusca.Enabled = true;
                        txtIdUsuario.Enabled = true;
                        sqlcon.Close();
                    }
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("La informacion del cliente no fue actualizada." + l);
                sqlcon.Close();

            }
        }
    }
}


