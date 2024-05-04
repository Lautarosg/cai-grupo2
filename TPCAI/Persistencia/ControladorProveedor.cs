using Datos.Controller;
using Newtonsoft.Json;
using Persistencia.utils;
using System.IO;
using System.Net.Http;
using System;
using TPCAI;
using System.Collections.Generic;

namespace Persistencia
{
    public class ControladorProveedor
    {
        public void AgregarProveedor(ProveedorPostRequest proveedor)
        {
            String path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(proveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($" Proveedor agregado con exito");
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($" Agregar proveedor Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public List<ProveedorDTO> ListarProveedores(string idAdmin)
        {

            String path = "/api/Proveedor/TraerProveedores";

            List<ProveedorDTO> proveedores = new List<ProveedorDTO>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProveedorDTO> listadoProveedores = JsonConvert.DeserializeObject<List<ProveedorDTO>>(contentStream);
                    Console.WriteLine("Listar proveedores successful");
                    return listadoProveedores;
                }
                else
                {
                    Console.WriteLine($"Listar proveedores Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return proveedores;

        }

        public static void BajaProveedor(string id, string idAdmin)
        {
            String path = "/api/Proveedor/BajaProveedor";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", id);
            map.Add("idUsuario", idAdmin);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.\nVerifique los datos ingresados");
            }
            else
            {
                Console.WriteLine("Proveedor dado de baja correctamente");
            }
        }
    }
}


