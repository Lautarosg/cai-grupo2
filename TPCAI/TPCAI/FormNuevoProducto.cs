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
        public string Usuario { get; set; }
        public int RolUsuario { get; set; }

        private int numeroSeleccionado;
        public FormNuevoProducto()
        {
            InitializeComponent();
            Load += FormNuevoProducto_Load;
        }
        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con opciones
            cbCategoriaProducto.Items.AddRange(opciones.Keys.ToArray());

            // Seleccionar la opción por defecto
            cbCategoriaProducto.SelectedItem = "Electro Hogar";
        }

        private void FormNuevoProveedor_Load(object sender, EventArgs e)
        {

        }
                
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        }

        private void btnConfirmarProducto_Click(object sender, EventArgs e)
        {
            {
                string precioVacio = txtPrecio.Text.ToString();
                string stockVacio = txtStock.Text.ToString();
                if (string.IsNullOrEmpty(precioVacio) || string.IsNullOrEmpty(stockVacio))
                    {
                    MessageBox.Show("Por favor, complete los campos.");
                    return;

                }
                else { 
                string usuario = this.Usuario;
                String idUsuario = usuario;
                String nombre = ValidadorUsuario.ValidarNombre(txtNombre.Text);
                int categoria = numeroSeleccionado;
                String idProveedor = "";
                decimal precio;
                int stock;

                    // Validar que el precio sea un decimal
                    if (!decimal.TryParse(txtPrecio.Text, out precio))
                    {
                        MessageBox.Show("Por favor, ingrese un valor decimal válido para el precio.");
                        return;
                    }

                    // Validar que el stock sea un entero
                    if (!int.TryParse(txtStock.Text, out stock))
                    {
                        MessageBox.Show("Por favor, ingrese un valor entero válido para el stock.");
                        return;
                    }

                    //VALIDACION DE DATOS DEL USER
                    //Uso un contador de errores para mostrar en pantalla en caso de que haya
                    String errores = "";

                errores += ValidadorUsuario.ValidarNombre(nombre);
                errores += ValidadorUsuario.ValidarPrecio(precio);
                errores += ValidadorUsuario.ValidarStock(stock);


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
                            //FormInicio formMenuVendedor = new FormInicio();
                            //formMenuVendedor.ShowDialog();
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
                        }

                    }
                }
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
