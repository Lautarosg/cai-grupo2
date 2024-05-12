using Datos;
using Newtonsoft.Json;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace Persistencia
{
    public class ControladorProducto
    {
        public void AgregarProducto(ProductoPostRequest producto)
        {
            String path = "/api/Producto/AgregarProducto";

            var jsonRequest = JsonConvert.SerializeObject(producto);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($" El producto ha sido agregado con éxito");
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($" Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
