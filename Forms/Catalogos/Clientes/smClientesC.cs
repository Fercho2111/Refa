using System;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinxAdmo.Forms.Catalogos.Clientes;

namespace LinxAdmo.Forms.Catalogos
{
    public partial class smClientesC : MaterialForm
    {
        public smClientesC()
        {
            InitializeComponent();
        }

        private void Deshabilita()
        {
            txtRFC.Enabled = false;
            cbxTPersona.Enabled = false;
            txtTPersonaD.Enabled = false;
            txtNom_Cliente.Enabled = false;
            txtCalle.Enabled = false;
            txtN_Exterior.Enabled = false;
            txtN_Interior.Enabled = false;
            txtColonia.Enabled = false;
            txtMunicipio.Enabled = false;
            txtCP.Enabled = false;
            txtCiudad.Enabled = false;
            cbxEstado.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefono.Enabled = false;
            txtContacto.Enabled = false;
            cbxVendedor.Enabled = false;
            txtVendedor.Enabled = false;
            txtCredito.Enabled = false;
            txtDiasCredito.Enabled = false;
            cbxPais.Enabled = false;
            txtPais.Enabled = false;
            cbxCFDI.Enabled = false;
            txtCFDI.Enabled = false;
            txtMetPago.Enabled = false;
            cbxMetPago.Enabled = false;
            txtForma_Pago.Enabled = false;
            cbxForma_Pago.Enabled = false;
            cbxRegFiscal.Enabled = false;
            txtRegFiscal.Enabled = false;
            txtCorreo.Enabled = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            
        }
        private void Habilita()
        {
            txtRFC.Enabled = true;
            cbxTPersona.Enabled = true;
            txtTPersonaD.Enabled = true;
            txtNom_Cliente.Enabled = true;
            txtCalle.Enabled = true;
            txtN_Exterior.Enabled = true;
            txtN_Interior.Enabled = true;
            txtColonia.Enabled = true;
            txtMunicipio.Enabled = true;
            txtCP.Enabled = true;
            txtCiudad.Enabled = true;
            cbxEstado.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefono.Enabled = true;
            txtContacto.Enabled = true;
            cbxVendedor.Enabled = true;
            txtVendedor.Enabled = true;
            txtCredito.Enabled = true;
            txtDiasCredito.Enabled = true;
            cbxPais.Enabled = true;
            txtPais.Enabled = true;
            cbxCFDI.Enabled = true;
            txtCFDI.Enabled = true;
            txtCorreo.Enabled = true;
            txtMetPago.Enabled = true;
            cbxMetPago.Enabled = true;
            txtForma_Pago.Enabled = true;
            cbxForma_Pago.Enabled = true;
            cbxRegFiscal.Enabled = true;
            txtRegFiscal.Enabled = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnBuscar.Visible = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnDescuento.Visible = true;
        }
        
        private void Limpia()
        {
            txtN_Cliente.Clear();
            txtRFC.Clear();
            cbxTPersona.Text= "";
            txtTPersonaD.Clear();
            txtNom_Cliente.Clear();
            txtCalle.Clear();
            txtN_Exterior.Clear();
            txtN_Interior.Clear();
            txtColonia.Clear();
            txtMunicipio.Clear();
            txtCP.Clear();
            txtCiudad.Clear();
            cbxEstado.Enabled = true;
            txtEstado.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            cbxVendedor.Text= "";
            txtVendedor.Clear();
            txtCredito.Clear();
            txtDiasCredito.Clear();
            cbxPais.Text= " ";
            txtPais.Clear();
            cbxCFDI.Text= " ";
            txtCFDI.Clear();
            txtCorreo.Clear();
            cbxMetPago.Text = " ";
            txtForma_Pago.Clear();
            cbxForma_Pago.Text = " ";
            txtMetPago.Clear();
            txtRegFiscal.Clear();
            cbxRegFiscal.Text = " ";
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnBuscar.Visible = true;
            btnDescuento.Checked = false;
        }

