using Datos;
using Datos.Controller;
using Negocio;
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
    public partial class FormNuevoProducto : Form
    {
        ValidadorUtil validadorUtil = new ValidadorUtil();
        public FormNuevoProducto()
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

        private void btnConfirmarProducto_Click(object sender, EventArgs e)
        {
            {
                String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
                string nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                


                //VALIDACION DE DATOS DEL USER
                //Uso un contador de errores para mostrar en pantalla en caso de que haya
                string errores = "";

                errores += ValidadorUsuario.ValidarNombre(nombre);               
                

                if (errores.Contains("error") || errores.Contains("-1"))
                {
                    MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                   /* //creo el nuevo producto 
                    ProductoPostRequest SwaggerProducto = new ProductoPostRequest(idAdmin, nombre);
                    NegocioProducto negocioProducto = new NegocioProducto();
                    negocioProducto.AgregarProducto(SwaggerProducto);
                    */
                    var result = MessageBox.Show("Producto Creado Exitosamente.\n Porfavor, haga click en OK para volver al menú", "Confirmación", MessageBoxButtons.OK);

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
            validadorUtil.ValidarInfoButton(txtNombre.Text.ToLower(), ValidadorUsuario.ValidarNombre(txtNombre.Text), pbNombreError, pbNombre);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtNombre.Text.ToLower(), ValidadorUsuario.ValidarApellido(txtNombre.Text), pbApellidoError, pbApellido);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtPrecio.Text.ToLower(), ValidadorUsuario.ValidarEmail(txtPrecio.Text), pbEmailError, pbEmail);
        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtStock.Text.ToLower(), ValidadorUsuario.ValidarCUIT(txtStock.Text), pbDNIError, pbDNI);
        }

        Dictionary<string, int> opciones = new Dictionary<string, int>
        {
            {"Audio", 1},
            {"Celulares", 2},
            {"Electro Hogar", 3},
            {"Informática", 4},
            {"Smart TV", 5}
        };

        private void cbPerfilUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                // Obtenemos la opción seleccionada
                string opcionSeleccionada = comboBox.SelectedItem.ToString();

                // Si la opción seleccionada está en el diccionario, obtenemos el número asociado
                if (opciones.ContainsKey(opcionSeleccionada))
                {
                    int numeroSeleccionado = opciones[opcionSeleccionada];                
                }
            }
        }
    }
}
