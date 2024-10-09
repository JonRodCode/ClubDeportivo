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
            btnRegistrar = new Button();
            btnCobrarCuota = new Button();
            btnInscribirAActividad = new Button();
            btnListar = new Button();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(83, 218);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(178, 85);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.Location = new Point(383, 218);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(178, 85);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "COBRAR CUOTA";
            btnCobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btnInscribirAActividad
            // 
            btnInscribirAActividad.Location = new Point(83, 378);
            btnInscribirAActividad.Name = "btnInscribirAActividad";
            btnInscribirAActividad.Size = new Size(178, 85);
            btnInscribirAActividad.TabIndex = 2;
            btnInscribirAActividad.Text = "INSCRIBIR A ACTIVIDAD";
            btnInscribirAActividad.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(383, 378);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(178, 85);
            btnListar.TabIndex = 3;
            btnListar.Text = "LISTAR VENCIMIENTO CUOTA";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(671, 516);
            Controls.Add(btnListar);
            Controls.Add(btnInscribirAActividad);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrar);
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