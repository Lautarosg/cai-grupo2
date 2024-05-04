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
    public partial class FormAdminProveedor : Form
    {
        negocioProveedor negocioProveedor = new negocioProveedor();
        public FormAdminProveedor()
        {
            InitializeComponent();
        }

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            FormNuevoProveedor formNuevoProveedor = new FormNuevoProveedor();
            formNuevoProveedor.ShowDialog();
            this.Hide();
            cargarProveedores();
        }

        private void dgvListaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargarProveedores()
        {
            List<ProveedorDTO> proveedores = negocioProveedor.listaProveedores();
            var bindingList = new BindingList<ProveedorDTO>(proveedores);
            var source = new BindingSource(bindingList, null);
            dgvListaProveedores.DataSource = source;
            dgvListaProveedores.Columns["id"].Visible = false;
            dgvListaProveedores.Columns["fechaBaja"].Visible = false;
            dgvListaProveedores.Columns["FechaAlta"].Visible = false;
            dgvListaProveedores.Columns["idUsuario"].Visible = false;
        }

        private void FormAdminProveedor_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void btnConfirmarBaja_Click(object sender, EventArgs e)
        {
            //Da de baja el proveedor en el swagger  segun el proveedor seleccionado
            ProveedorDTO proveedorSeleccionado = (ProveedorDTO)dgvListaProveedores.Rows[dgvListaProveedores.CurrentCell.RowIndex].DataBoundItem;
            Guid GuiProveedor = proveedorSeleccionado.Id;
            String IdProveedor = GuiProveedor.ToString();

            //consulta si esta seguro de eliminar usuario
            var result = MessageBox.Show("¿Está seguro que desea eliminar a " + proveedorSeleccionado.Apellido + ", " + proveedorSeleccionado.Nombre + "?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                negocioProveedor.BajaProveedor(IdProveedor);
                Console.WriteLine("Proveedor eliminado");
                cargarProveedores();
            }
        }

        private void dgvListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProveedorDTO proveedorSeleccionado = (ProveedorDTO)dgvListaProveedores.Rows[dgvListaProveedores.CurrentCell.RowIndex].DataBoundItem;
            txtSelProveedor.Text = proveedorSeleccionado.Apellido + ", " + proveedorSeleccionado.Nombre;
        }
    }
}
