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
    public partial class smTipoCambio : Form
    {
        public smTipoCambio()
        {
            InitializeComponent();
        }

        private void txtdolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txteuro.Focus();
            }
        }

        private void txteuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                double valor_dolar = Convert.ToDouble(txtdolar.Text);
                double valor_euro = Convert.ToDouble(txteuro.Text);
                double valor_euro_dolar = valor_euro / valor_dolar;
                txteurodolar.Text = Convert.ToString(valor_euro_dolar.ToString("N4"));
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                DateTime fecha = dtFecha.Value;
                string fechas = fecha.ToString("yyyy-MM-dd");
                double dolares = Convert.ToDouble(txtdolar.Text);
                double euros = Convert.ToDouble(txteuro.Text);
                double euro_dolar = Convert.ToDouble(txteurodolar.Text);
                string consulta = "INSERT INTO TipCambio(Fecha,Dolares,Euros,EuroDolar) VALUES ('" + fechas + "','" + dolares + "','" + euros + "','"+euro_dolar+"') ";
                SqlCommand comando = new SqlCommand(consulta, sqlcon);
                int resulta=comando.ExecuteNonQuery();

                if (resulta == 1)
                {
                    MessageBox.Show("Tipo de cambio registrado.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("El tipo de cambio no fue registrado.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                }                                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnInsertar.Enabled = false;           
            DateTime fecha = dtFecha.Value;
            string fecha_busca = fecha.ToString("yyyy-MM-dd");

            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "SELECT * FROM TipCambio WHERE Fecha = '" + fecha_busca + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader myreader;
                sqlcon.Open();
                myreader = cmd.ExecuteReader();
                if (myreader.Read() == true)
                {
                    txtdolar.Text = myreader["Dolares"].ToString();
                    txteuro.Text = myreader["Euros"].ToString();
                    txteurodolar.Text = myreader["EuroDolar"].ToString();
                }
                else
                {
                    MessageBox.Show("Tipo de cambio no encontrado.Verifique la fecha.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            
            DateTime fecha = dtFecha.Value;
            string fecha_busca = fecha.ToString("yyyy-MM-dd");
            double dolares = Convert.ToDouble(txtdolar.Text);
            double euros = Convert.ToDouble(txteuro.Text);
            double euro_dolar = Convert.ToDouble(txteurodolar.Text);

            try
            {
                SqlConnection sqlcon = new SqlConnection();
                sqlcon.ConnectionString = Conexion.Cn;
                string sql = "UPDATE TipCambio SET  Dolares='" + dolares + "', Euros='"+euros+"', EuroDolar='"+euro_dolar+"' WHERE Fecha = '" + fecha_busca + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);                
                sqlcon.Open();                
                int cant;
                cant = cmd.ExecuteNonQuery();

                if (cant == 1)
                {
                    MessageBox.Show("Tipo de cambio modificado con exito.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El tipo de cambio no fue modificado.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }      

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", informe este error a sistemas.", "LinxSystems|Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
