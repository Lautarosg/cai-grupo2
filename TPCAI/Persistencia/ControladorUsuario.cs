using Datos;
using Datos.Controller;
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
}


