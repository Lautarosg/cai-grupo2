using Negocio;
using Newtonsoft.Json.Linq;
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
    public partial class FormInicio : Form
    {
        NegocioUsuario usuarioNegocio = new NegocioUsuario();
        public FormInicio()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("En caso de no tener usuario, comunicarse con el administrador a admin@electrohogar.com", "Ayuda", MessageBoxButtons.OK);
        }

        int contadorContraseña = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuarioInicio.Text;
            String contraseña = txtContraseñaInicio.Text;

            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña.");
                return; // Salir del método para evitar continuar con el inicio de sesión
            }

            //valido el usuario y contraseña que ingreso
            // 1. verifico q el usuario exista
            // 2. verifico q la contraseña coincida (implementar logica de 3 intentos)
            // 3. Busco rol (host)
            if (!(usuario.Length > 0 && contraseña.Length > 0))
            {
                MessageBox.Show("Debe de ingresar un usuario y contraseña correcto");
            }

            // Creo un int rol que tome el valor del usuario que inicia sesion
            int rol;

            // implementar logica dependiendo el rol encontrado del Login
            
            
            rol = usuarioNegocio.LoginUsuario(usuario, contraseña);

                if (rol == -1)
                {
                    MessageBox.Show("no se encontro el usuario");
                }
                if (rol == -2)
                {
                    contadorContraseña++;
                    if (contadorContraseña == 1)
                    {
                    MessageBox.Show("La contreseña ingresada es incorrecta, le quedan dos intentos");

                    }
                    else if (contadorContraseña == 2)
                    {
                    MessageBox.Show("Ultimo intento, si falla se desactivará la cuenta temporalmente");
                    }
                    if (contadorContraseña == 3)
                    {
                    MessageBox.Show("El usuario se ha desactivado temporalmente, porfavor contacte a un administrador!");
                    usuarioNegocio.BajaUsuarioConNombre(usuario);
                    }          
                }
           

            // Obtener el rol del usuario para saber a que menu redireccionar
            //1= Vendedor 2=Supervisor 3=Administrador

            if (rol == 1 || rol == 2 || rol == 3) 
            {
                //comprobar si es el primer login del usuario
                
                int primerLogin = usuarioNegocio.EsPrimerLogin(contraseña);
                // si es primer login (1), primero mostrar pantalla de cambiar contraseña, despues pantalla correspondiente

                if(primerLogin == 1)
                {
                    //pantalla cambiar contraseña
                    FormCambiarContraseña formContraseña = new FormCambiarContraseña();
                    formContraseña.Usuario = usuario;
                    formContraseña.ShowDialog();
                }

                // si no es primer login (0), Ir al formulario que corresponde
                this.Hide();

                if (rol == 3)
                {
                    FormMenuAdmin formAdministrador = new FormMenuAdmin();
                    formAdministrador.Usuario = usuario;
                    formAdministrador.ShowDialog();
                }
                else if (rol == 2)
                {
                    FormMenuSupervisor formSupervisor = new FormMenuSupervisor();
                    formSupervisor.ShowDialog();
                }
                else if(rol == 1)
                {
                    FormMenuVendedor formVendedor = new FormMenuVendedor();
                    formVendedor.ShowDialog();
                }
            }     
           
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            contadorContraseña = 0; 
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void labelIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pbMostrarInicio_Click(object sender, EventArgs e)
        {
            pbOcultarInicio.BringToFront();
            txtContraseñaInicio.PasswordChar = '\0';
        }

        private void pbOcultarInicio_Click_1(object sender, EventArgs e)
        {
            pbMostrarInicio.BringToFront();
            txtContraseñaInicio.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

    }
    }
}