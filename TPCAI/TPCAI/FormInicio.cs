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

            // Obtener el rol del user para saber a que menu redireccionar
            //1= Vendedor 2=Supervisor 3=Administrador

            /**  aca tendria que obtener el rol del usuario para saber que menu ingresar
             * algo como
             * "usuarioNegocio.ObtenerPerfil(idUsuario);"
             **/
            int rol = 3;  //lo harcodee en valor asi no pincha el programa y probar los menus

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
            else
            {
                FormMenuVendedor formVendedor = new FormMenuVendedor();
                formVendedor.ShowDialog();
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
            var result = MessageBox.Show("Esta seguro que desea salir?", "sale aplicacion", MessageBoxButtons.YesNo);
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