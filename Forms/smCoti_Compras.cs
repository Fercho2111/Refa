using MaterialSkin.Controls;
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
    public partial class smCoti_Compras : MaterialForm
    {
        public smCoti_Compras()
        {
            InitializeComponent();            
        }

        private void smCompras_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("d");
            string fech = lblFecha.Text;
            string fechaexa = DateTime.Now.ToString("yyyy-MM-dd");
            lblfech.Text = DateTime.Now.ToString("d");
            string fecha = lblfech.Text;
            string fechaexa2 = DateTime.Now.ToString("yyyy-MM-dd");
            btnconfirmar.Visible = false;
        }

        private void llena_grid()
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;
            try
            {                
                SqlCommand cmd = new SqlCommand("SELECT * FROM D_Cotizacion WHERE N_Cotizacion='"+txtbusca_cotizacion.Text+"'", sqlcon);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable Tabla = new DataTable();
                adaptador.Fill(Tabla);
                dgvConfi_Compra.DataSource = Tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }            
        }            

        private void cbxproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;
            try
            {
                
                string sql = "SELECT * FROM Proveedores WHERE Id_Proveedor = '" + cbxproveedor.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    txtpai_prefe.Text = myreader["Pais"].ToString();
                    txtproveedor.Text = myreader["Nombre"].ToString();
                    txtmoneda2.Text = myreader["Cmone"].ToString();

                }

                myreader.Close();
                string sql_pai = "SELECT * FROM Pais_Prefe WHERE Id_Pais = '" + txtpai_prefe.Text + "'";
                SqlCommand cmd_pai = new SqlCommand(sql_pai, sqlcon);
                SqlDataReader myreader_pai;
                myreader_pai = cmd_pai.ExecuteReader();
                while (myreader_pai.Read())
                {
                    txtpais.Text = myreader_pai["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlcon.Close();
            }
        }

        private void cbxproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM Proveedores WHERE Id_Proveedor = '" + cbxproveedor.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                try
                {
                    sqlcon.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        txtpai_prefe.Text = myreader["Pais"].ToString();
                        txtproveedor.Text = myreader["Nombre"].ToString();
                        txtmoneda2.Text = myreader["CMone"].ToString();
                    }
                    myreader.Close();
                    string sql_pai = "SELECT * FROM Pais_Prefe WHERE Id_Pais = '" + txtpai_prefe.Text + "'";
                    SqlCommand cmd_pai = new SqlCommand(sql_pai, sqlcon);
                    SqlDataReader myreader_pai;
                    myreader_pai = cmd_pai.ExecuteReader();
                    while (myreader_pai.Read())
                    {
                        txtpais.Text = myreader_pai["Descripcion"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                string fech = lblFecha.Text;
                string fechaexa = DateTime.Now.ToString("yyyy-MM-dd");
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string selectQuery = "SELECT * FROM Proveedores";
                SqlCommand command = new SqlCommand(selectQuery, sqlcon);
                SqlDataAdapter mysqldt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                cbxproveedor.ValueMember = "Id_proveedor"; /*Valor que mostrara en el box*/
                cbxproveedor.DisplayMember = "Id_proveedor"; /*Columna a mostrar de la base de datos*/
                cbxproveedor.DataSource = dt;

                string sql_mone = "SELECT IdMon FROM TipMoneda";
                SqlCommand cmd_mone = new SqlCommand(sql_mone, sqlcon);
                SqlDataAdapter mysqldt_mone = new SqlDataAdapter(cmd_mone);
                DataTable dt_mone = new DataTable();
                mysqldt_mone.Fill(dt_mone);
                cbxmoneda.ValueMember = "IdMon";
                cbxmoneda.DisplayMember = "IdMon";
                cbxmoneda.DataSource = dt_mone;

                
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql = "SELECT N_Cotizacion FROM Cotizacion WHERE N_Cotizacion = (SELECT max(N_Cotizacion) FROM Cotizacion)";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                int ultima_cotizacion = Convert.ToInt32(cmd.ExecuteScalar());
                int nueva_cotizacion = ultima_cotizacion + 1;
                txtncotizacion.Text = Convert.ToString(nueva_cotizacion);                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        private void cbxmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tmone = "SELECT Moneda FROM TipMoneda WHERE IdMon = '" + cbxmoneda.Text + "'";
                SqlCommand cmd_tmone = new SqlCommand(sql_tmone, sqlcon);
                sqlcon.Open();
                SqlDataReader myreader_tmone;
                myreader_tmone = cmd_tmone.ExecuteReader();
                while (myreader_tmone.Read())
                {
                    txtmoneda.Text = myreader_tmone["Moneda"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void cbxmoneda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tmone = "SELECT Moneda FROM TipMoneda WHERE IdMon = '" + cbxmoneda.Text + "'";
                SqlCommand cmd_tmone = new SqlCommand(sql_tmone, sqlcon);
                sqlcon.Open();
                SqlDataReader myreader_tmone;
                myreader_tmone = cmd_tmone.ExecuteReader();
                while (myreader_tmone.Read())
                {
                    txtmoneda.Text = myreader_tmone["Moneda"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txtmoneda2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tmone = "SELECT * FROM TipMoneda WHERE IdMon = '" + txtmoneda2.Text + "'";
                SqlCommand cmd_tmone = new SqlCommand(sql_tmone, sqlcon);
                sqlcon.Open();
                SqlDataReader myreader_tmone;
                myreader_tmone = cmd_tmone.ExecuteReader();
                while (myreader_tmone.Read())
                {
                    txtmoneda.Text = myreader_tmone["Moneda"].ToString();
                    cbxmoneda.Text = myreader_tmone["IdMon"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void txtarticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string Articulo = txtarticulo.Text;
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    string sql_arti = "SELECT * FROM Articulos WHERE Articulo = '" + Articulo + "'";
                    SqlCommand cmd_arti = new SqlCommand(sql_arti, sqlcon);
                    SqlDataReader myreader_arti;
                    sqlcon.Open();
                    myreader_arti = cmd_arti.ExecuteReader();
                    if (myreader_arti.Read() == true)
                    {
                        txtprecio.Text = myreader_arti["PreciLista"].ToString();
                        txtasignacion.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Este articulo no existe en el catalogo de articulos, debe registrarlo primero.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtarticulo.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    txtarticulo.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txtfechallega_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    dgvcoti_compras.Rows.Add(txtcantidad.Text,txtarticulo.Text,txtasignacion.Text,txtdescripcion.Text,"","",txtprecio.Text,txtimporte.Text,txtfechallega.Text);
                    txtcantidad.Clear();
                    txtarticulo.Clear();
                    txtasignacion.Clear();
                    txtprecio.Clear();
                    txtcantidad.Focus();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    double can_piezas = Convert.ToInt32(txtcantidad.Text);
                    double precio = Convert.ToDouble(txtprecio.Text);
                    double total_importe = can_piezas * precio;
                    txtimporte.Text = Convert.ToString(total_importe.ToString("N2"));                   
                    txtfechallega.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void txtasignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    txtprecio.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void txtcantidad_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if ((int)e.KeyCode == (int)Keys.Escape)
                {
                    int total_piezas = 0;
                    double total_general = 0;
                    for (int i = 0; i <= dgvcoti_compras.RowCount - 2 ; i++)
                    {
                        string suma_p = dgvcoti_compras.Rows[i].Cells["Cantidad"].Value.ToString();
                        int cant_pieza = Convert.ToInt32(suma_p);
                        total_piezas = total_piezas + cant_pieza;
                        txtptotales.Text = Convert.ToString(total_piezas);
                        string suma_importe = dgvcoti_compras.Rows[i].Cells["Importe"].Value.ToString();
                        double cant_impor = Convert.ToDouble(suma_importe);
                        total_general = total_general + cant_impor;
                        txtimpor_total.Text = Convert.ToString(total_general.ToString("N2"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cont;
                int cont_det;
                int exito = 0;                
                for (int i = 0; i <= dgvcoti_compras.Rows.Count; i++)
                {
                    string valor_cantidad = dgvcoti_compras.Rows[i].Cells["Cantidad"].Value.ToString();
                    string valor_articulo = dgvcoti_compras.Rows[i].Cells["Articulo"].Value.ToString();

                    if (valor_cantidad == null)
                    {
                        break;
                    }
                    else
                    {
                        SqlConnection sqlcon = new SqlConnection();
                        sqlcon.ConnectionString = Conexion.Cn;
                        sqlcon.Open();
                        // VARIABLES PARA COTIZACION
                        int n_cotizacion = Convert.ToInt32(txtncotizacion.Text);
                        string n_proveedor = Convert.ToString(cbxproveedor.Text);
                        string pais = txtpais.Text;
                        string moneda = cbxmoneda.Text;
                        string num_inquiry = txtnuminqu.Text;
                        string referencia = txtreferencia.Text;
                        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                        string autoriza = txtautoriza.Text;
                        int pza_totales = Convert.ToInt32(txtptotales.Text);
                        double importe_total = Convert.ToDouble(txtimpor_total.Text);
                        //INSERTANDO EN COTIZACION
                        string sql = "INSERT INTO Cotizacion (N_Cotizacion,Proveedor,Pais,Moneda,Num_Inquiry,Referencia,Fecha,Autoriza,Pzas_Totales,Importe_Total) VALUES ('" + n_cotizacion + "','" + n_proveedor + "','" + pais + "','" + moneda + "','" + num_inquiry + "','" + referencia + "','" + fecha + "','" + autoriza + "','" + pza_totales + "','" + importe_total + "')";
                        SqlCommand cmd = new SqlCommand(sql, sqlcon);
                        cont = cmd.ExecuteNonQuery();

                        for (int j = 0; j <= dgvcoti_compras.Rows.Count; j++)
                        {
                            int n_cotizacion_d = Convert.ToInt32(txtncotizacion.Text);
                            int valor_cantida_d = Convert.ToInt32(dgvcoti_compras.Rows[j].Cells["Cantidad"].Value.ToString());
                            string valor_articulo_d = dgvcoti_compras.Rows[j].Cells["Articulo"].Value.ToString();
                            string valor_asignado_d = dgvcoti_compras.Rows[j].Cells["Asignado"].Value.ToString();
                            string valor_descripcion_d = dgvcoti_compras.Rows[j].Cells["Descripcion"].Value.ToString();
                            //string valor_nref_d = dgvcoti_compras.Rows[j].Cells["N_Ref"].Value.ToString();
                            //int valor_exist_d = Convert.ToInt32(dgvcoti_compras.Rows[j].Cells["Exist"].Value.ToString());
                            double valor_precio_d = Convert.ToDouble(dgvcoti_compras.Rows[j].Cells["Precio"].Value.ToString());
                            double valor_importe_d = Convert.ToDouble(dgvcoti_compras.Rows[j].Cells["Importe"].Value.ToString());
                            DateTime fecha_d = Convert.ToDateTime(dgvcoti_compras.Rows[j].Cells["Delivery"].Value.ToString());
                            string fecha_d_db = fecha_d.ToString("yyyy-MM-dd");
                            string consulta_det_cotizacion = "INSERT INTO D_Cotizacion(N_Cotizacion,Cantidad,Articulo,Asignacion,Descripcion,Precio,Importe,Delivery) VALUES ('" + n_cotizacion_d + "','" + valor_cantida_d + "','" + valor_articulo_d + "','" + valor_asignado_d + "','" + valor_descripcion_d + "','" + valor_precio_d + "','" + valor_importe_d + "','" + fecha_d_db + "')";
                            SqlCommand cmd2 = new SqlCommand(consulta_det_cotizacion, sqlcon);
                            cont_det = cmd2.ExecuteNonQuery();
                            exito++;
                        }
                        if (exito == 1)
                        {
                            MessageBox.Show("Cotizacion registrada con exito.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }
                        else
                        {
                            MessageBox.Show("No se puedo registrar el pedido. Informe a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                                                                           
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Cotizacion registrada con exito.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                //MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtbusca_cotizacion.Focus();
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = Conexion.Cn;

            try
            {                
                sqlcon.Open();                
                int n_cotizacion = Convert.ToInt32(txtbusca_cotizacion.Text);
                string sqlconfirmada = "SELECT Confirmado FROM Cotizacion WHERE N_cotizacion=('" + n_cotizacion + "')";
                SqlCommand cmd_confirmada = new SqlCommand(sqlconfirmada, sqlcon);
                Boolean resulta = Convert.ToBoolean(cmd_confirmada.ExecuteScalar());
                
                if (resulta==true)
                {
                    MessageBox.Show("Esta cotizacion ya ha sido confirmada. Consultela para agregar material a almacen.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "SELECT * FROM Cotizacion WHERE N_Cotizacion = ('" + n_cotizacion + "')";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader registros = cmd.ExecuteReader();
                    

                    if (registros.Read())
                    {
                        txtresul_proveedor.Text = registros["Proveedor"].ToString();
                        txtresul_pais.Text = registros["Pais"].ToString();
                        txtresul_moneda.Text = registros["Moneda"].ToString();
                        txtresul_ninquiry.Text = registros["Num_Inquiry"].ToString();
                        string fecha_db = registros["Fecha"].ToString();
                        DateTime fech = Convert.ToDateTime(fecha_db);
                        string fecha_usu = Convert.ToString(fech.ToString("dd-MM-yyyy"));
                        lblresul_fecha.Text = fecha_usu;
                        txtresul_refe.Text = registros["Referencia"].ToString();
                        txtresul_autoriza.Text = registros["Autoriza"].ToString();
                        txtresul_ptotales.Text = registros["Pzas_Totales"].ToString();
                        double impotota = Convert.ToDouble(registros["Importe_Total"]);
                        txtresul_imtotal.Text = Convert.ToString(impotota.ToString("N2"));
                        llena_grid();
                        dgvConfi_Compra.Columns[1].ReadOnly = true;
                        dgvConfi_Compra.Columns[2].ReadOnly = true;
                        dgvConfi_Compra.Columns[3].ReadOnly = true;
                        dgvConfi_Compra.Columns[4].ReadOnly = true;
                        dgvConfi_Compra.Columns[5].ReadOnly = true;
                        dgvConfi_Compra.Columns[6].ReadOnly = true;
                        dgvConfi_Compra.Columns[7].ReadOnly = true;
                        dgvConfi_Compra.Columns[8].ReadOnly = true;
                        dgvConfi_Compra.Columns[9].ReadOnly = true;
                        dgvConfi_Compra.Columns[10].ReadOnly = true;
                        registros.Close();
                        string sql_nconf = "SELECT N_Confirma FROM ConfiCom WHERE N_Confirma = (SELECT max(N_Confirma) FROM ConfiCom)";
                        SqlCommand cmd_nconf = new SqlCommand(sql_nconf, sqlcon);
                        int ultiman_confi = Convert.ToInt32(cmd_nconf.ExecuteScalar());
                        txtnconfirmacion.Text = Convert.ToString(ultiman_confi);
                        btnconfirmar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Clave de cotizacion inexistente, Verifique.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtncotizacion.Clear();
                        txtncotizacion.Focus();
                        sqlcon.Close();
                    }
                }                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtresul_moneda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string mon = txtresul_moneda.Text;
                string sqlmon = "SELECT * FROM TipMoneda WHERE IdMon = ('" + mon + "')";
                SqlCommand cmd_mon = new SqlCommand(sqlmon, sqlcon);
                SqlDataReader regis_mon = cmd_mon.ExecuteReader();
                if (regis_mon.Read())
                {
                    txtresul_moneda2.Text = regis_mon["Moneda"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtresul_proveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string proveedor = txtresul_proveedor.Text;
                string sqlpro = "SELECT Nombre FROM Proveedores WHERE Id_proveedor = ('" + proveedor + "')";
                SqlCommand cmd_pro = new SqlCommand(sqlpro, sqlcon);
                SqlDataReader regis_pro = cmd_pro.ExecuteReader();
                if (regis_pro.Read())
                {
                    txtresul_proveedor2.Text = regis_pro["Nombre"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int sihay = 0;
                int n_cotizacion = Convert.ToInt32(txtbusca_cotizacion.Text);
                int proveedor = Convert.ToInt32(txtresul_proveedor.Text);
                string pais = txtresul_pais.Text;
                string moneda = txtresul_moneda.Text;
                string inquiry = txtresul_ninquiry.Text;
                string fecha1 = lblresul_fecha.Text;
                DateTime fecha = Convert.ToDateTime(fecha1);
                string fecha_db_coti = Convert.ToString(fecha.ToString("yyyy-MM-dd"));
                string fecha2 = lblfech.Text;
                DateTime fecha2_2 = Convert.ToDateTime(fecha2);
                string fecha_db_confi = Convert.ToString(fecha2_2.ToString("yyyy-MM-dd"));
                string referencia = txtresul_refe.Text;
                string autoriza = txtresul_autoriza.Text;
                int pzastota = Convert.ToInt32(txtresul_ptotales.Text);
                double impotota = Convert.ToDouble(txtresul_imtotal.Text);
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql = "INSERT INTO ConfiCom(N_Cotizacion, Proveedor, Pais, Moneda, Num_Inquiry, Fecha_Coti,Fecha_Confi, Referencia, Autoriza, Pzas_Totales, Importe_Total) VALUES ('" + n_cotizacion + "','" + proveedor + "','" + pais + "','" + moneda + "','" + inquiry + "','" + fecha_db_coti + "','" + fecha_db_confi + "','" + referencia + "','" + autoriza + "','" + pzastota + "','" + impotota + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader registros = cmd.ExecuteReader();                
           
                foreach (DataGridViewRow r in dgvConfi_Compra.Rows)
                {
                    bool isChecked = Convert.ToBoolean(r.Cells[0].Value);
                    if (isChecked == true)
                    {
                        //registros.Close();
                        int n_confirmacion = Convert.ToInt32(txtnconfirmacion.Text);
                        DateTime fecha_confi = Convert.ToDateTime(lblfech.Text);
                        string fechaconfi_db = Convert.ToString(fecha_confi.ToString("yyyy-MM-dd"));
                        int cantidad = Convert.ToInt32(r.Cells[2].Value);                       
                        string articulo = Convert.ToString(r.Cells[3].Value);
                        string asignacion = Convert.ToString(r.Cells[4].Value);
                        string descripcion = Convert.ToString(r.Cells[5].Value);
                        string n_ref = Convert.ToString(r.Cells[6].Value);
                        int exist = Convert.ToInt32(r.Cells[7].Value);
                        double precio = Convert.ToDouble(r.Cells[8].Value);
                        double importe = Convert.ToDouble(r.Cells[9].Value);
                        DateTime fecha_delivery = Convert.ToDateTime(r.Cells[10].Value);
                        string fecha_deli_db = Convert.ToString(fecha_delivery.ToString("yyyy-MM-dd"));
                        SqlConnection sqlcon1 = new SqlConnection();
                        sqlcon1.ConnectionString = Conexion.Cn;
                        sqlcon1.Open();
                        string sql_dcon = "INSERT INTO D_ConfiCom(N_confirma,N_Cotizacion,Fecha_Confirma,Cantidad,Articulo,Asignacion,Descripcion,N_Ref,Exist,Precio,Importe,Delivery) " +
                        "VALUES ('" + n_confirmacion + "','"+ n_cotizacion +"','" + fechaconfi_db + "','" + cantidad + "','" + articulo + "','" + asignacion + "','" + descripcion + "','" + n_ref + "','" + exist + "','" + precio + "','" + importe + "','" + fecha_deli_db + "')";
                        SqlCommand cmd_dcon = new SqlCommand(sql_dcon, sqlcon1);
                        SqlDataReader registros_dcon = cmd_dcon.ExecuteReader();
                        sihay = 1;
                    }
                }
                if (sihay==1)
                {
                    MessageBox.Show("Cotizacion registrada con exito.", "LinxSystems|Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show(" Cotizacion no registrada. Verifique la selección.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
