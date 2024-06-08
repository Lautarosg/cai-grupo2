using Datos;
using Negocio;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormProductoMasVendidoCategoria : Form
    {
        public FormProductoMasVendidoCategoria()
        {
            InitializeComponent();
            ProductosMasVendidosPorCategoria();
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();
        }

        private void ProductosMasVendidosPorCategoria()
        {
            //String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

            // Obtener productos: TraerProductos
            string productosJson = NegocioProducto.GetProductos();
            JArray arrayProductos = JArray.Parse(productosJson);


            // Obtener ventas: GetVentas
            string ventasJson = NegocioVentas.ListarVentas(); 
            JArray arrayVentas = JArray.Parse(ventasJson);


            // Procesa datos para encontrar los productos con mayor cantidad de ventas por categoría
            Dictionary<string, JObject> productosMasVendidosPorCategoria = new Dictionary<string, JObject>();

          
            // Procesa las ventas para obtener los productos con la mayor cantidad de ventas por categoría
            //comparacion entre venta y producto, lee primero de cada venta el productid y cantidad
            //despues continua con producto
            foreach (JObject venta in arrayVentas)
            {
                string productoId = venta["productoId"].Value<string>();
                int cantidad = venta["cantidad"].Value<int>();

                foreach (JObject producto in arrayProductos)
                {
                    string id = producto["id"].Value<string>();
                    string categoria = producto["idCategoria"].Value<string>();

                    if (id == productoId) //compara los id de venta y prodcuto
                    {
                        if (!productosMasVendidosPorCategoria.ContainsKey(categoria) || cantidad > productosMasVendidosPorCategoria[categoria]["cantidad"].Value<int>())
                        {
                            productosMasVendidosPorCategoria[categoria] = producto;
                            productosMasVendidosPorCategoria[categoria]["cantidad"] = cantidad;
                        }
                    }
                }
            }

            // Muestra los productos con la mayor cantidad de ventas por categoría en la ListBox
            foreach (var kvp in productosMasVendidosPorCategoria)
            {
                listProdMasVendidoCateg.Items.Add($"Categoría: {kvp.Key}, Producto: {kvp.Value["nombre"]}, Cantidad de Ventas: {kvp.Value["cantidad"]}");
            }
        }

        private void FormProductoMasVendidoCategoria_Load(object sender, EventArgs e)
        {

        }

        private void listProdMasVendidoCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
