namespace TPCAI
{
    partial class FormAdminProveedor
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
            this.btnAltaProveedor = new System.Windows.Forms.Button();
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.lblBuscarProveedor = new System.Windows.Forms.Label();
            this.btnConfirmarBaja = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtSelProveedor = new System.Windows.Forms.TextBox();
            this.lblSelProveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.Location = new System.Drawing.Point(530, 27);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(135, 42);
            this.btnAltaProveedor.TabIndex = 23;
            this.btnAltaProveedor.Text = "Agregar Usuario";
            this.btnAltaProveedor.UseVisualStyleBackColor = true;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnAltaProveedor_Click);
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Location = new System.Drawing.Point(69, 102);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.Size = new System.Drawing.Size(516, 187);
            this.dgvListaProveedores.TabIndex = 22;
            this.dgvListaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellClick);
            this.dgvListaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellContentClick);
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(15, 60);
            this.txtBuscarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(157, 20);
            this.txtBuscarProveedor.TabIndex = 21;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(191, 54);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(70, 30);
            this.btnBuscarProveedor.TabIndex = 20;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // lblBuscarProveedor
            // 
            this.lblBuscarProveedor.AutoSize = true;
            this.lblBuscarProveedor.Location = new System.Drawing.Point(12, 36);
            this.lblBuscarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarProveedor.Name = "lblBuscarProveedor";
            this.lblBuscarProveedor.Size = new System.Drawing.Size(98, 13);
            this.lblBuscarProveedor.TabIndex = 19;
            this.lblBuscarProveedor.Text = "Buscar por Nombre";
            // 
            // btnConfirmarBaja
            // 
            this.btnConfirmarBaja.Location = new System.Drawing.Point(203, 320);
            this.btnConfirmarBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarBaja.Name = "btnConfirmarBaja";
            this.btnConfirmarBaja.Size = new System.Drawing.Size(107, 35);
            this.btnConfirmarBaja.TabIndex = 18;
            this.btnConfirmarBaja.Text = "Eliminar";
            this.btnConfirmarBaja.UseVisualStyleBackColor = true;
            this.btnConfirmarBaja.Click += new System.EventHandler(this.btnConfirmarBaja_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(558, 327);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 35);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver Atrás";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtSelProveedor
            // 
            this.txtSelProveedor.Location = new System.Drawing.Point(15, 335);
            this.txtSelProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelProveedor.Name = "txtSelProveedor";
            this.txtSelProveedor.Size = new System.Drawing.Size(157, 20);
            this.txtSelProveedor.TabIndex = 16;
            // 
            // lblSelProveedor
            // 
            this.lblSelProveedor.AutoSize = true;
            this.lblSelProveedor.Location = new System.Drawing.Point(12, 311);
            this.lblSelProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelProveedor.Name = "lblSelProveedor";
            this.lblSelProveedor.Size = new System.Drawing.Size(112, 13);
            this.lblSelProveedor.TabIndex = 15;
            this.lblSelProveedor.Text = "Usuario seleccionado:";
            // 
            // FormAdminProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 372);
            this.Controls.Add(this.btnAltaProveedor);
            this.Controls.Add(this.dgvListaProveedores);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.lblBuscarProveedor);
            this.Controls.Add(this.btnConfirmarBaja);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtSelProveedor);
            this.Controls.Add(this.lblSelProveedor);
            this.Name = "FormAdminProveedor";
            this.Text = "Administrar Proveedores";
            this.Load += new System.EventHandler(this.FormAdminProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProveedor;
        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.Button btnConfirmarBaja;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtSelProveedor;
        private System.Windows.Forms.Label lblSelProveedor;
    }
}