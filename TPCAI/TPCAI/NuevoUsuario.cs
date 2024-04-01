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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        //son las validaciones del ingreso de un nuevo usuario en el login
        private void buttonConfirmarNuevoUser_Click(object sender, EventArgs e)
        {

            string nombre = ValidadorUsuario.ValidarNombre(textBoxNombre.Text);
            string apellido = ValidadorUsuario.ValidarNombre(textBoxApellido.Text);
            string dni = textBoxDNI.Text;
            string direccion = textBoxDireccion.Text;
            string email = textBoxEmail.Text;
            string fechanacimiento = textBoxFechaNac.Text;
            string telefono = textBoxTelefono.Text;

            //Uso un contador de errores para mostrar en pantalla en caso de que haya
            string errores = "";

            errores += ValidadorUsuario.ValidarNombre(nombre);
            errores += ValidadorUsuario.ValidarApellido(apellido);
            errores += ValidadorUsuario.ValidarDNI(dni);
            errores += ValidadorUsuario.ValidarDireccion(direccion);
            errores += ValidadorUsuario.ValidarEmail(email);
            errores += ValidadorUsuario.ValidarTelefono(telefono);
            errores += ValidadorUsuario.ValidarFechaNac(fechanacimiento);

            if (errores.Contains("error") || errores.Contains("-1"))
            {
                MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                
                MessageBox.Show("Se creó el usuario exitosamente.");


            }
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrar formRegistrar = new FormRegistrar();
            formRegistrar.ShowDialog();
        }
    }
}
