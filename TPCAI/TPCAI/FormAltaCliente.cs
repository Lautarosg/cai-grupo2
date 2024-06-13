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
    public partial class FormAltaCliente : Form
    {
        public string Usuario {  get; set; }
        public int RolUsuario { get; set; }

        NegocioUsuario negocioUsuario = new NegocioUsuario();

        private NegocioCliente clienteNegocio = new NegocioCliente();
        public FormAltaCliente()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }



        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

       

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolectar y validar datos del formulario
                string usuario = this.Usuario;
                string idUsuario = negocioUsuario.BuscarId(usuario);
                string nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                string apellido = ValidadorUsuario.ValidarApellido(txtApellido.Text);
                int dni = ValidadorUsuario.ValidarDNI(txtDni.Text);
                string direccion = ValidadorUsuario.ValidarDireccion(txtDireccion.Text);
                string telefono = ValidadorUsuario.ValidarTelefono(txtTelefono.Text);
                string email = ValidadorUsuario.ValidarEmail(txtMail.Text);
                DateTime fechaNacimiento = ValidadorUsuario.ValidarFechaNac(dtpFechaNacimiento.Value);
                string host = "2";

                // Crear y agregar cliente
                clienteNegocio.agregarCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);

                // Mensaje de éxito
                MessageBox.Show("Cliente agregado con éxito.");

                // Recargar clientes
                cargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (RolUsuario == 3)
            {
                FormMenuAdmin formAdministrador = new FormMenuAdmin();
                formAdministrador.Usuario = Usuario;
                formAdministrador.RolUsuario = RolUsuario;
                formAdministrador.ShowDialog();
            }
            else if (RolUsuario == 1)
            {
                FormMenuVendedor formSupervisor = new FormMenuVendedor();
                formSupervisor.Usuario = Usuario;
                formSupervisor.RolUsuario = RolUsuario;
                formSupervisor.ShowDialog();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    ClienteDTO clienteSeleccionado = (ClienteDTO)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;

                    // Recolectar y validar datos del formulario
                    Guid idCliente = clienteSeleccionado.Id;
                    string direccion = ValidadorUsuario.ValidarDireccion(txtDireccion.Text);
                    string telefono = ValidadorUsuario.ValidarTelefono(txtTelefono.Text);
                    string email = ValidadorUsuario.ValidarEmail(txtMail.Text);

                    // Modificar cliente
                    clienteNegocio.modificarCliente(idCliente, direccion, telefono, email);

                    // Mensaje de éxito
                    MessageBox.Show("Cliente modificado con éxito.");

                    // Recargar clientes
                    cargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtener el cliente seleccionado
                ClienteDTO clienteSeleccionado = (ClienteDTO)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                if (clienteSeleccionado != null)
                {
                    // Rellenar los campos del formulario con la información del cliente seleccionado
                    txtNombre.Text = clienteSeleccionado.Nombre;
                    txtApellido.Text = clienteSeleccionado.Apellido;
                    txtDni.Text = clienteSeleccionado.Dni.ToString();
                    txtDireccion.Text = clienteSeleccionado.Direccion;
                    txtTelefono.Text = clienteSeleccionado.Telefono;
                    txtMail.Text = clienteSeleccionado.Email;
                    dtpFechaNacimiento.Value = clienteSeleccionado.FechaNacimiento;
                }
            }
        }



        /*private async void cargaClientes()
        {
            try
            {
                var productos = await Task.Run(() => clienteNegocio.listarClientes());
                dataGridView1.DataSource = productos;
                dataGridView1.Columns["id"].Visible = false;
                //dataGridView1.Columns[""].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }*/
        private void cargarClientes()
        {
            List<ClienteDTO> clientes = clienteNegocio.listarClientes();

            if (clientes == null || clientes.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes.");
                return;
            }

            var bindingList = new BindingList<ClienteDTO>(clientes);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["FechaBaja"].Visible = false;
        }
    }
}
