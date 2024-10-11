using LinxAdmo.Forms.Catalogos.Articulos;
using LinxAdmo.Forms.Reportes;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LinxAdmo.Forms.Catalogos
{
    public partial class smArticulos : MaterialForm
    {
        public smArticulos()
        {
            InitializeComponent();
        }

        private void Deshabilita()
        {
            txtxClave.Enabled = false;
            txtDescripcion.Enabled = false;
            cbxLinea.Enabled = false;
            txtLinea.Enabled = false;
            cbxSerie.Enabled = false;
            txtSerie.Enabled = false;
            txtF_Peso.Enabled = false;
            txtCodigoSat.Enabled = false;
            txtCodigoSatD.Enabled = false;
            txtUnidadMedida.Enabled = false;
            txtUnidadMedidaD.Enabled = false;
            txtStockMinimo.Enabled = false;
            txtReferencia.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void Limpia()
        {
            txtxClave.Clear();
            txtDescripcion.Clear();
            cbxLinea.Text = "";
            txtLinea.Clear();
            cbxSerie.Text = "";
            txtSerie.Clear();
            txtF_Peso.Clear();
            txtCodigoSat.Clear();
            txtCodigoSatD.Clear();
            txtUnidadMedida.Clear();
            txtUnidadMedidaD.Clear();
            txtStockMinimo.Clear();
            txtReferencia.Clear();
            txtPrecio.Clear();
            txtCbarras.Clear();
        }

        private void Habilita()
        {
            txtxClave.Enabled = true;
            txtDescripcion.Enabled = true;
            cbxLinea.Enabled = true;            
            cbxSerie.Enabled = true;           
            txtF_Peso.Enabled = true;
            txtCodigoSat.Enabled = true;           
            txtUnidadMedida.Enabled = true;         
            txtStockMinimo.Enabled = true;
            txtReferencia.Enabled = true;
            txtPrecio.Enabled = true;
            txtCbarras.Enabled = true;
        }

        private void smArticulos_Load(object sender, EventArgs e)
        {
            Deshabilita();
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }


        private void btnBuscar_CSat_Click(object sender, EventArgs e)/*MUESTRA OTRO FORMULARIO PARA BUSCAR CLAVE SAT*/
        {
            smClaSat frmClasat = new smClaSat();
            frmClasat.Show();
        }

        private void btnBuscar_Umed_Click(object sender, EventArgs e)/*MUESTRA OTRO FORMULARIO PARA BUSCAR UNIDAD DE MEDIDA*/
        {
            smUniMed frmUniMed = new smUniMed();
            frmUniMed.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)/*MUESTRA OTRO FORMULARIO PARA BUSCAR EL ARTICULO*/
        {
            smBuscaArti frmBuscaArti = new smBuscaArti();
            frmBuscaArti.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)/*MUESTRA OTRO FORMULARIO PARA EDITAR EL ARTICULO*/
        {
            smEdiArti frmEdiArti = new smEdiArti();
            frmEdiArti.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)/*LLENA EL COMBOBOX LINEA*/
        {
            Habilita();
            txtxClave.Focus();
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnBuscar.Visible = false;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

            try
            {
                //LLENANDO COMBO LINEA //////////////////////////////////////////////////////////////////////////////////////////////////
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_lin = "SELECT * FROM Lineas";
                SqlCommand cmd_lin = new SqlCommand(sql_lin, sqlcon);
                SqlDataAdapter mysqldt_lin = new SqlDataAdapter(cmd_lin);
                DataTable dt_lin = new DataTable();
                mysqldt_lin.Fill(dt_lin);
                cbxLinea.ValueMember = "Linea";
                cbxLinea.DisplayMember = "Linea";
                cbxLinea.DataSource = dt_lin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)/*INSERTA UN ARTICULO NUEVO*/
        {
            try
            {
                string Clave = txtxClave.Text;
                string Cbarras = txtCbarras.Text;
                string Descripcion = txtDescripcion.Text;
                int Linea = Convert.ToInt32(cbxLinea.Text);
                int Serie = Convert.ToInt32(cbxSerie.Text);
                double F_Peso = Convert.ToDouble(txtF_Peso.Text);
                int C_Sat = Convert.ToInt32(txtCodigoSat.Text);
                string U_Medida = txtUnidadMedida.Text;
                int Stock_Minimo = Convert.ToInt32(txtStockMinimo.Text);
                int Sin_iva;
                if (cBox1_Siniva.Checked == true)
                {
                    Sin_iva = 1;
                }
                else
                {
                    Sin_iva = 0;
                }
                int Habilitado;
                if (checkBox1_Inhabilitado.Checked == true)
                {
                    Habilitado = 1;
                }
                else
                {
                    Habilitado = 0;
                }
                string Referencia = txtReferencia.Text;
                double Precio = Convert.ToDouble(txtPrecio.Text);                
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql_art = "INSERT INTO Articulos_ (Linea, Serie, Clave,Codigo_Barras,Descripcion,Precio,Peso,Stock_Minimo,Inactivo,Ex_iva,Clave_Sat,U_Medida,Referencia) " +
                "VALUES ('" + Linea + "','" + Serie + "','" + Clave + "','"+Cbarras+"','" + Descripcion + "','" + Precio + "','" + F_Peso + "','" + Stock_Minimo + "','" + Habilitado + "','" + Sin_iva + "','" + C_Sat + "','" + U_Medida + "','" + Referencia + "')";
                SqlCommand comando = new SqlCommand(sql_art, sqlcon);
                int cont;
                cont = comando.ExecuteNonQuery();

                if (cont == 1)
                {
                    MessageBox.Show("Articulo registrado con exito.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpia();
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnBuscar.Visible = true;
                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("Articulo no registrado. De aviso a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpia();
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnBuscar.Visible = true;
                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpia();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnBuscar.Visible = true;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            Limpia();
        }

        private void cbxLinea_TextChanged(object sender, EventArgs e)/*RELLENA COMBOBOX Y TEXTBOX CON LA LINEA*/
        {
            try
            {
                //LLENADO TEXT DESCRIPCION DE LINEAS//////////////////
                string id_linea = cbxLinea.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_lin = "SELECT * FROM Lineas WHERE Linea = '" + id_linea + "'";
                SqlCommand cmd_lin = new SqlCommand(sql_lin, sqlcon);
                SqlDataReader myreader_lin;
                sqlcon.Open();
                myreader_lin = cmd_lin.ExecuteReader();
                while (myreader_lin.Read())
                {
                    txtLinea.Text = myreader_lin["Des_Linea"].ToString();
                }
                sqlcon.Close();

                //LLENANDO COMBO SERIE //////////////////////////////////////////////////////////////////////////////////////////////////
                string id_Linea = cbxLinea.Text;
                string sql_ser = "SELECT * FROM Series WHERE Linea= '" + id_Linea + "' ";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataAdapter mysqldt_ser = new SqlDataAdapter(cmd_ser);
                DataTable dt_ser = new DataTable();
                mysqldt_ser.Fill(dt_ser);
                cbxSerie.ValueMember = "Serie";
                cbxSerie.DisplayMember = "Serie";
                cbxSerie.DataSource = dt_ser;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSerie_TextChanged(object sender, EventArgs e)/*RELLENA COMBOBOX Y TEXTBOX CON LA SERIE*/
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE SERIESSS////////////////////////////
                string id_Serie = cbxSerie.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT Desc_Serie FROM Series WHERE Serie = '" + id_Serie + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtSerie.Text = myreader_ser["Desc_Serie"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoSat_KeyPress(object sender, KeyPressEventArgs e)/*RELLENA EL COMBOBOX Y TEXTBOX CON EL CODIGO DEL SAT*/
        {
            string Clave = txtCodigoSat.Text;
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    int existe = 0;
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Clavp_Sat WHERE Clave = '" + Clave + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader myreader;
                    try
                    {
                        sqlcon.Open();
                        myreader = cmd.ExecuteReader();
                        while (myreader.Read())
                        {
                            existe = 1;
                            txtCodigoSatD.Text = myreader["Descripcion"].ToString();
                        }
                        if (existe == 0)
                        {
                            MessageBox.Show("La clave ingresada no existe en el catalogo de claves SAT. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCodigoSat.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUnidadMedida_KeyPress(object sender, KeyPressEventArgs e)/*RELLENA EL COMBO BOX Y TEXBOX CON LA UNIDAD DE MEDIDAD DEL PRODCUTO*/
        {
            string Clave_UM = txtUnidadMedida.Text;
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    int existe = 0;
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Uni_Med WHERE Clave_Um = '" + Clave_UM + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader myreader;
                    try
                    {
                        sqlcon.Open();
                        myreader = cmd.ExecuteReader();
                        while (myreader.Read())
                        {
                            existe = 1;
                            txtUnidadMedidaD.Text = myreader["Descripcion_Um"].ToString();
                        }
                        if (existe == 0)
                        {
                            MessageBox.Show("La clave ingresada no existe en el catalogo de unidades de medida. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUnidadMedida.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtxClave_KeyPress(object sender, KeyPressEventArgs e)/*BUSCA EL PRODUCTO POR CLAVE*/
        {
            string Clave = txtxClave.Text;
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    int existe = 0;
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Articulos_ WHERE Clave = '" + Clave + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader myreader;
                    try
                    {
                        sqlcon.Open();
                        myreader = cmd.ExecuteReader();
                        while (myreader.Read())
                        {
                            existe = 1;
                            txtDescripcion.Text = myreader["Descripcion"].ToString();
                            cbxLinea.Text = myreader["Linea"].ToString();
                            cbxSerie.Text = myreader["Serie"].ToString();
                            txtF_Peso.Text = myreader["Peso"].ToString();
                            txtCodigoSat.Text = myreader["Clave_Sat"].ToString();
                            txtUnidadMedida.Text = myreader["U_Medida"].ToString();
                            txtStockMinimo.Text = myreader["Stock_Minimo"].ToString();
                            cBox1_Siniva.Checked = Convert.ToBoolean(myreader["Ex_Iva"].ToString());
                            checkBox1_Inhabilitado.Checked = Convert.ToBoolean(myreader["Inactivo"].ToString());
                            txtReferencia.Text = myreader["Referencia"].ToString();
                            txtPrecio.Text = myreader["Precio"].ToString();
                        }
                        if (existe == 0)
                        {
                            MessageBox.Show("La clave del producto no existe en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCodigoSat.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)/*GENERA LOS REPORTES ESTA PROGRA*/
        {
            Repo_ArtiCla frmrepo_Articla = new Repo_ArtiCla();
            frmrepo_Articla.ShowDialog();           
        }

        private void txtCbarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Clave = txtxClave.Text;
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    txtPrecio.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
