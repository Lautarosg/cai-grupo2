using Datos.Controller;
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
    public partial class FormNuevoProveedor : Form
    {
        ValidadorUtil validadorUtil = new ValidadorUtil();
        public FormNuevoProveedor()
        {
            InitializeComponent();
        }

        private void FormNuevoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void lblInstruccionesRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminProveedor formProveedor = new FormAdminProveedor();
            formProveedor.ShowDialog();
        }

        private void btnConfirmarProveedor_Click(object sender, EventArgs e)
        {
            {
                String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
                string nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                string apellido = ValidadorUsuario.ValidarNombre(txtApellido.Text);
                string email = ValidadorUsuario.ValidarEmail(txtEmail.Text);
                string cuit = ValidadorUsuario.ValidarCUIT(txtCUIT.Text);

               
                //VALIDACION DE DATOS DEL USER
                //Uso un contador de errores para mostrar en pantalla en caso de que haya
                string errores = "";

                errores += ValidadorUsuario.ValidarNombre(nombre);
                errores += ValidadorUsuario.ValidarApellido(apellido);
                errores += ValidadorUsuario.ValidarEmail(email);
                errores += ValidadorUsuario.ValidarCUIT(cuit);

                if (errores.Contains("error") || errores.Contains("-1"))
                {
                    MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //creo el nuevo proveedor 
                    ProveedorPostRequest SwaggerProveedor = new ProveedorPostRequest(idAdmin, nombre, apellido, email,cuit);
                    negocioProveedor negocioProveedor = new negocioProveedor();
                    negocioProveedor.AgregarProveedor(SwaggerProveedor);

                    var result = MessageBox.Show("Proveedor Creado Exitosamente.\n Porfavor, haga click en OK para volver al menú", "Confirmación", MessageBoxButtons.OK);

                    if (result == DialogResult.OK) //si el user hace click en OK, vuelve al menú 
                    {
                        this.Hide();
                        FormAdminProveedor formAdminProveedor = new FormAdminProveedor();
                        formAdminProveedor.ShowDialog();
                    }


                }
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtApellido.Text.ToLower(), ValidadorUsuario.ValidarNombre(txtApellido.Text), pbNombreError, pbNombre);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtNombre.Text.ToLower(), ValidadorUsuario.ValidarApellido(txtNombre.Text), pbApellidoError, pbApellido);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtEmail.Text.ToLower(), ValidadorUsuario.ValidarEmail(txtEmail.Text), pbEmailError, pbEmail);
        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtCUIT.Text.ToLower(), ValidadorUsuario.ValidarCUIT(txtCUIT.Text), pbDNIError, pbDNI);
        }
    }
}
