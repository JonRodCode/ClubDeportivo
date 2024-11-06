namespace PrimerProyecto
{
    partial class frmCobrarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrarCuota));
            lblNumSocio = new Label();
            txtNumSocio = new TextBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            btnVolver = new Button();
            btnIrAPagar = new Button();
            btnVerificar = new Button();
            pnFormaPago = new Panel();
            lblFormaDePago = new Label();
            btnCambiar = new Button();
            pnFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.BackColor = Color.White;
            lblNumSocio.Location = new Point(91, 270);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(69, 15);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "N° de Socio";
            // 
            // txtNumSocio
            // 
            txtNumSocio.Location = new Point(166, 266);
            txtNumSocio.Margin = new Padding(3, 2, 3, 2);
            txtNumSocio.Name = "txtNumSocio";
            txtNumSocio.Size = new Size(110, 23);
            txtNumSocio.TabIndex = 0;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(43, 58);
            rbTarjeta.Margin = new Padding(3, 2, 3, 2);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(59, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(43, 36);
            rbEfectivo.Margin = new Padding(3, 2, 3, 2);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = (Image)resources.GetObject("btnVolver.BackgroundImage");
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.Location = new Point(407, 359);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(129, 49);
            btnVolver.TabIndex = 4;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIrAPagar
            // 
            btnIrAPagar.BackgroundImage = (Image)resources.GetObject("btnIrAPagar.BackgroundImage");
            btnIrAPagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIrAPagar.Enabled = false;
            btnIrAPagar.Location = new Point(248, 359);
            btnIrAPagar.Margin = new Padding(3, 2, 3, 2);
            btnIrAPagar.Name = "btnIrAPagar";
            btnIrAPagar.Size = new Size(123, 49);
            btnIrAPagar.TabIndex = 3;
            btnIrAPagar.UseVisualStyleBackColor = true;
            btnIrAPagar.Click += btnPagar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackgroundImage = (Image)resources.GetObject("btnVerificar.BackgroundImage");
            btnVerificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVerificar.Location = new Point(88, 356);
            btnVerificar.Margin = new Padding(3, 2, 3, 2);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(123, 52);
            btnVerificar.TabIndex = 1;
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // pnFormaPago
            // 
            pnFormaPago.BorderStyle = BorderStyle.FixedSingle;
            pnFormaPago.Controls.Add(rbTarjeta);
            pnFormaPago.Controls.Add(lblFormaDePago);
            pnFormaPago.Controls.Add(rbEfectivo);
            pnFormaPago.Enabled = false;
            pnFormaPago.Location = new Point(317, 230);
            pnFormaPago.Margin = new Padding(3, 2, 3, 2);
            pnFormaPago.Name = "pnFormaPago";
            pnFormaPago.Size = new Size(219, 94);
            pnFormaPago.TabIndex = 2;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(13, 7);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(87, 15);
            lblFormaDePago.TabIndex = 0;
            lblFormaDePago.Text = "Forma de pago";
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.White;
            btnCambiar.BackgroundImage = (Image)resources.GetObject("btnCambiar.BackgroundImage");
            btnCambiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiar.Location = new Point(88, 356);
            btnCambiar.Margin = new Padding(3, 2, 3, 2);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(123, 52);
            btnCambiar.TabIndex = 5;
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Visible = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // frmCobrarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 590);
            Controls.Add(btnCambiar);
            Controls.Add(pnFormaPago);
            Controls.Add(btnVerificar);
            Controls.Add(btnIrAPagar);
            Controls.Add(btnVolver);
            Controls.Add(txtNumSocio);
            Controls.Add(lblNumSocio);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCobrarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CobrarCuota";
            pnFormaPago.ResumeLayout(false);
            pnFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumSocio;
        private TextBox txtNumSocio;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Button btnVolver;
        private Button btnIrAPagar;
        private Button btnVerificar;
        private Panel pnFormaPago;
        private Label lblFormaDePago;
        private Button btnCambiar;
    }
}