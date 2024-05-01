using Datos;
using Datos.Controller;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class ControladorUsuario
    {
        public void AgregarUsuario(UsuarioPostRequest usuarioPost)
        {
            String path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(usuarioPost);

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
                    Console.WriteLine($" Agregar Usuario Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        public void Login(Login Login)
        {
            {
                String path = "/api/Usuario/Login";

                var jsonRequest = JsonConvert.SerializeObject(Login);
                Console.WriteLine("Usuario ingresado:" + Login.NombreUsuario + "Contraseña ingresada:" + Login.Contraseña);
                try
                {
                    HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                    if (response.IsSuccessStatusCode)
                    {
                        var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                        string respuesta = reader.ReadToEnd();
                        Console.WriteLine("Login request was successful.");

                    }
                    else
                    {
                        Console.WriteLine($"Login request failed with status code {response.StatusCode}.");

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"A Login error occurred: {ex.Message}");

                }

            }
        }


        

        public static void BajaUsuario(string idUsuario)
        {
            String IdUsuarioMaster = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
            String path = "/api/Usuario/BajaUsuario";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", IdUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.\nVerifique los datos ingresados");
            }
            else
            {
                Console.WriteLine("Usuario dado de baja correctamente");
            }
        }

        public string ListaUsuarios()
        {
            // Trae todos los usuarios activos del master ID
            String IdUsuarioMaster = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
            

            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Usuario/TraerUsuariosActivos?id={IdUsuarioMaster}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Algo salio mal.\nVerifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

        
        public JToken BuscoUsuarioporID(string id)
        {
            // Busca en los usuarios activos a un usuario por el id
            string content = ListaUsuarios();
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);
            string idFinal = id.Trim('"');

            JToken usuario = jsonArray.FirstOrDefault(item => (string)item["id"] == idFinal);

            return usuario;
        }



    }


}


