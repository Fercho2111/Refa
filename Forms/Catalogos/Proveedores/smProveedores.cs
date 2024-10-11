using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinxAdmo.Forms.Catalogos
{
    public partial class smProveedores : MaterialForm
    {
        public smProveedores()
        {
            InitializeComponent();
        }

        private void Inhabilita()
        {
            txtNProveedor.Enabled = false;
            txtProveedorD.Enabled = false;
            txtCalle.Enabled = false;
            txtColonia.Enabled = false;
            txtCiudad.Enabled = false;
            txtCP.Enabled = false;
            txtRFC.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;            
        }

        private void Habilita()
        {
            txtNProveedor.Enabled = true;
            txtProveedorD.Enabled = true;
            txtCalle.Enabled = true;
            txtColonia.Enabled = true;
            txtCiudad.Enabled = true;
            txtCP.Enabled = true;
            txtRFC.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            btnBuscar.Visible = false;
        }

        private void Limpia()
        {
            txtNProveedor.Clear();
            txtProveedorD.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
            txtCiudad.Clear();
            txtCP.Clear();
            txtRFC.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void smProveedores_Load(object sender, EventArgs e)
        {
            Inhabilita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //LLENANDO TEXT DE NUMERO DE CLIENTE                    
                SqlConnection sqlcon_Prov = new SqlConnection();
                sqlcon_Prov.ConnectionString = Conexion.Cn;
                string sql_Prov = "SELECT * FROM Proveedores WHERE Id_proveedor = (SELECT MAX(Id_proveedor) FROM Proveedores)";
                sqlcon_Prov.Open();
                SqlCommand cmd_Prov = new SqlCommand(sql_Prov, sqlcon_Prov);
                int NProveedor = Convert.ToInt32(cmd_Prov.ExecuteScalar()) + 1;
                txtNProveedor.Text = Convert.ToString(NProveedor);
                sqlcon_Prov.Close();
                Habilita();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cancelar?", "LinxSystems|Cancelar Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpia();
                    Inhabilita();
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnBuscar.Visible = true;
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string NProveedor = txtNProveedor.Text;
                string Nombre = txtProveedorD.Text;
                string Calle = txtCalle.Text;
                string Colonia = txtColonia.Text;
                string Ciudad = txtCiudad.Text;
                string CP = txtCP.Text;
                string RFC = txtRFC.Text;
                string Telefono = txtTelefono.Text;
                string Correo = txtCorreo.Text;

                //CREAMOS LA CONSULTA Y LA INSERTAMOS LAS VARIABLES/////////////////////                              
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                string sql_pro = "INSERT INTO Proveedores (Id_proveedor,Nombre,Calle,Colonia,Ciudad,CP,RFC,Telefono,Correo) " +
                "VALUES ('" + NProveedor + "','" + Nombre + "','" + Calle + "','" + Colonia + "','" + Ciudad + "','" + CP + "','" + RFC + "','" + Telefono + "'," +
                "'" + Correo+"')";
                SqlCommand comando = new SqlCommand(sql_pro, sqlcon);
                int cont;
                cont = comando.ExecuteNonQuery();

                if (cont == 1)
                {
                    MessageBox.Show("Proveedor registrado con exito.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                    Limpia();
                    Inhabilita();
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnBuscar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Proveedor no registrado. De aviso a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }
    }
}
////AHORAAAAA FALTA BUSCAR Y MODIFICAR 