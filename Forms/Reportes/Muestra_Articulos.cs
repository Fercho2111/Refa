using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinxAdmo.Forms.Reportes
{
    public partial class Muestra_Articulos : Form
    {
        public Muestra_Articulos()
        {
            InitializeComponent();
        }

        public string Clave { get; set; }
        public int Linea { get; set; }
        public int Serie { get; set; }
        public int Cexistencia { get; set; }
        public int Sexistencia { get; set; } 
        private void Muestra_Articulos_Load(object sender, EventArgs e)
        {
            if(Clave!= null)
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.SP_CONSULTA_ARTICULO' Puede moverla o quitarla según sea necesario.
                this.SP_CONSULTA_ARTICULOTableAdapter.Fill(this.DataSetPrincipal.SP_CONSULTA_ARTICULO, Clave);
                this.reportViewer1.RefreshReport();
                this.reportViewer2_Linea.Visible = false;
                this.reportViewer3_Serie.Visible = false;
                this.reportViewer4_Cexis.Visible = false;
                this.reportViewer5_SinExis.Visible = false;

            }

            if (Linea != 0)
            {
                this.SP_CONSU_ART_LINEATableAdapter.Fill(this.DataSetPrincipal.SP_CONSU_ART_LINEA, Linea);
                this.reportViewer2_Linea.RefreshReport();
                this.reportViewer1.Visible = false;
                this.reportViewer3_Serie.Visible = false;
                this.reportViewer4_Cexis.Visible = false;
                this.reportViewer5_SinExis.Visible = false;
            }

            if (Serie != 0)
            {
                this.SP_CONSU_ART_SERIETableAdapter.Fill(this.DataSetPrincipal.SP_CONSU_ART_SERIE, Serie);
                this.reportViewer3_Serie.RefreshReport();
                this.reportViewer1.Visible = false;
                this.reportViewer2_Linea.Visible = false;
                this.reportViewer4_Cexis.Visible = false;
                this.reportViewer5_SinExis.Visible = false;
            }

            if(Cexistencia !=0)
            {
                this.SP_CONSU_ART_CEXISTableAdapter.Fill(this.DataSetPrincipal.SP_CONSU_ART_CEXIS, Cexistencia);
                this.reportViewer4_Cexis.RefreshReport();
                this.reportViewer1.Visible = false;
                this.reportViewer2_Linea.Visible = false;
                this.reportViewer3_Serie.Visible = false;
                this.reportViewer5_SinExis.Visible = false;
            }

            if(Sexistencia != 0)
            {
                //SE GENERA AQUI EL REPORTE DE ARTICULOS QUE NO TIENEN EXISTENCIA
                this.SP_CONSU_ART_SEXISTableAdapter.Fill(this.DataSetPrincipal.SP_CONSU_ART_SEXIS, Sexistencia);
                this.reportViewer5_SinExis.RefreshReport();
                this.reportViewer1.Visible = false;
                this.reportViewer2_Linea.Visible = false;
                this.reportViewer3_Serie.Visible = false;
                this.reportViewer4_Cexis.Visible = false;
            }
        }
    }
}
