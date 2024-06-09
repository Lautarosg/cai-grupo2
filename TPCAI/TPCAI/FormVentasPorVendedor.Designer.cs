namespace TPCAI
{
    partial class FormVentasPorVendedor
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
            this.listVentasPorVendedor = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listVentasPorVendedor
            // 
            this.listVentasPorVendedor.FormattingEnabled = true;
            this.listVentasPorVendedor.Location = new System.Drawing.Point(69, 75);
            this.listVentasPorVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listVentasPorVendedor.Name = "listVentasPorVendedor";
            this.listVentasPorVendedor.Size = new System.Drawing.Size(413, 225);
            this.listVentasPorVendedor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de ventas por vendedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormVentasPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVentasPorVendedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVentasPorVendedor";
            this.Text = "Ventas Por Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listVentasPorVendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}