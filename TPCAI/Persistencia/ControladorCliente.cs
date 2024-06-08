using Datos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace Persistencia
{
    public class ControladorCliente
    {
        public static string ObtenerClientes()
        {
            // Trae todos los clientes activos
            String path = "/api/Cliente/GetClientes";

            string content = "";
            HttpResponseMessage response = WebHelper.Get(path);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

        public static async Task AgregarCliente(ClienteDTO cliente)
        {
            string path = "/api/Cliente/AgregarCliente";
            string json = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = await Task.Run(() => WebHelper.Post(path, json));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al agregar el cliente: " + response.ReasonPhrase);
            }
        }

        /*public static async Task ModificarCliente(Guid id, string direccion, string telefono, string email)
        {
            string path = $"/api/Cliente/PatchCliente";
            var patchData = new
            {
                id = id.ToString(),
                direccion = direccion,
                telefono = telefono,
                email = email
            };
            string json = JsonConvert.SerializeObject(patchData);

            HttpResponseMessage response = await Task.Run(() => WebHelper.Patch(path, json));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al modificar el cliente: " + response.ReasonPhrase);
            }
        }
        */
    }
}
