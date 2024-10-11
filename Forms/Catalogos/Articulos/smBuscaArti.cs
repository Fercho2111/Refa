using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Catalogos
{
    public partial class smBuscaArti : MaterialForm
    {
        public smBuscaArti()
        {
            InitializeComponent();
        }

        private void smBuscaArti_Load(object sender, EventArgs e)
        {
            cboxNombre.Checked = true;
        }
        /*--------------------------------AQUIIIIIIIII LO NUEVOOOOOOOOOOOOOOOOOO-----------*/

        private void cboxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxNombre.Checked == true)
            {
                cboxCodigo.Checked = false;
            }
            else
            {
                cboxCodigo.Checked = true;
            }
        }

        private void cboxCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxCodigo.Checked == true)
            {
                cboxNombre.Checked = false;
            }
            else
            {
                cboxNombre.Checked = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Descripcion = txtCodigo.Text;
            string Clave = txtCodigo.Text;   
            try
            {
                if (cboxNombre.Checked == true)
                {                    
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT Linea,Serie,Clave,Descripcion,Precio,Existencia,Peso,Stock_Minimo,Clave_Sat,U_Medida,Referencia FROM Articulos_ WHERE Descripcion LIKE '" + Descripcion + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    gdvBusArt.DataSource = Tabla;
                    if (Tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe producto con este nombre en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }                

                if (cboxCodigo.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT Linea,Serie,Clave,Descripcion,Precio,Existencia,Peso,Stock_Minimo,Clave_Sat,U_Medida,Referencia FROM Articulos_ WHERE Clave LIKE '" + Clave + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    gdvBusArt.DataSource = Tabla;
                    if (Tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe producto con este codigo en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
