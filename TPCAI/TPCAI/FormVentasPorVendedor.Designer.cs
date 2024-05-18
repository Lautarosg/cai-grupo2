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
            this.listVentasPorVendedor.ItemHeight = 20;
            this.listVentasPorVendedor.Location = new System.Drawing.Point(103, 116);
            this.listVentasPorVendedor.Name = "listVentasPorVendedor";
            this.listVentasPorVendedor.Size = new System.Drawing.Size(617, 344);
            this.listVentasPorVendedor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de ventas por vendedor";
            // 
            // FormVentasPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVentasPorVendedor);
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