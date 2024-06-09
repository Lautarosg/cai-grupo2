using Datos;
using Datos.Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
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

        public List<ClienteDTO> listarClientes()
        {
            return controladorCliente.getClientes();
        }

        /*public void Task AgregarCliente(ClientePostRequest cliente)
        {
            await ControladorCliente.AgregarCliente(cliente);
        }*/

        public void agregarCliente(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            ClientePostRequest altaCliente = new ClientePostRequest(idAdmin, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            controladorCliente.AgregarCliente(altaCliente);

        }

        public void modificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {
            controladorCliente.ModificarCliente(idCliente, direccion, telefono, email);

        }

        /*
        public static async Task ModificarCliente(Guid id, string direccion, string telefono, string email)
        {
            await ControladorCliente.ModificarCliente(id, direccion, telefono, email);
        }
        */
    }
}
