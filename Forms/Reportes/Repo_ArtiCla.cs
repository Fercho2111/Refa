using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LinxAdmo.Forms.Reportes
{
    public partial class Repo_ArtiCla : MaterialForm
    {
        public Repo_ArtiCla()
        {
            InitializeComponent();
        }        

        private void Repo_Articulos_Load(object sender, EventArgs e)
        {
            lbelLinea.Visible = false;
            lbelSerie.Visible = false;
            lblClave.Visible = false;
            txtLinea_Producto.Visible = false;
            txtSerie_Producto.Visible = false;
            txtClave_Producto.Visible = false;
            cbxLinea.Checked = true;           
        }

        private void cbxLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLinea.Checked == true)
            {
                cbxSerie.Checked = false;
                cbxClave.Checked = false;
                cbxCon_Existecias.Checked = false;
                cboxSin_Existencias.Checked = false;
                lbelLinea.Visible = true;
                txtLinea_Producto.Visible = true;
                txtLinea_Producto.Focus();
            }
            else
            {
                lbelLinea.Visible = false;
                txtLinea_Producto.Visible = false;
            }
        }

        private void cbxSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSerie.Checked == true)
            {
                cbxLinea.Checked = false;
                cbxClave.Checked = false;
                cbxCon_Existecias.Checked = false;
                cboxSin_Existencias.Checked = false;
                lbelSerie.Visible = true;
                txtSerie_Producto.Visible =true;
                txtSerie_Producto.Focus();
            }
            else
            {
                lbelSerie.Visible = false;
                txtSerie_Producto.Visible = false;
            }
        }

        private void cbxClave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxClave.Checked == true)
            {
                cbxLinea.Checked = false;
                cbxSerie.Checked = false;
                cbxCon_Existecias.Checked = false;
                cboxSin_Existencias.Checked = false;
                lblClave.Visible = true;
                txtClave_Producto.Visible = true;
                txtClave_Producto.Focus();
            }
            else
            {
                lblClave.Visible = false;
                txtClave_Producto.Visible = false;
            }
        }

        private void cbxCon_Existecias_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCon_Existecias.Checked == true)
            {
                cbxLinea.Checked = false;
                cbxSerie.Checked = false;
                cbxClave.Checked = false;
                cboxSin_Existencias.Checked = false;
            }
        }

        private void cboxSin_Existencias_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSin_Existencias.Checked == true)
            {
                cbxLinea.Checked = false;
                cbxSerie.Checked = false;
                cbxClave.Checked = false;
                cbxCon_Existecias.Checked = false;
            }
        }

        private void btnGenera_Reporte_Click(object sender, EventArgs e)
        {
            if (cbxClave.Checked == true)
            {
                if (txtClave_Producto.Text == "")
                {
                    MessageBox.Show("No se encuentra la clave del articulo.Verifique.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Muestra_Articulos MuestraReporte = new Muestra_Articulos();
                    MuestraReporte.Clave = txtClave_Producto.Text;
                    MuestraReporte.ShowDialog();
                }                              
            }

            if (cbxLinea.Checked == true)
            {
                if (txtLinea_Producto.Text == "")
                {
                    MessageBox.Show("No se encuentra la linea ingresada.Verifique.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Muestra_Articulos MuestraReporte = new Muestra_Articulos();
                    MuestraReporte.Linea = Convert.ToInt32(txtLinea_Producto.Text);
                    MuestraReporte.ShowDialog();
                }                
            }

            if (cbxSerie.Checked == true)
            {
                if (txtSerie_Producto.Text == "")
                {
                    MessageBox.Show("No se encuentra la serie ingresada.Verifique.", "LinxSystems|Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Muestra_Articulos MuestraReporte = new Muestra_Articulos();
                    MuestraReporte.Serie = Convert.ToInt32(txtSerie_Producto.Text);
                    MuestraReporte.ShowDialog();
                }
            }

            if (cbxCon_Existecias.Checked == true)
            {
                txtCon_Exis.Text = "1";
                Muestra_Articulos MuestraReporte = new Muestra_Articulos();
                MuestraReporte.Cexistencia = Convert.ToInt32(txtCon_Exis.Text);
                MuestraReporte.ShowDialog();
            }

            if (cboxSin_Existencias.Checked == true)
            {
                txtSin_Exis.Text = "1";
                Muestra_Articulos MuestraReporte = new Muestra_Articulos();
                MuestraReporte.Sexistencia = Convert.ToInt32(txtSin_Exis.Text);
                MuestraReporte.ShowDialog();
            }
        }
    }
}
