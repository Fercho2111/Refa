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
    public partial class smEliProductos : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public smEliProductos()
        {
            InitializeComponent();
        }

        public void Habilita() 
        {

            btnElimina.Enabled = true;
        
        }

        public void Deshabilita() 
        {

            btnElimina.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtDepartamento.Enabled = false;
            txtCantidad.Enabled = false;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtDepartamento.Clear();
            txtCantidad.Clear();


        }
 

        private void smEliProductos_Load(object sender, EventArgs e)
        {
            btnElimina.Enabled = false;
            Deshabilita();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                sqlcon.Open();

                int idProducto = Convert.ToInt32(txtCodigo.Text);


                string consulta = "SELECT * FROM Productos WHERE IdProducto=('" + idProducto + "')";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                SqlDataReader registros = comando.ExecuteReader();

                if (registros.Read())
                {
                    txtCodigo.Text = registros["IdProducto"].ToString();
                    txtNombre.Text = registros["Nombre"].ToString();
                    txtDescripcion.Text = registros["Descripcion"].ToString();
                    txtDepartamento.Text = registros["IdDeparta"].ToString();
                    txtCantidad.Text = registros["Stock"].ToString();

                    Habilita();
                    sqlcon.Close();

                }
                else
                {
                    MessageBox.Show("No existe producto con ese Id o Nombre, Intente de nuevo.");
                    Deshabilita();
                    sqlcon.Close();

                }

            }
            catch (Exception l)
            {
                MessageBox.Show("No existe un producto con ese Id o Nombre, Intente de nuevo." + " " + l);
                Habilita();
                sqlcon.Close();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeBox = "¿Realmente desea eliminar este producto?";
                string Titulo = "Linx Systems| Confirmacion de Eliminacion";
                MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                DialogResult Respuesta;
                Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                if (Respuesta == DialogResult.Yes)
                {
                    sqlcon.Open();
                    int IdProducto = Convert.ToInt32(txtCodigo.Text);
                    string consulta = "DELETE FROM Productos WHERE IdProducto='" + IdProducto + "'";
                    SqlCommand comando = new SqlCommand(consulta, sqlcon);
                    int cant;
                    cant = comando.ExecuteNonQuery();

                    if (cant == 1)
                    {
                        MessageBox.Show("La información del producto se elimino correctamente.");
                        Deshabilita();
                        sqlcon.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se elimino el producto.");
                        Deshabilita();
                        sqlcon.Close();
                    }

                }
                else
                {
                    MessageBox.Show("No se elimino el producto.");
                    Deshabilita();
                    sqlcon.Close();
                }

            }
            catch (Exception l)
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto" + " " + l);
                Deshabilita();
                sqlcon.Close();
            }
        }
    }
}
