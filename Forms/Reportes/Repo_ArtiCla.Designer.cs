namespace LinxAdmo.Forms.Reportes
{
    partial class Repo_ArtiCla
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
            this.lbelLinea = new MaterialSkin.Controls.MaterialLabel();
            this.txtLinea_Producto = new System.Windows.Forms.TextBox();
            this.cbxLinea = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxSerie = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxClave = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxCon_Existecias = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxSin_Existencias = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtSerie_Producto = new System.Windows.Forms.TextBox();
            this.lbelSerie = new MaterialSkin.Controls.MaterialLabel();
            this.txtClave_Producto = new System.Windows.Forms.TextBox();
            this.lblClave = new MaterialSkin.Controls.MaterialLabel();
            this.btnGenera_Reporte = new MaterialSkin.Controls.MaterialButton();
            this.txtCon_Exis = new System.Windows.Forms.TextBox();
            this.txtSin_Exis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbelLinea
            // 
            this.lbelLinea.AutoSize = true;
            this.lbelLinea.Depth = 0;
            this.lbelLinea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbelLinea.Location = new System.Drawing.Point(27, 211);
            this.lbelLinea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbelLinea.Name = "lbelLinea";
            this.lbelLinea.Size = new System.Drawing.Size(112, 19);
            this.lbelLinea.TabIndex = 0;
            this.lbelLinea.Text = "Linea Producto:";
            // 
            // txtLinea_Producto
            // 
            this.txtLinea_Producto.Location = new System.Drawing.Point(145, 210);
            this.txtLinea_Producto.Name = "txtLinea_Producto";
            this.txtLinea_Producto.Size = new System.Drawing.Size(177, 20);
            this.txtLinea_Producto.TabIndex = 1;
            // 
            // cbxLinea
            // 
            this.cbxLinea.AutoSize = true;
            this.cbxLinea.Depth = 0;
            this.cbxLinea.Location = new System.Drawing.Point(18, 75);
            this.cbxLinea.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLinea.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxLinea.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.ReadOnly = false;
            this.cbxLinea.Ripple = true;
            this.cbxLinea.Size = new System.Drawing.Size(102, 37);
            this.cbxLinea.TabIndex = 2;
            this.cbxLinea.Text = "Por Linea";
            this.cbxLinea.UseVisualStyleBackColor = true;
            this.cbxLinea.CheckedChanged += new System.EventHandler(this.cbxLinea_CheckedChanged);
            // 
            // cbxSerie
            // 
            this.cbxSerie.AutoSize = true;
            this.cbxSerie.Depth = 0;
            this.cbxSerie.Location = new System.Drawing.Point(18, 112);
            this.cbxSerie.Margin = new System.Windows.Forms.Padding(0);
            this.cbxSerie.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.ReadOnly = false;
            this.cbxSerie.Ripple = true;
            this.cbxSerie.Size = new System.Drawing.Size(98, 37);
            this.cbxSerie.TabIndex = 3;
            this.cbxSerie.Text = "Por Serie";
            this.cbxSerie.UseVisualStyleBackColor = true;
            this.cbxSerie.CheckedChanged += new System.EventHandler(this.cbxSerie_CheckedChanged);
            // 
            // cbxClave
            // 
            this.cbxClave.AutoSize = true;
            this.cbxClave.Depth = 0;
            this.cbxClave.Location = new System.Drawing.Point(18, 149);
            this.cbxClave.Margin = new System.Windows.Forms.Padding(0);
            this.cbxClave.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxClave.Name = "cbxClave";
            this.cbxClave.ReadOnly = false;
            this.cbxClave.Ripple = true;
            this.cbxClave.Size = new System.Drawing.Size(102, 37);
            this.cbxClave.TabIndex = 4;
            this.cbxClave.Text = "Por Clave";
            this.cbxClave.UseVisualStyleBackColor = true;
            this.cbxClave.CheckedChanged += new System.EventHandler(this.cbxClave_CheckedChanged);
            // 
            // cbxCon_Existecias
            // 
            this.cbxCon_Existecias.AutoSize = true;
            this.cbxCon_Existecias.Depth = 0;
            this.cbxCon_Existecias.Location = new System.Drawing.Point(168, 75);
            this.cbxCon_Existecias.Margin = new System.Windows.Forms.Padding(0);
            this.cbxCon_Existecias.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxCon_Existecias.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxCon_Existecias.Name = "cbxCon_Existecias";
            this.cbxCon_Existecias.ReadOnly = false;
            this.cbxCon_Existecias.Ripple = true;
            this.cbxCon_Existecias.Size = new System.Drawing.Size(147, 37);
            this.cbxCon_Existecias.TabIndex = 5;
            this.cbxCon_Existecias.Text = "Con Existencias";
            this.cbxCon_Existecias.UseVisualStyleBackColor = true;
            this.cbxCon_Existecias.CheckedChanged += new System.EventHandler(this.cbxCon_Existecias_CheckedChanged);
            // 
            // cboxSin_Existencias
            // 
            this.cboxSin_Existencias.AutoSize = true;
            this.cboxSin_Existencias.Depth = 0;
            this.cboxSin_Existencias.Location = new System.Drawing.Point(168, 112);
            this.cboxSin_Existencias.Margin = new System.Windows.Forms.Padding(0);
            this.cboxSin_Existencias.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxSin_Existencias.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxSin_Existencias.Name = "cboxSin_Existencias";
            this.cboxSin_Existencias.ReadOnly = false;
            this.cboxSin_Existencias.Ripple = true;
            this.cboxSin_Existencias.Size = new System.Drawing.Size(142, 37);
            this.cboxSin_Existencias.TabIndex = 6;
            this.cboxSin_Existencias.Text = "Sin Existencias";
            this.cboxSin_Existencias.UseVisualStyleBackColor = true;
            this.cboxSin_Existencias.CheckedChanged += new System.EventHandler(this.cboxSin_Existencias_CheckedChanged);
            // 
            // txtSerie_Producto
            // 
            this.txtSerie_Producto.Location = new System.Drawing.Point(145, 210);
            this.txtSerie_Producto.Name = "txtSerie_Producto";
            this.txtSerie_Producto.Size = new System.Drawing.Size(177, 20);
            this.txtSerie_Producto.TabIndex = 8;
            // 
            // lbelSerie
            // 
            this.lbelSerie.AutoSize = true;
            this.lbelSerie.Depth = 0;
            this.lbelSerie.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbelSerie.Location = new System.Drawing.Point(27, 212);
            this.lbelSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbelSerie.Name = "lbelSerie";
            this.lbelSerie.Size = new System.Drawing.Size(108, 19);
            this.lbelSerie.TabIndex = 7;
            this.lbelSerie.Text = "Serie Producto:";
            // 
            // txtClave_Producto
            // 
            this.txtClave_Producto.Location = new System.Drawing.Point(145, 210);
            this.txtClave_Producto.Name = "txtClave_Producto";
            this.txtClave_Producto.Size = new System.Drawing.Size(177, 20);
            this.txtClave_Producto.TabIndex = 10;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Depth = 0;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClave.Location = new System.Drawing.Point(27, 212);
            this.lblClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(112, 19);
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "Clave Producto:";
            // 
            // btnGenera_Reporte
            // 
            this.btnGenera_Reporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenera_Reporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenera_Reporte.Depth = 0;
            this.btnGenera_Reporte.HighEmphasis = true;
            this.btnGenera_Reporte.Icon = null;
            this.btnGenera_Reporte.Location = new System.Drawing.Point(168, 150);
            this.btnGenera_Reporte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenera_Reporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenera_Reporte.Name = "btnGenera_Reporte";
            this.btnGenera_Reporte.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenera_Reporte.Size = new System.Drawing.Size(154, 36);
            this.btnGenera_Reporte.TabIndex = 11;
            this.btnGenera_Reporte.Text = "Generar Reporte";
            this.btnGenera_Reporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenera_Reporte.UseAccentColor = false;
            this.btnGenera_Reporte.UseVisualStyleBackColor = true;
            this.btnGenera_Reporte.Click += new System.EventHandler(this.btnGenera_Reporte_Click);
            // 
            // txtCon_Exis
            // 
            this.txtCon_Exis.Location = new System.Drawing.Point(6, 221);
            this.txtCon_Exis.Name = "txtCon_Exis";
            this.txtCon_Exis.Size = new System.Drawing.Size(10, 20);
            this.txtCon_Exis.TabIndex = 12;
            this.txtCon_Exis.Visible = false;
            // 
            // txtSin_Exis
            // 
            this.txtSin_Exis.Location = new System.Drawing.Point(6, 221);
            this.txtSin_Exis.Name = "txtSin_Exis";
            this.txtSin_Exis.Size = new System.Drawing.Size(10, 20);
            this.txtSin_Exis.TabIndex = 13;
            this.txtSin_Exis.Visible = false;
            // 
            // Repo_ArtiCla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 247);
            this.Controls.Add(this.txtSin_Exis);
            this.Controls.Add(this.txtCon_Exis);
            this.Controls.Add(this.btnGenera_Reporte);
            this.Controls.Add(this.txtClave_Producto);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtSerie_Producto);
            this.Controls.Add(this.lbelSerie);
            this.Controls.Add(this.cboxSin_Existencias);
            this.Controls.Add(this.cbxCon_Existecias);
            this.Controls.Add(this.cbxClave);
            this.Controls.Add(this.cbxSerie);
            this.Controls.Add(this.cbxLinea);
            this.Controls.Add(this.txtLinea_Producto);
            this.Controls.Add(this.lbelLinea);
            this.Name = "Repo_ArtiCla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Articulos";
            this.Load += new System.EventHandler(this.Repo_Articulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbelLinea;
        private System.Windows.Forms.TextBox txtLinea_Producto;
        private MaterialSkin.Controls.MaterialCheckbox cbxLinea;
        private MaterialSkin.Controls.MaterialCheckbox cbxSerie;
        private MaterialSkin.Controls.MaterialCheckbox cbxClave;
        private MaterialSkin.Controls.MaterialCheckbox cbxCon_Existecias;
        private MaterialSkin.Controls.MaterialCheckbox cboxSin_Existencias;
        private System.Windows.Forms.TextBox txtSerie_Producto;
        private MaterialSkin.Controls.MaterialLabel lbelSerie;
        private System.Windows.Forms.TextBox txtClave_Producto;
        private MaterialSkin.Controls.MaterialLabel lblClave;
        private MaterialSkin.Controls.MaterialButton btnGenera_Reporte;
        private System.Windows.Forms.TextBox txtCon_Exis;
        private System.Windows.Forms.TextBox txtSin_Exis;
    }
}