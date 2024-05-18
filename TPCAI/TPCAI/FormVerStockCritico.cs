using Datos;
using Negocio;
using Newtonsoft.Json.Linq;
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
    public partial class FormVerStockCritico : Form
    {
        NegocioProducto negocioProducto = new NegocioProducto();
        

        public FormVerStockCritico()
        {
            InitializeComponent();


        }

        private void FormVerStockCritico_Load(object sender, EventArgs e)
        {
            List<ProductoDTO> productos = negocioProducto.ListaProductos();

            //listaStockCritico.DataSource = productos;

            foreach (ProductoDTO producto in productos)
            {
                string datosProducto = $"Stock: {producto.Stock} - Nombre: {producto.Nombre} - Categoría: {producto.IdCategoria}";
                listaStockCritico.Items.Add(datosProducto);
            }

        }

        //Boton volver atras
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();
        }

              
       private void buttonVerStockCritico_Click(object sender, EventArgs e)
        {
            
            //devuelve una lista de todos los productos criticos
            //ordenados con su categoria, y dato de su nombre
            Dictionary<int, List<(string Nombre, int Stock)>> productosAgrupados = new Dictionary<int, List<(string, int)>>();
            int productosConStrockCritico = 0; //inicializo

            List<JToken> listaProductosConStrockCritico = new List<JToken>();

            int StockMaximo = 10;

            if (productosConStrockCritico > 0)
            {
                //productosConStrockCritico = listaProductosConStrockCritico.Count; //inicializo la var con tamaño de la lista

                //recorrer prodructos y agregarlos en productosAgrupados
                foreach (JToken producto in listaProductosConStrockCritico)
                {
                    string nombreProducto = producto["nombre"].Value<string>();
                    int idCategoria = producto["idCategoria"].Value<int>();
                    int stock = NegocioProducto.VerStock(nombreProducto);

                    if (!productosAgrupados.ContainsKey(idCategoria))
                    {
                        productosAgrupados[idCategoria] = new List<(string, int)>();
                    }

                    //agrupo segun key categoria
                    productosAgrupados[idCategoria].Add((nombreProducto, stock));
                }

                // Filtrar los productos con stock menor al 25% 
                //Stock < (0.25 * p.Stock)
                //pending


                foreach (var categoriaProductos in productosAgrupados)
                {
                    int idCategoria = categoriaProductos.Key;
                    string mensaje = $"Productos en stock crítico de categoría {idCategoria}:\n";

                    foreach (var producto in categoriaProductos.Value)
                    {
                        // Filtrar los productos con stock menor al 25%
                        if (producto.Stock < 0.25 * StockMaximo) // comparo contra el maximo supuesto
                        {
                            mensaje += $"  Nombre: {producto.Nombre}, Stock: {producto.Stock}\n";

                            // Agregar a ListBox
                            listaStockCritico.Items.Add($"Categoría {idCategoria}: {producto.Nombre}, Stock: {producto.Stock}");
                        }
                    }

                    mensaje += "\n";
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                MessageBox.Show("No hay productos con stock crítico");
            }

        }

        private void listaStockCritico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
