namespace PrimerProyecto
{
    partial class frmMenu
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
            lblMenu = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            btnCobrar = new Button();
            btnCarnet = new Button();
            btnVencimientos = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(76, 24);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(59, 25);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "label1";
            lblMenu.Click += lblMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(532, 17);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 39);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(110, 108);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(215, 90);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar socio y no socio";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(110, 222);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(215, 90);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "Cobrar cuota";
            btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnCarnet
            // 
            btnCarnet.Location = new Point(412, 108);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(215, 90);
            btnCarnet.TabIndex = 4;
            btnCarnet.Text = "Entregar carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            // 
            // btnVencimientos
            // 
            btnVencimientos.Location = new Point(412, 222);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(215, 90);
            btnVencimientos.TabIndex = 5;
            btnVencimientos.Text = "Listar vencimientos";
            btnVencimientos.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 444);
            Controls.Add(btnVencimientos);
            Controls.Add(btnCarnet);
            Controls.Add(btnCobrar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSalir);
            Controls.Add(lblMenu);
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnSalir;
        private Button btnRegistrar;
        private Button btnCobrar;
        private Button btnCarnet;
        private Button btnVencimientos;
    }
}