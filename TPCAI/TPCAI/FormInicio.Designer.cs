namespace TPCAI
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtUsuarioInicio = new System.Windows.Forms.TextBox();
            this.txtContraseñaInicio = new System.Windows.Forms.TextBox();
            this.btnLoginInicio = new System.Windows.Forms.Button();
            this.linkLblRegistrarInicio = new System.Windows.Forms.LinkLabel();
            this.lblUsuarioInicio = new System.Windows.Forms.Label();
            this.lblContraseñaInicio = new System.Windows.Forms.Label();
            this.lblIngresarInicio = new System.Windows.Forms.Label();
            this.btnSalirInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMostrarInicio = new System.Windows.Forms.PictureBox();
            this.pbOcultarInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInicio.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInicio.Location = new System.Drawing.Point(218, 29);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInicio.Size = new System.Drawing.Size(434, 41);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido a ElectroHogar";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsuarioInicio
            // 
            this.txtUsuarioInicio.Location = new System.Drawing.Point(147, 198);
            this.txtUsuarioInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuarioInicio.Name = "txtUsuarioInicio";
            this.txtUsuarioInicio.Size = new System.Drawing.Size(230, 26);
            this.txtUsuarioInicio.TabIndex = 1;
            this.txtUsuarioInicio.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseñaInicio
            // 
            this.txtContraseñaInicio.Location = new System.Drawing.Point(147, 275);
            this.txtContraseñaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseñaInicio.Name = "txtContraseñaInicio";
            this.txtContraseñaInicio.PasswordChar = '*';
            this.txtContraseñaInicio.Size = new System.Drawing.Size(230, 26);
            this.txtContraseñaInicio.TabIndex = 2;
            this.txtContraseñaInicio.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // btnLoginInicio
            // 
            this.btnLoginInicio.Location = new System.Drawing.Point(412, 349);
            this.btnLoginInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoginInicio.Name = "btnLoginInicio";
            this.btnLoginInicio.Size = new System.Drawing.Size(84, 35);
            this.btnLoginInicio.TabIndex = 3;
            this.btnLoginInicio.Text = "Ingresar";
            this.btnLoginInicio.UseVisualStyleBackColor = true;
            this.btnLoginInicio.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblRegistrarInicio
            // 
            this.linkLblRegistrarInicio.AutoSize = true;
            this.linkLblRegistrarInicio.Location = new System.Drawing.Point(30, 626);
            this.linkLblRegistrarInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblRegistrarInicio.Name = "linkLblRegistrarInicio";
            this.linkLblRegistrarInicio.Size = new System.Drawing.Size(54, 20);
            this.linkLblRegistrarInicio.TabIndex = 6;
            this.linkLblRegistrarInicio.TabStop = true;
            this.linkLblRegistrarInicio.Text = "Ayuda";
            this.linkLblRegistrarInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrar_LinkClicked);
            // 
            // lblUsuarioInicio
            // 
            this.lblUsuarioInicio.AutoSize = true;
            this.lblUsuarioInicio.Location = new System.Drawing.Point(30, 203);
            this.lblUsuarioInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioInicio.Name = "lblUsuarioInicio";
            this.lblUsuarioInicio.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarioInicio.TabIndex = 7;
            this.lblUsuarioInicio.Text = "Usuario";
            this.lblUsuarioInicio.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // lblContraseñaInicio
            // 
            this.lblContraseñaInicio.AutoSize = true;
            this.lblContraseñaInicio.Location = new System.Drawing.Point(30, 280);
            this.lblContraseñaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaInicio.Name = "lblContraseñaInicio";
            this.lblContraseñaInicio.Size = new System.Drawing.Size(92, 20);
            this.lblContraseñaInicio.TabIndex = 8;
            this.lblContraseñaInicio.Text = "Contraseña";
            // 
            // lblIngresarInicio
            // 
            this.lblIngresarInicio.AutoSize = true;
            this.lblIngresarInicio.Location = new System.Drawing.Point(142, 143);
            this.lblIngresarInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresarInicio.Name = "lblIngresarInicio";
            this.lblIngresarInicio.Size = new System.Drawing.Size(96, 20);
            this.lblIngresarInicio.TabIndex = 9;
            this.lblIngresarInicio.Text = "Inicie sesión";
            this.lblIngresarInicio.Click += new System.EventHandler(this.labelIngresar_Click);
            // 
            // btnSalirInicio
            // 
            this.btnSalirInicio.Location = new System.Drawing.Point(1060, 608);
            this.btnSalirInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirInicio.Name = "btnSalirInicio";
            this.btnSalirInicio.Size = new System.Drawing.Size(99, 57);
            this.btnSalirInicio.TabIndex = 10;
            this.btnSalirInicio.Text = "Salir";
            this.btnSalirInicio.UseVisualStyleBackColor = true;
            this.btnSalirInicio.Click += new System.EventHandler(this.btnSalirInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPCAI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(620, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbMostrarInicio
            // 
            this.pbMostrarInicio.Image = global::TPCAI.Properties.Resources.Visible;
            this.pbMostrarInicio.Location = new System.Drawing.Point(412, 280);
            this.pbMostrarInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbMostrarInicio.Name = "pbMostrarInicio";
            this.pbMostrarInicio.Size = new System.Drawing.Size(45, 31);
            this.pbMostrarInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarInicio.TabIndex = 12;
            this.pbMostrarInicio.TabStop = false;
            this.pbMostrarInicio.Click += new System.EventHandler(this.pbMostrarInicio_Click);
            // 
            // pbOcultarInicio
            // 
            this.pbOcultarInicio.Image = global::TPCAI.Properties.Resources.NotVisible;
            this.pbOcultarInicio.Location = new System.Drawing.Point(412, 280);
            this.pbOcultarInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbOcultarInicio.Name = "pbOcultarInicio";
            this.pbOcultarInicio.Size = new System.Drawing.Size(45, 31);
            this.pbOcultarInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultarInicio.TabIndex = 13;
            this.pbOcultarInicio.TabStop = false;
            this.pbOcultarInicio.Click += new System.EventHandler(this.pbOcultarInicio_Click_1);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pbMostrarInicio);
            this.Controls.Add(this.pbOcultarInicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirInicio);
            this.Controls.Add(this.lblIngresarInicio);
            this.Controls.Add(this.lblContraseñaInicio);
            this.Controls.Add(this.lblUsuarioInicio);
            this.Controls.Add(this.linkLblRegistrarInicio);
            this.Controls.Add(this.btnLoginInicio);
            this.Controls.Add(this.txtContraseñaInicio);
            this.Controls.Add(this.txtUsuarioInicio);
            this.Controls.Add(this.lblInicio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtUsuarioInicio;
        private System.Windows.Forms.TextBox txtContraseñaInicio;
        private System.Windows.Forms.Button btnLoginInicio;
        private System.Windows.Forms.LinkLabel linkLblRegistrarInicio;
        private System.Windows.Forms.Label lblUsuarioInicio;
        private System.Windows.Forms.Label lblContraseñaInicio;
        private System.Windows.Forms.Label lblIngresarInicio;
        private System.Windows.Forms.Button btnSalirInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMostrarInicio;
        private System.Windows.Forms.PictureBox pbOcultarInicio;
    }
}

