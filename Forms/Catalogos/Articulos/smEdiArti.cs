using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Catalogos.Articulos
{
    public partial class smEdiArti : MaterialForm
    {
        public smEdiArti()
        {
            InitializeComponent();
        }

        private new void Visible()
        {
            lblClave.Visible = true;
            txtxClave.Visible = true;
            lblDescripcion.Visible = true;
            txtDescripcion.Visible = true;
            lblLinea.Visible = true;
            cbxLinea.Visible = true;
            txtLinea.Visible = true;
            lblSerie.Visible = true;
            cbxSerie.Visible = true;
            txtSerie.Visible = true;
            lblFP.Visible = true;
            txtF_Peso.Visible = true;
            lblCsat.Visible = true;
            txtCodigoSat.Visible = true;
            btnBuscar_CSat.Visible = true;
            txtCodigoSatD.Visible = true;
            lblumedida.Visible = true;
            txtUnidadMedida.Visible = true;
            txtUnidadMedidaD.Visible = true;
            btnBuscar_Umed.Visible = true;
            lblsmin.Visible = true;
            txtStockMinimo.Visible = true;
            cBox1_Siniva.Visible = true;
            checkBox1_Inhabilitado.Visible = true;
            lblreferencia.Visible = true;
            txtReferencia.Visible = true;
            lblprecio.Visible = true;
            txtPrecio.Visible = true;
            lblCBarras.Visible = true;
            txtCBarras.Visible = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnBuscar_Lin.Visible = true;
            btnBuscar_Ser.Visible = true;
            btnElimina.Visible = true;
        }

        private void Invisible()
        {
            lblClave.Visible = false;
            txtxClave.Visible = false;
            lblDescripcion.Visible = false;
            txtDescripcion.Visible = false;
            lblLinea.Visible = false;
            cbxLinea.Visible = false;
            txtLinea.Visible = false;
            lblSerie.Visible = false;
            cbxSerie.Visible = false;
            txtSerie.Visible = false;
            lblFP.Visible = false;
            txtF_Peso.Visible = false;
            lblCsat.Visible = false;
            txtCodigoSat.Visible = false;
            btnBuscar_CSat.Visible = false;
            txtCodigoSatD.Visible = false;
            lblumedida.Visible = false;
            txtUnidadMedida.Visible = false;
            txtUnidadMedidaD.Visible = false;
            btnBuscar_Umed.Visible = false;
            lblsmin.Visible = false;
            txtStockMinimo.Visible = false;
            cBox1_Siniva.Visible = false;
            checkBox1_Inhabilitado.Visible = false;
            lblreferencia.Visible = false;
            txtReferencia.Visible = false;
            lblprecio.Visible = false;
            txtPrecio.Visible = false;
            lblCBarras.Visible = false;
            txtCBarras.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            btnBuscar_Lin.Visible = false;
            btnBuscar_Ser.Visible = false;
            btnElimina.Visible = false;
        }

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

        private void smEdiArti_Load(object sender, EventArgs e)
        {
            cboxNombre.Checked = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Clave = txtCodigo.Text;
            string Nombre = txtCodigo.Text;

            try
            {
                if (cboxNombre.Checked == true)
                {
                    int existe = 0;
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT * FROM Articulos_ WHERE Descripcion = '" + Nombre + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataReader myreader;
                    try
                    {
                        sqlcon.Open();
                        myreader = cmd.ExecuteReader();
                        while (myreader.Read())
                        {
                            existe = 1;
                            Visible();
                            txtxClave.Text = myreader["Clave"].ToString();
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
                            txtCBarras.Text = myreader["Codigo_Barras"].ToString();
                            txtPrecio.Text = myreader["Precio"].ToString();
                        }
                        if (existe == 0)
                        {
                            MessageBox.Show("El nombre del producto no existe en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtxClave.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlcon.Close();
                    }
                }

                if (cboxCodigo.Checked == true)
                {                    
                    if (Clave == "")
                    {
                        MessageBox.Show("La clave del producto no existe en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int existe = 0;
                        SqlConnection sqlcon_cla = new SqlConnection();
                        sqlcon_cla.ConnectionString = Conexion.Cn;
                        string sql_cla = "SELECT * FROM Articulos_ WHERE Clave = '" + Clave + "'";
                        SqlCommand cmd_cla = new SqlCommand(sql_cla, sqlcon_cla);
                        SqlDataReader myreader_cla;
                        try
                        {
                            sqlcon_cla.Open();
                            myreader_cla = cmd_cla.ExecuteReader();
                            while (myreader_cla.Read())
                            {
                                existe = 1;
                                Visible();
                                txtxClave.Text = myreader_cla["Clave"].ToString();
                                txtDescripcion.Text = myreader_cla["Descripcion"].ToString();
                                cbxLinea.Text = myreader_cla["Linea"].ToString();
                                cbxSerie.Text = myreader_cla["Serie"].ToString();
                                txtF_Peso.Text = myreader_cla["Peso"].ToString();
                                txtCodigoSat.Text = myreader_cla["Clave_Sat"].ToString();
                                txtUnidadMedida.Text = myreader_cla["U_Medida"].ToString();
                                txtStockMinimo.Text = myreader_cla["Stock_Minimo"].ToString();
                                cBox1_Siniva.Checked = Convert.ToBoolean(myreader_cla["Ex_Iva"].ToString());
                                checkBox1_Inhabilitado.Checked = Convert.ToBoolean(myreader_cla["Inactivo"].ToString());
                                txtReferencia.Text = myreader_cla["Referencia"].ToString();
                                txtCBarras.Text = myreader_cla["Codigo_Barras"].ToString();
                                txtPrecio.Text = myreader_cla["Precio"].ToString();
                            }
                            if (existe == 0)
                            {
                                MessageBox.Show("La clave del producto no existe en el catalogo de productos. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtxClave.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sqlcon_cla.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la edicion del articulo?", "LinxSystems|Cancelar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Invisible();
            }
            else
            {
                return;
            }
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el articulo seleccionado?", "LinxSystems | Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Clave = txtxClave.Text;
                    SqlConnection sqlcon_eli = new SqlConnection();                
                    sqlcon_eli.ConnectionString = Conexion.Cn;
                    sqlcon_eli.Open();
                    string sql_eli = "DELETE FROM Articulos_ WHERE Clave ='" + Clave + "'";
                    SqlCommand cmd_eli = new SqlCommand(sql_eli, sqlcon_eli);
                    int cant;
                    cant = cmd_eli.ExecuteNonQuery();
                    if (cant == 1)
                    {
                        MessageBox.Show("El Articulo ha sido eliminado correctamente.", "LinxSystems | Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Invisible();
                        sqlcon_eli.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Articulo no ha sido eliminado, avise a sistemas.", "LinxSystems | Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Proceso cancelado.", "LinxSystems | Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("El proceso present aun problema , avise a sistemas.", "LinxSystems | Eliminar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigoSat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE CODIGO SAT///////////////////////////
                string Clave = txtCodigoSat.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Clavp_Sat WHERE Clave = '" + Clave + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtCodigoSatD.Text = myreader_ser["Descripcion"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE UNIDAD DE MEDIDA///////////////////////////
                string U_Medida = txtUnidadMedida.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Uni_Med WHERE Clave_Um = '" + U_Medida + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtUnidadMedidaD.Text = myreader_ser["Descripcion_Um"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxLinea_TextChanged(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSerie_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE SERIESSS////////////////////////////
                string id_Serie = cbxSerie.Text;
                string id_Linea = cbxLinea.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Series WHERE Serie= '" + id_Serie + "' AND Linea='" + id_Linea + "'";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar este articulo?", "LinxSystems|Aceptar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Linea = Convert.ToInt32(cbxLinea.Text);
                    int Serie = Convert.ToInt32(cbxSerie.Text);
                    string Clave = txtxClave.Text;
                    string Descripcion = txtDescripcion.Text;
                    double Precio = Convert.ToDouble(txtPrecio.Text);
                    string C_Barras = txtCBarras.Text;
                    double Peso = Convert.ToDouble(txtF_Peso.Text);
                    int Stock_Min = Convert.ToInt32(txtStockMinimo.Text);
                    bool Inactivo = Convert.ToBoolean(cBox1_Siniva.Checked);
                    bool Ex_Iva = Convert.ToBoolean(checkBox1_Inhabilitado.Checked);
                    int Clave_Sat = Convert.ToInt32(txtCodigoSat.Text);
                    string Uni_Med = txtUnidadMedida.Text;
                    string Referencia = txtReferencia.Text;

                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "UPDATE Articulos_ SET Linea='" + Linea + "',Serie='" + Serie + "',Clave='" + Clave + "',Codigo_Barras='" + C_Barras + "',Descripcion='" + Descripcion + "',Precio='" + Precio + "',Peso='" + Peso + "',Stock_Minimo='" + Stock_Min + "',Inactivo='" + Inactivo + "',Ex_Iva='" + Ex_Iva + "',Clave_Sat='" + Clave_Sat + "',U_Medida='" + Uni_Med + "',Referencia='" + Referencia + "' WHERE Clave='" + Clave + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    sqlcon.Open();
                    int cant;
                    cant = cmd.ExecuteNonQuery();

                    if (cant == 1)
                    {
                        MessageBox.Show("Articulo modificado exitosamente.", "LinxSystems|Edicion de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Invisible();
                        txtCodigo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El articulo no fue modificado.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El articulo no fue modificado.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_CSat_Click(object sender, EventArgs e)
        {
            smClaSat frmClasat = new smClaSat();
            frmClasat.Show();
        }

        private void btnBuscar_Umed_Click(object sender, EventArgs e)
        {
            smUniMed frmUniMed = new smUniMed();
            frmUniMed.Show();
        }

        private void btnBuscar_Lin_Click(object sender, EventArgs e)
        {
            smBuscaLin frmBuscaLin = new smBuscaLin();
            frmBuscaLin.Show();
        }

        private void btnBuscar_Ser_Click(object sender, EventArgs e)
        {
            smBuscaSer frmBuscaSer = new smBuscaSer();
            frmBuscaSer.Show();
        }

        private void txtCodigoSat_KeyPress(object sender, KeyPressEventArgs e)
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
                            txtUnidadMedida.Focus();
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
    }
}
