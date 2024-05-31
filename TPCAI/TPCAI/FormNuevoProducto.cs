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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPCAI
{
    public partial class FormNuevoProducto : Form
    {
        ValidadorUtil validadorUtil = new ValidadorUtil();

        private int numeroSeleccionado;
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
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();
        }

        private void btnConfirmarProducto_Click(object sender, EventArgs e)
        {
            {
                String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
                String nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                int categoria = numeroSeleccionado;
                String idProveedor = "";
                int precio = Convert.ToInt32(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                //VALIDACION DE DATOS DEL USER
                //Uso un contador de errores para mostrar en pantalla en caso de que haya
                String errores = "";

                errores += ValidadorUsuario.ValidarNombre(nombre);               
                

                if (errores.Contains("error") || errores.Contains("-1"))
                {
                    MessageBox.Show(errores, "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //creo el nuevo producto 
                    ProductoPostRequest SwaggerProducto = new ProductoPostRequest(categoria, idUsuario, idProveedor, nombre, precio, stock);
                    NegocioProducto negocioProducto = new NegocioProducto();
                    negocioProducto.AgregarProducto(SwaggerProducto);
                    
                    var result = MessageBox.Show("Producto Creado Exitosamente.\n Por favor, haga click en OK para volver al menú", "Confirmación", MessageBoxButtons.OK);

                    if (result == DialogResult.OK) //si el user hace click en OK, vuelve al menú 
                    {
                        this.Hide();
                        FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                        formMenuAdmin.ShowDialog();
                    }


                }
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtNombre.Text.ToLower(), ValidadorUsuario.ValidarNombre(txtNombre.Text), pbNombreError, pbNombre);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtPrecio.Text.ToLower(), ValidadorUsuario.ValidarEmail(txtPrecio.Text), pbPrecioError, pbPrecio);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            // Verificar si la tecla presionada es un número, un punto o una tecla de control como la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar el evento KeyPress
            }

            // Permitir sólo un punto decimal y asegurarse de que no sea el primer carácter
            if (e.KeyChar == '.')
            {
                if (textBox.Text.IndexOf('.') > -1 || textBox.SelectionStart == 0)
                {
                    e.Handled = true; // Cancelar el evento KeyPress
                }
            }
        }
        
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            validadorUtil.ValidarInfoButton(txtStock.Text.ToLower(), ValidadorUsuario.ValidarCUIT(txtStock.Text), pbStockError, pbStock);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control como la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento KeyPress
            }              
        }

        Dictionary<string, int> opciones = new Dictionary<string, int>
        {
            {"Audio", 1},
            {"Celulares", 2},
            {"Electro Hogar", 3},
            {"Informática", 4},
            {"Smart TV", 5}
        };

        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            if (comboBox != null)
            {
                // Obtenemos la opción seleccionada
                string opcionSeleccionada = comboBox.SelectedItem.ToString();

                // Si la opción seleccionada está en el diccionario, obtenemos el número asociado
                if (opciones.ContainsKey(opcionSeleccionada))
                {
                    numeroSeleccionado = opciones[opcionSeleccionada];               
                }
            }
        }

       
    }
}
