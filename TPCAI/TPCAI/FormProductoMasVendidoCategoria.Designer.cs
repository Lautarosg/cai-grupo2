namespace TPCAI
{
    partial class FormProductoMasVendidoCategoria
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
            this.listProdMasVendidoCateg = new System.Windows.Forms.ListBox();
            this.buttonVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProdMasVendidoCateg
            // 
            this.listProdMasVendidoCateg.FormattingEnabled = true;
            this.listProdMasVendidoCateg.ItemHeight = 20;
            this.listProdMasVendidoCateg.Location = new System.Drawing.Point(77, 54);
            this.listProdMasVendidoCateg.Name = "listProdMasVendidoCateg";
            this.listProdMasVendidoCateg.Size = new System.Drawing.Size(605, 324);
            this.listProdMasVendidoCateg.TabIndex = 0;
            // 
            // buttonVolverAtras
            // 
            this.buttonVolverAtras.Location = new System.Drawing.Point(673, 426);
            this.buttonVolverAtras.Name = "buttonVolverAtras";
            this.buttonVolverAtras.Size = new System.Drawing.Size(145, 58);
            this.buttonVolverAtras.TabIndex = 1;
            this.buttonVolverAtras.Text = "Volver Atrás";
            this.buttonVolverAtras.UseVisualStyleBackColor = true;
            this.buttonVolverAtras.Click += new System.EventHandler(this.buttonVolverAtras_Click);
            // 
            // FormProductoMasVendidoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 512);
            this.Controls.Add(this.buttonVolverAtras);
            this.Controls.Add(this.listProdMasVendidoCateg);
            this.Name = "FormProductoMasVendidoCategoria";
            this.Text = "Producto Mas Vendido Por Categoria";
            this.Load += new System.EventHandler(this.FormProductoMasVendidoCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProdMasVendidoCateg;
        private System.Windows.Forms.Button buttonVolverAtras;
    }
}