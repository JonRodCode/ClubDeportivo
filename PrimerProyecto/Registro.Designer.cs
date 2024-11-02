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
            lblNombre.Location = new Point(100, 160);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.White;
            lblApellido.Location = new Point(100, 188);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.White;
            lblTipo.Location = new Point(100, 266);
            lblTipo.Margin = new Padding(2, 0, 2, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.White;
            lblDocumento.Location = new Point(244, 266);
            lblDocumento.Margin = new Padding(2, 0, 2, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 160);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(169, 186);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(254, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(316, 263);
            txtDocumento.Margin = new Padding(2, 2, 2, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(106, 23);
            txtDocumento.TabIndex = 5;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(167, 266);
            cboTipo.Margin = new Padding(2, 2, 2, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(67, 23);
            cboTipo.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = (Image)resources.GetObject("btnLimpiar.BackgroundImage");
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.Location = new Point(438, 216);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 43);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIngresar.Location = new Point(438, 160);
            btnIngresar.Margin = new Padding(2, 2, 2, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(105, 43);
            btnIngresar.TabIndex = 8;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // dtgvPrincipal
            // 
            dtgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPrincipal.Location = new Point(79, 346);
            dtgvPrincipal.Margin = new Padding(2, 2, 2, 2);
            dtgvPrincipal.Name = "dtgvPrincipal";
            dtgvPrincipal.RowHeadersWidth = 62;
            dtgvPrincipal.RowTemplate.Height = 33;
            dtgvPrincipal.Size = new Size(465, 135);
            dtgvPrincipal.TabIndex = 11;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.White;
            lblMail.Location = new Point(99, 216);
            lblMail.Margin = new Padding(2, 0, 2, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 11;
            lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(169, 211);
            txtMail.Margin = new Padding(2, 2, 2, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(254, 23);
            txtMail.TabIndex = 2;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.White;
            lblCelular.Location = new Point(99, 239);
            lblCelular.Margin = new Padding(2, 0, 2, 0);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 13;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(169, 236);
            txtCelular.Margin = new Padding(2, 2, 2, 2);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(254, 23);
            txtCelular.TabIndex = 3;
            // 
            // chkRegistrarSocio
            // 
            chkRegistrarSocio.AutoSize = true;
            chkRegistrarSocio.Location = new Point(406, 300);
            chkRegistrarSocio.Margin = new Padding(3, 2, 3, 2);
            chkRegistrarSocio.Name = "chkRegistrarSocio";
            chkRegistrarSocio.Size = new Size(15, 14);
            chkRegistrarSocio.TabIndex = 7;
            chkRegistrarSocio.UseVisualStyleBackColor = true;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = Color.White;
            lblRegistrar.Location = new Point(274, 300);
            lblRegistrar.Margin = new Padding(2, 0, 2, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(129, 15);
            lblRegistrar.TabIndex = 15;
            lblRegistrar.Text = "¿Registrar como Socio?";
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.BackColor = Color.White;
            lblApto.Location = new Point(100, 298);
            lblApto.Margin = new Padding(2, 0, 2, 0);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(66, 15);
            lblApto.TabIndex = 17;
            lblApto.Text = "Apto Fisico";
            // 
            // chkApto
            // 
            chkApto.AutoSize = true;
            chkApto.Location = new Point(172, 300);
            chkApto.Margin = new Padding(3, 2, 3, 2);
            chkApto.Name = "chkApto";
            chkApto.Size = new Size(15, 14);
            chkApto.TabIndex = 6;
            chkApto.UseVisualStyleBackColor = true;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.BackColor = Color.White;
            lblListaClientes.Location = new Point(79, 330);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(90, 15);
            lblListaClientes.TabIndex = 18;
            lblListaClientes.Text = "Lista de clientes";
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = (Image)resources.GetObject("btnVolver.BackgroundImage");
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.Location = new Point(438, 276);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 40);
            btnVolver.TabIndex = 10;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
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
            Margin = new Padding(2, 2, 2, 2);
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
