using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Catalogos.Clientes
{
    public partial class txtMoneda : MaterialForm
    {
        public txtMoneda()
        {
            InitializeComponent();
        }

        private void Visible()
        {
            lblClie.Visible = true;
            txtN_Cliente.Visible = true;
            lblPer.Visible = true;
            cbxTPersona.Visible = true;
            txtTPersonaD.Visible = true;
            lblRegi.Visible = true;
            cbxRegFiscal.Visible = true;
            txtRegFiscal.Visible = true;
            lblNom.Visible = true;
            txtNom_Cliente.Visible = true;
            lblCp.Visible = true;
            txtCP.Visible = true;
            lblCfd.Visible = true;
            cbxCFDI.Visible = true;
            txtCFDI.Visible = true;
            lblCall.Visible = true;
            txtCalle.Visible = true;
            lblCol.Visible = true;
            txtColonia.Visible = true;
            lblExt.Visible = true;
            txtN_Exterior.Visible = true;
            lblInt.Visible = true;
            txtN_Interior.Visible = true;
            lblEst.Visible = true;
            cbxEstado.Visible = true;
            txtEstado.Visible = true;
            lblMun.Visible = true;
            txtMunicipio.Visible = true;
            lblCiu.Visible = true;
            txtCiudad.Visible = true;
            lblCele.Visible = true;
            txtCorreo.Visible = true;
            lblTel.Visible = true;
            txtTelefono.Visible = true;
            lblVend.Visible = true;
            cbxVendedor.Visible = true;
            txtVendedor.Visible = true;
            lblCre.Visible = true;
            txtCredito.Visible = true;
            lblCont.Visible = true;
            txtContacto.Visible = true;
            lblCre.Visible = true;
            txtCredito.Visible = true;
            lblCont.Visible = true;
            txtContacto.Visible = true;
            lblCredi.Visible = true;
            txtDiasCredito.Visible = true;
            lblMpag.Visible = true;
            cbxMetPago.Visible = true;
            txtMetPago.Visible = true;
            lblFpag.Visible = true;
            cbxForma_Pago.Visible = true;
            txtForma_Pago.Visible = true;
            lblPais.Visible = true;
            cbxPais.Visible = true;
            txtPais.Visible = true;
            cbxZona.Visible = true;
            
        }

        private void Invisible()
        {
            lblClie.Visible = false;
            txtN_Cliente.Visible = false;
            lblPer.Visible = false;
            cbxTPersona.Visible = false;
            txtTPersonaD.Visible = false;
            lblRegi.Visible = false;
            cbxRegFiscal.Visible = false;
            txtRegFiscal.Visible = false;
            lblNom.Visible = false;
            txtNom_Cliente.Visible = false;
            lblCp.Visible = false;
            txtCP.Visible = false;
            lblCfd.Visible = false;
            cbxCFDI.Visible = false;
            txtCFDI.Visible = false;
            lblCall.Visible = false;
            txtCalle.Visible = false;
            lblCol.Visible = false;
            txtColonia.Visible = false;
            lblExt.Visible = false;
            txtN_Exterior.Visible = false;
            lblInt.Visible = false;
            txtN_Interior.Visible = false;
            lblEst.Visible = false;
            cbxEstado.Visible = false;
            txtEstado.Visible = false;
            lblMun.Visible = false;
            txtMunicipio.Visible = false;
            lblCiu.Visible = false;
            txtCiudad.Visible = false;
            lblCele.Visible = false;
            txtCorreo.Visible = false;
            lblTel.Visible = false;
            txtTelefono.Visible = false;
            lblVend.Visible = false;
            cbxVendedor.Visible = false;
            txtVendedor.Visible = false;
            lblCre.Visible = false;
            txtCredito.Visible = false;
            lblCont.Visible = false;
            txtContacto.Visible = false;
            lblCre.Visible = false;
            txtCredito.Visible = false;
            lblCont.Visible = false;
            txtContacto.Visible = false;
            lblCredi.Visible = false;
            txtDiasCredito.Visible = false;
            lblMpag.Visible = false;
            cbxMetPago.Visible = false;
            txtMetPago.Visible = false;
            lblFpag.Visible = false;
            cbxForma_Pago.Visible = false;
            txtForma_Pago.Visible = false;
            lblPais.Visible = false;
            cbxPais.Visible = false;
            txtPais.Visible = false;

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

        private void smEdiClie_Load(object sender, EventArgs e)
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
                    string sql = "SELECT * FROM Clientes WHERE Nombre = '" + Nombre + "'";
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
                            txtN_Cliente.Text = myreader["Id_Cliente"].ToString();
                            txtRFC.Text = myreader["RFC"].ToString();
                            cbxMoneda.Text = myreader["Moneda"].ToString();
                            cbxTPersona.Text = myreader["T_Persona"].ToString();
                            cbxRegFiscal.Text = myreader["Reg_Fiscal"].ToString();
                            txtNom_Cliente.Text = myreader["Nombre"].ToString();
                            txtCP.Text = myreader["CP"].ToString();
                            cbxCFDI.Text = myreader["Uso_Cfdi"].ToString();
                            txtCalle.Text = myreader["Calle"].ToString();
                            txtColonia.Text = myreader["Colonia"].ToString();
                            txtN_Exterior.Text = myreader["N_Exterior"].ToString();
                            txtN_Interior.Text = myreader["N_Interior"].ToString();
                            cbxEstado.Text = myreader["Estado"].ToString();
                            txtMunicipio.Text = myreader["Municipio"].ToString();
                            txtCiudad.Text = myreader["Ciudad"].ToString();
                            txtCorreo.Text = myreader["Correo"].ToString();
                            txtTelefono.Text = myreader["Telefono"].ToString();
                            cbxVendedor.Text = myreader["Vendedor"].ToString();
                            txtCredito.Text = myreader["Credito"].ToString();
                            txtContacto.Text = myreader["Contacto"].ToString();
                            txtDiasCredito.Text = myreader["Dias_Credito"].ToString();
                            cbxMetPago.Text = myreader["MetoPago"].ToString();
                            cbxForma_Pago.Text = myreader["FormPago"].ToString();
                            cbxPais.Text = myreader["Pais"].ToString();
                            cbxZona.Text = myreader["Zona"].ToString();
                        }
                        if (existe == 0)
                        {
                            MessageBox.Show("El nombre del cliente no existe en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCodigo.Clear();
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
                        MessageBox.Show("El numero de cliente no existe en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int existe = 0;
                        SqlConnection sqlcon_cla = new SqlConnection();
                        sqlcon_cla.ConnectionString = Conexion.Cn;
                        string sql_cla = "SELECT * FROM Clientes WHERE Id_Cliente= '" + Clave + "'";
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
                                txtN_Cliente.Text = myreader_cla["Id_Cliente"].ToString();
                                txtRFC.Text = myreader_cla["RFC"].ToString();
                                cbxMoneda.Text = myreader_cla["Moneda"].ToString();
                                cbxTPersona.Text = myreader_cla["T_Persona"].ToString();
                                cbxRegFiscal.Text = myreader_cla["Reg_Fiscal"].ToString();
                                txtNom_Cliente.Text = myreader_cla["Nombre"].ToString();
                                txtCP.Text = myreader_cla["CP"].ToString();
                                cbxCFDI.Text = myreader_cla["Uso_Cfdi"].ToString();
                                txtCalle.Text = myreader_cla["Calle"].ToString();
                                txtColonia.Text = myreader_cla["Colonia"].ToString();
                                txtN_Exterior.Text = myreader_cla["N_Exterior"].ToString();
                                txtN_Interior.Text = myreader_cla["N_Interior"].ToString();
                                cbxEstado.Text = myreader_cla["Estado"].ToString();
                                txtMunicipio.Text = myreader_cla["Municipio"].ToString();
                                txtCiudad.Text = myreader_cla["Ciudad"].ToString();
                                txtCorreo.Text = myreader_cla["Correo"].ToString();
                                txtTelefono.Text = myreader_cla["Telefono"].ToString();
                                cbxVendedor.Text = myreader_cla["Vendedor"].ToString();
                                txtCredito.Text = myreader_cla["Credito"].ToString();
                                txtContacto.Text = myreader_cla["Contacto"].ToString();
                                txtDiasCredito.Text = myreader_cla["Dias_Credito"].ToString();
                                cbxMetPago.Text = myreader_cla["MetoPago"].ToString();
                                cbxForma_Pago.Text = myreader_cla["FormPago"].ToString();
                                cbxPais.Text = myreader_cla["Pais"].ToString();
                                cbxZona.Text = myreader_cla["Zona"].ToString();
                            }
                            if (existe == 0)
                            {
                                MessageBox.Show("El numero de cliente no existe en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtCodigo.Clear();
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

        private void cbxTPersona_TextChanged(object sender, EventArgs e)
        {
             try
            {
                //LLENANDO TEXT DESCRIPCION DE TIPO DE PERSONA///////////////////////////
                string Tip_Persona = cbxTPersona.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM TipPersona WHERE Id_Persona = '" + Tip_Persona + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtTPersonaD.Text = myreader_ser["Descripcion"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRegFiscal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE REGIMEN FISCAL///////////////////////////
                string RegFiscal = cbxRegFiscal.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM RegFiscal WHERE Id_Rfiscal = '" + RegFiscal + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtRegFiscal.Text = myreader_ser["Rfiscal"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCFDI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE USO CFDI///////////////////////////
                string Uso_Cfdi = cbxCFDI.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Uso WHERE IdUso = '" + Uso_Cfdi + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtCFDI.Text= myreader_ser["Uso"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxEstado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE ESTADO///////////////////////////
                string Estado = cbxEstado.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Estados WHERE Estado = '" + Estado + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtEstado.Text = myreader_ser["Nombre"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxVendedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE VENDEDOR///////////////////////////
                string Vendedor = cbxVendedor.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Vendedores WHERE Id_Vendedor = '" + Vendedor + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtVendedor.Text = myreader_ser["Nombre"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxMetPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE METODO DE PAGO///////////////////////////
                string M_Pago = cbxMetPago.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM MetoPago WHERE IdMetoPag = '" + M_Pago + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtMetPago.Text = myreader_ser["MetoPago"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxForma_Pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE FORMA DE PAGO///////////////////////////
                string F_Pago = cbxForma_Pago.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM FormPago WHERE IdForPag = '" + F_Pago + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtForma_Pago.Text = myreader_ser["ForPago"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxPais_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE PAIS///////////////////////////
                string Pais = cbxPais.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Pais_Prefe WHERE Id_Pais = '" + Pais + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtPais.Text = myreader_ser["Descripcion"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxZona_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE ZONA///////////////////////////
                string Zona = cbxZona.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM Zona WHERE IdZona = '" + Zona + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                    txtZona.Text = myreader_ser["Zona"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxMoneda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DESCRIPCION DE MONEDA///////////////////////////
                string Moneda = cbxMoneda.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_ser = "SELECT * FROM TipMoneda WHERE IdMon = '" + Moneda + "'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataReader myreader_ser;
                sqlcon.Open();
                myreader_ser = cmd_ser.ExecuteReader();
                while (myreader_ser.Read())
                {
                     txMoneda.Text= myreader_ser["Moneda"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la eidcion de los datos del cliente?", "LinxSystems|Cancelar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Invisible();
            }
            else
            {
                return;
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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar la información del cliente?", "LinxSystems|Aceptar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string N_Cliente = txtN_Cliente.Text;
                string Moneda = cbxMoneda.Text;
                string RFC = txtRFC.Text;
                string T_Persona = cbxTPersona.Text;
                string R_Fiscal = cbxRegFiscal.Text;
                string Nombre = txtNom_Cliente.Text;
                string CP = txtCodigo.Text;
                string Uso_cfdi = cbxCFDI.Text;
                string Calle = txtCalle.Text;
                string Colonia = txtColonia.Text;
                string N_Exterior = txtN_Exterior.Text;
                string N_Interior = txtN_Interior.Text;
                string Estado = cbxEstado.Text;
                string Municipio = txtMunicipio.Text;
                string Ciudad = txtCiudad.Text;
                string Correo = txtCorreo.Text;
                string Telefono = txtTelefono.Text;
                string Vendedor = cbxVendedor.Text;
                double Credito = Convert.ToDouble(txtCredito.Text);
                string Contacto = txtContacto.Text;
                int Dias_Credito = Convert.ToInt32(txtDiasCredito.Text);
                string Met_Pago = cbxMetPago.Text;
                string For_Pago = cbxForma_Pago.Text;
                string Pais = cbxPais.Text;
                string Zona = cbxZona.Text;

                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "UPDATE Clientes SET Id_Cliente='" + N_Cliente + "',Nombre='" + Nombre + "',RFC='" + RFC + "',T_Persona='" + T_Persona + "',Calle='" + Calle + "',N_Exterior='" + N_Exterior + "',N_Interior='" + N_Interior + "',Colonia='" + Colonia + "',Municipio='" + Municipio + "',CP='" + CP + "',Ciudad='" + Ciudad + "',Estado ='" + Estado + "',Telefono ='" + Telefono + "',Contacto ='" + Contacto + "',Vendedor ='" + Vendedor + "',Zona ='" + Zona + "',Credito ='" + Credito + "',Dias_Credito ='" + Dias_Credito + "',Pais ='" + Pais + "',Uso_Cfdi ='" + Uso_cfdi + "',Correo ='" + Correo + "',Reg_Fiscal ='" + R_Fiscal + "',FormPago ='" + For_Pago + "',MetoPago ='" + Met_Pago + "',Moneda ='" + txMoneda + "' WHERE Id_Cliente='" + N_Cliente + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                sqlcon.Open();
                int cant;
                cant = cmd.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("Cliente modificado exitosamente.", "LinxSystems|Edicion de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Invisible();
                    txtCodigo.Clear();
                }
                else
                {
                    MessageBox.Show("El cliente no fue modificado.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El cliente no fue modificado.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        
        }

        private void btnBuscar_Mon_Click(object sender, EventArgs e)
        {
            smClaSat frmClasat = new smClaSat();
            frmClasat.Show();
        }
    }
}



