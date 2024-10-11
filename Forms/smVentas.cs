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
    public partial class smVentas : Form
    {
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);
        const int MF_BYCOMMAND = 0;
        const int MF_DISABLED = 2;
        const int SC_CLOSE = 0xF060;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
        public smVentas()
        {
            InitializeComponent();
        }

        public void metodo_deshabilita()
        {
            cbxclie.Enabled = false;
            cbxZona.Enabled = false;
            txtpedido.Enabled = false;
            cbxmone.Enabled = false;
            txtrefe.Enabled = false;
            txtiva.Enabled = false;
            txttcamb.Enabled = false;
            cbxconven.Enabled = false;
            txtenba.Enabled = false;
            cbxforpag.Enabled = false;
            cbxmetpag.Enabled = false;
            cbxuso.Enabled = false;
            txtCanti.Enabled = false;
            txtArti.Enabled = false;
            txtPrecio.Enabled = false;
            txtImporte.Enabled = false;
            btnGuardar.Enabled = false;
            btnDescartar.Enabled = false;
            txtcli.Enabled = false;
            txtzon2.Enabled = false;
            txtmone.Enabled = false;
            txtrefe.Enabled = false;
            txtconven.Enabled = false;
            txtenba.Enabled = false;
            txtforpag.Enabled = false;
            txtmetpag.Enabled = false;
            txtuso.Enabled = false;
            txtsubps.Clear();
            txtivaps.Clear();
            txttops.Clear();
            txtsubps.Visible = false;
            txtivaps.Visible = false;
            txttops.Visible = false;
            lblspe.Visible = false;
            lblips.Visible = false;
            lbltops.Visible = false;
            //txtpedido.Clear();
            btnSalir.Enabled = true;
            btnNuevo.Enabled = false;

        }

        public void metodo_nuevo()
        {
            dgvDetVen.Visible = true;
            cbxclie.Enabled = true;
            cbxZona.Enabled = true;
            txtpedido.Enabled = true;
            cbxmone.Enabled = true;
            txtrefe.Enabled = true;
            txtiva.Enabled = true;
            txttcamb.Enabled = true;
            cbxconven.Enabled = true;
            txtenba.Enabled = true;
            cbxforpag.Enabled = true;
            cbxmetpag.Enabled = true;
            cbxuso.Enabled = true;
            txtCanti.Enabled = true;
            txtArti.Enabled = true;
            txtPrecio.Enabled = true;
            txtImporte.Enabled = true;
            btnDescartar.Enabled = true;
            btnNuevo.Enabled = false;
            txtcli.Enabled = true;
            txtzon2.Enabled = true;
            txtmone.Enabled = true;
            txtrefe.Enabled = true;
            txtconven.Enabled = true;
            txtenba.Enabled = true;
            txtforpag.Enabled = true;
            txtmetpag.Enabled = true;
            txtuso.Enabled = true;
            txtsubtot.Enabled = true;
            txttiva.Enabled = true;
            txttotal.Enabled = true;
            txtsubps.ReadOnly = true;
            txtivaps.ReadOnly = true;
            txttops.ReadOnly = true;
            txtpedido.ReadOnly = true;
            txttcamb.ReadOnly = true;
            txtDesA.Clear();
            txtDesB.Clear();
            txtDesC.Clear();
            txtDesA.Text = "0.00";
            txtDesB.Text = "0.00";
            txtDesC.Text = "0.00";
            txtDesA.ReadOnly=true;
            txtDesB.ReadOnly = true;
            txtDesC.ReadOnly = true;
            dgvDetVen.Rows.Clear();
            cbxclie.Focus();
        }

        public void metodo_carga()
        {
            btnNuevo.Focus();
            dgvDetVen.Enabled = false;
            cbxclie.Enabled = false;
            cbxZona.Enabled = false;
            txtpedido.Enabled = false;
            cbxmone.Enabled = false;
            txtrefe.Enabled = false;
            txtiva.Enabled = false;
            txttcamb.Enabled = false;
            cbxconven.Enabled = false;
            txtenba.Enabled = false;
            cbxforpag.Enabled = false;
            cbxmetpag.Enabled = false;
            cbxuso.Enabled = false;
            txtCanti.Enabled = false;
            txtArti.Enabled = false;
            txtPrecio.Enabled = false;
            txtImporte.Enabled = false;
            btnGuardar.Enabled = false;
            btnDescartar.Enabled = false;
            txtcli.Enabled = false;
            txtzon2.Enabled = false;
            txtmone.Enabled = false;
            txtrefe.Enabled = false;
            txtconven.Enabled = false;
            txtenba.Enabled = false;
            txtforpag.Enabled = false;
            txtmetpag.Enabled = false;
            txtuso.Enabled = false;
            txtsubtot.Enabled = false;
            txttiva.Enabled = false;
            txttotal.Enabled = false;
            btnSalir.Enabled = false;
        }

        public void metodo_componentes_ocultos()
        {
            txtplista.Visible = false;
            
        }

        private void smVentas_Load(object sender, EventArgs e)
        {
            dgvDetVenps.Visible = false;
            lblps.Visible = false;
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
            metodo_carga();
            metodo_componentes_ocultos();
            txtplista.Visible = false;
            lblFecha.Text = DateTime.Now.ToString("d");
            string fech = lblFecha.Text;
            string fechaexa = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            dgvDetVen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtiva.Text = "16.00";
            txtImporte.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtsubtot.ReadOnly = true;
            txttiva.ReadOnly = true;
            txttotal.ReadOnly = true;
            txtDesA.Text = "0.00";
            txtDesB.Text = "0.00";
            txtDesC.Text = "0.00";

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;
            string sql = "SELECT * FROM Clientes WHERE Id_Cliente = '" + cbxclie.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader myreader;
            try
            {
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtcli.Text = myreader["Nombre"].ToString();
                    cbxZona.Text = myreader["Zona"].ToString();
                    cbxmone.Text = myreader["Moneda"].ToString();
                    cbxconven.Text = myreader["CodVenta"].ToString();
                    cbxforpag.Text = myreader["FormPago"].ToString();
                    cbxmetpag.Text = myreader["MetoPago"].ToString();
                    cbxuso.Text = myreader["Uso"].ToString();
                    txtDesA.Text = myreader["Desca"].ToString();
                    txtDesB.Text = myreader["Descb"].ToString();
                    txtDesC.Text = myreader["Descc"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                int existe=0;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM Clientes WHERE Id_Cliente = '" + cbxclie.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                try
                {
                    sqlcon.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        existe = 1;
                        txtcli.Text = myreader["Nombre"].ToString();
                        cbxZona.Text = myreader["Zona"].ToString();
                        cbxmone.Text = myreader["Moneda"].ToString();
                        cbxconven.Text = myreader["CodVenta"].ToString();
                        cbxforpag.Text = myreader["FormPago"].ToString();
                        cbxmetpag.Text = myreader["MetoPago"].ToString();
                        cbxuso.Text = myreader["Uso"].ToString();
                        txtDesA.Text = myreader["Desca"].ToString();
                        txtDesB.Text = myreader["Descb"].ToString();
                        txtDesC.Text = myreader["Descc"].ToString();
                        cbxclie.Enabled = false;
                        txtcli.Enabled = false;
                    }
                    if (existe == 0)
                    {
                        MessageBox.Show("El cliente ingresado no existe, verifique el numero.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                     
                        cbxclie.Text = "";
                        cbxclie.Focus();
                    }
                }                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
        }

        private void CbxZona_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM Zona WHERE IdZona = '" + cbxZona.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtzon2.Text = myreader["Zona"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void CbxZona_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;
            string sql = "SELECT * FROM Zona WHERE IdZona = '" + cbxZona.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader myreader;
            try
            {
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtzon2.Text = myreader["Zona"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxmone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM TipMoneda WHERE IdMon = '" + cbxmone.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtmone.Text = myreader["Moneda"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxmone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM TipMoneda WHERE IdMon = '" + cbxmone.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtmone.Text = myreader["Moneda"].ToString();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxconven_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM CondVenta WHERE IdConVenta = '" + cbxconven.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtconven.Text = myreader["CondVenta"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxconven_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM CondVenta WHERE IdConVenta = '" + cbxconven.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtconven.Text = myreader["CondVenta"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxforpag_SelectedIndexChanged(object sender,EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM FormPago WHERE IdForPag = '" + cbxforpag.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtforpag.Text = myreader["ForPago"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxforpag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM FormPago WHERE IdForPag = '" + cbxforpag.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtforpag.Text = myreader["ForPago"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxmetpag_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM MetoPago WHERE IdMetoPag = '" + cbxmetpag.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtmetpag.Text = myreader["MetoPago"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxmetpag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM MetoPago WHERE IdMetoPag = '" + cbxmetpag.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtmetpag.Text = myreader["MetoPago"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void Cbxuso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM Uso WHERE IdUso = '" + cbxuso.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtuso.Text = myreader["Uso"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void cbxuso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM Uso WHERE IdUso = '" + cbxuso.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtuso.Text = myreader["Uso"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int cont;
                int cont_det;
                for (int i = 0; i <= dgvDetVen.RowCount - 2; i++)
                {

                    string valor_cantida = dgvDetVen.Rows[i].Cells["Cantidad"].Value.ToString();
                    string valor_articulo = dgvDetVen.Rows[i].Cells["Articulo"].Value.ToString();
                    if (valor_cantida == null)
                    {
                        break;
                    }
                    else
                    {
                        SqlConnection sqlcon = new SqlConnection();
                        sqlcon.ConnectionString = Conexion.Cn;
                        sqlcon.Open();
                        //VARIABLES PARA PEDIDO
                        int npedido = Convert.ToInt32(txtpedido.Text);
                        string id_cliente = cbxclie.Text;
                        string moneda = cbxmone.Text;
                        string referencia = txtrefe.Text;
                        double iva = Convert.ToDouble(txtiva.Text);
                        double tcambio = Convert.ToDouble(txttcamb.Text);
                        string conventa = cbxconven.Text;
                        string embarque = txtenba.Text;
                        string forpago = cbxforpag.Text;
                        string metpago = cbxmetpag.Text;
                        string uso = cbxuso.Text;
                        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                        double subtotal = Convert.ToDouble(txtsubtot.Text);
                        double tiva = Convert.ToDouble(txttiva.Text);
                        double total = Convert.ToDouble(txttotal.Text);
                        //INSERTAR PEDIDO
                        string consulta = "INSERT INTO Pedidos(Numero_pedido,Id_Cliente,Fecha,Moneda,Iva,Referencia,Tcambio,ConVenta,Embarque,ForPag,MetoPag,Uso,SubTotal,Tiva,Total,Fecha_origen) VALUES ('" + npedido + "','" + id_cliente + "','" + fecha + "','" + moneda + "','" + iva + "','" + referencia + "','" + tcambio + "','" + conventa + "','" + embarque + "','" + forpago + "','" + metpago + "','" + uso + "','" + subtotal + "','" + tiva + "','" + total + "',GetDate())";
                        SqlCommand comando = new SqlCommand(consulta, sqlcon);
                        cont = comando.ExecuteNonQuery();

                        for (int j = 0; j <= dgvDetVen.RowCount - 2; j++)
                        {
                            string valor_cantida_d = dgvDetVen.Rows[j].Cells["Cantidad"].Value.ToString();
                            string valor_articulo_d = dgvDetVen.Rows[j].Cells["Articulo"].Value.ToString();
                            double precilista = Convert.ToDouble(dgvDetVen.Rows[j].Cells["PreciLista"].Value.ToString());
                            double precio = Convert.ToDouble(dgvDetVen.Rows[j].Cells["Precio"].Value.ToString());
                            double importe = Convert.ToDouble(dgvDetVen.Rows[j].Cells["Importe"].Value.ToString());
                            //double observaciones = Convert.ToDouble(dgvDetVen.Rows[i].Cells["Observaciones"].Value.ToString());
                            string consulta_det_pedido = "INSERT INTO D_Pedido(Numero_pedido,Id_Cliente,Fecha,Cantidad,Articulo,PreciLista,Precio,Importe) VALUES ('" + npedido + "','" + id_cliente + "','" + fecha + "','" + valor_cantida_d + "','" + valor_articulo_d + "','" + precilista + "','" + precio + "','" + importe + "')";
                            SqlCommand comando2 = new SqlCommand(consulta_det_pedido, sqlcon);
                            cont_det = comando2.ExecuteNonQuery();
                        }
                        if (cont == 1)
                        {
                            MessageBox.Show("Pedido registrado.");
                            //metodo_deshabilita();
                            //btnNuevo.Enabled = true;
                            sqlcon.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se puedo registrar el pedido. Informe a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //metodo_deshabilita();
                            //btnNuevo.Enabled = true;
                            sqlcon.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }


            //------------------------------------------ PEDIDOS ARTICULOS ESPECIALES---------------------------------------------------------------------------------------------


            try
            {
             int cont_ps;
             int cont_det_ps;
             for (int i = 0; i <= dgvDetVenps.RowCount - 2; i++)
             {

                 string valor_cantida_ps = dgvDetVenps.Rows[i].Cells["Cantidadps"].Value.ToString();
                 string valor_articulo_ps = dgvDetVenps.Rows[i].Cells["Articulops"].Value.ToString();
                 if (valor_cantida_ps == null)
                 {
                     break;
                 }
                 else
                 {
                      SqlConnection sqlcon_ps = new SqlConnection();
                      sqlcon_ps.ConnectionString = Conexion.Cn;
                      sqlcon_ps.Open();
                     //VARIABLES PARA PEDIDO
                     int npedido = Convert.ToInt32(txtnpedido_esp.Text);
                     string id_cliente = cbxclie.Text;
                     string moneda = cbxmone.Text;
                     string referencia = txtrefe.Text;
                     double iva = Convert.ToDouble(txtiva.Text);
                     double tcambio = Convert.ToDouble(txttcamb.Text);
                     string conventa = cbxconven.Text;
                     string embarque = txtenba.Text;
                     string forpago = cbxforpag.Text;
                     string metpago = cbxmetpag.Text;
                     string uso = cbxuso.Text;
                     string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                     double subtotal = Convert.ToDouble(txtsubps.Text);
                     double tiva = Convert.ToDouble(txtivaps.Text);
                     double total = Convert.ToDouble(txttops.Text);
                     //INSERTAR PEDIDO
                     string consulta_ps = "INSERT INTO Pedidos(Numero_pedido,Id_Cliente,Fecha,Moneda,Iva,Referencia,Tcambio,ConVenta,Embarque,ForPag,MetoPag,Uso,SubTotal,Tiva,Total,Fecha_origen) VALUES ('" + npedido + "','" + id_cliente + "','" + fecha + "','" + moneda + "','" + iva + "','" + referencia + "','" + tcambio + "','" + conventa + "','" + embarque + "','" + forpago + "','" + metpago + "','" + uso + "','" + subtotal + "','" + tiva + "','" + total + "',GetDate())";
                     SqlCommand comando_ps = new SqlCommand(consulta_ps, sqlcon_ps);
                     cont_ps = comando_ps.ExecuteNonQuery();

                     for (int j = 0; j <= dgvDetVenps.RowCount - 2; j++)
                     {
                         string valor_cantida_d_ps = dgvDetVenps.Rows[j].Cells["Cantidadps"].Value.ToString();
                         string valor_articulo_d_ps = dgvDetVenps.Rows[j].Cells["Articulops"].Value.ToString();
                         double precilista_ps = Convert.ToDouble(dgvDetVenps.Rows[j].Cells["PreciListaps"].Value.ToString());
                         double precio_ps = Convert.ToDouble(dgvDetVenps.Rows[j].Cells["Preciops"].Value.ToString());
                         double importe_ps = Convert.ToDouble(dgvDetVenps.Rows[j].Cells["Importeps"].Value.ToString());
                         //double observaciones = Convert.ToDouble(dgvDetVen.Rows[i].Cells["Observaciones"].Value.ToString());
                         string consulta_det_pedido_ps = "INSERT INTO D_Pedido(Numero_pedido,Id_Cliente,Fecha,Cantidad,Articulo,PreciLista,Precio,Importe) VALUES ('" + npedido + "','" + id_cliente + "','" + fecha + "','" + valor_cantida_d_ps + "','" + valor_articulo_d_ps + "','" + precilista_ps + "','" + precio_ps + "','" + importe_ps + "')";
                         SqlCommand comando2_ps = new SqlCommand(consulta_det_pedido_ps, sqlcon_ps);
                         cont_det_ps = comando2_ps.ExecuteNonQuery();
                     }
                     if (cont_ps == 1)
                     {
                         MessageBox.Show("Pedido registrado.");
                         //metodo_deshabilita();
                         btnNuevo.Enabled = true;
                         sqlcon.Close();
                     }
                     else
                     {
                         MessageBox.Show("No se puedo registrar el pedido. Informe a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         //metodo_deshabilita();
                         btnNuevo.Enabled = true;
                         sqlcon.Close();
                     }
                 }
             }
             }
             catch (Exception ex)
             {
                // MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 sqlcon.Close();
             }
            metodo_deshabilita();
        }

        private void txtCanti_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (txtCanti.Text == "0")
                    {
                        MessageBox.Show("La cantidad no puede ser igual a 0.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCanti.Clear();
                    }
                    else if (txtCanti.Text == "")
                    {
                        MessageBox.Show("La cantidad no puede ser un valor nulo", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtArti.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtArti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    string Articulo = txtArti.Text;
                    string Cliente = cbxclie.Text;
                    int exis_arti_esp = 0;
                    int exis_cli_esp = 0;
                    
                    sqlcon.Close();
                    string sql_arti_esp = "SELECT * FROM Precios_Esp WHERE Articulo = '" + Articulo + "' AND Id_Cliente_Zona = '" + Cliente + "'";
                    SqlCommand cmd_arti_esp = new SqlCommand(sql_arti_esp, sqlcon);
                    SqlDataReader myreader_arti_esp;
                    sqlcon.Open();
                    myreader_arti_esp = cmd_arti_esp.ExecuteReader();
                    if (myreader_arti_esp.Read() == true)
                    {
                        string existencia = Convert.ToString(myreader_arti_esp["Exis"]);
                        string cantidas = Convert.ToString(txtCanti.Text);
                        string plista = Convert.ToString(myreader_arti_esp["PreciLista"]);                       
                        txtplista.Text = plista;
                        txtExis.Text = existencia;
                        exis_arti_esp = 1;

                        if(Convert.ToInt32(existencia)- Convert.ToInt32(cantidas) < 0)
                        {
                            MessageBox.Show("Existencia Insuficiente, la existencia actual de este producto es : " + existencia + ", corrija la cantidad.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPrecio.Clear();
                            txtImporte.Clear();
                            txtCanti.Clear();
                            txtCanti.Focus();
                        }

                        if (exis_arti_esp == 1)
                        {
                            string tipo_arti = Convert.ToString(myreader_arti_esp["TipArt"]);
                            double preciesp_arti = Convert.ToDouble(myreader_arti_esp["Precio_us"]);
                            string tipo_moneda = txtmone.Text;
                            txttipo.Text = tipo_arti;
                            if (tipo_moneda == "DOLARES AMERICANOS")
                            {
                                //MULTIPLICA EL PRECIO DEL ARTICULO EN DOLARES POR EL TIPO DE CAMBIO Y DEVUELVE M/N SI MONEDA = DOLAR AMERICANO
                                double cantidad = Convert.ToDouble(txtCanti.Text);
                                double tipo_cambio = Convert.ToDouble(txttcamb.Text);
                                double preciesp_fin_mn = tipo_cambio * preciesp_arti;
                                txtPrecio.Text = Convert.ToString(preciesp_fin_mn);
                                double importe = preciesp_fin_mn * cantidad;
                                txtImporte.Text = Convert.ToString(importe);
                                txtImporte.Focus();

                            }
                            else
                            {
                                //DEVUELVE EL PRECIO EN DOLARES AMERICANOS DEL ARTICULO SI LA MONEDA NO ES = DOLAR AMERICANO
                                txtPrecio.Text = Convert.ToString(preciesp_arti);
                                double cantidad = Convert.ToDouble(txtCanti.Text);
                                double precio = Convert.ToDouble(txtPrecio.Text);
                                double importe = cantidad * precio;
                                txtImporte.Text = Convert.ToString(importe);
                                txtImporte.Focus();
                            }                                                    
                            /*else
                            {
                                MessageBox.Show("Este articulo no tiene precio especial, a este cliente solo se le venden precios especiales.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtArti.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El cliente ingresado no es cliente especial.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        int exis_clie = 0;
                        int exis_arti = 0;
                        sqlcon.Close();
                        string sql_cli = "SELECT * FROM Clientes WHERE Id_Cliente = '" + Cliente + "'";
                        SqlCommand cmd_cli = new SqlCommand(sql_cli, sqlcon);
                        SqlDataReader myreader_cli;
                        sqlcon.Open();
                        myreader_cli = cmd_cli.ExecuteReader();

                        if (myreader_cli.Read() == true)
                        {
                            exis_clie = 1;
                            if (exis_clie == 1)
                            {
                                sqlcon.Close();
                                string sql_arti = "SELECT * FROM Articulos WHERE Articulo = '" + Articulo + "'";
                                SqlCommand cmd_arti = new SqlCommand(sql_arti, sqlcon);
                                SqlDataReader myreader_arti;
                                sqlcon.Open();
                                myreader_arti = cmd_arti.ExecuteReader();
                                if (myreader_arti.Read() == true)
                                {
                                    exis_arti = 1;
                                    if (exis_arti == 1)
                                    {
                                        double precio = Convert.ToDouble(myreader_arti["Precio"]);
                                        double cantidad = Convert.ToDouble(txtCanti.Text);
                                        double importe = cantidad * precio;
                                        txtPrecio.Text = Convert.ToString(precio);
                                        txtImporte.Text =Convert.ToString(importe);
                                        txtImporte.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Articulo inexistente, verifique.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                                    txtArti.Clear();
                                    txtArti.Focus();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cliente inexistente,verifique el numero de cliente.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cbxclie.Text="";
                            cbxclie.Focus();
                        }*/
                        }


                    }
                    else
                    {
                        int exis_arti = 0;
                        sqlcon.Close();
                        string sql_arti = "SELECT * FROM Articulos WHERE Articulo = '" + Articulo + "'";
                        SqlCommand cmd_arti = new SqlCommand(sql_arti, sqlcon);
                        SqlDataReader myreader_arti;
                        sqlcon.Open();
                        myreader_arti = cmd_arti.ExecuteReader();
                        if (myreader_arti.Read() == true)
                        {
                            exis_arti = 1;
                            if (exis_arti == 1)
                            {                               
                                string tip_arti = Convert.ToString(myreader_arti["TipArt"]);
                                double precio = Convert.ToDouble(myreader_arti["PreciLista"]);
                                double cantidad = Convert.ToDouble(txtCanti.Text);
                                double importe = cantidad * precio;
                                txtPrecio.Text = Convert.ToString(precio);
                                txtImporte.Text = Convert.ToString(importe);
                                string plista = Convert.ToString(myreader_arti["PreciLista"]);
                                txtplista.Text = plista;
                                string existencia = Convert.ToString(myreader_arti["Exis"]);
                                txtExis.Text = existencia;
                                txttipo.Text = tip_arti;
                                //VAIRBALES CALCULAR EXISTENCIA CONTRA CANTIDAD
                                int cantidad_exis = Convert.ToInt32(txtCanti.Text);                                

                                if (Convert.ToInt32(existencia) - cantidad_exis < 0)
                                {
                                    MessageBox.Show("Existencia Insuficiente, la existencia actual de este producto es : " + existencia + ", corrija la cantidad.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPrecio.Clear();
                                    txtImporte.Clear();
                                    txtCanti.Clear();
                                    txtCanti.Focus();
                                }

                                if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00")
                                {
                                    double precio_lista = Convert.ToDouble(txtPrecio.Text);
                                    double precio_descuentos = precio_lista * .3 * .9;
                                    double importe_descuento = precio_descuentos * cantidad; 
                                    txtPrecio.Text = Convert.ToString(precio_descuentos);
                                    txtImporte.Text = Convert.ToString(importe_descuento);

                                }                             
                                else if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00")
                                {
                                    double precio_lista = Convert.ToDouble(txtPrecio.Text);
                                    double precio_descuentos = precio_lista * .3 * .9 ;
                                    double importe_descuento = precio_descuentos * cantidad;
                                    txtPrecio.Text = Convert.ToString(precio_descuentos);
                                    txtImporte.Text = Convert.ToString(importe_descuento);

                                }
                                else
                                {
                                    txtPrecio.Text = Convert.ToString(precio);
                                    txtImporte.Text = Convert.ToString(importe);
                                }
                                txtImporte.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Articulo inexistente o sin registrar su precio especial, verifique.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                            txtArti.Clear();
                            txtArti.Focus();
                        }                        
                    }
                    
                   /* sqlcon.Close();
                    string sql = "SELECT * FROM Articulos WHERE Articulo ='" + Articulo + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader myreader;
                    sqlcon.Open();
                    myreader = cmd.ExecuteReader();
                    if (myreader.Read() == true)
                    {
                        //MUESTRA PRECIO DE LISTA
                        string plista = Convert.ToString(myreader["PreciLista"]);
                        txtplista.Text = plista;
                        // VARIABLES PARA CALCULAR CANTIDAD CONTRA EXISTENCIAS
                        int cantidad = Convert.ToInt32(txtCanti.Text);
                        int existencia = Convert.ToInt32(myreader["Exis"].ToString());

                        // VARIABLES CANTIDAD * PRECIO=IMPORTE
                        string Precio = myreader["Precio"].ToString();
                        Double Precios = Convert.ToDouble(Precio);
                        txtPrecio.Text = myreader["Precio"].ToString();
                        string precios = txtPrecio.Text;
                        txtExis.Text = Convert.ToString(existencia);

                        //OPERACIONES CANTIDAD Y PRECIO ARTICULO
                        Double Importe = Convert.ToDouble(txtCanti.Text) * Precios;
                        txtImporte.Text = Convert.ToString(Importe);
                        txtImporte.ReadOnly = true;
                        txtPrecio.ReadOnly = true;

                        if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00")
                        {
                            double precio_original = Convert.ToDouble(Precio);
                            double operacion_descuento = (precio_original * .30) * .90;
                            string resultado_descuento = Convert.ToString(operacion_descuento);
                            txtPrecio.Text = resultado_descuento;

                            //CALCULA IMPORTE CON DESCUENTO
                            double importe_descuento = Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCanti.Text);
                            txtImporte.Text = Convert.ToString(importe_descuento);
                            txtImporte.ReadOnly = true;
                            txtPrecio.ReadOnly = true;
                        }

                        if (existencia - cantidad < 0)
                        {
                            MessageBox.Show("Existencia Insuficiente, la existencia actual de este producto es : " + existencia + ", corrija la cantidad.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCanti.Clear();
                            txtPrecio.Clear();
                            txtImporte.Clear();
                            txtCanti.Focus();
                        }
                        else
                        {
                            //DESHABILITA IMPORTE Y TOTAL EN CASO QUE SI EXITA EL PRODUCTO
                            txtImporte.ReadOnly = true;
                            txtPrecio.ReadOnly = true;
                            txtImporte.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Articulo Inexistente, Verifique.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtArti.Clear();
                    }*/
                }            
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (dgvDetVen.Rows.Count > 0)
                    {

                        bool existe = false;

                        for (int i = 0; i < dgvDetVen.RowCount; i++)
                        {
                            if (Convert.ToString(dgvDetVen.Rows[i].Cells["Articulo"].Value) == Convert.ToString(txtArti.Text))
                            {

                                //SUMANDO CANTIDAD A PRODUCTO YA EXISTENTE
                                int CantiExis = Convert.ToInt32(dgvDetVen.Rows[i].Cells["Cantidad"].Value);
                                int Cantidad_operacion = CantiExis + Convert.ToInt32(txtCanti.Text);
                                dgvDetVen.Rows[i].Cells["Cantidad"].Value = Convert.ToString(Cantidad_operacion);

                                //MULTIPLICANDO CANTIDAD POR PRECIO

                                double cantidad = Convert.ToDouble(dgvDetVen.Rows[i].Cells["Cantidad"].Value);
                                double precio = Convert.ToDouble(dgvDetVen.Rows[i].Cells["Precio"].Value);
                                double importe_operacion = cantidad * precio;
                                dgvDetVen.Rows[i].Cells["Importe"].Value = Convert.ToString(importe_operacion.ToString("N2"));
                                MessageBox.Show("El producto ya ha sido ingresado");
                                existe = true;

                                int valor_cantida = Convert.ToInt32(txtCanti.Text);
                                string valor_articulo = txtArti.Text;
                                SqlConnection sqlcon = new SqlConnection();
                                sqlcon.ConnectionString = Conexion.Cn;
                                sqlcon.Open();
                                string consulta = "UPDATE Articulos SET  Exis=Exis-'" + valor_cantida + "' WHERE Articulo = '" + valor_articulo + "'";
                                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                                int cant;
                                cant = comando.ExecuteNonQuery();
                                txtArti.Clear();
                                txtPrecio.Clear();
                                txtImporte.Clear();
                                txtCanti.Clear();
                                txtCanti.Focus();
                                break;
                            }
                        }

                        if (existe == false && txtImporte.Text != "")
                        {
                            //MODIFICANDO EXISTENCIAS PARA QUE NO DEJE INGRESAR A DATAGRID MAS PRODUCTOS DE LOS QUE ESTAN EN EXISTENCIAS
                            int valor_cantida = Convert.ToInt32(txtCanti.Text);
                            string valor_articulo = txtArti.Text;
                            SqlConnection sqlcon = new SqlConnection();
                            sqlcon.ConnectionString = Conexion.Cn;
                            sqlcon.Open();
                            string consulta = "UPDATE Articulos SET  Exis=Exis-'" + valor_cantida + "' WHERE Articulo = '" + valor_articulo + "'";
                            SqlCommand comando = new SqlCommand(consulta, sqlcon);
                            int cant;
                            cant = comando.ExecuteNonQuery();
                            if (txttipo.Text == "B")
                            {
                                dgvDetVen.Rows.Add(txtCanti.Text, txtArti.Text, "", "", "", txtplista.Text, txtPrecio.Text, txtImporte.Text, "", "", "", "", "", "", "", txttipo.Text);
                                txtArti.Clear();
                                txtPrecio.Clear();
                                txtImporte.Clear();
                                txtCanti.Clear();
                                txtCanti.Focus();
                            }
                            else
                            {

  //---------------------------------------------------------------------------ARTICULOS PRECIO ESPECIAL-------------------------------------------------------------------
                                bool existe_ps = false;
                                if (dgvDetVenps.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dgvDetVenps.RowCount; i++)
                                    {
                                        if (Convert.ToString(dgvDetVenps.Rows[i].Cells["Articulops"].Value) == Convert.ToString(txtArti.Text))
                                        {

                                            //SUMANDO CANTIDAD A PRODUCTO YA EXISTENTE PRECIO ESPECIAL
                                            int CantiExis_ps = Convert.ToInt32(dgvDetVenps.Rows[i].Cells["Cantidadps"].Value);
                                            MessageBox.Show(Convert.ToString(CantiExis_ps));
                                            int Cantidad_operacion_ps = CantiExis_ps + Convert.ToInt32(txtCanti.Text);
                                            dgvDetVenps.Rows[i].Cells["Cantidadps"].Value = Convert.ToString(Cantidad_operacion_ps);
                                            double cantidad_ps = Convert.ToDouble(dgvDetVenps.Rows[i].Cells["Cantidadps"].Value);
                                            double precio_ps = Convert.ToDouble(dgvDetVenps.Rows[i].Cells["Preciops"].Value);
                                            double importe_operacion_ps = cantidad_ps * precio_ps;
                                            dgvDetVenps.Rows[i].Cells["Importeps"].Value = Convert.ToString(importe_operacion_ps.ToString("N2"));
                                            MessageBox.Show("El producto ya ha sido ingresado");
                                            existe_ps = true;

                                            int valor_cantida_ps = Convert.ToInt32(txtCanti.Text);
                                            string valor_articulo_ps = txtArti.Text;
                                            SqlConnection sqlcon_ps = new SqlConnection();
                                            sqlcon_ps.ConnectionString = Conexion.Cn;
                                            sqlcon_ps.Open();
                                            string consulta_ps = "UPDATE Precios_Esp SET  Exis=Exis-'" + valor_cantida_ps + "' WHERE Articulo = '" + valor_articulo_ps + "'";
                                            SqlCommand comando_ps = new SqlCommand(consulta_ps, sqlcon_ps);
                                            int cant_ps;
                                            cant_ps = comando_ps.ExecuteNonQuery();
                                            sqlcon_ps.Close();
                                            txtArti.Clear();
                                            txtPrecio.Clear();
                                            txtImporte.Clear();
                                            txtCanti.Clear();
                                            txtCanti.Focus();
                                            break;                                            
                                        }
                                    }
                                }

                                if (existe_ps == false && txtImporte.Text!="")
                                {
                                    int valor_cantida_ps= Convert.ToInt32(txtCanti.Text);
                                    string valor_articulo_ps = txtArti.Text;
                                    SqlConnection sqlcon_ps = new SqlConnection();
                                    sqlcon_ps.ConnectionString = Conexion.Cn;
                                    sqlcon_ps.Open();
                                    string consulta_ps = "UPDATE Precios_Esp SET  Exis=Exis-'" + valor_cantida_ps + "' WHERE Articulo = '" + valor_articulo_ps + "'";
                                    SqlCommand comando_ps = new SqlCommand(consulta_ps, sqlcon_ps);
                                    int cant_ps;
                                    cant_ps = comando_ps.ExecuteNonQuery();
                                    dgvDetVenps.Visible = true;
                                    lblps.Visible = true;
                                    dgvDetVenps.Rows.Add(txtCanti.Text, txtArti.Text, "", "", "", txtplista.Text, txtPrecio.Text, txtImporte.Text, "", "", "", "", "", "", "", txttipo.Text);
                                    txtArti.Clear();
                                    txtPrecio.Clear();
                                    txtImporte.Clear();
                                    txtCanti.Clear();
                                    txtCanti.Focus();
                                }                                                                                                    
                            }
                        }
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Articulo Inexistente, Verifique.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            try
            {
                metodo_deshabilita();
                int cant = 0;
                for (int i = 0; i <= dgvDetVen.RowCount - 2; i++)
                {
                    string valor_cantida = dgvDetVen.Rows[i].Cells["Cantidad"].Value.ToString();
                    string valor_articulo = dgvDetVen.Rows[i].Cells["Articulo"].Value.ToString();
                    
                    if (valor_cantida == null)
                    {
                        break;
                    }
                    else
                    {
                        //SUMANDO LOS PRODUCTOS DEL DATAGRID DEBIDO A QUE SE CANCELO EL PEDIDO
                        SqlConnection sqlcon = new SqlConnection();
                        sqlcon.ConnectionString = Conexion.Cn;
                        sqlcon.Open();
                        string consulta = "UPDATE Articulos SET  Exis=Exis+'" + valor_cantida + "' WHERE Articulo = '" + valor_articulo + "'";
                        SqlCommand comando = new SqlCommand(consulta, sqlcon);
                        cant = comando.ExecuteNonQuery();
                        /*MessageBox.Show(valor_cantida);
                         MessageBox.Show(valor_articulo);*/
                        cant = 1;
                    }
                }
                if (cant == 1)
                {
                    MessageBox.Show("El pedido fue descartado con exito.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dgvDetVen.Rows.Clear();
                dgvDetVen.Refresh();
                //btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnDescartar.Enabled = false;
                cbxclie.Enabled = false;
                txtsubtot.Text = "0.00";
                txttiva.Text = "0.00";
                txttotal.Text = "0.00";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                metodo_deshabilita();
                int cant_ps = 0;
                for (int i = 0; i <= dgvDetVenps.RowCount - 2; i++)
                {
                    string valor_cantida_ps = dgvDetVenps.Rows[i].Cells["Cantidadps"].Value.ToString();
                    string valor_articulo_ps = dgvDetVenps.Rows[i].Cells["Articulops"].Value.ToString();

                    if (valor_cantida_ps == null)
                    {
                        break;
                    }
                    else
                    {
                        //SUMANDO LOS PRODUCTOS DEL DATAGRID DEBIDO A QUE SE CANCELO EL PEDIDO
                        SqlConnection sqlcon_ps = new SqlConnection();
                        sqlcon_ps.ConnectionString = Conexion.Cn;
                        sqlcon_ps.Open();
                        string consulta_ps = "UPDATE Precios_Esp SET  Exis=Exis+'" + valor_cantida_ps + "' WHERE Articulo = '" + valor_articulo_ps + "'";
                        SqlCommand comando_ps = new SqlCommand(consulta_ps, sqlcon_ps);
                        cant_ps = comando_ps.ExecuteNonQuery();
                        /*MessageBox.Show(valor_cantida);
                         MessageBox.Show(valor_articulo);*/
                        cant_ps = 1;
                    }
                }
                if (cant_ps == 1)
                {
                    MessageBox.Show("El pedido fue descartado con exito.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dgvDetVenps.Rows.Clear();
                dgvDetVenps.Refresh();
                //btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnDescartar.Enabled = false;
                cbxclie.Enabled = false;
                txtsubtot.Text = "0.00";
                txttiva.Text = "0.00";
                txttotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            metodo_nuevo();            
            dgvDetVen.Enabled = true;
            string fech = lblFecha.Text;
            string fechaexa = DateTime.Now.ToString("yyyy-MM-dd");
            
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql = "SELECT Numero_pedido FROM Pedidos WHERE Numero_pedido = (SELECT max(Numero_pedido) FROM Pedidos)";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                int ultimo_pedido = Convert.ToInt32(cmd.ExecuteScalar());
                int nuevo_pedido = ultimo_pedido + 1;
                txtpedido.Text = Convert.ToString(nuevo_pedido);
                int pedido = Convert.ToInt32(txtpedido.Text);
                int npedido_esp = pedido + 1;
                txtnpedido_esp.Text = Convert.ToString(npedido_esp);

                string selectQuery = "SELECT * FROM Clientes";
                SqlCommand command = new SqlCommand(selectQuery, sqlcon);
                SqlDataAdapter mysqldt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                cbxclie.ValueMember = "Id_Cliente"; /*Valor que mostrara en el box*/
                cbxclie.DisplayMember = "Id_Cliente"; /*Columna a mostrar de la base de datos*/
                cbxclie.DataSource = dt;

                /*SqlConnection sqlcon2 = new SqlConnection(@"Data Source=DESKTOP\EQUIPO;Initial Catalog=LinxSys;Integrated Security=True");
                sqlcon2.Open();*/
                string selectQuery2 = "SELECT * FROM TipMoneda";
                SqlCommand command2 = new SqlCommand(selectQuery2, sqlcon);
                SqlDataAdapter mysqldt2 = new SqlDataAdapter(command2);
                DataTable dt2 = new DataTable();
                mysqldt2.Fill(dt2);
                cbxmone.ValueMember = "IdMon"; /*Valor que mostrara en el box*/
                cbxmone.DisplayMember = "IdMon"; /*Columna a mostrar de la base de datos*/
                cbxmone.DataSource = dt2;


                string selectQuery3 = "SELECT * FROM FormPago";
                SqlCommand command3 = new SqlCommand(selectQuery3, sqlcon);
                SqlDataAdapter mysqldt3 = new SqlDataAdapter(command3);
                DataTable dt3 = new DataTable();
                mysqldt3.Fill(dt3);
                cbxforpag.ValueMember = "IdForPag"; /*Valor que mostrara en el box*/
                cbxforpag.DisplayMember = "IdForPag"; /*Columna a mostrar de la base de datos*/
                cbxforpag.DataSource = dt3;


                string selectQuery4 = "SELECT * FROM MetoPago";
                SqlCommand command4 = new SqlCommand(selectQuery4, sqlcon);
                SqlDataAdapter mysqldt4 = new SqlDataAdapter(command4);
                DataTable dt4 = new DataTable();
                mysqldt4.Fill(dt4);
                cbxmetpag.ValueMember = "IdMetoPag"; /*Valor que mostrara en el box*/
                cbxmetpag.DisplayMember = "IdMetoPag"; /*Columna a mostrar de la base de datos*/
                cbxmetpag.DataSource = dt4;


                string selectQuery5 = "SELECT * FROM Uso";
                SqlCommand command5 = new SqlCommand(selectQuery5, sqlcon);
                SqlDataAdapter mysqldt5 = new SqlDataAdapter(command5);
                DataTable dt5 = new DataTable();
                mysqldt5.Fill(dt5);
                cbxuso.ValueMember = "IdUso"; /*Valor que mostrara en el box*/
                cbxuso.DisplayMember = "IdUso"; /*Columna a mostrar de la base de datos*/
                cbxuso.DataSource = dt5;


                string selectQuery6 = "SELECT * FROM Zona";
                SqlCommand command6 = new SqlCommand(selectQuery6, sqlcon);
                SqlDataAdapter mysqldt6 = new SqlDataAdapter(command6);
                DataTable dt6 = new DataTable();
                mysqldt6.Fill(dt6);
                cbxZona.ValueMember = "IdZona"; /*Valor que mostrara en el box*/
                cbxZona.DisplayMember = "IdZona"; /*Columna a mostrar de la base de datos*/
                cbxZona.DataSource = dt6;


                string selectQuery7 = "SELECT * FROM CondVenta";
                SqlCommand command7 = new SqlCommand(selectQuery7, sqlcon);
                SqlDataAdapter mysqldt7 = new SqlDataAdapter(command7);
                DataTable dt7 = new DataTable();
                mysqldt7.Fill(dt7);
                cbxconven.ValueMember = "IdConVenta"; /*Valor que mostrara en el box*/
                cbxconven.DisplayMember = "IdConVenta"; /*Columna a mostrar de la base de datos*/
                cbxconven.DataSource = dt7;

                string selectQuery8 = "SELECT Dolares FROM Tipcambio Where Fecha = '" + fechaexa + "'";
                SqlCommand command8 = new SqlCommand(selectQuery8, sqlcon);
                SqlDataAdapter mysqldt8 = new SqlDataAdapter(command8);
                string cod = Convert.ToString(command8.ExecuteScalar());
                string codi = Convert.ToString(cod);
                txttcamb.Text = codi;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtcli.Text = "";
            txtzon2.Text = "";
            txtmone.Text = "";
            txtrefe.Text = "";           
            txtconven.Text = "";
            txtenba.Text = "";
            txtforpag.Text = "";
            txtmetpag.Text = "";
            txtuso.Text = "";
            txtsubtot.Text = "0.00";
            txttiva.Text = "0.00";
            txttotal.Text = "0.00";
            cbxclie.Text = "";
            cbxZona.Text = "";
            cbxmone.Text = "";
            cbxconven.Text = "";
            cbxforpag.Text = "";
            cbxmetpag.Text = "";
            cbxuso.Text = "";
            txtDesA.Text = "0.00";
            txtDesB.Text = "0.00";
            txtDesC.Text = "0.00";
        }

        private void txtCanti_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ((int)e.KeyCode == (int)Keys.Escape)
                {
                    double suma = 0;
                    double suma_esp = 0;
                    double iva = 0;
                    double iva_esp = 0;
                    double total = 0;
                    double total_esp = 0;
                    int num = 0;

                    for (int i = 0; i <= dgvDetVen.RowCount - 2; i++)
                    {
                        string tipo_arti = dgvDetVen.Rows[i].Cells["TipArt"].Value.ToString();
                        if (tipo_arti == "B")
                        {
                            string suma_importe = dgvDetVen.Rows[i].Cells["Importe"].Value.ToString();
                            double suma_importes = Convert.ToDouble(suma_importe);
                            suma = suma + suma_importes;
                            iva = (suma * Convert.ToDouble(txtiva.Text)) / 100;
                            total = iva + suma;
                            btnGuardar.Enabled = true;
                            btnGuardar.Focus();
                            txtsubtot.Text = Convert.ToString(suma.ToString("N2"));
                            txttiva.Text = Convert.ToString(iva.ToString("N2"));
                            txttotal.Text = Convert.ToString(total.ToString("N2"));
                            num = 1;
                        }/*else if (tipo_arti == "A")
                        {
                            txtsubps.Visible = true;
                            txtivaps.Visible = true;
                            txttops.Visible = true;
                            lblspe.Visible = true;
                            lblips.Visible = true;
                            lbltops.Visible = true;
                            string suma_importe_esp = dgvDetVen.Rows[i].Cells["Importe"].Value.ToString();
                            double suma_importes_esp = Convert.ToDouble(suma_importe_esp);
                            suma_esp = suma_esp + suma_importes_esp;
                            iva_esp = (suma_esp * Convert.ToDouble(txtiva.Text)) / 100;
                            total_esp = iva_esp + suma_esp;
                            btnGuardar.Enabled = true;
                            btnGuardar.Focus();
                            txtsubps.Text = Convert.ToString(suma_esp.ToString("N2"));
                            txtivaps.Text = Convert.ToString(iva_esp.ToString("N2"));
                            txttops.Text = Convert.ToString(total_esp.ToString("N2"));
                            num = 1;
                        } */                   
                    }
                    if (num != 1)
                    {
                        MessageBox.Show("La cantidad no puede ser 0. Verifique.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtDesC.Text == "10.00")
                        {
                            double subtotal_original_1 = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen_1 = subtotal_original_1 * .90;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen_1);
                            double iva_descuento_volumen_1 = subtotal_descuento_volumen_1 * .16;
                            txttiva.Text = Convert.ToString(iva_descuento_volumen_1);
                            double total_descuento_volumen_1 = subtotal_descuento_volumen_1 + iva_descuento_volumen_1;
                            txttotal.Text = Convert.ToString(total_descuento_volumen_1);
                        }else if(txtDesC.Text == "5.00")
                        {
                            double subtotal_original_1 = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen_1 = subtotal_original_1 * .95;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen_1);
                            double iva_descuento_volumen_1 = subtotal_descuento_volumen_1 * .16;
                            txttiva.Text = Convert.ToString(iva_descuento_volumen_1);
                            double total_descuento_volumen_1 = subtotal_descuento_volumen_1 + iva_descuento_volumen_1;
                            txttotal.Text = Convert.ToString(total_descuento_volumen_1);
                        }
                        else
                        {
                            double subtotal_original = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen = subtotal_original * .90;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen);
                            double iva_descuento_volumen = subtotal_descuento_volumen * .16;
                            double total_descuento_volumen = subtotal_descuento_volumen + iva_descuento_volumen;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen);
                            txttiva.Text = Convert.ToString(iva_descuento_volumen);
                            txttotal.Text = Convert.ToString(total_descuento_volumen);
                        }
                       /* if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00" && txtDesC.Text == "10.00")
                        {
                            double subtotal_original = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen = subtotal_original * .3 * .9 * .9;
                            double iva_descuento_volumen = subtotal_descuento_volumen * .16;
                            double total_descuento_volumen = subtotal_descuento_volumen + iva_descuento_volumen;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen);
                            txttiva.Text = Convert.ToString(iva_descuento_volumen);
                            txttotal.Text = Convert.ToString(total_descuento_volumen);
                        }
                        else if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00" && txtDesC.Text == "5.00")
                        {
                            double subtotal_original = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen = subtotal_original * .3 * .9 * .95;
                            double iva_descuento_volumen = subtotal_descuento_volumen * .16;
                            double total_descuento_volumen = subtotal_descuento_volumen + iva_descuento_volumen;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen);
                            txttiva.Text = Convert.ToString(iva_descuento_volumen);
                            txttotal.Text = Convert.ToString(total_descuento_volumen);
                        }
                        else if (txtDesA.Text == "70.00" && txtDesB.Text == "10.00" && txtDesC.Text == "0.00")
                        {
                            double subtotal_original = Convert.ToDouble(txtsubtot.Text);
                            double subtotal_descuento_volumen = subtotal_original * .3 * .9;
                            double iva_descuento_volumen = subtotal_descuento_volumen * .16;
                            double total_descuento_volumen = subtotal_descuento_volumen + iva_descuento_volumen;
                            txtsubtot.Text = Convert.ToString(subtotal_descuento_volumen);
                            txttiva.Text = Convert.ToString(iva_descuento_volumen);
                            txttotal.Text = Convert.ToString(total_descuento_volumen);
                        }
                        else
                        {*/
                            
                        //}
                    }

                    for (int i = 0; i <= dgvDetVenps.RowCount - 2; i++)
                    {
                        string tipo_arti = dgvDetVenps.Rows[i].Cells["TipArtps"].Value.ToString();
                        if (tipo_arti == "A")
                        {
                            txtsubps.Visible = true;
                            txtivaps.Visible = true;
                            txttops.Visible = true;
                            lblspe.Visible = true;
                            lblips.Visible = true;
                            lbltops.Visible = true;
                            string suma_importe_esp = dgvDetVenps.Rows[i].Cells["Importeps"].Value.ToString();
                            double suma_importes_esp = Convert.ToDouble(suma_importe_esp);
                            suma_esp = suma_esp + suma_importes_esp;
                            iva_esp = (suma_esp * Convert.ToDouble(txtiva.Text)) / 100;
                            total_esp = iva_esp + suma_esp;
                            btnGuardar.Enabled = true;
                            btnGuardar.Focus();
                            txtsubps.Text = Convert.ToString(suma_esp.ToString("N2"));
                            txtivaps.Text = Convert.ToString(iva_esp.ToString("N2"));
                            txttops.Text = Convert.ToString(total_esp.ToString("N2"));
                            num = 1;
                        }
                    }
                    if (num != 1)
                    {
                        MessageBox.Show("La cantidad no puede ser 0. Verifique.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmone_TextChanged(object sender, EventArgs e)
        {
            if (txtmone.Text == " MONEDA NACIONAL" || txtmone.Text == "DOLARES AMERICANOS")
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                dgvDetVen.Visible = true;
                string fech = lblFecha.Text;
                string fechaexa = DateTime.Now.ToString("yyyy-MM-dd");
                string selectQuery22 = "SELECT Dolares FROM Tipcambio Where Fecha = '" + fechaexa + "'";
                SqlCommand command22 = new SqlCommand(selectQuery22, sqlcon);
                SqlDataAdapter mysqldt22 = new SqlDataAdapter(command22);
                string cod = Convert.ToString(command22.ExecuteScalar());
                string codi = Convert.ToString(cod);
                txttcamb.Text = codi;
            }
            if (txtmone.Text == "EURO")
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                dgvDetVen.Visible = true;
                string fech = lblFecha.Text;
                string fechaexa = DateTime.Now.ToString("yyyy-MM-dd");
                string selectQuery23 = "SELECT Euros FROM Tipcambio Where Fecha = '" + fechaexa + "'";
                SqlCommand command23 = new SqlCommand(selectQuery23, sqlcon);
                SqlDataAdapter mysqldt8 = new SqlDataAdapter(command23);
                string cod = Convert.ToString(command23.ExecuteScalar());
                string codi = Convert.ToString(cod);
                txttcamb.Text = codi;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smVentas_Resize(object sender, EventArgs e)
        {
            var sm = GetSystemMenu(Handle, false);
            EnableMenuItem(sm, SC_CLOSE, MF_BYCOMMAND | MF_DISABLED);
        }
    }
}



                          