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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(@"Data Source=DBSERVER\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                sqlcon.Open();

                int Codigo = Convert.ToInt32(txtCodigo.Text);
                string Nombre = txtNombre.Text;
                string Descripcion = txtDescripcion.Text;
                double Costo =double.Parse(txtCosto.Text);
                double PrecioVen = double.Parse(txtPVenta.Text);
                int Departamento = Int32.Parse(txtDepartamento.Text);
                int Stock = Int32.Parse(txtCantidad.Text);
                int StockMini = Int32.Parse(txtStockMin.Text);

                string consulta = "INSERT INTO Productos(IdProducto,Nombre,Descripcion,Costo,PrecioVen,IdDeparta,Stock,StockMini) VALUES ('"+Codigo+"','" + Nombre + "','" + Descripcion + "','" + Costo + "','" + PrecioVen + "','" + Departamento + "','" + Stock + "','" + StockMini + "') ";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                comando.ExecuteNonQuery();
                MessageBox.Show("¡El producto fue registrado exitosamente!");
                sqlcon.Close();



            }
            catch (Exception l)
            {
                MessageBox.Show("El producto no se registro de forma correcta" + l);
            }

        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            FrmEdiProductos frmEditaProdcuto = new FrmEdiProductos();
            frmEditaProdcuto.ShowDialog();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            FrmEliProductos frmEliProductos = new FrmEliProductos();
            frmEliProductos.Show();
        }
    }
}
