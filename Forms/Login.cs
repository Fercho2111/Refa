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
    public partial class Linx : Form
    {
        public Linx()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(132, 191, 183);
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(132, 191, 183);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;           
            string query = "SELECT * FROM Usuarios WHERE Usuario= '" + txtUsu.Text.Trim() + "' AND Contra = '" + txtCon.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            try
            {
                if (dtbl.Rows.Count == 1)
                {
                    sqlcon.Open();
                    Menu frmMenu = new Menu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos,intente de nuevo.");
                    txtUsu.Clear();
                    txtCon.Clear();
                    txtUsu.Focus();
                    sqlcon.Close();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error de tipo: " + i);
            }

            /*Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();*/
        }

        private void Linx_Load(object sender, EventArgs e)
        {

            txtUsu.CharacterCasing = CharacterCasing.Upper;
            txtCon.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtCon.Focus();
            }
        }

        private void txtCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
