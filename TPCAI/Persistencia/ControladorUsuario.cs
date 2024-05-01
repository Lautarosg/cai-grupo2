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


    /*public void BajaUsuario(Guid idUsuario)
        {
            String path = "/api/Usuario/BajaUsuario?id=" + idUsuario;

            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
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
        }*/

    /*DA ERROR CUANDO SE INGRESA EL USER
    public static string TraerUsuarios()
    {
        // usuarios activos
        string content = "";
        HttpResponseMessage response = WebHelper.Get($"Usuario/TraerUsuariosActivos");
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

    public static JToken ObtenerUsuario(string nombre, string apellido, int dni)
    {
        // Busca en los usuarios activos a un usuario por el nombre de usuario y devuelve su id
        string idUsuario = "";
        string content = TraerUsuarios();
        // Analizar el contenido JSON
        JArray jsonArray = JArray.Parse(content);
        JToken usuario = jsonArray.FirstOrDefault(item => (string)item["nombre"] == nombre && (string)item["apellido"] == apellido && (int)item["dni"] == dni);

        return usuario;
    }

    public void BajaUsuario(string nombre, string apellido, int dni)
    {
        string idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        Dictionary<String, String> map = new Dictionary<String, String>();
        JToken usuario = ObtenerUsuario(nombre, apellido, dni);
        if (usuario == null)
        {
            Console.WriteLine("El usuario ingresado no existe en la base de datos");
        }
        else
        {
            string idUsuario = usuario["id"].ToString();
            map.Add("id", idUsuario);
            map.Add("idUsuario", idAdmin);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody("Usuario/BajaUsuario", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                Console.WriteLine("Usuario eliminado");
            }
        }
    }
    */

    /*
    public UsuarioDTO Login(Login Login)
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
                        var ResponseBody = response.Content.ReadAsStringAsync().Result;
                        UsuarioDTO ResponseData = JsonConvert.DeserializeObject<UsuarioDTO>(ResponseBody);
                        Console.WriteLine("Login request was successful.");
                        return ResponseData;

                }
                else
                    {
                        Console.WriteLine($"Login request failed with status code {response.StatusCode}.");
                        return null;
                }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"A Login error occurred: {ex.Message}");
                    return null;
                }

            }
        }
    }
    */

}


