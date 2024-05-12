namespace TPCAI
{
    partial class FormNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoProducto));
            this.cbPerfilUsuario = new System.Windows.Forms.ComboBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbDNI = new System.Windows.Forms.PictureBox();
            this.pbApellido = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.lblVerificarContRegistrar = new System.Windows.Forms.Label();
            this.buttonVolverAtras = new System.Windows.Forms.Button();
            this.btnConfirmarProducto = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbNombreError = new System.Windows.Forms.PictureBox();
            this.pbApellidoError = new System.Windows.Forms.PictureBox();
            this.pbDNIError = new System.Windows.Forms.PictureBox();
            this.pbEmailError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNIError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPerfilUsuario
            // 
            this.cbPerfilUsuario.FormattingEnabled = true;
            this.cbPerfilUsuario.Items.AddRange(new object[] {
            "1 - Audio",
            "2 - Celulares",
            "3 - Electro Hogar",
            "4 - Informática",
            "5 - Smart TV"});
            this.cbPerfilUsuario.Location = new System.Drawing.Point(117, 45);
            this.cbPerfilUsuario.Name = "cbPerfilUsuario";
            this.cbPerfilUsuario.Size = new System.Drawing.Size(94, 21);
            this.cbPerfilUsuario.TabIndex = 121;
            this.cbPerfilUsuario.SelectedIndexChanged += new System.EventHandler(this.cbPerfilUsuario_SelectedIndexChanged);
            // 
            // pbEmail
            // 
            this.pbEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbEmail.Image")));
            this.pbEmail.Location = new System.Drawing.Point(476, 49);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(19, 18);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 108;
            this.pbEmail.TabStop = false;
            // 
            // pbDNI
            // 
            this.pbDNI.Image = ((System.Drawing.Image)(resources.GetObject("pbDNI.Image")));
            this.pbDNI.Location = new System.Drawing.Point(476, 88);
            this.pbDNI.Name = "pbDNI";
            this.pbDNI.Size = new System.Drawing.Size(19, 17);
            this.pbDNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNI.TabIndex = 106;
            this.pbDNI.TabStop = false;
            // 
            // pbApellido
            // 
            this.pbApellido.Image = ((System.Drawing.Image)(resources.GetObject("pbApellido.Image")));
            this.pbApellido.Location = new System.Drawing.Point(222, 83);
            this.pbApellido.Name = "pbApellido";
            this.pbApellido.Size = new System.Drawing.Size(19, 18);
            this.pbApellido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellido.TabIndex = 105;
            this.pbApellido.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(222, 45);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(19, 17);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombre.TabIndex = 104;
            this.pbNombre.TabStop = false;
            // 
            // lblVerificarContRegistrar
            // 
            this.lblVerificarContRegistrar.AutoSize = true;
            this.lblVerificarContRegistrar.Location = new System.Drawing.Point(562, 402);
            this.lblVerificarContRegistrar.Name = "lblVerificarContRegistrar";
            this.lblVerificarContRegistrar.Size = new System.Drawing.Size(0, 13);
            this.lblVerificarContRegistrar.TabIndex = 99;
            // 
            // buttonVolverAtras
            // 
            this.buttonVolverAtras.Location = new System.Drawing.Point(419, 226);
            this.buttonVolverAtras.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVolverAtras.Name = "buttonVolverAtras";
            this.buttonVolverAtras.Size = new System.Drawing.Size(93, 33);
            this.buttonVolverAtras.TabIndex = 84;
            this.buttonVolverAtras.Text = "Volver Atrás";
            this.buttonVolverAtras.UseVisualStyleBackColor = true;
            this.buttonVolverAtras.Click += new System.EventHandler(this.buttonVolverAtras_Click);
            // 
            // btnConfirmarProducto
            // 
            this.btnConfirmarProducto.Location = new System.Drawing.Point(222, 176);
            this.btnConfirmarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarProducto.Name = "btnConfirmarProducto";
            this.btnConfirmarProducto.Size = new System.Drawing.Size(93, 33);
            this.btnConfirmarProducto.TabIndex = 83;
            this.btnConfirmarProducto.Text = "Confirmar";
            this.btnConfirmarProducto.UseVisualStyleBackColor = true;
            this.btnConfirmarProducto.Click += new System.EventHandler(this.btnConfirmarProducto_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(17, 49);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 82;
            this.lblCategoria.Text = "Categoría";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Datos del Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(377, 47);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(94, 20);
            this.txtPrecio.TabIndex = 79;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(277, 49);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 78;
            this.lblPrecio.Text = "Precio";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(377, 85);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(94, 20);
            this.txtStock.TabIndex = 73;
            this.txtStock.TextChanged += new System.EventHandler(this.txtCUIT_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(277, 88);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 72;
            this.lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(94, 20);
            this.txtNombre.TabIndex = 71;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 84);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "Nombre";
            // 
            // pbNombreError
            // 
            this.pbNombreError.Image = ((System.Drawing.Image)(resources.GetObject("pbNombreError.Image")));
            this.pbNombreError.Location = new System.Drawing.Point(222, 45);
            this.pbNombreError.Name = "pbNombreError";
            this.pbNombreError.Size = new System.Drawing.Size(19, 17);
            this.pbNombreError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombreError.TabIndex = 111;
            this.pbNombreError.TabStop = false;
            // 
            // pbApellidoError
            // 
            this.pbApellidoError.Image = ((System.Drawing.Image)(resources.GetObject("pbApellidoError.Image")));
            this.pbApellidoError.Location = new System.Drawing.Point(222, 84);
            this.pbApellidoError.Name = "pbApellidoError";
            this.pbApellidoError.Size = new System.Drawing.Size(19, 17);
            this.pbApellidoError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApellidoError.TabIndex = 112;
            this.pbApellidoError.TabStop = false;
            // 
            // pbDNIError
            // 
            this.pbDNIError.Image = ((System.Drawing.Image)(resources.GetObject("pbDNIError.Image")));
            this.pbDNIError.Location = new System.Drawing.Point(476, 88);
            this.pbDNIError.Name = "pbDNIError";
            this.pbDNIError.Size = new System.Drawing.Size(19, 17);
            this.pbDNIError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDNIError.TabIndex = 113;
            this.pbDNIError.TabStop = false;
            // 
            // pbEmailError
            // 
            this.pbEmailError.Image = ((System.Drawing.Image)(resources.GetObject("pbEmailError.Image")));
            this.pbEmailError.Location = new System.Drawing.Point(476, 50);
            this.pbEmailError.Name = "pbEmailError";
            this.pbEmailError.Size = new System.Drawing.Size(19, 17);
            this.pbEmailError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmailError.TabIndex = 115;
            this.pbEmailError.TabStop = false;
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.cbPerfilUsuario);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.pbDNI);
            this.Controls.Add(this.pbApellido);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.lblVerificarContRegistrar);
            this.Controls.Add(this.buttonVolverAtras);
            this.Controls.Add(this.btnConfirmarProducto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbNombreError);
            this.Controls.Add(this.pbApellidoError);
            this.Controls.Add(this.pbDNIError);
            this.Controls.Add(this.pbEmailError);
            this.Name = "FormNuevoProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormNuevoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApellidoError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDNIError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPerfilUsuario;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbDNI;
        private System.Windows.Forms.PictureBox pbApellido;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.Label lblVerificarContRegistrar;
        private System.Windows.Forms.Button buttonVolverAtras;
        private System.Windows.Forms.Button btnConfirmarProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbNombreError;
        private System.Windows.Forms.PictureBox pbApellidoError;
        private System.Windows.Forms.PictureBox pbDNIError;
        private System.Windows.Forms.PictureBox pbEmailError;
    }
}