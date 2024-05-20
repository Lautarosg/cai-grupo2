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
            this.cbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.pbPrecio = new System.Windows.Forms.PictureBox();
            this.pbStock = new System.Windows.Forms.PictureBox();
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
            this.pbStockError = new System.Windows.Forms.PictureBox();
            this.pbPrecioError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioError)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategoriaProducto
            // 
            this.cbCategoriaProducto.FormattingEnabled = true;
            this.cbCategoriaProducto.Items.AddRange(new object[] {
            "1 - Audio",
            "2 - Celulares",
            "3 - Electro Hogar",
            "4 - Informática",
            "5 - Smart TV"});
            this.cbCategoriaProducto.Location = new System.Drawing.Point(117, 45);
            this.cbCategoriaProducto.Name = "cbCategoriaProducto";
            this.cbCategoriaProducto.Size = new System.Drawing.Size(94, 21);
            this.cbCategoriaProducto.TabIndex = 121;
            this.cbCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaProducto_SelectedIndexChanged);
            // 
            // pbPrecio
            // 
            this.pbPrecio.Image = ((System.Drawing.Image)(resources.GetObject("pbPrecio.Image")));
            this.pbPrecio.Location = new System.Drawing.Point(476, 50);
            this.pbPrecio.Name = "pbPrecio";
            this.pbPrecio.Size = new System.Drawing.Size(19, 17);
            this.pbPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrecio.TabIndex = 108;
            this.pbPrecio.TabStop = false;
            // 
            // pbStock
            // 
            this.pbStock.Image = ((System.Drawing.Image)(resources.GetObject("pbStock.Image")));
            this.pbStock.Location = new System.Drawing.Point(476, 88);
            this.pbStock.Name = "pbStock";
            this.pbStock.Size = new System.Drawing.Size(19, 17);
            this.pbStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStock.TabIndex = 106;
            this.pbStock.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(222, 88);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(19, 17);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombre.TabIndex = 105;
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
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += txtPrecio_KeyPress;
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
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyPress += txtStock_KeyPress;
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
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
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
            this.pbNombreError.Location = new System.Drawing.Point(222, 88);
            this.pbNombreError.Name = "pbNombreError";
            this.pbNombreError.Size = new System.Drawing.Size(19, 17);
            this.pbNombreError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombreError.TabIndex = 111;
            this.pbNombreError.TabStop = false;
            // 
            // pbStockError
            // 
            this.pbStockError.Image = ((System.Drawing.Image)(resources.GetObject("pbStockError.Image")));
            this.pbStockError.Location = new System.Drawing.Point(476, 88);
            this.pbStockError.Name = "pbStockError";
            this.pbStockError.Size = new System.Drawing.Size(19, 17);
            this.pbStockError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStockError.TabIndex = 113;
            this.pbStockError.TabStop = false;
            // 
            // pbPrecioError
            // 
            this.pbPrecioError.Image = ((System.Drawing.Image)(resources.GetObject("pbPrecioError.Image")));
            this.pbPrecioError.Location = new System.Drawing.Point(476, 50);
            this.pbPrecioError.Name = "pbPrecioError";
            this.pbPrecioError.Size = new System.Drawing.Size(19, 17);
            this.pbPrecioError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrecioError.TabIndex = 115;
            this.pbPrecioError.TabStop = false;
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.cbCategoriaProducto);
            this.Controls.Add(this.pbPrecio);
            this.Controls.Add(this.pbStock);
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
            this.Controls.Add(this.pbStockError);
            this.Controls.Add(this.pbPrecioError);
            this.Name = "FormNuevoProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormNuevoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecioError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoriaProducto;
        private System.Windows.Forms.PictureBox pbPrecio;
        private System.Windows.Forms.PictureBox pbStock;
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
        private System.Windows.Forms.PictureBox pbStockError;
        private System.Windows.Forms.PictureBox pbPrecioError;
    }
}