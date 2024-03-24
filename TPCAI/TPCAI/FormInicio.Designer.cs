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
            this.TxtContraseñaInicio = new System.Windows.Forms.TextBox();
            this.btnLoginInicio = new System.Windows.Forms.Button();
            this.linkLblRegistrarInicio = new System.Windows.Forms.LinkLabel();
            this.lblUsuarioInicio = new System.Windows.Forms.Label();
            this.lblContraseñaInicio = new System.Windows.Forms.Label();
            this.lblIngresarInicio = new System.Windows.Forms.Label();
            this.btnSalirInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(287, 35);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInicio.Size = new System.Drawing.Size(134, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido a ElectroHogar";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsuarioInicio
            // 
            this.txtUsuarioInicio.Location = new System.Drawing.Point(98, 129);
            this.txtUsuarioInicio.Name = "txtUsuarioInicio";
            this.txtUsuarioInicio.Size = new System.Drawing.Size(155, 20);
            this.txtUsuarioInicio.TabIndex = 1;
            this.txtUsuarioInicio.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // TxtContraseñaInicio
            // 
            this.TxtContraseñaInicio.Location = new System.Drawing.Point(98, 179);
            this.TxtContraseñaInicio.Name = "TxtContraseñaInicio";
            this.TxtContraseñaInicio.Size = new System.Drawing.Size(155, 20);
            this.TxtContraseñaInicio.TabIndex = 2;
            this.TxtContraseñaInicio.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // btnLoginInicio
            // 
            this.btnLoginInicio.Location = new System.Drawing.Point(279, 176);
            this.btnLoginInicio.Name = "btnLoginInicio";
            this.btnLoginInicio.Size = new System.Drawing.Size(56, 23);
            this.btnLoginInicio.TabIndex = 3;
            this.btnLoginInicio.Text = "Ingresar";
            this.btnLoginInicio.UseVisualStyleBackColor = true;
            this.btnLoginInicio.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblRegistrarInicio
            // 
            this.linkLblRegistrarInicio.AutoSize = true;
            this.linkLblRegistrarInicio.Location = new System.Drawing.Point(95, 232);
            this.linkLblRegistrarInicio.Name = "linkLblRegistrarInicio";
            this.linkLblRegistrarInicio.Size = new System.Drawing.Size(161, 13);
            this.linkLblRegistrarInicio.TabIndex = 6;
            this.linkLblRegistrarInicio.TabStop = true;
            this.linkLblRegistrarInicio.Text = "No esta registrado? Hagalo aquí";
            this.linkLblRegistrarInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrar_LinkClicked);
            // 
            // lblUsuarioInicio
            // 
            this.lblUsuarioInicio.AutoSize = true;
            this.lblUsuarioInicio.Location = new System.Drawing.Point(20, 132);
            this.lblUsuarioInicio.Name = "lblUsuarioInicio";
            this.lblUsuarioInicio.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioInicio.TabIndex = 7;
            this.lblUsuarioInicio.Text = "Usuario";
            this.lblUsuarioInicio.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // lblContraseñaInicio
            // 
            this.lblContraseñaInicio.AutoSize = true;
            this.lblContraseñaInicio.Location = new System.Drawing.Point(20, 182);
            this.lblContraseñaInicio.Name = "lblContraseñaInicio";
            this.lblContraseñaInicio.Size = new System.Drawing.Size(61, 13);
            this.lblContraseñaInicio.TabIndex = 8;
            this.lblContraseñaInicio.Text = "Contraseña";
            // 
            // lblIngresarInicio
            // 
            this.lblIngresarInicio.AutoSize = true;
            this.lblIngresarInicio.Location = new System.Drawing.Point(95, 93);
            this.lblIngresarInicio.Name = "lblIngresarInicio";
            this.lblIngresarInicio.Size = new System.Drawing.Size(65, 13);
            this.lblIngresarInicio.TabIndex = 9;
            this.lblIngresarInicio.Text = "Inicie sesión";
            this.lblIngresarInicio.Click += new System.EventHandler(this.labelIngresar_Click);
            // 
            // btnSalirInicio
            // 
            this.btnSalirInicio.Location = new System.Drawing.Point(707, 395);
            this.btnSalirInicio.Name = "btnSalirInicio";
            this.btnSalirInicio.Size = new System.Drawing.Size(66, 37);
            this.btnSalirInicio.TabIndex = 10;
            this.btnSalirInicio.Text = "Salir";
            this.btnSalirInicio.UseVisualStyleBackColor = true;
            this.btnSalirInicio.Click += new System.EventHandler(this.btnSalirInicio_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirInicio);
            this.Controls.Add(this.lblIngresarInicio);
            this.Controls.Add(this.lblContraseñaInicio);
            this.Controls.Add(this.lblUsuarioInicio);
            this.Controls.Add(this.linkLblRegistrarInicio);
            this.Controls.Add(this.btnLoginInicio);
            this.Controls.Add(this.TxtContraseñaInicio);
            this.Controls.Add(this.txtUsuarioInicio);
            this.Controls.Add(this.lblInicio);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtUsuarioInicio;
        private System.Windows.Forms.TextBox TxtContraseñaInicio;
        private System.Windows.Forms.Button btnLoginInicio;
        private System.Windows.Forms.LinkLabel linkLblRegistrarInicio;
        private System.Windows.Forms.Label lblUsuarioInicio;
        private System.Windows.Forms.Label lblContraseñaInicio;
        private System.Windows.Forms.Label lblIngresarInicio;
        private System.Windows.Forms.Button btnSalirInicio;
    }
}

