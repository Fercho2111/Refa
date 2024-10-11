using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LinxAdmo.Forms.Catalogos
{
    public partial class smUniMed : MaterialForm
    {
        public smUniMed()
        {
            InitializeComponent();
        }
        private void smUniMed_Load(object sender, EventArgs e)
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
                    string sql = "SELECT * FROM Uni_MEd WHERE Descripcion_Um LIKE '" + Descripcion + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    dgvUniMed.DataSource = Tabla;
                }

                if (cboxCodigo.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Uni_med WHERE Clave_Um LIKE '" + Clave + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    dgvUniMed.DataSource = Tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
