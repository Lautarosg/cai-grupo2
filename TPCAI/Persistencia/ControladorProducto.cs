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

        //Lista todos los productos en el swagger TraerProductos
        public static List<ProductoDTO> ListaTodosProductos()
        {
            string path = "/api/Producto/TraerProductos";
            List<ProductoDTO> producto = new List<ProductoDTO>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProductoDTO> listadoProductos = JsonConvert.DeserializeObject<List<ProductoDTO>>(contentStream);
                    Console.WriteLine("Listar producto successful");
                    return listadoProductos;
                }
                else
                {
                    Console.WriteLine($"Listar producto Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return producto;

        }

       
        //Lista todos los productos en el swagger TraerProductos, pero devuelve un string, usado en calculo de producto con mayor cantidad de ventas
        public static string ListaProductos()
        {
            // Trae todos los productos
            string path = "/api/Producto/TraerProductos";
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
        public static JToken ListaProductoPorNombre(string nombre)
        {
            // extrae solo los nombres de productos
            string content = ListaProductos();
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);
            JToken producto = jsonArray.FirstOrDefault(item => (string)item["nombre"] == nombre);

            return producto;
        }
        public static int VerStock(string nombre)
        {
            JToken producto = ListaProductoPorNombre(nombre);
            int stock = producto["stock"].Value<int>();


            return stock;
        }


        public static async Task ModificarProducto(Guid id, string idUsuario, int precio, int stock)
        {
            string path = "/api/Producto/ModificarProducto";
            var patchData = new
            {
                id = id.ToString(),
                idUsuario = idUsuario.ToString(),
                precio = precio,
                stock = stock
            };
            string json = JsonConvert.SerializeObject(patchData);

            HttpResponseMessage response = await Task.Run(() => WebHelper.Patch(path, json));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al modificar el producto: " + response.ReasonPhrase);
            }
        }

        public static async Task EliminarProducto(Guid id, string idUsuario)
        {
            string path = "/api/Producto/BajaProducto";
            var productoDeleteRequest = new
            {
                id = id,
                idUsuario = idUsuario
            };

            var jsonRequest = JsonConvert.SerializeObject(productoDeleteRequest);
            HttpResponseMessage response = await Task.Run(() => WebHelper.DeleteWithBody(path, jsonRequest));

            if (!response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                string respuesta = reader.ReadToEnd();
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}\n{respuesta}");
            }
        }
    }

}
