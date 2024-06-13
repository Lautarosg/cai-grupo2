using Datos;
using Newtonsoft.Json.Linq;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TPCAI;



namespace Negocio
{
    public class NegocioProducto
    {
        private ControladorProducto controladorProducto = new ControladorProducto();
        private static String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        

        public void AgregarProducto(ProductoPostRequest producto)
        {
            controladorProducto.AgregarProducto(producto);
        }

        //Tuve que corregir la opcion que usaba {} con esta recomendada por c#
        //asi funciona la compilacion
        public static int VerStock(string nombreProducto) => ControladorProducto.VerStock(nombreProducto);

        //cargo todos los productos en lista, para saber si conecta el swagger
        public static List<ProductoDTO> ListaProductos()
        {
            return ControladorProducto.ListaTodosProductos();
        }

        public static string GetProductos()
        {
            return ControladorProducto.ListaProductos();
        }


        public static async Task ModificarProducto(Guid id, string idUsuario, int precio, int stock)
        {
            await ControladorProducto.ModificarProducto(id, idUsuario, precio, stock);
        }

        public static async Task EliminarProducto(Guid id, string idUsuario)
        {
            await ControladorProducto.EliminarProducto(id, idUsuario);
        }

        public int ContarStockCritico()
        {
            // Devuelve una lista de todos los productos críticos
            // ordenados con su categoría y dato de su nombre
            Dictionary<int, List<(string Nombre, int Stock)>> productosAgrupados = new Dictionary<int, List<(string, int)>>();

            string listaproductos = GetProductos();//traigo todos los productos
            JArray arrayproductos = JArray.Parse(listaproductos);

            int StockMaximo = 10; // Máximo supuesto para comparar
            int contador = 0;
            if (arrayproductos.Count > 0)
            {
                // Recorrer productos y agregarlos en productosAgrupados
                foreach (JObject producto in arrayproductos)
                {
                    //string nombreProducto = producto["nombre"].Value<string>();
                    //int idCategoria = producto["idCategoria"].Value<int>();
                    int stock = producto["stock"].Value<int>(); // Corregido aquí

                    if (stock < 0.25 * StockMaximo) // Comparo contra el máximo supuesto
                    {
                        contador++;
                    }
                }

            }
            return contador;
        }

    }

}
