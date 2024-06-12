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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TPCAI
{
    public partial class FormCambiarContraseña : Form
    {
        public string Usuario { get; set; }

        public int RolUsuario  { get; set; }

        NegocioUsuario usuarioNegocio = new NegocioUsuario(); 

        ValidadorUtil validadorUtil = new ValidadorUtil();
        public FormCambiarContraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfCambio_Click(object sender, EventArgs e)
        {
            string usuario = this.Usuario;
            string contraseña = txtContraseñaActual.Text;
            string contraseñaNueva = txtContraseñaRegistrar.Text;
            string contraseñaVerificar = txtVerificarRegistrar.Text;

            if (validadorUtil.validarIguales(contraseña, contraseñaVerificar))
            {
                lblErrorContraseñaRegistrar.Text = "La contraseña debe ser la misma!";
            }
            else if(contraseña == "")
            {
                lblContrActual.Text = "Debe ingresar la contraseña actual";
            }
            else
            {
                usuarioNegocio.ModificarContraseña(usuario, contraseña, contraseñaNueva);
            }
        }

        private void pbMostrarRegistrar_Click(object sender, EventArgs e)
        {
            pbOcultarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '\0';
            txtContraseñaActual.PasswordChar = '\0';
            txtVerificarRegistrar.PasswordChar = '\0';
        }

        private void pbOcultarRegistrar_Click(object sender, EventArgs e)
        {
            pbMostrarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '*';
            txtContraseñaActual.PasswordChar = '*';
            txtVerificarRegistrar.PasswordChar = '*';
        }

        private void txtContraseñaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVerificarRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (RolUsuario == 3)
            {
                FormMenuAdmin formAdministrador = new FormMenuAdmin();
                formAdministrador.Usuario = Usuario;
                formAdministrador.RolUsuario = RolUsuario;
                formAdministrador.ShowDialog();
            }
            else if (RolUsuario == 2)
            {
                FormMenuSupervisor formSupervisor = new FormMenuSupervisor();
                formSupervisor.Usuario = Usuario;
                formSupervisor.RolUsuario = RolUsuario;
                formSupervisor.ShowDialog();
            }
            else if (RolUsuario == 1)
            {
                FormMenuVendedor formVendedor = new FormMenuVendedor();
                formVendedor.Usuario = Usuario;
                formVendedor.RolUsuario = RolUsuario;
                formVendedor.ShowDialog();
            }
        }
    }
}
