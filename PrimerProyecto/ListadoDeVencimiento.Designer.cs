﻿namespace PrimerProyecto
{
    partial class fmrListadoDeVencimiento
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
            dgvListSocios = new DataGridView();
            IdSocio = new DataGridViewTextBoxColumn();
            nomape = new DataGridViewTextBoxColumn();
            TDocC = new DataGridViewTextBoxColumn();
            DocC = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            lblListado = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvListSocios
            // 
            dgvListSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListSocios.Columns.AddRange(new DataGridViewColumn[] { IdSocio, nomape, TDocC, DocC, mail, celular });
            dgvListSocios.Location = new Point(34, 107);
            dgvListSocios.Name = "dgvListSocios";
            dgvListSocios.RowHeadersWidth = 51;
            dgvListSocios.RowTemplate.Height = 29;
            dgvListSocios.Size = new Size(720, 290);
            dgvListSocios.TabIndex = 0;
            // 
            // IdSocio
            // 
            IdSocio.HeaderText = "N° de Socio";
            IdSocio.MinimumWidth = 6;
            IdSocio.Name = "IdSocio";
            IdSocio.ReadOnly = true;
            IdSocio.Width = 125;
            // 
            // nomape
            // 
            nomape.HeaderText = "Socio";
            nomape.MinimumWidth = 6;
            nomape.Name = "nomape";
            nomape.ReadOnly = true;
            nomape.Width = 125;
            // 
            // TDocC
            // 
            TDocC.HeaderText = "Tipo de Doc.";
            TDocC.MinimumWidth = 6;
            TDocC.Name = "TDocC";
            TDocC.ReadOnly = true;
            TDocC.Width = 125;
            // 
            // DocC
            // 
            DocC.HeaderText = "N° de Doc.";
            DocC.MinimumWidth = 6;
            DocC.Name = "DocC";
            DocC.ReadOnly = true;
            DocC.Width = 125;
            // 
            // mail
            // 
            mail.HeaderText = "Mail";
            mail.MinimumWidth = 6;
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Width = 125;
            // 
            // celular
            // 
            celular.HeaderText = "N° de Celular";
            celular.MinimumWidth = 6;
            celular.Name = "celular";
            celular.ReadOnly = true;
            celular.Width = 125;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Location = new Point(168, 54);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(419, 20);
            lblListado.TabIndex = 1;
            lblListado.Text = "Listado de socios a los que se les vence la cuota el dia de hoy.";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(608, 411);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 29);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver al Menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // fmrListadoDeVencimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblListado);
            Controls.Add(dgvListSocios);
            Name = "fmrListadoDeVencimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoDeVencimiento";
            Load += ListadoDeVencimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListSocios;
        private Label lblListado;
        private Button btnVolver;
        private DataGridViewTextBoxColumn IdSocio;
        private DataGridViewTextBoxColumn nomape;
        private DataGridViewTextBoxColumn TDocC;
        private DataGridViewTextBoxColumn DocC;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn celular;
    }
}