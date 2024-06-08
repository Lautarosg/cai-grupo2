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
        public FormAltaCliente()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Guid idUsuario = Guid.NewGuid();
                string nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                string apellido = ValidadorUsuario.ValidarApellido(txtApellido.Text);
                int dni =  ValidadorUsuario.ValidarDNI(txtDni.Text);
                string direccion = ValidadorUsuario.ValidarDireccion(txtDireccion.Text);
                string telefono = ValidadorUsuario.ValidarTelefono(txtTelefono.Text);
                string email = ValidadorUsuario.ValidarEmail (txtMail.Text);
                DateTime fechaNacimiento = ValidadorUsuario.ValidarFechaNac(dtpFechaNacimiento.Value);
                string host = "2";
                

                ClienteDTO nuevoCliente = new ClienteDTO(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);

                await NegocioCliente.AgregarCliente(nuevoCliente);

                MessageBox.Show("Cliente agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
