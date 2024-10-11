namespace LinxAdmo.Forms.Catalogos
{
    partial class smClaSat
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
            this.cboxCodigo = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.dgvCSAT = new System.Windows.Forms.DataGridView();
            this.linxSysDataSet = new LinxAdmo.LinxSysDataSet();
            this.linxSysDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linxSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linxSysDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCodigo
            // 
            this.cboxCodigo.AutoSize = true;
            this.cboxCodigo.Depth = 0;
            this.cboxCodigo.Location = new System.Drawing.Point(555, 93);
            this.cboxCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.cboxCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxCodigo.Name = "cboxCodigo";
            this.cboxCodigo.ReadOnly = false;
            this.cboxCodigo.Ripple = true;
            this.cboxCodigo.Size = new System.Drawing.Size(85, 37);
            this.cboxCodigo.TabIndex = 0;
            this.cboxCodigo.Text = "Codigo";
            this.cboxCodigo.UseVisualStyleBackColor = true;
            this.cboxCodigo.CheckedChanged += new System.EventHandler(this.cbxCodigo_CheckedChanged);
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Depth = 0;
            this.cboxNombre.Location = new System.Drawing.Point(554, 64);
            this.cboxNombre.Margin = new System.Windows.Forms.Padding(0);
            this.cboxNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.ReadOnly = false;
            this.cboxNombre.Ripple = true;
            this.cboxNombre.Size = new System.Drawing.Size(91, 37);
            this.cboxNombre.TabIndex = 1;
            this.cboxNombre.Text = "Nombre";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cbxNombre_CheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.HideSelection = true;
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(21, 74);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PrefixSuffixText = null;
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(430, 48);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(458, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvCSAT
            // 
            this.dgvCSAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSAT.Location = new System.Drawing.Point(21, 139);
            this.dgvCSAT.Name = "dgvCSAT";
            this.dgvCSAT.Size = new System.Drawing.Size(619, 292);
            this.dgvCSAT.TabIndex = 4;
            // 
            // linxSysDataSet
            // 
            this.linxSysDataSet.DataSetName = "LinxSysDataSet";
            this.linxSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linxSysDataSetBindingSource
            // 
            this.linxSysDataSetBindingSource.DataSource = this.linxSysDataSet;
            this.linxSysDataSetBindingSource.Position = 0;
            // 
            // smClaSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.dgvCSAT);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.cboxCodigo);
            this.Name = "smClaSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claves SAT";
            this.Load += new System.EventHandler(this.smClaSat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linxSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linxSysDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox cboxCodigo;
        private MaterialSkin.Controls.MaterialCheckbox cboxNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvCSAT;
        private LinxSysDataSet linxSysDataSet;
        private System.Windows.Forms.BindingSource linxSysDataSetBindingSource;
    }
}