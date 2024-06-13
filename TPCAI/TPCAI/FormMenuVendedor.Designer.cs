namespace TPCAI
{
    partial class FormMenuVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarVta = new System.Windows.Forms.Button();
            this.buttonVtaVendedor = new System.Windows.Forms.Button();
            this.btnAdminCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija que opción desea realizar:";
            // 
            // buttonRegistrarVta
            // 
            this.buttonRegistrarVta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegistrarVta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegistrarVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVta.Location = new System.Drawing.Point(47, 18);
            this.buttonRegistrarVta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrarVta.Name = "buttonRegistrarVta";
            this.buttonRegistrarVta.Size = new System.Drawing.Size(118, 50);
            this.buttonRegistrarVta.TabIndex = 2;
            this.buttonRegistrarVta.Text = "Registrar Venta";
            this.buttonRegistrarVta.UseVisualStyleBackColor = true;
            this.buttonRegistrarVta.Click += new System.EventHandler(this.buttonRegistrarVta_Click);
            // 
            // buttonVtaVendedor
            // 
            this.buttonVtaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonVtaVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVtaVendedor.Location = new System.Drawing.Point(196, 18);
            this.buttonVtaVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVtaVendedor.Name = "buttonVtaVendedor";
            this.buttonVtaVendedor.Size = new System.Drawing.Size(120, 50);
            this.buttonVtaVendedor.TabIndex = 3;
            this.buttonVtaVendedor.Text = "Ventas por Vendedor";
            this.buttonVtaVendedor.UseVisualStyleBackColor = true;
            this.buttonVtaVendedor.Click += new System.EventHandler(this.buttonVtaVendedor_Click);
            // 
            // btnAdminCliente
            // 
            this.btnAdminCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdminCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdminCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCliente.Location = new System.Drawing.Point(120, 18);
            this.btnAdminCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminCliente.Name = "btnAdminCliente";
            this.btnAdminCliente.Size = new System.Drawing.Size(118, 50);
            this.btnAdminCliente.TabIndex = 4;
            this.btnAdminCliente.Text = "Administración de Clientes";
            this.btnAdminCliente.UseVisualStyleBackColor = true;
            this.btnAdminCliente.Click += new System.EventHandler(this.btnAdminCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.buttonRegistrarVta);
            this.groupBox1.Controls.Add(this.buttonVtaVendedor);
            this.groupBox1.Location = new System.Drawing.Point(42, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnAdminCliente);
            this.groupBox2.Location = new System.Drawing.Point(42, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(42, 282);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(109, 30);
            this.btnCambiarContraseña.TabIndex = 7;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(309, 267);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(90, 45);
            this.btnCerrarSesion.TabIndex = 25;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FormMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 323);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuVendedor";
            this.Text = "Menú Vendedor";
            this.Load += new System.EventHandler(this.FormMenuVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrarVta;
        private System.Windows.Forms.Button buttonVtaVendedor;
        private System.Windows.Forms.Button btnAdminCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}