﻿using Datos;
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
        public List<ProductoDTO> ListaTodosProductos(string idAdmin)
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




        //metodo para ver el stock critico - Estoy viendo porque no lista aun

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

    }

}
