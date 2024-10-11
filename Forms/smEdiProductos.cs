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
    public partial class smEdiProductos : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public smEdiProductos()
        {
            InitializeComponent();
        }

        public void Limpia()
        {
            btnActualiza.Enabled = false;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
            txtDepartamento.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCosto.Enabled = false;
            txtPVenta.Enabled = false;
            txtStockMin.Enabled = false;

            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtDepartamento.Clear();
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtPVenta.Clear();
            txtStockMin.Clear();

        }

        public void Habilita() 
        {
            btnActualiza.Enabled = true;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtCantidad.Enabled = true;
            txtDepartamento.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCosto.Enabled = true;
            txtPVenta.Enabled = true;
            txtStockMin.Enabled = true;
        }

        private void Actualiza_DataPro()
        {
            SqlCommand Comando = new SqlCommand("SELECT * FROM PRODUCTOS", sqlcon);
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            Adaptador.SelectCommand = Comando;
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            DatagridProdu.DataSource = Tabla;

        }


            private void smEdiProductos_Load(object sender, EventArgs e)
        {

            Actualiza_DataPro();
            Limpia();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
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
                    txtCosto.Text = registros["Costo"].ToString();
                    txtPVenta.Text = registros["PrecioVen"].ToString();
                    txtDepartamento.Text = registros["IdDeparta"].ToString();
                    txtCantidad.Text = registros["Stock"].ToString();                   
                    txtStockMin.Text = registros["StockMini"].ToString();

                    Habilita();
                    
                 
                }
                else
                {
                    MessageBox.Show("No existe producto con ese Id o Nombre, Intente de nuevo.");
                    Limpia();
                    sqlcon.Close();

                }

            }
            catch (Exception l)
            {
                MessageBox.Show("No existe un producto con ese Id o Nombre, Intente de nuevo." + " " + l);
                sqlcon.Close();
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeBox = "¿Realmente desea actualizar la informacion de este producto?";
                string Titulo = "Linx Systems| Confirmacion de Actualizacion";
                MessageBoxButtons Botones = MessageBoxButtons.YesNo;
                DialogResult Respuesta;
                Respuesta = MessageBox.Show(this, MensajeBox, Titulo, Botones, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                    sqlcon.Open();

                    int IdProducto = Convert.ToInt32(txtCodigo.Text);
                    string Nombre = txtNombre.Text;
                    string Descripcion = txtDescripcion.Text;
                    decimal Costo = Convert.ToDecimal(txtCosto.Text);
                    decimal PrecioVen = Convert.ToDecimal(txtPVenta.Text);
                    int IdDeparta = Convert.ToInt32(txtDepartamento.Text);
                    int Stock = Convert.ToInt32(txtCantidad.Text);
                    int StockMini = Convert.ToInt32(txtStockMin.Text);

                    string consulta = "UPDATE Productos SET  IdProducto='"+IdProducto+"',Nombre='" + Nombre + "', Descripcion='" + Descripcion + "',Costo='" + Costo + "',PrecioVen='" + PrecioVen + "',IdDeparta='"+IdDeparta+"',Stock='"+Stock+"'+Stock,StockMini='"+StockMini+"' WHERE IdProducto='" + IdProducto + "' ";
                    SqlCommand comando = new SqlCommand(consulta, sqlcon);
                    int cant;
                    cant = comando.ExecuteNonQuery();

                    if (cant == 1)
                    {

                        MessageBox.Show("La información del producto se actualizo correctamente.");
                        Actualiza_DataPro();
                        Limpia();
                        sqlcon.Close();

                    }
                    else
                    {
                        MessageBox.Show("La informacion del producto no fue actualizada.");
                        Limpia();
                        sqlcon.Close();
                    }

                }
                else
                {

                    MessageBox.Show("La informacion del producto no fue actualizada.");
                    Limpia();
                    sqlcon.Close();
                  
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("La informacion del producto no fue actualizada." + l);
                sqlcon.Close();

            }
        }
    }
}
