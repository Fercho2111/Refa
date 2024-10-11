namespace LinxAdmo.Forms.Catalogos.Articulos
{
    partial class smEdiArti
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
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboxNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.cboxCodigo = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox1_Inhabilitado = new System.Windows.Forms.CheckBox();
            this.cBox1_Siniva = new System.Windows.Forms.CheckBox();
            this.txtUnidadMedidaD = new System.Windows.Forms.TextBox();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new MaterialSkin.Controls.MaterialLabel();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblreferencia = new MaterialSkin.Controls.MaterialLabel();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lblsmin = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblumedida = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoSatD = new System.Windows.Forms.TextBox();
            this.txtCodigoSat = new System.Windows.Forms.TextBox();
            this.lblCsat = new MaterialSkin.Controls.MaterialLabel();
            this.txtF_Peso = new System.Windows.Forms.TextBox();
            this.lblFP = new MaterialSkin.Controls.MaterialLabel();
            this.lblSerie = new MaterialSkin.Controls.MaterialLabel();
            this.lblLinea = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.txtxClave = new System.Windows.Forms.TextBox();
            this.lblClave = new MaterialSkin.Controls.MaterialLabel();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            this.btnBuscar_Ser = new System.Windows.Forms.Button();
            this.btnBuscar_Lin = new System.Windows.Forms.Button();
            this.btnBuscar_Umed = new System.Windows.Forms.Button();
            this.btnBuscar_CSat = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtCBarras = new System.Windows.Forms.TextBox();
            this.lblCBarras = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(453, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 12;
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
            this.txtCodigo.Location = new System.Drawing.Point(16, 74);
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
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // cboxNombre
            // 
            this.cboxNombre.AutoSize = true;
            this.cboxNombre.Depth = 0;
            this.cboxNombre.Location = new System.Drawing.Point(562, 64);
            this.cboxNombre.Margin = new System.Windows.Forms.Padding(0);
            this.cboxNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxNombre.Name = "cboxNombre";
            this.cboxNombre.ReadOnly = false;
            this.cboxNombre.Ripple = true;
            this.cboxNombre.Size = new System.Drawing.Size(91, 37);
            this.cboxNombre.TabIndex = 10;
            this.cboxNombre.Text = "Nombre";
            this.cboxNombre.UseVisualStyleBackColor = true;
            this.cboxNombre.CheckedChanged += new System.EventHandler(this.cboxNombre_CheckedChanged);
            // 
            // cboxCodigo
            // 
            this.cboxCodigo.AutoSize = true;
            this.cboxCodigo.Depth = 0;
            this.cboxCodigo.Location = new System.Drawing.Point(563, 93);
            this.cboxCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.cboxCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxCodigo.Name = "cboxCodigo";
            this.cboxCodigo.ReadOnly = false;
            this.cboxCodigo.Ripple = true;
            this.cboxCodigo.Size = new System.Drawing.Size(85, 37);
            this.cboxCodigo.TabIndex = 9;
            this.cboxCodigo.Text = "Codigo";
            this.cboxCodigo.UseVisualStyleBackColor = true;
            this.cboxCodigo.CheckedChanged += new System.EventHandler(this.cboxCodigo_CheckedChanged);
            // 
            // checkBox1_Inhabilitado
            // 
            this.checkBox1_Inhabilitado.AutoSize = true;
            this.checkBox1_Inhabilitado.Location = new System.Drawing.Point(586, 246);
            this.checkBox1_Inhabilitado.Name = "checkBox1_Inhabilitado";
            this.checkBox1_Inhabilitado.Size = new System.Drawing.Size(71, 17);
            this.checkBox1_Inhabilitado.TabIndex = 69;
            this.checkBox1_Inhabilitado.Text = "Inhabilitar";
            this.checkBox1_Inhabilitado.UseVisualStyleBackColor = true;
            this.checkBox1_Inhabilitado.Visible = false;
            // 
            // cBox1_Siniva
            // 
            this.cBox1_Siniva.AutoSize = true;
            this.cBox1_Siniva.Location = new System.Drawing.Point(519, 246);
            this.cBox1_Siniva.Name = "cBox1_Siniva";
            this.cBox1_Siniva.Size = new System.Drawing.Size(61, 17);
            this.cBox1_Siniva.TabIndex = 67;
            this.cBox1_Siniva.Text = "Sin IVA";
            this.cBox1_Siniva.UseVisualStyleBackColor = true;
            this.cBox1_Siniva.Visible = false;
            // 
            // txtUnidadMedidaD
            // 
            this.txtUnidadMedidaD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadMedidaD.Enabled = false;
            this.txtUnidadMedidaD.Location = new System.Drawing.Point(153, 243);
            this.txtUnidadMedidaD.Name = "txtUnidadMedidaD";
            this.txtUnidadMedidaD.Size = new System.Drawing.Size(139, 20);
            this.txtUnidadMedidaD.TabIndex = 65;
            this.txtUnidadMedidaD.Visible = false;
            // 
            // cbxSerie
            // 
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(422, 176);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(45, 21);
            this.cbxSerie.TabIndex = 56;
            this.cbxSerie.Visible = false;
            this.cbxSerie.TextChanged += new System.EventHandler(this.cbxSerie_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(475, 177);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(159, 20);
            this.txtSerie.TabIndex = 57;
            this.txtSerie.Visible = false;
            // 
            // txtLinea
            // 
            this.txtLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLinea.Enabled = false;
            this.txtLinea.Location = new System.Drawing.Point(124, 177);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(199, 20);
            this.txtLinea.TabIndex = 54;
            this.txtLinea.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(826, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 68);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptar.Location = new System.Drawing.Point(657, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 68);
            this.btnAceptar.TabIndex = 78;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(541, 303);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(104, 20);
            this.txtPrecio.TabIndex = 71;
            this.txtPrecio.Visible = false;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Depth = 0;
            this.lblprecio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblprecio.Location = new System.Drawing.Point(479, 303);
            this.lblprecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(57, 19);
            this.lblprecio.TabIndex = 76;
            this.lblprecio.Text = "Precio : ";
            this.lblprecio.Visible = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Location = new System.Drawing.Point(107, 276);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(538, 20);
            this.txtReferencia.TabIndex = 70;
            this.txtReferencia.Visible = false;
            // 
            // lblreferencia
            // 
            this.lblreferencia.AutoSize = true;
            this.lblreferencia.Depth = 0;
            this.lblreferencia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblreferencia.Location = new System.Drawing.Point(15, 277);
            this.lblreferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblreferencia.Name = "lblreferencia";
            this.lblreferencia.Size = new System.Drawing.Size(88, 19);
            this.lblreferencia.TabIndex = 74;
            this.lblreferencia.Text = "Referencia : ";
            this.lblreferencia.Visible = false;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(445, 243);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(60, 20);
            this.txtStockMinimo.TabIndex = 66;
            this.txtStockMinimo.Visible = false;
            // 
            // lblsmin
            // 
            this.lblsmin.AutoSize = true;
            this.lblsmin.Depth = 0;
            this.lblsmin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblsmin.Location = new System.Drawing.Point(333, 244);
            this.lblsmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblsmin.Name = "lblsmin";
            this.lblsmin.Size = new System.Drawing.Size(111, 19);
            this.lblsmin.TabIndex = 72;
            this.lblsmin.Text = "Stock Minimo : ";
            this.lblsmin.Visible = false;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(103, 243);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(46, 20);
            this.txtUnidadMedida.TabIndex = 64;
            this.txtUnidadMedida.Visible = false;
            this.txtUnidadMedida.TextChanged += new System.EventHandler(this.txtUnidadMedida_TextChanged);
            // 
            // lblumedida
            // 
            this.lblumedida.AutoSize = true;
            this.lblumedida.Depth = 0;
            this.lblumedida.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblumedida.Location = new System.Drawing.Point(15, 244);
            this.lblumedida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblumedida.Name = "lblumedida";
            this.lblumedida.Size = new System.Drawing.Size(80, 19);
            this.lblumedida.TabIndex = 68;
            this.lblumedida.Text = "U. Medida :";
            this.lblumedida.Visible = false;
            // 
            // txtCodigoSatD
            // 
            this.txtCodigoSatD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoSatD.Enabled = false;
            this.txtCodigoSatD.Location = new System.Drawing.Point(268, 210);
            this.txtCodigoSatD.Name = "txtCodigoSatD";
            this.txtCodigoSatD.Size = new System.Drawing.Size(603, 20);
            this.txtCodigoSatD.TabIndex = 62;
            this.txtCodigoSatD.Visible = false;
            // 
            // txtCodigoSat
            // 
            this.txtCodigoSat.Location = new System.Drawing.Point(117, 210);
            this.txtCodigoSat.Name = "txtCodigoSat";
            this.txtCodigoSat.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSat.TabIndex = 61;
            this.txtCodigoSat.Visible = false;
            this.txtCodigoSat.TextChanged += new System.EventHandler(this.txtCodigoSat_TextChanged);
            this.txtCodigoSat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSat_KeyPress);
            // 
            // lblCsat
            // 
            this.lblCsat.AutoSize = true;
            this.lblCsat.Depth = 0;
            this.lblCsat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCsat.Location = new System.Drawing.Point(15, 210);
            this.lblCsat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCsat.Name = "lblCsat";
            this.lblCsat.Size = new System.Drawing.Size(97, 19);
            this.lblCsat.TabIndex = 63;
            this.lblCsat.Text = "Codigo SAT : ";
            this.lblCsat.Visible = false;
            // 
            // txtF_Peso
            // 
            this.txtF_Peso.Location = new System.Drawing.Point(798, 177);
            this.txtF_Peso.Name = "txtF_Peso";
            this.txtF_Peso.Size = new System.Drawing.Size(73, 20);
            this.txtF_Peso.TabIndex = 59;
            this.txtF_Peso.Visible = false;
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Depth = 0;
            this.lblFP.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFP.Location = new System.Drawing.Point(678, 178);
            this.lblFP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(114, 19);
            this.lblFP.TabIndex = 60;
            this.lblFP.Text = "Factor de Peso :";
            this.lblFP.Visible = false;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Depth = 0;
            this.lblSerie.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSerie.Location = new System.Drawing.Point(368, 178);
            this.lblSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(48, 19);
            this.lblSerie.TabIndex = 58;
            this.lblSerie.Text = "Serie : ";
            this.lblSerie.Visible = false;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Depth = 0;
            this.lblLinea.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLinea.Location = new System.Drawing.Point(15, 178);
            this.lblLinea.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(52, 19);
            this.lblLinea.TabIndex = 55;
            this.lblLinea.Text = "Linea : ";
            this.lblLinea.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(344, 138);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(527, 20);
            this.txtDescripcion.TabIndex = 51;
            this.txtDescripcion.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Depth = 0;
            this.lblDescripcion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescripcion.Location = new System.Drawing.Point(242, 138);
            this.lblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 19);
            this.lblDescripcion.TabIndex = 52;
            this.lblDescripcion.Text = "Descripcion : ";
            this.lblDescripcion.Visible = false;
            // 
            // txtxClave
            // 
            this.txtxClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxClave.Enabled = false;
            this.txtxClave.Location = new System.Drawing.Point(73, 137);
            this.txtxClave.Name = "txtxClave";
            this.txtxClave.Size = new System.Drawing.Size(144, 20);
            this.txtxClave.TabIndex = 50;
            this.txtxClave.Visible = false;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Depth = 0;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClave.Location = new System.Drawing.Point(15, 138);
            this.lblClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 19);
            this.lblClave.TabIndex = 49;
            this.lblClave.Text = "Clave : ";
            this.lblClave.Visible = false;
            // 
            // cbxLinea
            // 
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(73, 176);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(45, 21);
            this.cbxLinea.TabIndex = 82;
            this.cbxLinea.Visible = false;
            this.cbxLinea.TextChanged += new System.EventHandler(this.cbxLinea_TextChanged);
            // 
            // btnBuscar_Ser
            // 
            this.btnBuscar_Ser.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar_Ser.BackgroundImage = global::LinxAdmo.Properties.Resources.busca;
            this.btnBuscar_Ser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_Ser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_Ser.ForeColor = System.Drawing.Color.White;
            this.btnBuscar_Ser.Location = new System.Drawing.Point(640, 177);
            this.btnBuscar_Ser.Name = "btnBuscar_Ser";
            this.btnBuscar_Ser.Size = new System.Drawing.Size(31, 20);
            this.btnBuscar_Ser.TabIndex = 84;
            this.btnBuscar_Ser.UseVisualStyleBackColor = false;
            this.btnBuscar_Ser.Visible = false;
            this.btnBuscar_Ser.Click += new System.EventHandler(this.btnBuscar_Ser_Click);
            // 
            // btnBuscar_Lin
            // 
            this.btnBuscar_Lin.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar_Lin.BackgroundImage = global::LinxAdmo.Properties.Resources.busca;
            this.btnBuscar_Lin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_Lin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_Lin.ForeColor = System.Drawing.Color.White;
            this.btnBuscar_Lin.Location = new System.Drawing.Point(329, 176);
            this.btnBuscar_Lin.Name = "btnBuscar_Lin";
            this.btnBuscar_Lin.Size = new System.Drawing.Size(31, 20);
            this.btnBuscar_Lin.TabIndex = 83;
            this.btnBuscar_Lin.UseVisualStyleBackColor = false;
            this.btnBuscar_Lin.Visible = false;
            this.btnBuscar_Lin.Click += new System.EventHandler(this.btnBuscar_Lin_Click);
            // 
            // btnBuscar_Umed
            // 
            this.btnBuscar_Umed.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar_Umed.BackgroundImage = global::LinxAdmo.Properties.Resources.busca;
            this.btnBuscar_Umed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_Umed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_Umed.ForeColor = System.Drawing.Color.White;
            this.btnBuscar_Umed.Location = new System.Drawing.Point(297, 242);
            this.btnBuscar_Umed.Name = "btnBuscar_Umed";
            this.btnBuscar_Umed.Size = new System.Drawing.Size(31, 20);
            this.btnBuscar_Umed.TabIndex = 81;
            this.btnBuscar_Umed.UseVisualStyleBackColor = false;
            this.btnBuscar_Umed.Visible = false;
            this.btnBuscar_Umed.Click += new System.EventHandler(this.btnBuscar_Umed_Click);
            // 
            // btnBuscar_CSat
            // 
            this.btnBuscar_CSat.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar_CSat.BackgroundImage = global::LinxAdmo.Properties.Resources.busca;
            this.btnBuscar_CSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_CSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar_CSat.ForeColor = System.Drawing.Color.White;
            this.btnBuscar_CSat.Location = new System.Drawing.Point(223, 210);
            this.btnBuscar_CSat.Name = "btnBuscar_CSat";
            this.btnBuscar_CSat.Size = new System.Drawing.Size(31, 20);
            this.btnBuscar_CSat.TabIndex = 73;
            this.btnBuscar_CSat.UseVisualStyleBackColor = false;
            this.btnBuscar_CSat.Visible = false;
            this.btnBuscar_CSat.Click += new System.EventHandler(this.btnBuscar_CSat_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnElimina.Location = new System.Drawing.Point(741, 246);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(79, 68);
            this.btnElimina.TabIndex = 85;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Visible = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtCBarras
            // 
            this.txtCBarras.Location = new System.Drawing.Point(369, 304);
            this.txtCBarras.Name = "txtCBarras";
            this.txtCBarras.Size = new System.Drawing.Size(104, 20);
            this.txtCBarras.TabIndex = 86;
            this.txtCBarras.Visible = false;
            // 
            // lblCBarras
            // 
            this.lblCBarras.AutoSize = true;
            this.lblCBarras.Depth = 0;
            this.lblCBarras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCBarras.Location = new System.Drawing.Point(253, 304);
            this.lblCBarras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCBarras.Name = "lblCBarras";
            this.lblCBarras.Size = new System.Drawing.Size(113, 19);
            this.lblCBarras.TabIndex = 87;
            this.lblCBarras.Text = "Codigo Barras : ";
            this.lblCBarras.Visible = false;
            // 
            // smEdiArti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 333);
            this.Controls.Add(this.txtCBarras);
            this.Controls.Add(this.lblCBarras);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnBuscar_Ser);
            this.Controls.Add(this.btnBuscar_Lin);
            this.Controls.Add(this.cbxLinea);
            this.Controls.Add(this.btnBuscar_Umed);
            this.Controls.Add(this.checkBox1_Inhabilitado);
            this.Controls.Add(this.cBox1_Siniva);
            this.Controls.Add(this.txtUnidadMedidaD);
            this.Controls.Add(this.btnBuscar_CSat);
            this.Controls.Add(this.cbxSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.lblreferencia);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.lblsmin);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.lblumedida);
            this.Controls.Add(this.txtCodigoSatD);
            this.Controls.Add(this.txtCodigoSat);
            this.Controls.Add(this.lblCsat);
            this.Controls.Add(this.txtF_Peso);
            this.Controls.Add(this.lblFP);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtxClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboxNombre);
            this.Controls.Add(this.cboxCodigo);
            this.Name = "smEdiArti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edita Articulos";
            this.Load += new System.EventHandler(this.smEdiArti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigo;
        private MaterialSkin.Controls.MaterialCheckbox cboxNombre;
        private MaterialSkin.Controls.MaterialCheckbox cboxCodigo;
        private System.Windows.Forms.Button btnBuscar_Umed;
        private System.Windows.Forms.CheckBox checkBox1_Inhabilitado;
        private System.Windows.Forms.CheckBox cBox1_Siniva;
        private System.Windows.Forms.TextBox txtUnidadMedidaD;
        private System.Windows.Forms.Button btnBuscar_CSat;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecio;
        private MaterialSkin.Controls.MaterialLabel lblprecio;
        private System.Windows.Forms.TextBox txtReferencia;
        private MaterialSkin.Controls.MaterialLabel lblreferencia;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private MaterialSkin.Controls.MaterialLabel lblsmin;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private MaterialSkin.Controls.MaterialLabel lblumedida;
        private System.Windows.Forms.TextBox txtCodigoSatD;
        private System.Windows.Forms.TextBox txtCodigoSat;
        private MaterialSkin.Controls.MaterialLabel lblCsat;
        private System.Windows.Forms.TextBox txtF_Peso;
        private MaterialSkin.Controls.MaterialLabel lblFP;
        private MaterialSkin.Controls.MaterialLabel lblSerie;
        private MaterialSkin.Controls.MaterialLabel lblLinea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialLabel lblDescripcion;
        private System.Windows.Forms.TextBox txtxClave;
        private MaterialSkin.Controls.MaterialLabel lblClave;
        private System.Windows.Forms.ComboBox cbxLinea;
        private System.Windows.Forms.Button btnBuscar_Lin;
        private System.Windows.Forms.Button btnBuscar_Ser;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtCBarras;
        private MaterialSkin.Controls.MaterialLabel lblCBarras;
    }
}