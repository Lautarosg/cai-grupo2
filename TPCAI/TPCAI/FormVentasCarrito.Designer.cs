namespace TPCAI
{
    partial class FormVentasCarrito
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProvedores;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelProvedores;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonRemoveFromCart;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxProvedores = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelProvedores = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.buttonViewCart = new System.Windows.Forms.Button();
            this.buttonExecutePurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProvedores
            // 
            this.comboBoxProvedores.FormattingEnabled = true;
            this.comboBoxProvedores.Location = new System.Drawing.Point(150, 50);
            this.comboBoxProvedores.Name = "comboBoxProvedores";
            this.comboBoxProvedores.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvedores.TabIndex = 0;
            this.comboBoxProvedores.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvedores_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(150, 100);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(150, 150);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(200, 23);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelProvedores
            // 
            this.labelProvedores.AutoSize = true;
            this.labelProvedores.Location = new System.Drawing.Point(50, 53);
            this.labelProvedores.Name = "labelProvedores";
            this.labelProvedores.Size = new System.Drawing.Size(53, 13);
            this.labelProvedores.TabIndex = 3;
            this.labelProvedores.Text = "Producto:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(50, 102);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(150, 216);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(200, 23);
            this.buttonRemoveFromCart.TabIndex = 5;
            this.buttonRemoveFromCart.Text = "remover del carrito";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = true;
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.buttonRemoveFromCart_Click);
            // 
            // buttonViewCart
            // 
            this.buttonViewCart.Location = new System.Drawing.Point(150, 272);
            this.buttonViewCart.Name = "buttonViewCart";
            this.buttonViewCart.Size = new System.Drawing.Size(200, 23);
            this.buttonViewCart.TabIndex = 6;
            this.buttonViewCart.Text = "ver carro";
            this.buttonViewCart.UseVisualStyleBackColor = true;
            this.buttonViewCart.Click += new System.EventHandler(this.buttonViewCart_Click);
            // 
            // buttonExecutePurchase
            // 
            this.buttonExecutePurchase.Location = new System.Drawing.Point(150, 325);
            this.buttonExecutePurchase.Name = "buttonExecutePurchase";
            this.buttonExecutePurchase.Size = new System.Drawing.Size(200, 23);
            this.buttonExecutePurchase.TabIndex = 7;
            this.buttonExecutePurchase.Text = "comprar";
            this.buttonExecutePurchase.UseVisualStyleBackColor = true;
            this.buttonExecutePurchase.Click += new System.EventHandler(this.buttonExecutePurchase_Click);
            // 
            // FormVentasCarrito
            // 
            this.ClientSize = new System.Drawing.Size(406, 379);
            this.Controls.Add(this.buttonExecutePurchase);
            this.Controls.Add(this.buttonViewCart);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.labelProvedores);
            this.Controls.Add(this.comboBoxProvedores);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.buttonAddToCart);
            this.Name = "FormVentasCarrito";
            this.Text = "Carrito de compras";
            this.Load += new System.EventHandler(this.ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonViewCart;
        private System.Windows.Forms.Button buttonExecutePurchase;


    }
}
