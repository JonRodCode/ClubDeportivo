namespace PrimerProyecto
{
    partial class fmrInscribirEnActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrInscribirEnActividad));
            lbNDocNoSocio = new Label();
            txtNoSocio = new TextBox();
            btnVerificar = new Button();
            lblActividad = new Label();
            txtActividad = new TextBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            pnFormaPago = new Panel();
            lblFormaDePago = new Label();
            btnIrAPagar = new Button();
            btnVolver = new Button();
            dgvActividades = new DataGridView();
            ColumnActividad = new DataGridViewTextBoxColumn();
            ColumnProfesor = new DataGridViewTextBoxColumn();
            lblListado = new Label();
            btnCambiar = new Button();
            pnFormaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lbNDocNoSocio
            // 
            lbNDocNoSocio.AutoSize = true;
            lbNDocNoSocio.BackColor = Color.White;
            lbNDocNoSocio.Location = new Point(65, 161);
            lbNDocNoSocio.Name = "lbNDocNoSocio";
            lbNDocNoSocio.Size = new Size(132, 20);
            lbNDocNoSocio.TabIndex = 0;
            lbNDocNoSocio.Text = "N° de Documento:";
            // 
            // txtNoSocio
            // 
            txtNoSocio.Location = new Point(246, 158);
            txtNoSocio.Name = "txtNoSocio";
            txtNoSocio.Size = new Size(125, 27);
            txtNoSocio.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.BackgroundImage = (Image)resources.GetObject("btnVerificar.BackgroundImage");
            btnVerificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerificar.Location = new Point(242, 234);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(129, 50);
            btnVerificar.TabIndex = 2;
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.BackColor = Color.White;
            lblActividad.Location = new Point(65, 204);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(155, 20);
            lblActividad.TabIndex = 3;
            lblActividad.Text = "Nombre de Actividad:";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(246, 197);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(125, 27);
            txtActividad.TabIndex = 1;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(45, 49);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(45, 79);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(74, 24);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // pnFormaPago
            // 
            pnFormaPago.BorderStyle = BorderStyle.FixedSingle;
            pnFormaPago.Controls.Add(lblFormaDePago);
            pnFormaPago.Controls.Add(rbTarjeta);
            pnFormaPago.Controls.Add(rbEfectivo);
            pnFormaPago.Enabled = false;
            pnFormaPago.Location = new Point(397, 154);
            pnFormaPago.Name = "pnFormaPago";
            pnFormaPago.Size = new Size(178, 125);
            pnFormaPago.TabIndex = 3;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(3, 10);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(109, 20);
            lblFormaDePago.TabIndex = 2;
            lblFormaDePago.Text = "Forma de Pago";
            // 
            // btnIrAPagar
            // 
            btnIrAPagar.BackgroundImage = (Image)resources.GetObject("btnIrAPagar.BackgroundImage");
            btnIrAPagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIrAPagar.Enabled = false;
            btnIrAPagar.Location = new Point(409, 326);
            btnIrAPagar.Name = "btnIrAPagar";
            btnIrAPagar.Size = new Size(166, 73);
            btnIrAPagar.TabIndex = 4;
            btnIrAPagar.UseVisualStyleBackColor = true;
            btnIrAPagar.Click += btnIrAPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.btn_volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.Location = new Point(409, 427);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(166, 68);
            btnVolver.TabIndex = 5;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvActividades
            // 
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { ColumnActividad, ColumnProfesor });
            dgvActividades.Location = new Point(65, 326);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.RowTemplate.Height = 29;
            dgvActividades.Size = new Size(306, 167);
            dgvActividades.TabIndex = 6;
            // 
            // ColumnActividad
            // 
            ColumnActividad.HeaderText = "Actividad";
            ColumnActividad.MinimumWidth = 6;
            ColumnActividad.Name = "ColumnActividad";
            ColumnActividad.ReadOnly = true;
            ColumnActividad.Width = 125;
            // 
            // ColumnProfesor
            // 
            ColumnProfesor.HeaderText = "Profesor";
            ColumnProfesor.MinimumWidth = 6;
            ColumnProfesor.Name = "ColumnProfesor";
            ColumnProfesor.ReadOnly = true;
            ColumnProfesor.Width = 125;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.BackColor = Color.White;
            lblListado.Location = new Point(65, 303);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(159, 20);
            lblListado.TabIndex = 7;
            lblListado.Text = "Listado de Actividades";
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.White;
            btnCambiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiar.Location = new Point(242, 234);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(129, 50);
            btnCambiar.TabIndex = 8;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Visible = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // fmrInscribirEnActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 601);
            Controls.Add(btnCambiar);
            Controls.Add(lblListado);
            Controls.Add(dgvActividades);
            Controls.Add(btnVolver);
            Controls.Add(btnIrAPagar);
            Controls.Add(pnFormaPago);
            Controls.Add(txtActividad);
            Controls.Add(lblActividad);
            Controls.Add(btnVerificar);
            Controls.Add(txtNoSocio);
            Controls.Add(lbNDocNoSocio);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmrInscribirEnActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InscribirEnActividad";
            Load += fmrInscribirEnActividad_Load;
            pnFormaPago.ResumeLayout(false);
            pnFormaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNDocNoSocio;
        private TextBox txtNoSocio;
        private Button btnVerificar;
        private Label lblActividad;
        private TextBox txtActividad;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private Panel pnFormaPago;
        private Label lblFormaDePago;
        private Button btnIrAPagar;
        private Button btnVolver;
        private DataGridView dgvActividades;
        private DataGridViewTextBoxColumn ColumnActividad;
        private DataGridViewTextBoxColumn ColumnProfesor;
        private Label lblListado;
        private Button btnCambiar;
    }
}