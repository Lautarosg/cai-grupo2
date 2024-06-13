using Negocio;
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
    public partial class FormMenuSupervisor : Form
    {
        public string Usuario { get; set; }
        public int RolUsuario { get; set; }

        NegocioProducto negocioProducto = new NegocioProducto();
        public FormMenuSupervisor()
        {
            InitializeComponent();
        }

        private void FormMenuSupervisor_Load(object sender, EventArgs e)
        {
            textBoxProdCritico.Text = (negocioProducto.ContarStockCritico()).ToString();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            string usuario = this.Usuario;
            FormCambiarContraseña formContraseña = new FormCambiarContraseña();
            formContraseña.Usuario = usuario;
            formContraseña.RolUsuario = RolUsuario;
            formContraseña.ShowDialog();
        }

        
        private void buttonAltaProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            string usuario = this.Usuario;
            FormNuevoProducto formProducto = new FormNuevoProducto();
            formProducto.Usuario = usuario;
            formProducto.RolUsuario = RolUsuario;
            formProducto.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();    
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

        private void buttonAdminProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            string usuario = this.Usuario;
            FormAdminProducto formProducto = new FormAdminProducto();
            formProducto.Usuario = usuario;
            formProducto.RolUsuario = RolUsuario;
            formProducto.ShowDialog();
        }

        private void textBoxProdCritico_Click(object sender, EventArgs e)
        {

        }
    }
}
