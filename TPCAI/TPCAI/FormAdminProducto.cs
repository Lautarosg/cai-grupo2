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
    public partial class FormAdminProducto : Form
    {
        public string Usuario { get; set; }
        public int RolUsuario { get; set; }
        
        NegocioUsuario negocioUsuario = new NegocioUsuario();

        private NegocioProducto productoNegocio = new NegocioProducto();    
        public FormAdminProducto()
        {
            InitializeComponent();
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }



        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string usuario = this.Usuario;
                    var selectedRow = dataGridView1.SelectedRows[0];
                    Guid id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
                    string idUsuario = negocioUsuario.BuscarId(usuario); // Utilizar el idUsuario del usuario actual

                    await NegocioProducto.EliminarProducto(id, idUsuario);

                    MessageBox.Show("Producto eliminado con éxito.");

                    // Refrescar la lista de productos
                    var productos = await Task.Run(() => NegocioProducto.ListaProductos());
                    dataGridView1.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("Seleccione un producto de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormInicio formMenuVendedor = new FormInicio();
            //formMenuVendedor.ShowDialog();
            if (RolUsuario == 3)
            {
                FormMenuAdmin formAdministrador = new FormMenuAdmin();
                formAdministrador.Usuario = Usuario;
                formAdministrador.RolUsuario = RolUsuario;
                formAdministrador.ShowDialog();
            }
            else if (RolUsuario == 2)
            {
                FormMenuSupervisor formSupervisor = new FormMenuSupervisor();
                formSupervisor.Usuario = Usuario;
                formSupervisor.RolUsuario = RolUsuario;
                formSupervisor.ShowDialog();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string usuario = this.Usuario;
                    var selectedRow = dataGridView1.SelectedRows[0];
                    Guid id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
                    string idUsuario = negocioUsuario.BuscarId(usuario);
                    int precio = int.Parse(txtPrecio.Text);
                    int stock = int.Parse(txtStock.Text);

                    await NegocioProducto.ModificarProducto(id, idUsuario, precio, stock);

                    MessageBox.Show("Producto modificado con éxito.");
                }
                else
                {
                    MessageBox.Show("Seleccione un producto de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
                txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoDTO productoSeleccionado = (ProductoDTO)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            txtPrecio.Text = productoSeleccionado.Precio.ToString();
            txtStock.Text = productoSeleccionado.Stock.ToString();
        }



        private async void cargarProductos()
        {
            try
            {
                var productos = await Task.Run(() => NegocioProducto.ListaProductos());
                dataGridView1.DataSource = productos;
                dataGridView1.Columns["id"].Visible = false;
                //dataGridView1.Columns[""].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
