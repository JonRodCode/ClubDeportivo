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
            lblNumSocio = new Label();
            txtNumSocio = new TextBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            btnVolver = new Button();
            btnIrAPagar = new Button();
            btnVerificar = new Button();
            pnFormaPago = new Panel();
            lblFormaDePago = new Label();
            pnFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(75, 52);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(88, 20);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "N° de Socio";
            // 
            // txtNumSocio
            // 
            txtNumSocio.Location = new Point(179, 49);
            txtNumSocio.Name = "txtNumSocio";
            txtNumSocio.Size = new Size(125, 27);
            txtNumSocio.TabIndex = 1;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(49, 78);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(74, 24);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(49, 48);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(570, 266);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(138, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnIrAPagar
            // 
            btnIrAPagar.Enabled = false;
            btnIrAPagar.Location = new Point(75, 261);
            btnIrAPagar.Name = "btnIrAPagar";
            btnIrAPagar.Size = new Size(134, 34);
            btnIrAPagar.TabIndex = 4;
            btnIrAPagar.Text = "Ir a Pagar";
            btnIrAPagar.UseVisualStyleBackColor = true;
            btnIrAPagar.Click += btnPagar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(128, 98);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // pnFP
            // 
            pnFormaPago.BorderStyle = BorderStyle.FixedSingle;
            pnFormaPago.Controls.Add(rbTarjeta);
            pnFormaPago.Controls.Add(lblFormaDePago);
            pnFormaPago.Controls.Add(rbEfectivo);
            pnFormaPago.Enabled = false;
            pnFormaPago.Location = new Point(505, 49);
            pnFormaPago.Name = "pnFP";
            pnFormaPago.Size = new Size(250, 125);
            pnFormaPago.TabIndex = 7;
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(15, 9);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(111, 20);
            lblFormaDePago.TabIndex = 0;
            lblFormaDePago.Text = "Forma de pago";
            // 
            // frmCobrarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(779, 421);
            Controls.Add(pnFormaPago);
            Controls.Add(btnVerificar);
            Controls.Add(btnIrAPagar);
            Controls.Add(btnVolver);
            Controls.Add(txtNumSocio);
            Controls.Add(lblNumSocio);
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
    }
}