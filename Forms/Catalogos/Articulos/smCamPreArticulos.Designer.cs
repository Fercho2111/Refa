namespace LinxAdmo.Forms.Catalogos
{
    partial class smCamPreArticulos
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvPrecioArticulos = new System.Windows.Forms.DataGridView();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescirpcionUMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxMonto = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxPorcentaje = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecioArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvPrecioArticulos);
            this.materialCard1.Controls.Add(this.cboxMonto);
            this.materialCard1.Controls.Add(this.cboxPorcentaje);
            this.materialCard1.Controls.Add(this.cbxSerie);
            this.materialCard1.Controls.Add(this.cbxLinea);
            this.materialCard1.Controls.Add(this.txtSerie);
            this.materialCard1.Controls.Add(this.txtLinea);
            this.materialCard1.Controls.Add(this.btnAplicar);
            this.materialCard1.Controls.Add(this.btnFiltrar);
            this.materialCard1.Controls.Add(this.txtPrecio);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(796, 333);
            this.materialCard1.TabIndex = 1;
            // 
            // dgvPrecioArticulos
            // 
            this.dgvPrecioArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecioArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.Serie,
            this.Clave,
            this.Descripcion,
            this.Peso,
            this.Precio,
            this.CostProm,
            this.UltCosto,
            this.StockMin,
            this.Varia,
            this.CodigoSat,
            this.DescripcionSAT,
            this.UnidadMedidad,
            this.DescirpcionUMedida});
            this.dgvPrecioArticulos.Location = new System.Drawing.Point(17, 118);
            this.dgvPrecioArticulos.Name = "dgvPrecioArticulos";
            this.dgvPrecioArticulos.Size = new System.Drawing.Size(762, 198);
            this.dgvPrecioArticulos.TabIndex = 50;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // CostProm
            // 
            this.CostProm.HeaderText = "Cost.Prom";
            this.CostProm.Name = "CostProm";
            this.CostProm.ReadOnly = true;
            // 
            // UltCosto
            // 
            this.UltCosto.HeaderText = "Ult.Costo";
            this.UltCosto.Name = "UltCosto";
            this.UltCosto.ReadOnly = true;
            // 
            // StockMin
            // 
            this.StockMin.HeaderText = "StockMin";
            this.StockMin.Name = "StockMin";
            this.StockMin.ReadOnly = true;
            // 
            // Varia
            // 
            this.Varia.HeaderText = "%Varia";
            this.Varia.Name = "Varia";
            this.Varia.ReadOnly = true;
            // 
            // CodigoSat
            // 
            this.CodigoSat.HeaderText = "Codigo SAT";
            this.CodigoSat.Name = "CodigoSat";
            this.CodigoSat.ReadOnly = true;
            // 
            // DescripcionSAT
            // 
            this.DescripcionSAT.HeaderText = "Descripcion";
            this.DescripcionSAT.Name = "DescripcionSAT";
            this.DescripcionSAT.ReadOnly = true;
            // 
            // UnidadMedidad
            // 
            this.UnidadMedidad.HeaderText = "U.Medida";
            this.UnidadMedidad.Name = "UnidadMedidad";
            this.UnidadMedidad.ReadOnly = true;
            // 
            // DescirpcionUMedida
            // 
            this.DescirpcionUMedida.HeaderText = "Descripcion";
            this.DescirpcionUMedida.Name = "DescirpcionUMedida";
            this.DescirpcionUMedida.ReadOnly = true;
            // 
            // cboxMonto
            // 
            this.cboxMonto.AutoSize = true;
            this.cboxMonto.Depth = 0;
            this.cboxMonto.Location = new System.Drawing.Point(353, 33);
            this.cboxMonto.Margin = new System.Windows.Forms.Padding(0);
            this.cboxMonto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxMonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxMonto.Name = "cboxMonto";
            this.cboxMonto.ReadOnly = false;
            this.cboxMonto.Ripple = true;
            this.cboxMonto.Size = new System.Drawing.Size(81, 37);
            this.cboxMonto.TabIndex = 7;
            this.cboxMonto.Text = "Monto";
            this.cboxMonto.UseVisualStyleBackColor = true;
            // 
            // cboxPorcentaje
            // 
            this.cboxPorcentaje.AutoSize = true;
            this.cboxPorcentaje.Depth = 0;
            this.cboxPorcentaje.Location = new System.Drawing.Point(353, 5);
            this.cboxPorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.cboxPorcentaje.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxPorcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxPorcentaje.Name = "cboxPorcentaje";
            this.cboxPorcentaje.ReadOnly = false;
            this.cboxPorcentaje.Ripple = true;
            this.cboxPorcentaje.Size = new System.Drawing.Size(110, 37);
            this.cboxPorcentaje.TabIndex = 6;
            this.cboxPorcentaje.Text = "Porcentaje";
            this.cboxPorcentaje.UseVisualStyleBackColor = true;
            // 
            // cbxSerie
            // 
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(75, 40);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(45, 21);
            this.cbxSerie.TabIndex = 3;
            // 
            // cbxLinea
            // 
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(75, 13);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(45, 21);
            this.cbxLinea.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(126, 41);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(199, 20);
            this.txtSerie.TabIndex = 4;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(126, 13);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(199, 20);
            this.txtLinea.TabIndex = 2;
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAplicar.Location = new System.Drawing.Point(531, 69);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnFiltrar.Location = new System.Drawing.Point(250, 67);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(419, 71);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(106, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(361, 71);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Precio : ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Serie : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Linea : ";
            // 
            // smCamPreArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 400);
            this.Controls.Add(this.materialCard1);
            this.Name = "smCamPreArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio Precio de Articulos";
            this.Load += new System.EventHandler(this.smCamPreArticulos_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecioArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckbox cboxPorcentaje;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.ComboBox cbxLinea;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dgvPrecioArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescirpcionUMedida;
        private MaterialSkin.Controls.MaterialCheckbox cboxMonto;
    }
}