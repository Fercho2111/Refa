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
    public partial class FrmEliUsuarios : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public FrmEliUsuarios()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {

            txtIdUsuario.Clear();
            txtNombreU.Clear();
            txtDirecc.Clear();
            txtTelefon.Clear();

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            try
            {

                sqlcon.Open();

                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);


                string consulta = "SELECT * FROM Usuarios WHERE Id=('" + txtIdUsuario.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                SqlDataReader registros = comando.ExecuteReader();

                if (registros.Read())
                {

                    txtNombreU.Text = registros["Nombre"].ToString();
                    txtTelefon.Text = registros["Telefono"].ToString();
                    txtDirecc.Text = registros["Domicilio"].ToString();
                    btnEliminar.Enabled = true;
                    sqlcon.Close();

                }
                else
                {
                    MessageBox.Show("No existe un Usuario con ese Id o Nombre, Intente de nuevo.");
                    txtDirecc.Enabled = false;
                    txtNombreU.Enabled = false;
                    txtTelefon.Enabled = false;
                    btnBusca.Enabled = true;
                    btnEliminar.Enabled = false;
                    Limpiar();
                    sqlcon.Close();
                }
               
            }
            catch (Exception l)
            {
                MessageBox.Show("No existe un usuario con ese Id o Nombre, Intente de nuevo." + " " + l);
                btnEliminar.Enabled = false;
                sqlcon.Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdiUsuario = Convert.ToInt32(txtIdUsuario.Text);
                if (IdiUsuario == 10)
                {
                    MessageBox.Show("NO PUEDE ELIMINAR ESTE USUARIO");
                }
                else
                {
                    string MensajeBox = "¿Realmente desea eliminar este usuario?";
                    string Titulo = "Linx Systems| Confirmacion de Eliminacion";
                    MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                    DialogResult Respuesta;
                    Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    if (Respuesta == DialogResult.Yes)
                    {
                        sqlcon.Open();
                        int IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                        string consulta = "DELETE FROM Usuarios WHERE Id='" + IdUsuario + "'";
                        SqlCommand comando = new SqlCommand(consulta, sqlcon);
                        int cant;
                        cant = comando.ExecuteNonQuery();

                        if (cant == 1)
                        {
                            MessageBox.Show("El usuario se elimino correctamente.");
                            Limpiar();
                            btnEliminar.Enabled = false;
                            btnBusca.Enabled = true;
                            txtIdUsuario.Enabled = true;
                            txtDirecc.Enabled = false;
                            txtNombreU.Enabled = false;
                            txtTelefon.Enabled = false;
                            sqlcon.Close();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible eliminar el usuario.");
                            sqlcon.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No fue posible eliminar el usuario.");
                        sqlcon.Close();
                    }
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("Ocurrio un error al eliminar al usuario" + " " + l);
                sqlcon.Close();
            }
        }

        private void smEliUsuarios_Load(object sender, EventArgs e)
        {

            txtTelefon.Enabled = false;
            txtDirecc.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreU.Enabled = false;
        }
    }
}
