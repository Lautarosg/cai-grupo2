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
        }



        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

       

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = this.Usuario;
                string idUsuario = negocioUsuario.BuscarId(usuario);
                string nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                string apellido = ValidadorUsuario.ValidarApellido(txtApellido.Text);
                int dni =  ValidadorUsuario.ValidarDNI(txtDni.Text);
                string direccion = ValidadorUsuario.ValidarDireccion(txtDireccion.Text);
                string telefono = ValidadorUsuario.ValidarTelefono(txtTelefono.Text);
                string email = ValidadorUsuario.ValidarEmail (txtMail.Text);
                DateTime fechaNacimiento = ValidadorUsuario.ValidarFechaNac(dtpFechaNacimiento.Value);
                string host = "2";


                clienteNegocio.agregarCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);

                

                MessageBox.Show("Cliente agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
            cargarClientes();
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
            ClienteDTO clienteSeleccionado = (ClienteDTO)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;

            Guid idCliente = clienteSeleccionado.Id;
            String direccion = ValidadorUsuario.ValidarDireccion(txtDireccion.Text);
            String telefono = ValidadorUsuario.ValidarTelefono(txtTelefono.Text);
            String email = ValidadorUsuario.ValidarEmail(txtMail.Text);

            clienteNegocio.modificarCliente(idCliente, direccion, telefono, email);

            cargarClientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDTO clienteSeleccionado = (ClienteDTO)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = clienteSeleccionado.Nombre;
            txtApellido.Text = clienteSeleccionado.Apellido;
            txtDni.Text = clienteSeleccionado.Dni.ToString();
            txtDireccion.Text = clienteSeleccionado.Direccion;
            txtTelefono.Text = clienteSeleccionado.Telefono;
            txtMail.Text = clienteSeleccionado.Email;
            dtpFechaNacimiento.Value = clienteSeleccionado.FechaNacimiento;
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

            var bindingList = new BindingList<ClienteDTO>(clientes);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["fechaBaja"].Visible = false;
        }
    }
}
