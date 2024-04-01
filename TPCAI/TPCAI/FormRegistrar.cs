using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormRegistrar : Form
    {
        const int minCarUsuario = 3;
        const int maxCarUsuario = 15;
        const int minCarContraseña = 8;
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormsRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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

            if (check == false) {

                var result = MessageBox.Show("Usuario Creado Exitosamente. \n¿Esta seguro que quiere continuar con el registro?", "Sale Aplicacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    NuevoUsuario formNuevoUsuario = new NuevoUsuario();
                    formNuevoUsuario.Show();
                }
            }


        }

        private void txtUsuarioRegistrar_TextChanged(object sender, EventArgs e)
        {
            string usuarioNuevo = txtUsuarioRegistrar.Text;
            
            ValidadorUtil validador = new ValidadorUtil();
            
            if (validador.validarVacio(usuarioNuevo))
            {
                lblErrorUsuarioRegistrar.Text = "Debe ingresar un nombre de usuario";
            }
            if (validador.validarVacio(usuarioNuevo)|| validador.validarMin(usuarioNuevo, minCarUsuario))
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

        private void txtContraseñaRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaVerificar_TextChanged(object sender, EventArgs e)
        {
            lblVerificarContRegistrar.Text ="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio form = new FormInicio();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea salir?", "sale aplicacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtContraseñaRegistrar_TextChanged_1(object sender, EventArgs e)
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

        private void lblErrorUsuarioRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void labe_Click(object sender, EventArgs e)
        {

        }

        private void pbMostrarRegistrar_Click(object sender, EventArgs e)
        {
            pbOcultarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '\0';
            txtVerificarRegistrar.PasswordChar = '\0';
        }

        private void pbOcultarRegistrar_Click_1(object sender, EventArgs e)
        {
            pbMostrarRegistrar.BringToFront();
            txtContraseñaRegistrar.PasswordChar = '*';
            txtVerificarRegistrar.PasswordChar = '*';
        }
    }
}
