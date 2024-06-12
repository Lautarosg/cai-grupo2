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
    public partial class FormMenuVendedor : Form
    {
        public string Usuario { get; set; }
        public int RolUsuario { get; set; }
        public FormMenuVendedor()
        {
            InitializeComponent();
        }

        private void FormMenuVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAltaCliente formAdminCliente = new FormAltaCliente();
            formAdminCliente.ShowDialog();
        }

        private void buttonRegistrarVta_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string usuario = this.Usuario;
            FormCambiarContraseña formContraseña = new FormCambiarContraseña();
            formContraseña.Usuario = usuario;
            formContraseña.RolUsuario = RolUsuario;
            formContraseña.ShowDialog();
        }
    }
}
