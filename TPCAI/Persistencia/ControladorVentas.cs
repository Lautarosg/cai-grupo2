using Datos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace Persistencia
{
    public class ControladorVentas
    {
        /*public static string VentasByCliente(string idCliente)
        {
            // 
            
            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Venta/GetVentaByCliente?id={idCliente}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }*/


        public string VentasByCliente(string idCliente)
        {
            // 

            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Venta/GetVentaByCliente?id={idCliente}");
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;

            }
            return content;
        }

        public static string GetVenta()
        {
            string path = "/api/Venta/GetVenta";

            string content = "";
            HttpResponseMessage response = WebHelper.Get(path);
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

        public static string ListarVentas()
        {
            string path = "/api/Venta/GetVenta";

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
        public static class WebHelper2
        {
            private static readonly HttpClient client = new HttpClient();

            public static HttpResponseMessage PostWithBody(string url, string jsonContent)
            {
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                return client.PostAsync(url, content).Result;
            }

        }
        private static readonly HttpClient client = new HttpClient();

        public bool AgregarVenta(Guid idCliente, Guid idAdmin, Guid idProducto, int Cantidad)
        {
            string path = "https://cai-tp.azurewebsites.net/api/Venta/AgregarVenta";

            var payload = new
            {
                idCliente = idCliente.ToString(),
                idUsuario = idAdmin.ToString(),
                idProducto = idProducto.ToString(),
                cantidad = Cantidad
            };

            var jsonRequest = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(path, content).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.");
            }

            return true;
        }
    }
}

