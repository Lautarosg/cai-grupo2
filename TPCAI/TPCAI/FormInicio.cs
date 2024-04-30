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
    public partial class FormInicio : Form
    {

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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuarioInicio.Text;
            String password = txtContraseñaInicio.Text;

            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña.");
                return; // Salir del método para evitar continuar con el inicio de sesión
            }

            //valido el usuario y password que ingreso
            if (!(usuario.Length > 0 && password.Length > 0))
            {
                MessageBox.Show("Debe de ingresar un usuario y contraseña correcto");
            }

            // Creo un int rol que tome el valor del usuario que inicia sesion
            NegocioUsuario usuarioNegocio = new NegocioUsuario();
            int rol = usuarioNegocio.LoginUsuario(usuario, password);

            if (rol == -1)
            {
                MessageBox.Show("no se encontro el usuario");
            }
            // Obtener el rol del user para saber a que menu redireccionar
            //1= Vendedor 2=Supervisor 3=Administrador
           
            if (rol != -1 || rol != 0) 
            {

                // Ir al formulario que corresponde
                this.Hide();

                if (rol == 3)
                {
                    FormMenuAdmin formAdministrador = new FormMenuAdmin();
                    formAdministrador.ShowDialog();
                }
                else if (rol == 2)
                {
                    FormMenuSupervisor formSupervisor = new FormMenuSupervisor();
                    formSupervisor.ShowDialog();
                }
                else if(rol ==1)
                {
                    FormMenuVendedor formVendedor = new FormMenuVendedor();
                    formVendedor.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Dato ingresado incorrecto");
            }            
           
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

                FormMenuAdmin formAdministrador = new FormMenuAdmin();
                formAdministrador.ShowDialog();
        }
    }
}