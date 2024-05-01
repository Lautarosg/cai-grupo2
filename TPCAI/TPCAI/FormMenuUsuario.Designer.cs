namespace TPCAI
{
    partial class FormMenuUsuario
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
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonListarUsuariosActivos = new System.Windows.Forms.Button();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario seleccionado:";
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(15, 334);
            this.txtUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(157, 20);
            this.txtUsuarioSeleccionado.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(203, 319);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(107, 35);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "Eliminar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar por Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonListarUsuariosActivos
            // 
            this.buttonListarUsuariosActivos.Location = new System.Drawing.Point(191, 53);
            this.buttonListarUsuariosActivos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListarUsuariosActivos.Name = "buttonListarUsuariosActivos";
            this.buttonListarUsuariosActivos.Size = new System.Drawing.Size(70, 30);
            this.buttonListarUsuariosActivos.TabIndex = 11;
            this.buttonListarUsuariosActivos.Text = "Buscar";
            this.buttonListarUsuariosActivos.UseVisualStyleBackColor = true;
            this.buttonListarUsuariosActivos.Click += new System.EventHandler(this.buttonListarUsuariosActivos_Click);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(15, 59);
            this.txtBuscarUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(157, 20);
            this.txtBuscarUser.TabIndex = 12;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(118, 101);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(456, 187);
            this.dgvListaUsuarios.TabIndex = 13;
            this.dgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellClick);
            this.dgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentClick);
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Location = new System.Drawing.Point(530, 26);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(135, 42);
            this.btnAltaUsuario.TabIndex = 14;
            this.btnAltaUsuario.Text = "Agregar Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // FormMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 372);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.buttonListarUsuariosActivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuarioSeleccionado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuUsuario";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.FormMenuUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonListarUsuariosActivos;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Button btnAltaUsuario;
    }
}