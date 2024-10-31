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
            pnFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lbNDocNoSocio
            // 
            lbNDocNoSocio.AutoSize = true;
            lbNDocNoSocio.Location = new Point(69, 71);
            lbNDocNoSocio.Name = "lbNDocNoSocio";
            lbNDocNoSocio.Size = new Size(132, 20);
            lbNDocNoSocio.TabIndex = 0;
            lbNDocNoSocio.Text = "N° de Documento:";
            // 
            // txtNoSocio
            // 
            txtNoSocio.Location = new Point(250, 68);
            txtNoSocio.Name = "txtNoSocio";
            txtNoSocio.Size = new Size(125, 27);
            txtNoSocio.TabIndex = 1;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(159, 167);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(129, 29);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(69, 114);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(155, 20);
            lblActividad.TabIndex = 3;
            lblActividad.Text = "Nombre de Actividad:";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(250, 107);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(125, 27);
            txtActividad.TabIndex = 4;
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
            pnFormaPago.Location = new Point(518, 46);
            pnFormaPago.Name = "pnFormaPago";
            pnFormaPago.Size = new Size(250, 125);
            pnFormaPago.TabIndex = 6;
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
            btnIrAPagar.Enabled = false;
            btnIrAPagar.Location = new Point(63, 271);
            btnIrAPagar.Name = "btnIrAPagar";
            btnIrAPagar.Size = new Size(127, 29);
            btnIrAPagar.TabIndex = 7;
            btnIrAPagar.Text = "Ir a pagar";
            btnIrAPagar.UseVisualStyleBackColor = true;
            btnIrAPagar.Click += btnIrAPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(580, 271);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(148, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // fmrInscribirEnActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnIrAPagar);
            Controls.Add(pnFormaPago);
            Controls.Add(txtActividad);
            Controls.Add(lblActividad);
            Controls.Add(btnVerificar);
            Controls.Add(txtNoSocio);
            Controls.Add(lbNDocNoSocio);
            Name = "fmrInscribirEnActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InscribirEnActividad";
            pnFormaPago.ResumeLayout(false);
            pnFormaPago.PerformLayout();
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
    }
}