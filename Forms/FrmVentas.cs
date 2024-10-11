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
    public partial class FrmVentas : Form
    {
        public DataTable dt;

        public FrmVentas()
        {
            InitializeComponent();
        }


        private void smVentas_Load(object sender, EventArgs e)
        {

            lblFecha.Text = DateTime.Today.ToString("d");
            txtTotal.Text = "$0.00";
            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Articulo");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Importe");
            dt.Columns.Add("Existencia");
            dgvDetVen.DataSource = dt;
        }

        private void smVentas_Shown(object sender, EventArgs e)
        {
            txtCproducto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*    using (SqlConnection conexion = new SqlConnection(SqlConexion.CadenaConexion))
            {
                conexion.Open();
                String consulta;
                int f = 0;
                int cantidad = 1;
                Int32 i;
                Int32 celda;
                DataGridViewCell dgc;
                Boolean repetido = false;
                Int32 indexcelda;
                Int32 CodiProdu;

                try
                {
                    //KEYPRESS ENTER CODIGO
                    consulta = "SELECT IdProducto, Descripcion,PrecioVen,Stock FROM Productos WHERE IdProducto = @IdProducto GROUP BY Idproducto, Descripcion, PrecioVen,Stock";                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = consulta;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conexion;
                    cmd.Parameters.AddWithValue("@IdProducto", txtCproducto.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        foreach (DataGridViewRow fila in dgvDetVen.Rows)
                        {
                            if (Convert.ToString(fila.Cells["Codigo"].Value) != txtCproducto.Text)
                            {

                                dgvDetVen.Rows[f].Cells[0].Value = cantidad;
                                dgvDetVen.Rows[f].Cells[1].Value = dr.GetInt32(0);//COdigo Productos
                                dgvDetVen.Rows[f].Cells[2].Value = dr.GetString(1);
                                dgvDetVen.Rows[f].Cells[3].Value = dr.GetDecimal(2);
                                dgvDetVen.Rows[f].Cells[4].Value = cantidad * Convert.ToDecimal(dgvDetVen.Rows[f].Cells[3].Value);
                                dgvDetVen.Rows[f].Cells[5].Value = dr.GetInt32(3);

                                f = f + 1;
                                txtCproducto.Clear();
                            }
                        }
                    }
                }
                catch
                {

                }
            }*/
        }

        private void txtCproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                using (SqlConnection conexion = new SqlConnection(SqlConexion.CadenaConexion))
                {
                    conexion.Open();
                    String consulta;
                
                    int cantidad = 1;
                    int FilaEncontrada;
                    int f = 0;
                    Int32 i;
                    Int32 celda;
                    DataGridViewCell dgc;
                    Boolean repetido = false;
                    Int32 indexcelda;
                    Int32 CodiProdu=0;

                    try
                    {
                        //KEYPRESS ENTER CODIGO
                        consulta = "SELECT IdProducto, Descripcion,PrecioVen,Stock FROM Productos WHERE IdProducto = @IdProducto GROUP BY Idproducto, Descripcion, PrecioVen,Stock";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = consulta;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conexion;
                        cmd.Parameters.AddWithValue("@IdProducto", txtCproducto.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        

                        while (dr.Read())
                        {
                           
                            
                            
                            foreach (DataGridViewRow fila in dgvDetVen.Rows)
                            {
                                string codi = null;
                                int Cantidad = 0;
                                codi = Convert.ToString(fila.Cells[0].Value);
                                Cantidad = Convert.ToInt32(fila.Cells[1].Value);

                                if (Convert.ToString(fila.Cells[f].Value) == txtCproducto.Text)
                                {
                                    repetido = true;
                                    int Existencia;
                                    Cantidad++;
                                    Existencia = Convert.ToInt32(fila.Cells[5].Value);
                                    /*dgvDetVen.Rows[f].Cells[4].Value = Cantidad * Convert.ToDecimal(dgvDetVen.Rows[f].Cells[3].Value);*/


                                }
                                else
                                {
                                    if (repetido== false)
                                    {

                                        DataRow row = dt.NewRow();
                                        row["Codigo"] = txtCproducto.Text;
                                        row["Cantidad"] = cantidad;
                                        row["Articulo"] = dr.GetString(1);
                                        row["Precio"] = dr.GetDecimal(2);
                                        row["Importe"] = cantidad * Convert.ToDecimal(dgvDetVen.Rows[f].Cells[3].Value);
                                        row["Existencias"] = dr.GetInt32(3);
                                        dt.Rows.Add(row);

                                        /*
                                        DataRow row = dt.NewRow();
                                        dgvDetVen.Rows[f].Cells[0].Value = txtCproducto.Text;
                                        dgvDetVen.Rows[f].Cells[1].Value = cantidad;//COdigo Productos
                                        dgvDetVen.Rows[f].Cells[2].Value = dr.GetString(1);
                                        dgvDetVen.Rows[f].Cells[3].Value = dr.GetDecimal(2);
                                        dgvDetVen.Rows[f].Cells[4].Value = cantidad * Convert.ToDecimal(dgvDetVen.Rows[f].Cells[3].Value);
                                        dgvDetVen.Rows[f].Cells[5].Value = dr.GetInt32(3);
                                        dt.Rows.Add(row);
                                        repetido = true;
                                        txtCproducto.Clear();*/
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {

                    }

                }
            }
        }
    }
}







                            
                            