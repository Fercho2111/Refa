namespace LinxAdmo.Forms.Catalogos.Clientes
{
    partial class smBuscaCli
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
            this.gdvBusCli = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboxNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxCodigo = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxRfc = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBusCli)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvBusCli
            // 
            this.gdvBusCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvBusCli.Location = new System.Drawing.Point(13, 172);
            this.gdvBusCli.Name = "gdvBusCli";
            this.gdvBusCli.Size = new System.Drawing.Size(619, 292);
            this.gdvBusCli.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(450, 94);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 18;
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
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.HideSelection = true;
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(13, 90);
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
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Depth = 0;
            this.cboxNombre.Location = new System.Drawing.Point(546, 70);
            this.cboxNombre.Margin = new System.Windows.Forms.Padding(0);
            this.cboxNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.ReadOnly = false;
            this.cboxNombre.Ripple = true;
            this.cboxNombre.Size = new System.Drawing.Size(91, 37);
            this.cboxNombre.TabIndex = 16;
            this.cboxNombre.Text = "Nombre";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cboxNombre_CheckedChanged);
            // 
            // cboxCodigo
            // 
            this.cboxCodigo.AutoSize = true;
            this.cboxCodigo.Depth = 0;
            this.cboxCodigo.Location = new System.Drawing.Point(547, 99);
            this.cboxCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.cboxCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxCodigo.Name = "cboxCodigo";
            this.cboxCodigo.ReadOnly = false;
            this.cboxCodigo.Ripple = true;
            this.cboxCodigo.Size = new System.Drawing.Size(85, 37);
            this.cboxCodigo.TabIndex = 15;
            this.cboxCodigo.Text = "Codigo";
            this.cboxCodigo.UseVisualStyleBackColor = true;
            this.cboxCodigo.CheckedChanged += new System.EventHandler(this.cboxCodigo_CheckedChanged);
            // 
            // cboxRfc
            // 
            this.cboxRfc.AutoSize = true;
            this.cboxRfc.Depth = 0;
            this.cboxRfc.Location = new System.Drawing.Point(548, 129);
            this.cboxRfc.Margin = new System.Windows.Forms.Padding(0);
            this.cboxRfc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxRfc.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxRfc.Name = "cboxRfc";
            this.cboxRfc.ReadOnly = false;
            this.cboxRfc.Ripple = true;
            this.cboxRfc.Size = new System.Drawing.Size(64, 37);
            this.cboxRfc.TabIndex = 20;
            this.cboxRfc.Text = "RFC";
            this.cboxRfc.UseVisualStyleBackColor = true;
            this.cboxRfc.CheckedChanged += new System.EventHandler(this.cboxRfc_CheckedChanged);
            // 
            // smBuscaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 471);
            this.Controls.Add(this.cboxRfc);
            this.Controls.Add(this.gdvBusCli);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.cboxCodigo);
            this.Name = "smBuscaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Clientes";
            this.Load += new System.EventHandler(this.smBuscaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBusCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvBusCli;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialCheckbox cboxNombre;
        private MaterialSkin.Controls.MaterialCheckbox cboxCodigo;
        private MaterialSkin.Controls.MaterialCheckbox cboxRfc;
    }
}