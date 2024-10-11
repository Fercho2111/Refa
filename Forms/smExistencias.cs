using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinxAdmo.Forms
{
    public partial class smExistencias : Form
    {
        public smExistencias()
        {
            InitializeComponent();
        }

       /* private void smExistencias_Load(object sender, EventArgs e)
        {
            dgv_Exis.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            check_Bexacta.Checked = true;
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (check_Bexacta.Checked == true)
                    {
                        //string articulo = txtArticulo.Text;
                        SqlConnection sqlcon = new SqlConnection();
                        sqlcon.ConnectionString = Conexion.Cn;
                        sqlcon.Open();
                        string sql = "SELECT Exis.Alma,Exis.Articulo,Exis.Mercado,Exis.Pais,Exis.existact,Articulos.PreciLista FROM Exis INNER JOIN Articulos ON Exis.Articulo=@VARIABLE and Articulos.Articulo=@VARIABLE";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.Parameters.AddWithValue("@VARIABLE", txtArticulo.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        da.Fill(data);
                        da.Dispose();
                        sqlcon.Close();
                        dgv_Exis.DataSource = data;
                    }

                    else if (Check_Bgeneral.Checked == true)
                    {                        
                        string articulo = txtArticulo.Text;
                        SqlConnection sqlcon = new SqlConnection();
                        sqlcon.ConnectionString = Conexion.Cn;
                        sqlcon.Open();
                        string sql = "SELECT Exis.Articulo,Exis.Mercado,Exis.Pais,Exis.existact,Articulos.PreciLista FROM Exis INNER JOIN Articulos ON Exis.Articulo=Articulos.Articulo WHERE Articulos.articulo like '" + articulo + "%' AND Exis.articulo like '" + articulo + "%'";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cmd.Parameters.AddWithValue("@VARIABLE", txtArticulo.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        da.Fill(data);
                        da.Dispose();
                        sqlcon.Close();
                        dgv_Exis.DataSource = data;                        
                    }
                    else if (check_Bexacta.Checked == false && Check_Bgeneral.Checked == false)
                    {
                        MessageBox.Show("Debe marcar alguna de las casillas de busqueda.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check_Bexacta.Checked = true;
                        txtArticulo.Clear();
                        txtArticulo.Focus();
                    }                   
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void check_Bexacta_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Bexacta.Checked == true)
            {
                Check_Bgeneral.Checked = false;
            }
        }

        private void Check_Bgeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_Bgeneral.Checked == true)
            {
                check_Bexacta.Checked = false;
            }
        }*/
    }
}
