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
    public class NegocioCliente
    {
        private ControladorCliente controladorCliente = new ControladorCliente();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public static string listaCliente()
        {
            return ControladorCliente.ObtenerClientes();
        }
        public static string Cliente()
        {
            return ControladorCliente.ObtenerCliente();
        }

    }
}
