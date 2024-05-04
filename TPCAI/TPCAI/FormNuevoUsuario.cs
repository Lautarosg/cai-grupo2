using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Datos.Controller.UsuarioPostRequest;
using Negocio;
using Datos.Controller;

namespace TPCAI
{
    public partial class FormNuevoUsuario : Form
    {
        const int minCarUsuario = 8;
        const int maxCarUsuario = 15;
        const int minCarContraseña = 8;

        ValidadorUtil validadorUtil = new ValidadorUtil();

        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        //son las validaciones del ingreso de un nuevo usuario en el login
        private void buttonConfirmarNuevoUser_Click(object sender, EventArgs e)
        {
            String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
            int host = ValidadorUsuario.ValidarPerfil(cbPerfilUsuario.Text);
            string nombre = ValidadorUsuario.ValidarNombre(textBoxNombre.Text);
            string apellido = ValidadorUsuario.ValidarNombre(textBoxApellido.Text);
            string dni = textBoxDNI.Text;
            string direccion = ValidadorUsuario.ValidarDireccion(textBoxDireccion.Text);
            string email = ValidadorUsuario.ValidarEmail(textBoxEmail.Text);
            DateTime fechaNac = dtpfechaNacimiento.Value;
            string telefono = ValidadorUsuario.ValidarTelefono(textBoxTelefono.Text);

            /*
            // Validar que no haya errores en las validaciones
            if (nombre.Contains("Error") || apellido.Contains("Error") || dni == -1 || direccion.Contains("Error") || email.Contains("Error") || telefono.Contains("Error"))
            {
                // Mostrar mensaje de error con las validaciones fallidas
                MessageBox.Show("Se encontraron errores en los datos ingresados. Por favor, verifique y corrija los campos indicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            //VALIDACION DE USER Y CONTRASEÑA
            string contraseña = txtContraseñaRegistrar.Text;
            string verificar = txtVerificarRegistrar.Text;
            string usuarioNuevo = txtUsuarioRegistrar.Text;
            string contraseñaNuevo = txtContraseñaRegistrar.Text;
            bool check = false;

         
            if (validadorUtil.validarIguales(contraseña, verificar))
            {
                lblVerificarContRegistrar.Text = "La contraseña debe ser la misma!";
                check = false;
            }
            if (validadorUtil.validarVacio(usuarioNuevo))
            {
                lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
                check = false;

            }
            if (validadorUtil.validarVacio(contraseñaNuevo))
            {
                lblErrorContraseñaRegistrar.Text = "Debe ingresar una contraseña";
                check = false;
            }


            //VALIDACION DE DATOS DEL USER
            //Uso un contador de errores para mostrar en pantalla en caso de que haya
            string errores = "";

            errores += ValidadorUsuario.ValidarNombre(nombre);
            errores += ValidadorUsuario.ValidarApellido(apellido);
            errores += ValidadorUsuario.ValidarDNI(dni);
            errores += ValidadorUsuario.ValidarDireccion(direccion);
            errores += ValidadorUsuario.ValidarEmail(email);
            errores += ValidadorUsuario.ValidarTelefono(telefono);
            errores += ValidadorUsuario.ValidarFechaNac(fechaNac);

            if (errores.Contains("error") || errores.Contains("-1") || check == true)
            {
                MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //creo el nuevo usuario 
                UsuarioPostRequest SwaggerUser = new UsuarioPostRequest(idAdmin,nombre,apellido,direccion,telefono,email, fechaNac, usuarioNuevo,host, Convert.ToInt32(dni));
                NegocioUsuario negocioUsuario = new NegocioUsuario();
                negocioUsuario.AgregarUsuario(SwaggerUser);

                var result = MessageBox.Show("Usuario Creado Exitosamente.\n Porfavor, haga click en OK para volver al menú", "Confirmación", MessageBoxButtons.OK);

                if (DialogResult == DialogResult.OK) //si el user hace click en OK, vuelve al menú 
                {
                    this.Hide();
                    FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                    formMenuAdmin.ShowDialog();

                }


            }
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminUsuario formMenuUsuario = new FormAdminUsuario();
            formMenuUsuario.ShowDialog();
        }

        private void txtUsuarioRegistrar_TextChanged(object sender, EventArgs e)
        {
            string usuarioNuevo = txtUsuarioRegistrar.Text;
            string nombreUsuario = textBoxNombre.Text;
            string apellidoUsuario = textBoxApellido.Text;
           
            if (validadorUtil.validarVacio(usuarioNuevo))
            {
                lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
            }
            if (validadorUtil.validarVacio(usuarioNuevo) || validadorUtil.validarMin(usuarioNuevo, minCarUsuario))
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (validadorUtil.validarMax(usuarioNuevo, maxCarUsuario))
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (usuarioNuevo.Contains(nombreUsuario))
            {
                lblNomUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblNomUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (usuarioNuevo.Contains(apellidoUsuario))
            {
                lblApeUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblApeUsuarioRegistrar.ForeColor = Color.Green;
            }
            lblErrorUsuarioRegistrar.Text = "";
        }

        private void txtContraseñaVerificar_TextChanged(object sender, EventArgs e)
        {
            lblVerificarContRegistrar.Text = "";
        }

        private void txtContraseñaRegistrar_TextChanged(object sender, EventArgs e)
        {
            string contraseñaNuevo = txtContraseñaRegistrar.Text;
            

            if (validadorUtil.validarVacio(contraseñaNuevo))
            {
                lblErrorContraseñaRegistrar.Text = "Debe ingresar una contraseña";
            }
            if (validadorUtil.validarMin(contraseñaNuevo, minCarContraseña))
            {
                lblMinContraseñaRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMinContraseñaRegistrar.ForeColor = Color.Green;
            }
            if (validadorUtil.validarMay(contraseñaNuevo))
            {
                lblMayContraseñaRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMayContraseñaRegistrar.ForeColor = Color.Green;
            }
            lblErrorContraseñaRegistrar.Text = "";
        }


        private void pbMostrarRegistrar_Click(object sender, EventArgs e)
        {
            pbOcultarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '\0';
            txtVerificarRegistrar.PasswordChar = '\0';
        }

        private void pbOcultarRegistrar_Click(object sender, EventArgs e)
        {
            pbMostrarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '*';
            txtVerificarRegistrar.PasswordChar = '*';
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxNombre.Text.ToLower(), ValidadorUsuario.ValidarNombre(textBoxNombre.Text), pbNombreError, pbNombre);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxApellido.Text.ToLower(), ValidadorUsuario.ValidarApellido(textBoxApellido.Text), pbApellidoError, pbApellido);
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxDNI.Text, ValidadorUsuario.ValidarDNI(textBoxDNI.Text).ToString(), pbDNIError, pbDNI);
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxDireccion.Text, ValidadorUsuario.ValidarDireccion(textBoxDireccion.Text), pbDireccionError, pbDireccion);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxEmail.Text, ValidadorUsuario.ValidarEmail(textBoxEmail.Text), pbEmailError, pbEmail);
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(textBoxTelefono.Text, ValidadorUsuario.ValidarTelefono(textBoxTelefono.Text), pbTelefonoError, pbTelefono);
        }

        private void dtpfechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

            validadorUtil.ValidarInfoButton(dtpfechaNacimiento.Value.ToString(), ValidadorUsuario.ValidarFechaNac(dtpfechaNacimiento.Value).ToString(), pbNacimientoError, pbNacimiento);
        }

        private void lblUsuarioRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void pbNomUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pbNomUsuarioError_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruccionesRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxUsuarioRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void lblNomUsuarioRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void pbNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
