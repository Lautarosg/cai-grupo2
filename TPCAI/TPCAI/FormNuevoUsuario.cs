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
            string id = Guid.NewGuid().ToString();
            int host = ValidadorUsuario.ValidarPerfil(textBoxPerfil.Text);
            string nombre = ValidadorUsuario.ValidarNombre(textBoxNombre.Text);
            string apellido = ValidadorUsuario.ValidarNombre(textBoxApellido.Text);
            string dni = textBoxDNI.Text;
            string direccion = ValidadorUsuario.ValidarDireccion(textBoxDireccion.Text);
            string email = ValidadorUsuario.ValidarEmail(textBoxEmail.Text);
            string FechaNacimiento = textBoxFechaNac.Text;
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
            ValidadorUtil validador = new ValidadorUtil();
            string contraseña = txtContraseñaRegistrar.Text;
            string verificar = txtVerificarRegistrar.Text;
            string usuarioNuevo = txtUsuarioRegistrar.Text;
            string contraseñaNuevo = txtContraseñaRegistrar.Text;
            bool check = false;

         
            if (validador.validarIguales(contraseña, verificar))
            {
                lblVerificarContRegistrar.Text = "La contraseña debe ser la misma!";
                check = false;
            }
            if (validador.validarVacio(usuarioNuevo))
            {
                lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
                check = false;

            }
            if (validador.validarVacio(contraseñaNuevo))
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
            errores += ValidadorUsuario.ValidarFechaNac(FechaNacimiento);

            if (errores.Contains("error") || errores.Contains("-1") || check == true)
            {
                MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //creo el nuevo usuario en el POST:/api/Usuario/AgregarUsuario
                UserData SwaggerUser = new UserData();
                SwaggerUser.IdUsuario = id;
                SwaggerUser.Host = host;
                SwaggerUser.Nombre = nombre;
                SwaggerUser.Apellido = apellido;
                SwaggerUser.Dni = Convert.ToInt32(dni);
                SwaggerUser.Direccion = direccion;
                SwaggerUser.Telefono = telefono;
                SwaggerUser.Email = email;
                SwaggerUser.FechaNacimiento = FechaNacimiento;
                SwaggerUser.NombreUsuario = usuarioNuevo;
                SwaggerUser.Contrasenia = contraseña;


                NegocioUsuario.AgregarUsuario(SwaggerUser);

                var result = MessageBox.Show("Usuario Creado Exitosamente.\n Porfavor, haga click en OK para volver a inicio", "Confirmación", MessageBoxButtons.OK);

                if (DialogResult == DialogResult.OK) //si el user hace click en OK, vuelve al inicio
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
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();
        }

        private void txtUsuarioRegistrar_TextChanged(object sender, EventArgs e)
        {
            string usuarioNuevo = txtUsuarioRegistrar.Text;

            ValidadorUtil validador = new ValidadorUtil();

            if (validador.validarVacio(usuarioNuevo))
            {
                lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
            }
            if (validador.validarVacio(usuarioNuevo) || validador.validarMin(usuarioNuevo, minCarUsuario))
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMinUsuarioRegistrar.ForeColor = Color.Green;
            }
            if (validador.validarMax(usuarioNuevo, maxCarUsuario))
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMaxUsuarioRegistrar.ForeColor = Color.Green;
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
            ValidadorUtil validador = new ValidadorUtil();

            if (validador.validarVacio(contraseñaNuevo))
            {
                lblErrorContraseñaRegistrar.Text = "Debe ingresar una contraseña";
            }
            if (validador.validarMin(contraseñaNuevo, minCarContraseña))
            {
                lblMinContraseñaRegistrar.ForeColor = Color.Red;
            }
            else
            {
                lblMinContraseñaRegistrar.ForeColor = Color.Green;
            }
            if (validador.validarMay(contraseñaNuevo))
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

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
