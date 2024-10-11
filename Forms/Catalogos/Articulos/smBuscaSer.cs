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

namespace LinxAdmo.Forms.Catalogos.Articulos
{
    public partial class smBuscaSer : MaterialForm
    {
        public smBuscaSer()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT Serie,Desc_Serie,Linea FROM Series";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                mysqldt.SelectCommand = cmd;
                DataTable Tabla = new DataTable();
                mysqldt.Fill(Tabla);
                gdvBusLin.DataSource = Tabla;//AQUIIIIIIIIIIIIIIIIIIIIIII QUEDEEEEEEEEEEEEEEEEEEEEE SEGUIRRRRRRRRR
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
