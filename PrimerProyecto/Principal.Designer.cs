﻿namespace PrimerProyecto
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.Location = new Point(123, 160);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(180, 60);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackgroundImage = (Image)resources.GetObject("btnCobrarCuota.BackgroundImage");
            btnCobrarCuota.Location = new Point(123, 343);
            btnCobrarCuota.Margin = new Padding(3, 2, 3, 2);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(180, 60);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btnInscribirAActividad
            // 
            btnInscribirAActividad.BackgroundImage = (Image)resources.GetObject("btnInscribirAActividad.BackgroundImage");
            btnInscribirAActividad.Location = new Point(123, 252);
            btnInscribirAActividad.Margin = new Padding(3, 2, 3, 2);
            btnInscribirAActividad.Name = "btnInscribirAActividad";
            btnInscribirAActividad.Size = new Size(180, 60);
            btnInscribirAActividad.TabIndex = 2;
            btnInscribirAActividad.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.BackgroundImage = (Image)resources.GetObject("btnListar.BackgroundImage");
            btnListar.Location = new Point(123, 432);
            btnListar.Margin = new Padding(3, 2, 3, 2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(180, 60);
            btnListar.TabIndex = 3;
            btnListar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Prueba";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(textBox1);
            Controls.Add(btnListar);
            Controls.Add(btnInscribirAActividad);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClubDeportivo";
            FormClosing += frmPrincipal_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCobrarCuota;
        private Button btnInscribirAActividad;
        private Button btnListar;
        private TextBox textBox1;
    }
}