using Datos;
using Datos.Datos;
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

        public List<ClienteDTO> getClientes()
        {
            String path = "/api/Cliente/GetClientes";
            List<ClienteDTO> clientes = new List<ClienteDTO>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ClienteDTO> listadoClientes = JsonConvert.DeserializeObject<List<ClienteDTO>>(contentStream);
                    return listadoClientes;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return clientes;

        }

        /*public static async Task AgregarCliente(ClienteDTO cliente)
        {
            string path = "/api/Cliente/AgregarCliente";
            string json = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = await Task.Run(() => WebHelper.Post(path, json));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al agregar el cliente: " + response.ReasonPhrase);
            }
        }*/

        public void AgregarCliente(ClientePostRequest altaCliente)
        {
            String path = "/api/Cliente/AgregarCliente";

            var jsonRequest = JsonConvert.SerializeObject(altaCliente);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        
        public void ModificarCliente(Guid idCliente, String direccion, String telefono, String email)
        {
            String path = "/api/Cliente/PatchCliente";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idCliente.ToString());
            map.Add("direccion", direccion);
            map.Add("telefono", telefono);
            map.Add("email", email);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        
    }
}
