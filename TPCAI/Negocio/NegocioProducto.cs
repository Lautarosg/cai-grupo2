using Datos;
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
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        

        public void AgregarProducto(ProductoPostRequest producto)
        {
            controladorProducto.AgregarProducto(producto);
        }

        //Tuve que corregir la opcion que usaba {} con esta recomendada por c#
        //asi funciona la compilacion
        public static int VerStock(string nombreProducto) => ControladorProducto.VerStock(nombreProducto);

        //cargo todos los productos en lista, para saber si conecta el swagger
        public List<ProductoDTO> ListaProductos()
        {
            List<ProductoDTO> productos = controladorProducto.ListaTodosProductos(idAdmin);
            return productos;
        }

    }

}
