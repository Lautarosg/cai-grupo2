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
    public partial class FormMenuSupervisor : Form
    {
        public string Usuario { get; set; }
        public int RolUsuario { get; set; }

        public FormMenuSupervisor()
        {
            InitializeComponent();
        }

        private void FormMenuSupervisor_Load(object sender, EventArgs e)
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
