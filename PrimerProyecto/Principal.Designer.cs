namespace PrimerProyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnRegistrar = new Button();
            btnCobrarCuota = new Button();
            btnInscribirAActividad = new Button();
            btnListar = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.Location = new Point(141, 213);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(206, 80);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackgroundImage = (Image)resources.GetObject("btnCobrarCuota.BackgroundImage");
            btnCobrarCuota.BackgroundImageLayout = ImageLayout.Stretch;
            btnCobrarCuota.Location = new Point(141, 457);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(206, 80);
            btnCobrarCuota.TabIndex = 2;
            btnCobrarCuota.UseVisualStyleBackColor = true;
            btnCobrarCuota.Click += btnCobrarCuota_Click;
            // 
            // btnInscribirAActividad
            // 
            btnInscribirAActividad.BackgroundImage = (Image)resources.GetObject("btnInscribirAActividad.BackgroundImage");
            btnInscribirAActividad.BackgroundImageLayout = ImageLayout.Stretch;
            btnInscribirAActividad.Location = new Point(141, 336);
            btnInscribirAActividad.Name = "btnInscribirAActividad";
            btnInscribirAActividad.Size = new Size(206, 80);
            btnInscribirAActividad.TabIndex = 1;
            btnInscribirAActividad.UseVisualStyleBackColor = true;
            btnInscribirAActividad.Click += btnInscribirAActividad_Click;
            // 
            // btnListar
            // 
            btnListar.BackgroundImage = (Image)resources.GetObject("btnListar.BackgroundImage");
            btnListar.BackgroundImageLayout = ImageLayout.Stretch;
            btnListar.Location = new Point(141, 576);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(206, 80);
            btnListar.TabIndex = 3;
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 748);
            Controls.Add(btnListar);
            Controls.Add(btnInscribirAActividad);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClubDeportivo";
            FormClosing += frmPrincipal_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCobrarCuota;
        private Button btnInscribirAActividad;
        private Button btnListar;
    }
}