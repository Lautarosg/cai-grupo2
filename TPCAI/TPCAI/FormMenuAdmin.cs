using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormMenuAdmin : Form
    {
        public string Usuario { get; set; }
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();

        }

        private void buttonBajaSup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminUsuario formMenuUsuario = new FormAdminUsuario();
            formMenuUsuario.ShowDialog();
        }

        private void btnAdminProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminProveedor formProveedor = new FormAdminProveedor();
            formProveedor.ShowDialog();
        }

        private void buttonAltaProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.ShowDialog();
        }

        private void buttonStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVerStockCritico formVerStockCritico = new FormVerStockCritico();
            formVerStockCritico.ShowDialog();
        }

        private void buttonVtaProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVentasPorVendedor formVentasPorVendedor = new FormVentasPorVendedor();
            formVentasPorVendedor.ShowDialog();
        }

        private void buttonMasVendido_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductoMasVendidoCategoria formProductoMasVendidoCategoria = new FormProductoMasVendidoCategoria();
            formProductoMasVendidoCategoria.ShowDialog();
        }

        private void buttonAltaVend_Click(object sender, EventArgs e)
        {

        }

        private void buttonModProd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = this.Usuario;
            FormCambiarContraseña formContraseña = new FormCambiarContraseña();
            formContraseña.Usuario = usuario;
            formContraseña.ShowDialog();
        }
    }
}
