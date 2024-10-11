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
using LinxAdmo.Forms.Catalogos;

namespace LinxAdmo.Forms
{
    public partial class smAlta_Articulos : Form
    {
        
        public smAlta_Articulos()
        {
            InitializeComponent();            
        }
        
        private void smCompra_Articulos_Load(object sender, EventArgs e)
        {
            try
            {
                txtclave.Enabled = false;
                btnRegistrar.Visible = false;                
                txtarancel.Text = "00.00";
                txtol.Text = "00.00";
                txtlventa.Text = "00.00";
                txtpus.Text = "00.00";
                txtgtoimpor.Text = "00.00";
                txtempaque.Text = "00.00";
                txtempacador.Text = "00.00";
                txtcopr.Text = "00.00";
                txtms.Text = "00.00";
                txtpeso.Text = "00.00";
                txtdimensiones.Text = "0.00";
                txtID.Focus();
                this.txtID.BackColor = Color.FromArgb(175, 238, 238);
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;

                string sql_lin = "SELECT * FROM Lineas";
                SqlCommand cmd_lin = new SqlCommand(sql_lin, sqlcon);
                SqlDataAdapter mysqldt_lin = new SqlDataAdapter(cmd_lin);
                DataTable dt_lin = new DataTable();
                mysqldt_lin.Fill(dt_lin);
                cbxlinea.ValueMember = "Linea";
                cbxlinea.DisplayMember = "Linea";
                cbxlinea.DataSource = dt_lin;

                string sql_pai = "SELECT * FROM Pais_Prefe";
                SqlCommand cmd_pai = new SqlCommand(sql_pai, sqlcon);
                SqlDataAdapter mysqldt_pai = new SqlDataAdapter(cmd_pai);
                DataTable dt_pai = new DataTable();
                mysqldt_pai.Fill(dt_pai);
                cbxpais_pref.ValueMember = "Id_Pais";
                cbxpais_pref.DisplayMember = "Id_Pais";
                cbxpais_pref.DataSource = dt_pai;

                string sql_tart = "SELECT * FROM Tipo_Art";
                SqlCommand cmd_tart = new SqlCommand(sql_tart, sqlcon);
                SqlDataAdapter mysqldt_tart = new SqlDataAdapter(cmd_tart);
                DataTable dt_tart = new DataTable();
                mysqldt_tart.Fill(dt_tart);
                cbxtipo.ValueMember = "Clave";
                cbxtipo.DisplayMember = "Clave";
                cbxtipo.DataSource = dt_tart;


                string sql_pro = "SELECT * FROM Proveedores";
                SqlCommand cmd_pro = new SqlCommand(sql_pro, sqlcon);
                SqlDataAdapter mysqldt_pro = new SqlDataAdapter(cmd_pro);
                DataTable dt_pro = new DataTable();
                mysqldt_pro.Fill(dt_pro);
                cbxprove_pref.ValueMember = "Id_proveedor"; /*Valor que mostrara en el box*/
                cbxprove_pref.DisplayMember = "Id_proveedor"; /*Columna a mostrar de la base de datos*/
                cbxprove_pref.DataSource = dt_pro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }           
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               try
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string clave_art = txtclave.Text;
                    string sql_busca = "SELECT * FROM Articulos WHERE Articulo = '" + clave_art + "'";
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(sql_busca, sqlcon);
                    SqlDataReader myreader;
                    myreader = cmd.ExecuteReader();
                    if (myreader.Read() == true)
                    {
                        MessageBox.Show( "Esta clave de producto ya existe.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtclave.Focus();
                        txtdescripcion.Text = myreader["Descripcion"].ToString();
                        cbxlinea.Text = myreader["Linea"].ToString();
                        cbxserie.Text = myreader["Serie"].ToString();
                        cbxpais_pref.Text = myreader["PaisPrefe"].ToString();
                        cbxtipo.Text = myreader["Tipoabc"].ToString();
                        txtmarca.Text = myreader["Marca"].ToString();
                        txtnota.Text = myreader["Notas"].ToString();
                        txtarancel.Text = myreader["Arancel"].ToString();
                        txtol.Text = myreader["OL"].ToString();
                        txtpus.Text = myreader["PrecioDls"].ToString();
                        txtgtoimpor.Text = myreader["Gto_Impo"].ToString();
                        txtempaque.Text = myreader["Empaque"].ToString();
                        txtempacador.Text = myreader["Empacador"].ToString();
                        txtcopr.Text = myreader["CoPr"].ToString();
                        txtms.Text = myreader["Sdis"].ToString();
                        txtdimensiones.Text = myreader["Dimesiones"].ToString();
                        txtpeso.Text = myreader["PesoKg"].ToString();
                        txtlventa.Text = myreader["PreciLista"].ToString();
                        txtms.Text = myreader["Sdis"].ToString();
                        cbxprove_pref.Text = myreader["ProvPrefe"].ToString();
                        txtcla_sat.Text = myreader["ClaveSat"].ToString();
                        txtuni_medida.Text = myreader["UnidadMedida"].ToString();
                        btnRegistrar.Visible = false;
                        txtclave.Enabled = false;
                    }            
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex+"DAAAAA");
                    
                }
            }
        }
        private void cbxlinea_TextChanged(object sender, EventArgs e)
        {
           try
            {
                string id_linea = cbxlinea.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tb_lin = "SELECT * FROM Lineas WHERE Linea = '" + id_linea + "'";
                SqlCommand cmd_tb_lin = new SqlCommand(sql_tb_lin, sqlcon);
                SqlDataReader myreader_tb_lin;
                sqlcon.Open();
                myreader_tb_lin = cmd_tb_lin.ExecuteReader();
                while (myreader_tb_lin.Read())
                {
                    txtlinea.Text = myreader_tb_lin["Des_Linea"].ToString();                
                }
                myreader_tb_lin.Close();
                string sql_ser = "SELECT * FROM Series WHERE Linea= '"+id_linea+"'";
                SqlCommand cmd_ser = new SqlCommand(sql_ser, sqlcon);
                SqlDataAdapter mysqldt_ser = new SqlDataAdapter(cmd_ser);
                DataTable dt_ser = new DataTable();
                mysqldt_ser.Fill(dt_ser);
                cbxserie.ValueMember = "Serie";
                cbxserie.DisplayMember = "Serie";
                cbxserie.DataSource = dt_ser;                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void cbxserie_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id_serie = cbxserie.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tb_ser= "SELECT * FROM Series WHERE Serie = '" + id_serie + "'";
                SqlCommand cmd_tb_ser = new SqlCommand(sql_tb_ser, sqlcon);
                SqlDataReader myreader_tb_ser;
                sqlcon.Open();
                myreader_tb_ser = cmd_tb_ser.ExecuteReader();
                while (myreader_tb_ser.Read())
                {
                    txtserie.Text = myreader_tb_ser["Desc_Serie"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxpais_pref_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id_pais = cbxpais_pref.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tb_pai = "SELECT * FROM Pais_Prefe WHERE Id_Pais = '" + id_pais + "'";
                SqlCommand cmd_tb_pai = new SqlCommand(sql_tb_pai, sqlcon);
                SqlDataReader myreader_tb_pai;
                sqlcon.Open();
                myreader_tb_pai = cmd_tb_pai.ExecuteReader();
                while (myreader_tb_pai.Read())
                {
                    txtpais_pref.Text = myreader_tb_pai["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        private void cbxtipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id_tipo = cbxtipo.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tb_tipo = "SELECT * FROM Tipo_Art WHERE Clave = '" + id_tipo + "'";
                SqlCommand cmd_tb_tipo = new SqlCommand(sql_tb_tipo, sqlcon);
                SqlDataReader myreader_tb_tipo;
                sqlcon.Open();
                myreader_tb_tipo = cmd_tb_tipo.ExecuteReader();
                while (myreader_tb_tipo.Read())
                {
                    txttipo.Text = myreader_tb_tipo["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbxprove_pref_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id_proveedor = cbxprove_pref.Text;
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql_tb_prov = "SELECT * FROM Proveedores WHERE Id_proveedor = '" + id_proveedor + "'";
                SqlCommand cmd_tb_prov = new SqlCommand(sql_tb_prov, sqlcon);
                SqlDataReader myreader_tb_pro;
                sqlcon.Open();
                myreader_tb_pro = cmd_tb_prov.ExecuteReader();
                while (myreader_tb_pro.Read())
                {
                    txtprove_pref.Text = myreader_tb_pro["Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtcla_sat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string clave_sat = txtcla_sat.Text;
                    string sql_clasat = "SELECT * FROM Clavp_Sat WHERE Clave = '" + clave_sat + "'";
                    sqlcon.Open();
                    SqlCommand cmd_clasat = new SqlCommand(sql_clasat, sqlcon);
                    SqlDataReader myreader_clasat;
                    myreader_clasat = cmd_clasat.ExecuteReader();
                    if (myreader_clasat.Read() == true)
                    {
                        txtdes_clasat.Text = myreader_clasat["Descripcion"].ToString(); ;
                    }
                    else
                    {
                        MessageBox.Show("Clave de sat inexistente, Verifique la clave.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcla_sat.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "DAAAAA");

                }
            }
        }

        private void txtuni_medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string clave_um = txtuni_medida.Text;
                    string sql_um = "SELECT * FROM Uni_Med WHERE Clave_Um = '" + clave_um + "'";
                    sqlcon.Open();
                    SqlCommand cmd_um = new SqlCommand(sql_um, sqlcon);
                    SqlDataReader myreader_um;
                    myreader_um = cmd_um.ExecuteReader();
                    if (myreader_um.Read() == true)
                    {
                        txtdes_unimedida.Text = myreader_um["Descripcion_um"].ToString(); ;
                    }
                    else
                    {
                        MessageBox.Show("Unidad de medida inexistente, Verifique la clave.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuni_medida.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "DAAAAA");

                }
            }
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string  acceso= txtID.Text;
                    string sql_acc = "SELECT * FROM Control_Inter WHERE Clave_Ci = '" + acceso + "'";
                    sqlcon.Open();
                    SqlCommand cmd_acc = new SqlCommand(sql_acc, sqlcon);
                    SqlDataReader myreader_acc;
                    myreader_acc = cmd_acc.ExecuteReader();
                    if (myreader_acc.Read() == true)
                    {                        
                        btnRegistrar.Visible = true;
                        txtID.Clear();
                        MessageBox.Show("Acceso Exitoso.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtclave.Enabled = true;
                        txtclave.Focus();
                        txtID.Visible = false;
                        lblId.Visible = false;                        
                    }
                    else
                    {
                        MessageBox.Show("Clave de registro incorrecta, Verifique la clave.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "DAAAAA");

                }
            }
        }

        private void txtarancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtlventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtpus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtgtoimpor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtempaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtempacador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcopr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string linea = cbxlinea.Text;
            string serie= cbxserie.Text;
            string articulo= txtclave.Text;
            string pais_pref=cbxpais_pref.Text;
            string notas=txtnota.Text;
            double preci_lista=Convert.ToDouble(txtlventa.Text);
            double precio_dolar=Convert.ToDouble(txtpus.Text);
            string tipoabc = cbxtipo.Text;
            string marca = txtmarca.Text;
            double sdis= Convert.ToDouble(txtms.Text);
            string descripcion= txtdescripcion.Text;
            string clave_sat= txtcla_sat.Text;
            string uni_medidad=txtuni_medida.Text;
            string prov_preferente= cbxprove_pref.Text;
            double ol=Convert.ToDouble(txtol.Text);
            double arancel= Convert.ToDouble(txtarancel.Text);
            double gto= Convert.ToDouble(txtgtoimpor.Text);
            double empaque= Convert.ToDouble(txtempaque.Text);
            double empacador= Convert.ToDouble(txtempacador.Text);
            double copr= Convert.ToDouble(txtcopr.Text);
            double peso_kg= Convert.ToDouble(txtpeso.Text);
            string dimensiones=txtdimensiones.Text;

            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql_art = "INSERT INTO Articulos (Linea, Serie, Articulo,PaisPrefe, Notas, PreciLista, PrecioDls, Tipoabc, Marca, Sdis, Descripcion, ClaveSat, UnidadMedida, ProvPrefe, OL, Arancel, Gto_Impo, Empaque, Empacador, CoPr,PesoKg, Dimesiones) " +
                "VALUES ('" + linea + "','" + serie + "','" + articulo + "','" + pais_pref + "','" + notas + "','" + preci_lista + "','" + precio_dolar + "','" + tipoabc + "','" + marca + "','" + sdis + "','" + descripcion + "','" + clave_sat + "','" + uni_medidad + "','" + prov_preferente + "','" + ol + "','" + arancel + "','" + gto + "','" + empaque + "','" + empacador + "','" + copr + "','" + peso_kg + "','" + dimensiones + "')";
                SqlCommand comando = new SqlCommand(sql_art, sqlcon);
                int cont;
                cont = comando.ExecuteNonQuery();

                if (cont == 1)
                {
                    MessageBox.Show("Compra registrado con exito.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("Compra no registrada. De aviso a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }                    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string clave = txtclave.Text;
            string linea = cbxlinea.Text;
            string serie = cbxserie.Text;
            string articulo = txtclave.Text;
            string pais_pref = cbxpais_pref.Text;
            string notas = txtnota.Text;
            double preci_lista = Convert.ToDouble(txtlventa.Text);
            double precio_dolar = Convert.ToDouble(txtpus.Text);
            string tipoabc = cbxtipo.Text;
            string marca = txtmarca.Text;
            double sdis = Convert.ToDouble(txtms.Text);
            string descripcion = txtdescripcion.Text;
            string clave_sat = txtcla_sat.Text;
            string uni_medidad = txtuni_medida.Text;
            string prov_preferente = cbxprove_pref.Text;
            double ol = Convert.ToDouble(txtol.Text);
            double arancel = Convert.ToDouble(txtarancel.Text);
            double gto = Convert.ToDouble(txtgtoimpor.Text);
            double empaque = Convert.ToDouble(txtempaque.Text);
            double empacador = Convert.ToDouble(txtempacador.Text);
            double copr = Convert.ToDouble(txtcopr.Text);
            double peso_kg = Convert.ToDouble(txtpeso.Text);
            string dimensiones = txtdimensiones.Text;

            /* try
             {*/
                SqlConnection sqlcon_upart = new SqlConnection();
                sqlcon_upart.ConnectionString= Conexion.Cn;                
                sqlcon_upart.Open();
                string consulta_upart = "UPDATE Articulos SET Linea='"+linea+"',Serie='"+serie+"',Articulo='"+articulo+"',PaisPrefe='"+pais_pref+"', Notas='"+notas+"', PreciLista='"+preci_lista+"', PrecioDls='"+precio_dolar+"', Tipoabc='"+tipoabc+"'," +
                    " Marca='"+marca+"', Sdis='"+sdis+"', Descripcion='"+descripcion+"', ClaveSat='"+clave_sat+"', UnidadMedida='"+uni_medidad+"', ProvPrefe='"+prov_preferente+"', OL='"+ol+"', Arancel='"+arancel+"', Gto_Impo='"+gto+"', " +
                    "Empaque='"+empaque+"', Empacador='"+empacador+"', CoPr='"+copr+"',PesoKg='"+peso_kg+"', Dimesiones='"+dimensiones+"' WHERE Articulo = '" + clave + "'";
                SqlCommand comando_upart = new SqlCommand(consulta_upart, sqlcon_upart);
                int cant;
                cant = comando_upart.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("Registro modificado con exito.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no fue modificado.Informe a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            /*}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
