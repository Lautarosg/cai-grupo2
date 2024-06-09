using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioVentas
    {
        private ControladorVentas controladorVentas = new ControladorVentas();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        HttpClient client = new HttpClient();

        public string listaVentasByCliente(string idCliente)
        {
            return controladorVentas.VentasByCliente(idCliente);
        }

        //uso de GetVentas
        public static string GetVenta()
        {
            return ControladorVentas.GetVenta();
        }

        public void VentasReales()
        {
             

        }
        
        public bool AgregarVenta(Guid idCliente, Guid idUsuario, Guid idProducto,int cantidad )
        {
            return controladorVentas.AgregarVenta( idCliente,  idUsuario,  idProducto,  cantidad);
        }


    }
}
