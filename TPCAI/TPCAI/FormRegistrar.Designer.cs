namespace TPCAI
{
    partial class FormRegistrar
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
            this.lblInicioRegistra = new System.Windows.Forms.Label();
            this.txtUsuarioRegistrar = new System.Windows.Forms.TextBox();
            this.txtContraseñaRegistrar = new System.Windows.Forms.TextBox();
            this.txtVerificarRegistrar = new System.Windows.Forms.TextBox();
            this.lblUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblContrañesaRegistrar = new System.Windows.Forms.Label();
            this.lblContraseñaVerificar = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblErrorUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblInstruccionesRegistrar = new System.Windows.Forms.Label();
            this.lblMinUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMaxUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblInstruccionesContraseñaRegistrar = new System.Windows.Forms.Label();
            this.lblInstruccionesUsuarioRegistrar = new System.Windows.Forms.Label();
            this.lblMayContraseñaRegistrar = new System.Windows.Forms.Label();
            this.lblMinContraseñaRegistrar = new System.Windows.Forms.Label();
            this.btnVolverRegistrar = new System.Windows.Forms.Button();
            this.btnSalirRegistrar = new System.Windows.Forms.Button();
            this.lblErrorContraseñaRegistrar = new System.Windows.Forms.Label();
            this.lblVerificarContRegistrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicioRegistra
            // 
            this.lblInicioRegistra.AutoSize = true;
            this.lblInicioRegistra.Location = new System.Drawing.Point(321, 28);
            this.lblInicioRegistra.Name = "lblInicioRegistra";
            this.lblInicioRegistra.Size = new System.Drawing.Size(119, 13);
            this.lblInicioRegistra.TabIndex = 0;
            this.lblInicioRegistra.Text = "Registrar nuevo usuario";
            // 
            // txtUsuarioRegistrar
            // 
            this.txtUsuarioRegistrar.Location = new System.Drawing.Point(203, 97);
            this.txtUsuarioRegistrar.Name = "txtUsuarioRegistrar";
            this.txtUsuarioRegistrar.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioRegistrar.TabIndex = 1;
            this.txtUsuarioRegistrar.TextChanged += new System.EventHandler(this.txtUsuarioRegistrar_TextChanged);
            // 
            // txtContraseñaRegistrar
            // 
            this.txtContraseñaRegistrar.Location = new System.Drawing.Point(203, 175);
            this.txtContraseñaRegistrar.Name = "txtContraseñaRegistrar";
            this.txtContraseñaRegistrar.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaRegistrar.TabIndex = 2;
            this.txtContraseñaRegistrar.TextChanged += new System.EventHandler(this.txtContraseñaRegistrar_TextChanged_1);
            // 
            // txtVerificarRegistrar
            // 
            this.txtVerificarRegistrar.Location = new System.Drawing.Point(203, 221);
            this.txtVerificarRegistrar.Name = "txtVerificarRegistrar";
            this.txtVerificarRegistrar.Size = new System.Drawing.Size(100, 20);
            this.txtVerificarRegistrar.TabIndex = 3;
            this.txtVerificarRegistrar.TextChanged += new System.EventHandler(this.txtContraseñaVerificar_TextChanged);
            // 
            // lblUsuarioRegistrar
            // 
            this.lblUsuarioRegistrar.AutoSize = true;
            this.lblUsuarioRegistrar.Location = new System.Drawing.Point(25, 97);
            this.lblUsuarioRegistrar.Name = "lblUsuarioRegistrar";
            this.lblUsuarioRegistrar.Size = new System.Drawing.Size(147, 13);
            this.lblUsuarioRegistrar.TabIndex = 4;
            this.lblUsuarioRegistrar.Text = "Ingrese un nombre de usuario";
            this.lblUsuarioRegistrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContrañesaRegistrar
            // 
            this.lblContrañesaRegistrar.AutoSize = true;
            this.lblContrañesaRegistrar.Location = new System.Drawing.Point(25, 185);
            this.lblContrañesaRegistrar.Name = "lblContrañesaRegistrar";
            this.lblContrañesaRegistrar.Size = new System.Drawing.Size(119, 13);
            this.lblContrañesaRegistrar.TabIndex = 5;
            this.lblContrañesaRegistrar.Text = "Ingrese una contraseña";
            // 
            // lblContraseñaVerificar
            // 
            this.lblContraseñaVerificar.AutoSize = true;
            this.lblContraseñaVerificar.Location = new System.Drawing.Point(25, 228);
            this.lblContraseñaVerificar.Name = "lblContraseñaVerificar";
            this.lblContraseñaVerificar.Size = new System.Drawing.Size(105, 13);
            this.lblContraseñaVerificar.TabIndex = 6;
            this.lblContraseñaVerificar.Text = "Repita la contraseña";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(350, 218);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 25);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Crear usuario";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblErrorUsuarioRegistrar
            // 
            this.lblErrorUsuarioRegistrar.AutoSize = true;
            this.lblErrorUsuarioRegistrar.Location = new System.Drawing.Point(200, 134);
            this.lblErrorUsuarioRegistrar.Name = "lblErrorUsuarioRegistrar";
            this.lblErrorUsuarioRegistrar.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUsuarioRegistrar.TabIndex = 8;
            this.lblErrorUsuarioRegistrar.Click += new System.EventHandler(this.lblErrorUsuarioRegistrar_Click);
            // 
            // lblInstruccionesRegistrar
            // 
            this.lblInstruccionesRegistrar.AutoSize = true;
            this.lblInstruccionesRegistrar.Location = new System.Drawing.Point(497, 54);
            this.lblInstruccionesRegistrar.Name = "lblInstruccionesRegistrar";
            this.lblInstruccionesRegistrar.Size = new System.Drawing.Size(239, 13);
            this.lblInstruccionesRegistrar.TabIndex = 9;
            this.lblInstruccionesRegistrar.Text = "Tenga en cuenta al momento de crear su usuario";
            // 
            // lblMinUsuarioRegistrar
            // 
            this.lblMinUsuarioRegistrar.AutoSize = true;
            this.lblMinUsuarioRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinUsuarioRegistrar.Location = new System.Drawing.Point(497, 122);
            this.lblMinUsuarioRegistrar.Name = "lblMinUsuarioRegistrar";
            this.lblMinUsuarioRegistrar.Size = new System.Drawing.Size(103, 13);
            this.lblMinUsuarioRegistrar.TabIndex = 10;
            this.lblMinUsuarioRegistrar.Text = "más de 3 caracteres";
            // 
            // lblMaxUsuarioRegistrar
            // 
            this.lblMaxUsuarioRegistrar.AutoSize = true;
            this.lblMaxUsuarioRegistrar.Location = new System.Drawing.Point(497, 144);
            this.lblMaxUsuarioRegistrar.Name = "lblMaxUsuarioRegistrar";
            this.lblMaxUsuarioRegistrar.Size = new System.Drawing.Size(121, 13);
            this.lblMaxUsuarioRegistrar.TabIndex = 11;
            this.lblMaxUsuarioRegistrar.Text = "menos de 15 caracteres";
            // 
            // lblInstruccionesContraseñaRegistrar
            // 
            this.lblInstruccionesContraseñaRegistrar.AutoSize = true;
            this.lblInstruccionesContraseñaRegistrar.Location = new System.Drawing.Point(497, 178);
            this.lblInstruccionesContraseñaRegistrar.Name = "lblInstruccionesContraseñaRegistrar";
            this.lblInstruccionesContraseñaRegistrar.Size = new System.Drawing.Size(135, 13);
            this.lblInstruccionesContraseñaRegistrar.TabIndex = 12;
            this.lblInstruccionesContraseñaRegistrar.Text = "La contraseña debe incluir:";
            // 
            // lblInstruccionesUsuarioRegistrar
            // 
            this.lblInstruccionesUsuarioRegistrar.AutoSize = true;
            this.lblInstruccionesUsuarioRegistrar.Location = new System.Drawing.Point(497, 97);
            this.lblInstruccionesUsuarioRegistrar.Name = "lblInstruccionesUsuarioRegistrar";
            this.lblInstruccionesUsuarioRegistrar.Size = new System.Drawing.Size(166, 13);
            this.lblInstruccionesUsuarioRegistrar.TabIndex = 13;
            this.lblInstruccionesUsuarioRegistrar.Text = "El nombre de usuario debe incluir:";
            // 
            // lblMayContraseñaRegistrar
            // 
            this.lblMayContraseñaRegistrar.AutoSize = true;
            this.lblMayContraseñaRegistrar.Location = new System.Drawing.Point(497, 206);
            this.lblMayContraseñaRegistrar.Name = "lblMayContraseñaRegistrar";
            this.lblMayContraseñaRegistrar.Size = new System.Drawing.Size(80, 13);
            this.lblMayContraseñaRegistrar.TabIndex = 14;
            this.lblMayContraseñaRegistrar.Text = "Una mayúscula";
            // 
            // lblMinContraseñaRegistrar
            // 
            this.lblMinContraseñaRegistrar.AutoSize = true;
            this.lblMinContraseñaRegistrar.Location = new System.Drawing.Point(497, 228);
            this.lblMinContraseñaRegistrar.Name = "lblMinContraseñaRegistrar";
            this.lblMinContraseñaRegistrar.Size = new System.Drawing.Size(104, 13);
            this.lblMinContraseñaRegistrar.TabIndex = 15;
            this.lblMinContraseñaRegistrar.Text = "Más de 8 caracteres";
            // 
            // btnVolverRegistrar
            // 
            this.btnVolverRegistrar.Location = new System.Drawing.Point(551, 391);
            this.btnVolverRegistrar.Name = "btnVolverRegistrar";
            this.btnVolverRegistrar.Size = new System.Drawing.Size(96, 32);
            this.btnVolverRegistrar.TabIndex = 16;
            this.btnVolverRegistrar.Text = "Volver";
            this.btnVolverRegistrar.UseVisualStyleBackColor = true;
            this.btnVolverRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalirRegistrar
            // 
            this.btnSalirRegistrar.Location = new System.Drawing.Point(677, 391);
            this.btnSalirRegistrar.Name = "btnSalirRegistrar";
            this.btnSalirRegistrar.Size = new System.Drawing.Size(96, 32);
            this.btnSalirRegistrar.TabIndex = 17;
            this.btnSalirRegistrar.Text = "Salir";
            this.btnSalirRegistrar.UseVisualStyleBackColor = true;
            this.btnSalirRegistrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblErrorContraseñaRegistrar
            // 
            this.lblErrorContraseñaRegistrar.AutoSize = true;
            this.lblErrorContraseñaRegistrar.Location = new System.Drawing.Point(200, 202);
            this.lblErrorContraseñaRegistrar.Name = "lblErrorContraseñaRegistrar";
            this.lblErrorContraseñaRegistrar.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseñaRegistrar.TabIndex = 18;
            this.lblErrorContraseñaRegistrar.Click += new System.EventHandler(this.labe_Click);
            // 
            // lblVerificarContRegistrar
            // 
            this.lblVerificarContRegistrar.AutoSize = true;
            this.lblVerificarContRegistrar.Location = new System.Drawing.Point(201, 259);
            this.lblVerificarContRegistrar.Name = "lblVerificarContRegistrar";
            this.lblVerificarContRegistrar.Size = new System.Drawing.Size(0, 13);
            this.lblVerificarContRegistrar.TabIndex = 19;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVerificarContRegistrar);
            this.Controls.Add(this.lblErrorContraseñaRegistrar);
            this.Controls.Add(this.btnSalirRegistrar);
            this.Controls.Add(this.btnVolverRegistrar);
            this.Controls.Add(this.lblMinContraseñaRegistrar);
            this.Controls.Add(this.lblMayContraseñaRegistrar);
            this.Controls.Add(this.lblInstruccionesUsuarioRegistrar);
            this.Controls.Add(this.lblInstruccionesContraseñaRegistrar);
            this.Controls.Add(this.lblMaxUsuarioRegistrar);
            this.Controls.Add(this.lblMinUsuarioRegistrar);
            this.Controls.Add(this.lblInstruccionesRegistrar);
            this.Controls.Add(this.lblErrorUsuarioRegistrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblContraseñaVerificar);
            this.Controls.Add(this.lblContrañesaRegistrar);
            this.Controls.Add(this.lblUsuarioRegistrar);
            this.Controls.Add(this.txtVerificarRegistrar);
            this.Controls.Add(this.txtContraseñaRegistrar);
            this.Controls.Add(this.txtUsuarioRegistrar);
            this.Controls.Add(this.lblInicioRegistra);
            this.Name = "FormRegistrar";
            this.Text = "FormsRegistrar";
            this.Load += new System.EventHandler(this.FormsRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioRegistra;
        private System.Windows.Forms.TextBox txtUsuarioRegistrar;
        private System.Windows.Forms.TextBox txtContraseñaRegistrar;
        private System.Windows.Forms.TextBox txtVerificarRegistrar;
        private System.Windows.Forms.Label lblUsuarioRegistrar;
        private System.Windows.Forms.Label lblContrañesaRegistrar;
        private System.Windows.Forms.Label lblContraseñaVerificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblErrorUsuarioRegistrar;
        private System.Windows.Forms.Label lblInstruccionesRegistrar;
        private System.Windows.Forms.Label lblMinUsuarioRegistrar;
        private System.Windows.Forms.Label lblMaxUsuarioRegistrar;
        private System.Windows.Forms.Label lblInstruccionesContraseñaRegistrar;
        private System.Windows.Forms.Label lblInstruccionesUsuarioRegistrar;
        private System.Windows.Forms.Label lblMayContraseñaRegistrar;
        private System.Windows.Forms.Label lblMinContraseñaRegistrar;
        private System.Windows.Forms.Button btnVolverRegistrar;
        private System.Windows.Forms.Button btnSalirRegistrar;
        private System.Windows.Forms.Label lblErrorContraseñaRegistrar;
        private System.Windows.Forms.Label lblVerificarContRegistrar;
    }
}