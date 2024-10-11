using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LinxAdmo.Forms.Catalogos.Clientes
{
    public partial class smBuscaCli : MaterialForm
    {
        public smBuscaCli()
        {
            InitializeComponent();
        }

        private void smBuscaCli_Load(object sender, EventArgs e)
        {
            cboxNombre.Checked = true;
        }

        private void cboxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxNombre.Checked == true)
            {
                cboxCodigo.Checked = false;
                cboxRfc.Checked = false;
            }
        }

        private void cboxCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxCodigo.Checked == true)
            {
                cboxNombre.Checked = false;
                cboxRfc.Checked = false;
            }
        }

        private void cboxRfc_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRfc.Checked == true)
            {
                cboxNombre.Checked = false;
                cboxCodigo.Checked = false;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Descripcion = txtCodigo.Text;
            string Clave = txtCodigo.Text;
            try
            {
                if (cboxNombre.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT Id_Cliente,Nombre,RFC,T_Persona,Calle,N_Exterior,N_Interior,Colonia,Municipio,CP,Ciudad,Estado,Telefono,Contacto,Vendedor,Credito,Dias_Credito,Pais,Uso_Cfdi,Correo,Reg_Fiscal,FormPago,MetoPago FROM Clientes WHERE Nombre LIKE '" + Descripcion + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    gdvBusCli.DataSource = Tabla;
                    if (Tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe un cliente con este nombre en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (cboxCodigo.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT Id_Cliente,Nombre,RFC,T_Persona,Calle,N_Exterior,N_Interior,Colonia,Municipio,CP,Ciudad,Estado,Telefono,Contacto,Vendedor,Credito,Dias_Credito,Pais,Uso_Cfdi,Correo,Reg_Fiscal,FormPago,MetoPago FROM Clientes WHERE Id_Cliente LIKE '" + Clave + "%'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    gdvBusCli.DataSource = Tabla;
                    if (Tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe un cliente con este codigo en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (cboxRfc.Checked == true)
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = Conexion.Cn;
                    string sql = "SELECT Id_Cliente,Nombre,RFC,T_Persona,Calle,N_Exterior,N_Interior,Colonia,Municipio,CP,Ciudad,Estado,Telefono,Contacto,Vendedor,Credito,Dias_Credito,Pais,Uso_Cfdi,Correo,Reg_Fiscal,FormPago,MetoPago FROM Clientes WHERE RFC = '" + Clave + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter mysqldt = new SqlDataAdapter(cmd);
                    mysqldt.SelectCommand = cmd;
                    DataTable Tabla = new DataTable();
                    mysqldt.Fill(Tabla);
                    gdvBusCli.DataSource = Tabla;
                    if (Tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe un cliente con este RFC en el catalogo de clientes. Verifiquelo.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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