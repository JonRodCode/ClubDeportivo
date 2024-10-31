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
            gbFormaDePago = new GroupBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            btnVolver = new Button();
            btnComprobarPago = new Button();
            btnVerificar = new Button();
            gbFormaDePago.SuspendLayout();
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
            // gbFormaDePago
            // 
            gbFormaDePago.Controls.Add(rbTarjeta);
            gbFormaDePago.Controls.Add(rbEfectivo);
            gbFormaDePago.Location = new Point(526, 41);
            gbFormaDePago.Name = "gbFormaDePago";
            gbFormaDePago.Size = new Size(250, 125);
            gbFormaDePago.TabIndex = 2;
            gbFormaDePago.TabStop = false;
            gbFormaDePago.Text = "Forma de pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(39, 76);
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
            rbEfectivo.Location = new Point(39, 46);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(550, 264);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(138, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprobarPago
            // 
            btnComprobarPago.Enabled = false;
            btnComprobarPago.Location = new Point(75, 167);
            btnComprobarPago.Name = "btnComprobarPago";
            btnComprobarPago.Size = new Size(134, 34);
            btnComprobarPago.TabIndex = 4;
            btnComprobarPago.Text = "Ir a Pagar";
            btnComprobarPago.UseVisualStyleBackColor = true;
            btnComprobarPago.Click += btnPagar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(327, 49);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // frmCobrarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(779, 421);
            Controls.Add(btnVerificar);
            Controls.Add(btnComprobarPago);
            Controls.Add(btnVolver);
            Controls.Add(gbFormaDePago);
            Controls.Add(txtNumSocio);
            Controls.Add(lblNumSocio);
            Name = "frmCobrarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CobrarCuota";
            gbFormaDePago.ResumeLayout(false);
            gbFormaDePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumSocio;
        private TextBox txtNumSocio;
        private GroupBox gbFormaDePago;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Button btnVolver;
        private Button btnComprobarPago;
        private Button btnVerificar;
    }
}