using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Catalogos.Articulos
{
    public partial class smBuscaLin : MaterialForm
    {
        public smBuscaLin()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT Linea,Des_Linea,Des_Corta FROM Lineas";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                mysqldt.SelectCommand = cmd;
                DataTable Tabla = new DataTable();
                mysqldt.Fill(Tabla);
                gdvBusLin.DataSource = Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
