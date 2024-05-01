using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormBajaUsuario : Form
    {
        public FormBajaUsuario()
        {
            InitializeComponent();
        }


        //boton de volver atras
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Da de baja el usuario en el swagger "Usuario/BajaUsuario" segun el ID ingresado
            string idUsuario = textBoxidUserBaja.Text;

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.BajaUsuario(idUsuario);
            
            
        }

        private void buttonListarUsuariosActivos_Click(object sender, EventArgs e)
        {
            string idUsuario = textBoxListarUserPorId.Text;

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.BuscoUsuarioporID(idUsuario);
        }
    }
}
