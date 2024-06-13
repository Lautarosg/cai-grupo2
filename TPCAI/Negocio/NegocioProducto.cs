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

    }

}
