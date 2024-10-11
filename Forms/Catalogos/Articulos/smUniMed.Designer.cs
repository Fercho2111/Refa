namespace LinxAdmo.Forms.Catalogos
{
    partial class smUniMed
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
            this.dgvUniMed = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboxNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxCodigo = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniMed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUniMed
            // 
            this.dgvUniMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniMed.Location = new System.Drawing.Point(19, 139);
            this.dgvUniMed.Name = "dgvUniMed";
            this.dgvUniMed.Size = new System.Drawing.Size(619, 292);
            this.dgvUniMed.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(456, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtCodigo.Location = new System.Drawing.Point(19, 74);
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
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Depth = 0;
            this.cboxNombre.Location = new System.Drawing.Point(552, 64);
            this.cboxNombre.Margin = new System.Windows.Forms.Padding(0);
            this.cboxNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.ReadOnly = false;
            this.cboxNombre.Ripple = true;
            this.cboxNombre.Size = new System.Drawing.Size(91, 37);
            this.cboxNombre.TabIndex = 6;
            this.cboxNombre.Text = "Nombre";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cboxNombre_CheckedChanged);
            // 
            // cboxCodigo
            // 
            this.cboxCodigo.AutoSize = true;
            this.cboxCodigo.Depth = 0;
            this.cboxCodigo.Location = new System.Drawing.Point(553, 93);
            this.cboxCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.cboxCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxCodigo.Name = "cboxCodigo";
            this.cboxCodigo.ReadOnly = false;
            this.cboxCodigo.Ripple = true;
            this.cboxCodigo.Size = new System.Drawing.Size(85, 37);
            this.cboxCodigo.TabIndex = 5;
            this.cboxCodigo.Text = "Codigo";
            this.cboxCodigo.UseVisualStyleBackColor = true;
            this.cboxCodigo.CheckedChanged += new System.EventHandler(this.cboxCodigo_CheckedChanged);
            // 
            // smUniMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.dgvUniMed);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.cboxCodigo);
            this.Name = "smUniMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Unidades de Medida";
            this.Load += new System.EventHandler(this.smUniMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUniMed;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialCheckbox cboxNombre;
        private MaterialSkin.Controls.MaterialCheckbox cboxCodigo;
    }
}