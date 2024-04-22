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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija que opción desea realizar:";
            // 
            // buttonRegistrarVta
            // 
            this.buttonRegistrarVta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegistrarVta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarVta.Font = new System.Drawing.Font("Sitka Subheading", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVta.Location = new System.Drawing.Point(163, 189);
            this.buttonRegistrarVta.Name = "buttonRegistrarVta";
            this.buttonRegistrarVta.Size = new System.Drawing.Size(177, 77);
            this.buttonRegistrarVta.TabIndex = 2;
            this.buttonRegistrarVta.Text = "Registrar Venta";
            this.buttonRegistrarVta.UseVisualStyleBackColor = true;
            // 
            // buttonVtaVendedor
            // 
            this.buttonVtaVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVtaVendedor.Font = new System.Drawing.Font("Sitka Subheading", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVtaVendedor.Location = new System.Drawing.Point(418, 189);
            this.buttonVtaVendedor.Name = "buttonVtaVendedor";
            this.buttonVtaVendedor.Size = new System.Drawing.Size(180, 77);
            this.buttonVtaVendedor.TabIndex = 3;
            this.buttonVtaVendedor.Text = "Ventas por Vendedor";
            this.buttonVtaVendedor.UseVisualStyleBackColor = true;
            // 
            // FormMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVtaVendedor);
            this.Controls.Add(this.buttonRegistrarVta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuVendedor";
            this.Text = "Menú Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrarVta;
        private System.Windows.Forms.Button buttonVtaVendedor;
    }
}