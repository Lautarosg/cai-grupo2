using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioVentas
    {
        private ControladorVentas controladorVentas = new ControladorVentas();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public static string listaVentasByCliente(string idCliente)
        {
            return ControladorVentas.VentasByCliente(idCliente);
        }

    }
}
