namespace LinxAdmo.Forms.Reportes
{
    partial class Muestra_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_CONSULTA_ARTICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new LinxAdmo.Forms.Reportes.DataSetPrincipal();
            this.SP_CONSU_ART_LINEABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSU_ART_SERIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSU_ART_CEXISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSU_ART_SEXISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2_Linea = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3_Serie = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4_Cexis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer5_SinExis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_CONSULTA_ARTICULOTableAdapter = new LinxAdmo.Forms.Reportes.DataSetPrincipalTableAdapters.SP_CONSULTA_ARTICULOTableAdapter();
            this.SP_CONSU_ART_LINEATableAdapter = new LinxAdmo.Forms.Reportes.DataSetPrincipalTableAdapters.SP_CONSU_ART_LINEATableAdapter();
            this.SP_CONSU_ART_SERIETableAdapter = new LinxAdmo.Forms.Reportes.DataSetPrincipalTableAdapters.SP_CONSU_ART_SERIETableAdapter();
            this.SP_CONSU_ART_CEXISTableAdapter = new LinxAdmo.Forms.Reportes.DataSetPrincipalTableAdapters.SP_CONSU_ART_CEXISTableAdapter();
            this.SP_CONSU_ART_SEXISTableAdapter = new LinxAdmo.Forms.Reportes.DataSetPrincipalTableAdapters.SP_CONSU_ART_SEXISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTA_ARTICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_LINEABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_SERIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_CEXISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_SEXISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_CONSULTA_ARTICULOBindingSource
            // 
            this.SP_CONSULTA_ARTICULOBindingSource.DataMember = "SP_CONSULTA_ARTICULO";
            this.SP_CONSULTA_ARTICULOBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CONSU_ART_LINEABindingSource
            // 
            this.SP_CONSU_ART_LINEABindingSource.DataMember = "SP_CONSU_ART_LINEA";
            this.SP_CONSU_ART_LINEABindingSource.DataSource = this.DataSetPrincipal;
            // 
            // SP_CONSU_ART_SERIEBindingSource
            // 
            this.SP_CONSU_ART_SERIEBindingSource.DataMember = "SP_CONSU_ART_SERIE";
            this.SP_CONSU_ART_SERIEBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // SP_CONSU_ART_CEXISBindingSource
            // 
            this.SP_CONSU_ART_CEXISBindingSource.DataMember = "SP_CONSU_ART_CEXIS";
            this.SP_CONSU_ART_CEXISBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // SP_CONSU_ART_SEXISBindingSource
            // 
            this.SP_CONSU_ART_SEXISBindingSource.DataMember = "SP_CONSU_ART_SEXIS";
            this.SP_CONSU_ART_SEXISBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CONSULTA_ARTICULOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LinxAdmo.Forms.Reportes.Info_Articulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2_Linea
            // 
            this.reportViewer2_Linea.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SP_CONSU_ART_LINEABindingSource;
            this.reportViewer2_Linea.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2_Linea.LocalReport.ReportEmbeddedResource = "LinxAdmo.Forms.Reportes.Info_ArtLin.rdlc";
            this.reportViewer2_Linea.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2_Linea.Name = "reportViewer2_Linea";
            this.reportViewer2_Linea.ServerReport.BearerToken = null;
            this.reportViewer2_Linea.Size = new System.Drawing.Size(873, 553);
            this.reportViewer2_Linea.TabIndex = 1;
            // 
            // reportViewer3_Serie
            // 
            this.reportViewer3_Serie.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SP_CONSU_ART_SERIEBindingSource;
            this.reportViewer3_Serie.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3_Serie.LocalReport.ReportEmbeddedResource = "LinxAdmo.Forms.Reportes.Info_ArtSer.rdlc";
            this.reportViewer3_Serie.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3_Serie.Name = "reportViewer3_Serie";
            this.reportViewer3_Serie.ServerReport.BearerToken = null;
            this.reportViewer3_Serie.Size = new System.Drawing.Size(873, 553);
            this.reportViewer3_Serie.TabIndex = 2;
            // 
            // reportViewer4_Cexis
            // 
            this.reportViewer4_Cexis.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.SP_CONSU_ART_CEXISBindingSource;
            this.reportViewer4_Cexis.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4_Cexis.LocalReport.ReportEmbeddedResource = "LinxAdmo.Forms.Reportes.Info_ArtSex.rdlc";
            this.reportViewer4_Cexis.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4_Cexis.Name = "reportViewer4_Cexis";
            this.reportViewer4_Cexis.ServerReport.BearerToken = null;
            this.reportViewer4_Cexis.Size = new System.Drawing.Size(873, 553);
            this.reportViewer4_Cexis.TabIndex = 3;
            // 
            // reportViewer5_SinExis
            // 
            this.reportViewer5_SinExis.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.SP_CONSU_ART_SEXISBindingSource;
            this.reportViewer5_SinExis.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5_SinExis.LocalReport.ReportEmbeddedResource = "LinxAdmo.Forms.Reportes.Info_ArtNex.rdlc";
            this.reportViewer5_SinExis.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5_SinExis.Name = "reportViewer5_SinExis";
            this.reportViewer5_SinExis.ServerReport.BearerToken = null;
            this.reportViewer5_SinExis.Size = new System.Drawing.Size(873, 553);
            this.reportViewer5_SinExis.TabIndex = 4;
            // 
            // SP_CONSULTA_ARTICULOTableAdapter
            // 
            this.SP_CONSULTA_ARTICULOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_CONSU_ART_LINEATableAdapter
            // 
            this.SP_CONSU_ART_LINEATableAdapter.ClearBeforeFill = true;
            // 
            // SP_CONSU_ART_SERIETableAdapter
            // 
            this.SP_CONSU_ART_SERIETableAdapter.ClearBeforeFill = true;
            // 
            // SP_CONSU_ART_CEXISTableAdapter
            // 
            this.SP_CONSU_ART_CEXISTableAdapter.ClearBeforeFill = true;
            // 
            // SP_CONSU_ART_SEXISTableAdapter
            // 
            this.SP_CONSU_ART_SEXISTableAdapter.ClearBeforeFill = true;
            // 
            // Muestra_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 553);
            this.Controls.Add(this.reportViewer5_SinExis);
            this.Controls.Add(this.reportViewer4_Cexis);
            this.Controls.Add(this.reportViewer3_Serie);
            this.Controls.Add(this.reportViewer2_Linea);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Muestra_Articulos";
            this.Text = "Muestra_Articulos";
            this.Load += new System.EventHandler(this.Muestra_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTA_ARTICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_LINEABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_SERIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_CEXISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSU_ART_SEXISBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_CONSULTA_ARTICULOBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.SP_CONSULTA_ARTICULOTableAdapter SP_CONSULTA_ARTICULOTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2_Linea;
        private System.Windows.Forms.BindingSource SP_CONSU_ART_LINEABindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSU_ART_LINEATableAdapter SP_CONSU_ART_LINEATableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3_Serie;
        private System.Windows.Forms.BindingSource SP_CONSU_ART_SERIEBindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSU_ART_SERIETableAdapter SP_CONSU_ART_SERIETableAdapter;
        private System.Windows.Forms.BindingSource SP_CONSU_ART_CEXISBindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSU_ART_CEXISTableAdapter SP_CONSU_ART_CEXISTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4_Cexis;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5_SinExis;
        private System.Windows.Forms.BindingSource SP_CONSU_ART_SEXISBindingSource;
        private DataSetPrincipalTableAdapters.SP_CONSU_ART_SEXISTableAdapter SP_CONSU_ART_SEXISTableAdapter;
    }
}