        private void smClientes_Load(object sender, EventArgs e)
        {
            Deshabilita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilita();
            txtRFC.Focus();          
            try
            {
                //LLENANDO TEXT DE NUMERO DE CLIENTE                    
                SqlConnection sqlcon_NCliente = new SqlConnection();                
                sqlcon_NCliente.ConnectionString = Conexion.Cn;
                string sql_NCliente = "SELECT * FROM Clientes WHERE Id_Cliente = (SELECT MAX(Id_Cliente) FROM Clientes)";
                sqlcon_NCliente.Open();
                SqlCommand cmd_NCliente = new SqlCommand(sql_NCliente, sqlcon_NCliente);
                int N_Cliente = Convert.ToInt32(cmd_NCliente.ExecuteScalar())+1;
                txtN_Cliente.Text = Convert.ToString(N_Cliente);
                sqlcon_NCliente.Close();


                //LLENANDO COMBO TIPO PERSONA/////////////////////////////////////////////////////////////////////////////////////////////////
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tp = "SELECT * FROM TipPersona";
                SqlCommand cmd_tp = new SqlCommand(sql_tp, sqlcon);
                SqlDataAdapter mysqldt_tp = new SqlDataAdapter(cmd_tp);
                DataTable dt_tp = new DataTable();
                mysqldt_tp.Fill(dt_tp);
                cbxTPersona.ValueMember = "Id_Persona";
                cbxTPersona.DisplayMember = "Id_Persona";
                cbxTPersona.DataSource = dt_tp;

                //LLENANDO COMBO ESTADO/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_est = "SELECT * FROM Estados";
                SqlCommand cmd_est = new SqlCommand(sql_est, sqlcon);
                SqlDataAdapter mysqldt_est = new SqlDataAdapter(cmd_est);
                DataTable dt_est = new DataTable();
                mysqldt_est.Fill(dt_est);
                cbxEstado.ValueMember = "Estado";
                cbxEstado.DisplayMember = "Estado";
                cbxEstado.DataSource = dt_est;

                //LLENANDO COMBO PAIS/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_pai = "SELECT * FROM Pais_Prefe";
                SqlCommand cmd_pai = new SqlCommand(sql_pai, sqlcon);
                SqlDataAdapter mysqldt_pai = new SqlDataAdapter(cmd_pai);
                DataTable dt_pai = new DataTable();
                mysqldt_pai.Fill(dt_pai);
                cbxPais.ValueMember = "Id_Pais";
                cbxPais.DisplayMember = "Id_Pais";
                cbxPais.DataSource = dt_pai;

                //LLENANDO COMBO USO CFDI/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_cfdi = "SELECT * FROM Uso";
                SqlCommand cmd_cfdi = new SqlCommand(sql_cfdi, sqlcon);
                SqlDataAdapter mysqldt_cfdi = new SqlDataAdapter(cmd_cfdi);
                DataTable dt_cfdi = new DataTable();
                mysqldt_cfdi.Fill(dt_cfdi);
                cbxCFDI.ValueMember = "IdUso";
                cbxCFDI.DisplayMember = "IdUso";
                cbxCFDI.DataSource = dt_cfdi;

                //LLENANDO COMBO USO METODO DE PAGO/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_Mpago = "SELECT * FROM MetoPago";
                SqlCommand cmd_Mpago = new SqlCommand(sql_Mpago, sqlcon);
                SqlDataAdapter mysqldt_Mpago = new SqlDataAdapter(cmd_Mpago);
                DataTable dt_Mpago = new DataTable();
                mysqldt_Mpago.Fill(dt_Mpago);
                cbxMetPago.ValueMember = "IdMetoPag";
                cbxMetPago.DisplayMember = "IdMetoPag";
                cbxMetPago.DataSource = dt_Mpago;

                //LLENANDO COMBO USO FORMA DE PAGO/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_Fpago = "SELECT * FROM FormPago";
                SqlCommand cmd_Fpago = new SqlCommand(sql_Fpago, sqlcon);
                SqlDataAdapter mysqldt_Fpago = new SqlDataAdapter(cmd_Fpago);
                DataTable dt_Fpago = new DataTable();
                mysqldt_Fpago.Fill(dt_Fpago);
                cbxForma_Pago.ValueMember = "IdForPag";
                cbxForma_Pago.DisplayMember = "IdForPag";
                cbxForma_Pago.DataSource = dt_Fpago;

                //LLENANDO COMBO REGIMEN FISCAL/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_Rfiscal = "SELECT * FROM RegFiscal";
                SqlCommand cmd_Rfiscal = new SqlCommand(sql_Rfiscal, sqlcon);
                SqlDataAdapter mysqldt_Rfiscal = new SqlDataAdapter(cmd_Rfiscal);
                DataTable dt_Rfiscal = new DataTable();
                mysqldt_Rfiscal.Fill(dt_Rfiscal);
                cbxRegFiscal.ValueMember = "Id_Rfiscal";
                cbxRegFiscal.DisplayMember = "Id_Rfiscal";
                cbxRegFiscal.DataSource = dt_Rfiscal;


                //LLENANDO COMBO VENDEDOR/////////////////////////////////////////////////////////////////////////////////////////////////
                string sql_Ven = "SELECT * FROM Vendedores";
                SqlCommand cmd_Ven = new SqlCommand(sql_Ven, sqlcon);
                SqlDataAdapter mysqldt_Ven = new SqlDataAdapter(cmd_Ven);
                DataTable dt_Ven = new DataTable();
                mysqldt_Ven.Fill(dt_Ven);
                cbxVendedor.ValueMember = "Id_Vendedor";
                cbxVendedor.DisplayMember = "Id_Vendedor";
                cbxVendedor.DataSource = dt_Ven;

                //DEFINIENDO DATOS ININCIALES EN LOS COMBO BOX

                cbxTPersona.Text = "M";
                cbxEstado.Text = "09";
                cbxPais.Text = "08";
                cbxCFDI.Text = "P01";
                cbxMetPago.Text = "PUE";
                cbxForma_Pago.Text = "01";
                txtN_Interior.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void cbxTPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT DESCRIPCION DE TIPO DE PERSONA//////////////////
                string id_tp = cbxTPersona.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tp = "SELECT * FROM TipPersona WHERE Id_Persona = '" + id_tp + "'";
                SqlCommand cmd_tp = new SqlCommand(sql_tp, sqlcon);
                SqlDataReader myreader_tp;
                sqlcon.Open();
                myreader_tp = cmd_tp.ExecuteReader();
                while (myreader_tp.Read())
                {
                    txtTPersonaD.Text = myreader_tp["Descripcion"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRegFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT REGIMEN FISCAL //////////////////
                string Id_Rfiscal = cbxRegFiscal.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_Rfiscal = "SELECT * FROM RegFiscal WHERE Id_Rfiscal = '" + Id_Rfiscal + "'";
                SqlCommand cmd_Rfiscal = new SqlCommand(sql_Rfiscal, sqlcon);
                SqlDataReader myreader_Rfiscal;
                sqlcon.Open();
                myreader_Rfiscal = cmd_Rfiscal.ExecuteReader();
                while (myreader_Rfiscal.Read())
                {
                    txtRegFiscal.Text = myreader_Rfiscal["Rfiscal"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCFDI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT DESCRIPCION DE USO CFDI//////////////////
                string id_cfdi = cbxCFDI.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_cfdi = "SELECT * FROM Uso WHERE IdUso = '" + id_cfdi + "'";
                SqlCommand cmd_cfdi = new SqlCommand(sql_cfdi, sqlcon);
                SqlDataReader myreader_cfdi;
                sqlcon.Open();
                myreader_cfdi = cmd_cfdi.ExecuteReader();
                while (myreader_cfdi.Read())
                {
                    txtCFDI.Text = myreader_cfdi["Uso"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT DESCRIPCION DE ESTADO//////////////////
                string id_est = cbxEstado.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_est = "SELECT * FROM Estados WHERE Estado = '" + id_est + "'";
                SqlCommand cmd_est = new SqlCommand(sql_est, sqlcon);
                SqlDataReader myreader_est;
                sqlcon.Open();
                myreader_est = cmd_est.ExecuteReader();
                while (myreader_est.Read())
                {
                    txtEstado.Text = myreader_est["Nombre"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT VENDEDOR //////////////////
                string Id_Vendedor = cbxVendedor.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_Vendedor = "SELECT * FROM Vendedores WHERE Id_Vendedor = '" + Id_Vendedor + "'";
                SqlCommand cmd_Vendedor = new SqlCommand(sql_Vendedor, sqlcon);
                SqlDataReader myreader_Vendedor;
                sqlcon.Open();
                myreader_Vendedor = cmd_Vendedor.ExecuteReader();
                while (myreader_Vendedor.Read())
                {
                    string Nombre = myreader_Vendedor["Nombre"] + " ".ToString();
                    string A_Paterno = myreader_Vendedor["A_Paterno"] + " ".ToString();
                    string A_Materno = myreader_Vendedor["A_Materno"] + " ".ToString();
                    string N_Completo = Nombre + A_Paterno + A_Materno;
                    txtVendedor.Text = N_Completo;
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxMetPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT METODO DE PAGO//////////////////
                string Id_Mpago = cbxMetPago.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_Mpago = "SELECT * FROM MetoPago WHERE IdMetoPag = '" + Id_Mpago + "'";
                SqlCommand cmd_Mpago = new SqlCommand(sql_Mpago, sqlcon);
                SqlDataReader myreader_Mpago;
                sqlcon.Open();
                myreader_Mpago = cmd_Mpago.ExecuteReader();
                while (myreader_Mpago.Read())
                {
                    txtMetPago.Text = myreader_Mpago["MetoPago"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxForma_Pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT FORMA DE PAGO//////////////////
                string Id_Fpago = cbxForma_Pago.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_Fpago = "SELECT * FROM FormPago WHERE IdForPag = '" + Id_Fpago + "'";
                SqlCommand cmd_Fpago = new SqlCommand(sql_Fpago, sqlcon);
                SqlDataReader myreader_Fpago;
                sqlcon.Open();
                myreader_Fpago = cmd_Fpago.ExecuteReader();
                while (myreader_Fpago.Read())
                {
                    txtForma_Pago.Text = myreader_Fpago["ForPago"].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LLENADO TEXT DESCRIPCION DE PAIS//////////////////
                string id_pai = cbxPais.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_pai = "SELECT * FROM Pais_Prefe WHERE Id_Pais = '" + id_pai + "'";
                SqlCommand cmd_pai = new SqlCommand(sql_pai, sqlcon);
                SqlDataReader myreader_pai;
                sqlcon.Open();
                myreader_pai = cmd_pai.ExecuteReader();
                while (myreader_pai.Read())
                {
                    txtPais.Text = myreader_pai["Descripcion"].ToString();
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
            if (MessageBox.Show("¿Desea cancelar?", "LinxSystems|Cancelar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpia();
                Deshabilita();
                btnDescuento.Checked = false;
            }
            else
            {
                return;
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string Id_Cliente = txtN_Cliente.Text;
                string Nom_Cliente = txtNom_Cliente.Text;
                string Rfc = txtRFC.Text;
                string TPersona = cbxTPersona.Text;
                string Calle = txtCalle.Text;
                string N_Exterior = txtN_Exterior.Text;
                string N_interior = txtN_Interior.Text;
                string Colonia = txtColonia.Text;
                string Municipio = txtMunicipio.Text;
                string CP = txtCP.Text;
                string Ciudad = txtCiudad.Text;
                string Estado = cbxEstado.Text;
                string Telefono = txtTelefono.Text;
                string Contacto = txtContacto.Text;
                string Vendedor = cbxVendedor.Text;
                double Credito = Convert.ToDouble(txtCredito.Text);
                int Dias_Credito = Convert.ToInt32(txtDiasCredito.Text);
                string Pais = cbxPais.Text;
                string Uso_Cfdi = cbxCFDI.Text;
                string Correo = txtCorreo.Text;
                string Reg_Fiscal = cbxRegFiscal.Text;
                string For_Pago = cbxForma_Pago.Text;
                string Met_Pago = cbxMetPago.Text;
                Byte Descuento = Convert.ToByte(btnDescuento.Checked);
                //CREAMOS LA CONSULTA Y LA INSERTAMOS LAS VARIABLES/////////////////////                              
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql_art = "INSERT INTO Clientes (Id_Cliente,Nombre,RFC,T_Persona,Calle,N_Exterior,N_Interior,Colonia,Municipio,CP,Ciudad,Estado,Telefono,Contacto,Vendedor,Credito,Dias_Credito,Pais,Uso_Cfdi,Correo,Reg_Fiscal,FormPago,MetoPago,Des_Espe) " +
                "VALUES ('" + Id_Cliente + "','" + Nom_Cliente + "','" + Rfc + "','" + TPersona + "','" + Calle + "','" + N_Exterior + "','" + N_interior + "','" + Colonia + "'," +
                "'" + Municipio + "','" + CP + "','" + Ciudad + "','" + Estado + "','" + Telefono + "','" + Contacto + "','" + Vendedor + "','" + Credito + "','" + Dias_Credito + "','" + Pais + "'," +
                "'" + Uso_Cfdi + "','" + Correo + "','" + Reg_Fiscal + "','" + For_Pago + "','" + Met_Pago + "','"+Descuento+"')";
                SqlCommand comando = new SqlCommand(sql_art, sqlcon);
                int cont;
                cont = comando.ExecuteNonQuery();

                if (cont == 1)
                {
                    MessageBox.Show("Cliente registrado con exito.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                    Limpia();
                    Deshabilita();
                    
                }
                else
                {
                    MessageBox.Show("Cliente no registrado. De aviso a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpia();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            smBuscaCli frmBuscaCli = new smBuscaCli();
            frmBuscaCli.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtMoneda frmEdiClie = new txtMoneda();
            frmEdiClie.Show();
        }
    }
}
