using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class FormAdminUsuario : Form
    {
        NegocioUsuario negocioUsuario = new NegocioUsuario();

        public FormAdminUsuario()
        {
            InitializeComponent();
        }


        //boton de volver atras
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Da de baja el usuario en el swagger "Usuario/BajaUsuario" segun el ID ingresado
            UsuarioDTO usuarioSeleccionado = (UsuarioDTO)dgvListaUsuarios.Rows[dgvListaUsuarios.CurrentCell.RowIndex].DataBoundItem;
            Guid GuidUsuario = usuarioSeleccionado.Id;
            String IdUsuario = GuidUsuario.ToString();
            
            //consulta si esta seguro de eliminar usuario
            var result = MessageBox.Show("¿Está seguro que desea eliminar a " + usuarioSeleccionado.Apellido + ", " + usuarioSeleccionado.Nombre + "?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                negocioUsuario.BajaUsuario(IdUsuario);
                Console.WriteLine("Usuario eliminado");
                cargarUsuarios();
            }
        }

        private void buttonListarUsuariosActivos_Click(object sender, EventArgs e)
        {
            string idUsuario = txtBuscarUser.Text;

            negocioUsuario.BuscarUsuarioporID(idUsuario);
        }

        private void txtBuscarUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMenuUsuario_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        private void cargarUsuarios()
        {
            List<UsuarioDTO> usuarios = negocioUsuario.listarUsuarios();
            var bindingList = new BindingList<UsuarioDTO>(usuarios);
            var source = new BindingSource(bindingList, null);
            dgvListaUsuarios.DataSource = source;
            dgvListaUsuarios.Columns["id"].Visible = false;
            dgvListaUsuarios.Columns["fechaBaja"].Visible = false;
            dgvListaUsuarios.Columns["direccion"].Visible = false;
            dgvListaUsuarios.Columns["telefono"].Visible = false;
            dgvListaUsuarios.Columns["Email"].Visible = false;
            dgvListaUsuarios.Columns["Contraseña"].Visible = false;
            dgvListaUsuarios.Columns["FechaNacimiento"].Visible = false;
            dgvListaUsuarios.Columns["FechaCreacion"].Visible = false;
            dgvListaUsuarios.Columns["FechaContraseña"].Visible = false;
            dgvListaUsuarios.Columns["Estado"].Visible = false;
            dgvListaUsuarios.Columns["Rol"].Visible = false;
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioDTO usuarioSeleccionado = (UsuarioDTO)dgvListaUsuarios.Rows[dgvListaUsuarios.CurrentCell.RowIndex].DataBoundItem;
            txtUsuarioSeleccionado.Text = usuarioSeleccionado.Apellido + ", " +usuarioSeleccionado.Nombre;

        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario formNuevoUsuario = new FormNuevoUsuario();
            formNuevoUsuario.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsuarioSeleccionado_TextChanged(object sender, EventArgs e)
        {

        }

        /* Funcionalidad de buscar segun nombre -- No funciona todavia
        private void FiltrarDatosDatagridview(String txtBuscar)
        {
            (dgvListaUsuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre = {0}", txtBuscar);
        }

        private void txtBuscarUser_TextChanged_1(object sender, EventArgs e)
        {
            string txtBuscar = txtBuscarUser.Text;
            FiltrarDatosDatagridview(txtBuscar);
        }
        */

    }
}
