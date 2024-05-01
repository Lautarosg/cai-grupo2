namespace TPCAI
{
    partial class FormBajaUsuario
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
            this.textBoxidUserBaja = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonListarUsuariosActivos = new System.Windows.Forms.Button();
            this.textBoxListarUserPorId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los siguientes datos para dar de baja al usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // textBoxidUserBaja
            // 
            this.textBoxidUserBaja.Location = new System.Drawing.Point(228, 268);
            this.textBoxidUserBaja.Name = "textBoxidUserBaja";
            this.textBoxidUserBaja.Size = new System.Drawing.Size(234, 26);
            this.textBoxidUserBaja.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(322, 320);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(160, 54);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Listar Usuario Activos del master ID ingresado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Se recomienda listar usuarios antes de borrar";
            // 
            // buttonListarUsuariosActivos
            // 
            this.buttonListarUsuariosActivos.Location = new System.Drawing.Point(432, 88);
            this.buttonListarUsuariosActivos.Name = "buttonListarUsuariosActivos";
            this.buttonListarUsuariosActivos.Size = new System.Drawing.Size(134, 46);
            this.buttonListarUsuariosActivos.TabIndex = 11;
            this.buttonListarUsuariosActivos.Text = "Listar";
            this.buttonListarUsuariosActivos.UseVisualStyleBackColor = true;
            this.buttonListarUsuariosActivos.Click += new System.EventHandler(this.buttonListarUsuariosActivos_Click);
            // 
            // textBoxListarUserPorId
            // 
            this.textBoxListarUserPorId.Location = new System.Drawing.Point(46, 98);
            this.textBoxListarUserPorId.Name = "textBoxListarUserPorId";
            this.textBoxListarUserPorId.Size = new System.Drawing.Size(361, 26);
            this.textBoxListarUserPorId.TabIndex = 12;
            // 
            // FormBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxListarUserPorId);
            this.Controls.Add(this.buttonListarUsuariosActivos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxidUserBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBajaUsuario";
            this.Text = "Baja de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxidUserBaja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonListarUsuariosActivos;
        private System.Windows.Forms.TextBox textBoxListarUserPorId;
    }
}