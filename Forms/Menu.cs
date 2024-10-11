using LinxAdmo.Forms.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinxAdmo.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
 
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smArticulos frmArticulos = new smArticulos();
            frmArticulos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smClientesC frmClientes = new smClientesC();
            frmClientes.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smProveedores frmProveedores = new smProveedores();
            frmProveedores.ShowDialog();
        }

        private void lineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smLineas frmLineas = new smLineas();
            frmLineas.ShowDialog();
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smSeries frmSeries = new smSeries();
            frmSeries.ShowDialog();
        }

        private void cambioArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smCamPreArticulos frmCamPreArticulos = new smCamPreArticulos();
            frmCamPreArticulos.ShowDialog();
        }

        private void condicionDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smCondicionVenta frmCondicionVenta = new smCondicionVenta();
            frmCondicionVenta.ShowDialog();
        }

        private void tiposDeGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smTiposGastos frmTiposGastos = new smTiposGastos();
            frmTiposGastos.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smVendedores frmVendedores = new smVendedores();
            frmVendedores.ShowDialog();
        }

        private void rFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smRFC frmRFC = new smRFC();
            frmRFC.ShowDialog();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smComisiones frmComisiones = new smComisiones();
            frmComisiones.ShowDialog();
        }
    }
}
