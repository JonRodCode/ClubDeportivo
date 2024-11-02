namespace PrimerProyecto
{
    partial class frmComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));
            panel1 = new Panel();
            lblComprobante = new Label();
            btnImprimir = new Button();
            panel2 = new Panel();
            lblClub = new Label();
            panel3 = new Panel();
            lblFechaActual = new Label();
            lblDatosClub = new Label();
            lblFecha = new Label();
            panel4 = new Panel();
            lblTemaAPagar = new Label();
            lblVencimiento = new Label();
            lblProximoVenc = new Label();
            lblNumeroDeSocio = new Label();
            lblSocioNumero = new Label();
            lblPrecio = new Label();
            lblMonto = new Label();
            lblEfectivoOTarjeta = new Label();
            lblFormaDePago = new Label();
            lblPagoDe = new Label();
            lblCliente = new Label();
            btnPagar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblComprobante);
            panel1.Location = new Point(78, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 61);
            panel1.TabIndex = 0;
            // 
            // lblComprobante
            // 
            lblComprobante.AutoSize = true;
            lblComprobante.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprobante.Location = new Point(245, 12);
            lblComprobante.Name = "lblComprobante";
            lblComprobante.Size = new Size(267, 35);
            lblComprobante.TabIndex = 0;
            lblComprobante.Text = "Comprobante de Pago";
            // 
            // btnImprimir
            // 
            btnImprimir.BackgroundImage = (Image)resources.GetObject("btnImprimir.BackgroundImage");
            btnImprimir.BackgroundImageLayout = ImageLayout.Stretch;
            btnImprimir.Enabled = false;
            btnImprimir.Location = new Point(374, 578);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(189, 57);
            btnImprimir.TabIndex = 1;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblClub);
            panel2.Location = new Point(78, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 90);
            panel2.TabIndex = 1;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClub.Location = new Point(87, 24);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(183, 35);
            lblClub.TabIndex = 0;
            lblClub.Text = "Club Deportivo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblFechaActual);
            panel3.Controls.Add(lblDatosClub);
            panel3.Controls.Add(lblFecha);
            panel3.Location = new Point(472, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 90);
            panel3.TabIndex = 2;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Location = new Point(184, 13);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(93, 20);
            lblFechaActual.TabIndex = 2;
            lblFechaActual.Text = "Fecha Actual";
            // 
            // lblDatosClub
            // 
            lblDatosClub.AutoSize = true;
            lblDatosClub.Location = new Point(102, 50);
            lblDatosClub.Name = "lblDatosClub";
            lblDatosClub.Size = new Size(175, 20);
            lblDatosClub.TabIndex = 1;
            lblDatosClub.Text = "Datos generales del Club";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(102, 13);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTemaAPagar);
            panel4.Controls.Add(lblVencimiento);
            panel4.Controls.Add(lblProximoVenc);
            panel4.Controls.Add(lblNumeroDeSocio);
            panel4.Controls.Add(lblSocioNumero);
            panel4.Controls.Add(lblPrecio);
            panel4.Controls.Add(lblMonto);
            panel4.Controls.Add(lblEfectivoOTarjeta);
            panel4.Controls.Add(lblFormaDePago);
            panel4.Controls.Add(lblPagoDe);
            panel4.Controls.Add(lblCliente);
            panel4.Location = new Point(78, 339);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 233);
            panel4.TabIndex = 3;
            // 
            // lblTemaAPagar
            // 
            lblTemaAPagar.AutoSize = true;
            lblTemaAPagar.Location = new Point(245, 75);
            lblTemaAPagar.Name = "lblTemaAPagar";
            lblTemaAPagar.Size = new Size(107, 20);
            lblTemaAPagar.TabIndex = 11;
            lblTemaAPagar.Text = "Cuota Mensual";
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(245, 106);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(129, 20);
            lblVencimiento.TabIndex = 10;
            lblVencimiento.Text = "FechaVencimiento";
            // 
            // lblProximoVenc
            // 
            lblProximoVenc.AutoSize = true;
            lblProximoVenc.Location = new Point(38, 106);
            lblProximoVenc.Name = "lblProximoVenc";
            lblProximoVenc.Size = new Size(156, 20);
            lblProximoVenc.TabIndex = 9;
            lblProximoVenc.Text = "Próximo vencimiento: ";
            // 
            // lblNumeroDeSocio
            // 
            lblNumeroDeSocio.AutoSize = true;
            lblNumeroDeSocio.Location = new Point(118, 40);
            lblNumeroDeSocio.Name = "lblNumeroDeSocio";
            lblNumeroDeSocio.Size = new Size(17, 20);
            lblNumeroDeSocio.TabIndex = 8;
            lblNumeroDeSocio.Text = "0";
            // 
            // lblSocioNumero
            // 
            lblSocioNumero.AutoSize = true;
            lblSocioNumero.Location = new Point(38, 40);
            lblSocioNumero.Name = "lblSocioNumero";
            lblSocioNumero.Size = new Size(74, 20);
            lblSocioNumero.TabIndex = 6;
            lblSocioNumero.Text = "Socio N°: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(642, 180);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(482, 180);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(68, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto $:";
            // 
            // lblEfectivoOTarjeta
            // 
            lblEfectivoOTarjeta.AutoSize = true;
            lblEfectivoOTarjeta.Location = new Point(251, 180);
            lblEfectivoOTarjeta.Name = "lblEfectivoOTarjeta";
            lblEfectivoOTarjeta.Size = new Size(123, 20);
            lblEfectivoOTarjeta.TabIndex = 3;
            lblEfectivoOTarjeta.Text = "Efectivo o Tarjeta";
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Location = new Point(38, 180);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(118, 20);
            lblFormaDePago.TabIndex = 2;
            lblFormaDePago.Text = "Forma de pago: ";
            // 
            // lblPagoDe
            // 
            lblPagoDe.AutoSize = true;
            lblPagoDe.Location = new Point(38, 75);
            lblPagoDe.Name = "lblPagoDe";
            lblPagoDe.Size = new Size(66, 20);
            lblPagoDe.TabIndex = 1;
            lblPagoDe.Text = "Pago de:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(38, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(177, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre y Apellido Socio";
            // 
            // btnPagar
            // 
            btnPagar.BackgroundImage = (Image)resources.GetObject("btnPagar.BackgroundImage");
            btnPagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnPagar.Location = new Point(78, 578);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(195, 57);
            btnPagar.TabIndex = 4;
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.Location = new Point(688, 578);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 57);
            btnCancelar.TabIndex = 5;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 696);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Name = "frmComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante";
            Load += frmComprobante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblComprobante;
        private Button btnImprimir;
        private Panel panel2;
        private Label lblClub;
        private Panel panel3;
        private Label lblFecha;
        private Label lblDatosClub;
        private Label lblFechaActual;
        private Panel panel4;
        private Label lblPagoDe;
        private Label lblCliente;
        private Label lblFormaDePago;
        private Label lblPrecio;
        private Label lblMonto;
        private Label lblEfectivoOTarjeta;
        private Label lblSocioNumero;
        private Label lblNumeroDeSocio;
        private Label lblVencimiento;
        private Label lblProximoVenc;
        private Label lblTemaAPagar;
        private Button btnPagar;
        private Button btnCancelar;
    }
}