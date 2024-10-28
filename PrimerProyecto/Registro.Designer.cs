namespace PrimerProyecto
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            dtgvPrincipal = new DataGridView();
            lblMail = new Label();
            txtMail = new TextBox();
            lblCelular = new Label();
            txtCelular = new TextBox();
            chkRegistrarSocio = new CheckBox();
            lblRegistrar = new Label();
            lblApto = new Label();
            chkApto = new CheckBox();
            lblListaClientes = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.Location = new Point(114, 213);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.White;
            lblApellido.Location = new Point(114, 251);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.White;
            lblTipo.Location = new Point(114, 355);
            lblTipo.Margin = new Padding(2, 0, 2, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.White;
            lblDocumento.Location = new Point(279, 355);
            lblDocumento.Margin = new Padding(2, 0, 2, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(193, 213);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(193, 248);
            txtApellido.Margin = new Padding(2, 3, 2, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(290, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(361, 351);
            txtDocumento.Margin = new Padding(2, 3, 2, 3);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(121, 27);
            txtDocumento.TabIndex = 5;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(191, 355);
            cboTipo.Margin = new Padding(2, 3, 2, 3);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(76, 28);
            cboTipo.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.Location = new Point(501, 280);
            btnLimpiar.Margin = new Padding(2, 3, 2, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 37);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.Location = new Point(501, 213);
            btnIngresar.Margin = new Padding(2, 3, 2, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(120, 48);
            btnIngresar.TabIndex = 8;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // dtgvPrincipal
            // 
            dtgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPrincipal.Location = new Point(90, 461);
            dtgvPrincipal.Margin = new Padding(2, 3, 2, 3);
            dtgvPrincipal.Name = "dtgvPrincipal";
            dtgvPrincipal.RowHeadersWidth = 62;
            dtgvPrincipal.RowTemplate.Height = 33;
            dtgvPrincipal.Size = new Size(531, 180);
            dtgvPrincipal.TabIndex = 11;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.White;
            lblMail.Location = new Point(113, 288);
            lblMail.Margin = new Padding(2, 0, 2, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 20);
            lblMail.TabIndex = 11;
            lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(193, 281);
            txtMail.Margin = new Padding(2, 3, 2, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(290, 27);
            txtMail.TabIndex = 2;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.White;
            lblCelular.Location = new Point(113, 319);
            lblCelular.Margin = new Padding(2, 0, 2, 0);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(55, 20);
            lblCelular.TabIndex = 13;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(193, 315);
            txtCelular.Margin = new Padding(2, 3, 2, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(290, 27);
            txtCelular.TabIndex = 3;
            // 
            // chkRegistrarSocio
            // 
            chkRegistrarSocio.AutoSize = true;
            chkRegistrarSocio.Location = new Point(464, 400);
            chkRegistrarSocio.Name = "chkRegistrarSocio";
            chkRegistrarSocio.Size = new Size(18, 17);
            chkRegistrarSocio.TabIndex = 7;
            chkRegistrarSocio.UseVisualStyleBackColor = true;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = Color.White;
            lblRegistrar.Location = new Point(313, 400);
            lblRegistrar.Margin = new Padding(2, 0, 2, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(165, 20);
            lblRegistrar.TabIndex = 15;
            lblRegistrar.Text = "¿Registrar como Socio?";
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.BackColor = Color.White;
            lblApto.Location = new Point(114, 397);
            lblApto.Margin = new Padding(2, 0, 2, 0);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(83, 20);
            lblApto.TabIndex = 17;
            lblApto.Text = "Apto Fisico";
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.Location = new Point(197, 400);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(18, 17);
            chkApto.TabIndex = 6;
            chkApto.UseVisualStyleBackColor = true;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.BackColor = Color.White;
            lblListaClientes.Location = new Point(90, 440);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(114, 20);
            lblListaClientes.TabIndex = 18;
            lblListaClientes.Text = "Lista de clientes";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(501, 377);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 748);
            Controls.Add(btnVolver);
            Controls.Add(lblListaClientes);
            Controls.Add(chkApto);
            Controls.Add(lblApto);
            Controls.Add(chkRegistrarSocio);
            Controls.Add(lblRegistrar);
            Controls.Add(txtCelular);
            Controls.Add(lblCelular);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(dtgvPrincipal);
            Controls.Add(btnIngresar);
            Controls.Add(btnLimpiar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Button btnLimpiar;
        private Button btnIngresar;
        private DataGridView dtgvPrincipal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Documento;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblCelular;
        private TextBox txtCelular;
        private CheckBox chkRegistrarSocio;
        private Label lblRegistrar;
        private Label lblApto;
        private CheckBox chkApto;
        private Label lblListaClientes;
        private Button btnVolver;
    }
}
