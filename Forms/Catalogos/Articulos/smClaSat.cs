using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Catalogos
{
    public partial class smClaSat : MaterialForm
    {
        public smClaSat()
        {
            InitializeComponent();
        }

        private void smClaSat_Load(object sender, EventArgs e)
        {
            cboxNombre.Checked = true;
        }

        private void cbxNombre_CheckedChanged(object sender, EventArgs e)
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

        private void cbxCodigo_CheckedChanged(object sender, EventArgs e)
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
            ///AQUIIIIIII QUEDE DEFINE VARIABLES PARA BUSCAR POR CODIGO O POR NOMBRE DEPENDIENDO QUE CHECKBOX ESTE SELECCIONADO
            ///Y REALIZA LAS CONSULTAS CORRESPONDIENTES
            string Descripcion = txtCodigo.Text;
            string Clave = txtCodigo.Text;
            try
            {
                if (cboxNombre.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Clavp_Sat WHERE Descripcion LIKE '" + Descripcion + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    dgvCSAT.DataSource = Tabla;
                }

                if (cboxCodigo.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Clavp_Sat WHERE Clave LIKE '" + Clave + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    dgvCSAT.DataSource = Tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
