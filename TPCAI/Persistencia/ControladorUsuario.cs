﻿using Datos;
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
                    Console.WriteLine($" Usuario Creado: {response.StatusCode} - {response.ReasonPhrase}");
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
        /*
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
        */
        public int Login(Login Login)
        {
            int valor = 0;
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
                        valor = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Login request failed with status code {response.StatusCode}.");
                        valor = -1;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"A Login error occurred: {ex.Message}");

                }
                return valor;

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

        public string ListaUsuarios(String idAdmin)
        {

            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Usuario/TraerUsuariosActivos?id={idAdmin}");

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


        public JToken BuscarUsuarioporID(string id, String idAdmin)
        {
            // Busca en los usuarios activos a un usuario por el id
            string content = ListaUsuarios(idAdmin);
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);
            string idFinal = id.Trim('"');

            JToken usuario = jsonArray.FirstOrDefault(item => (string)item["id"] == idFinal);

            return usuario;
        }

        public List<UsuarioDTO> ListarUsuarios(string idAdmin)
        {

            String path = "/api/Usuario/TraerUsuariosActivos?id=" + idAdmin;

            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<UsuarioDTO> listadoUsuarios = JsonConvert.DeserializeObject<List<UsuarioDTO>>(contentStream);
                    Console.WriteLine("Listar usuarios successful");
                    return listadoUsuarios;
                }
                else
                {
                    Console.WriteLine($"Listar clientes Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return usuarios;

        }

        public JToken BuscarUsuarioPorNombreUsuario(string usuario, String idAdmin)
        {
            // Busca en los usuarios activos a un usuario por el id
            string content = ListaUsuarios(idAdmin);
            // Analizar el contenido JSON
            JArray jsonArray = JArray.Parse(content);

            JToken usuarioEncontrado = jsonArray.FirstOrDefault(item => (string)item["nombreUsuario"] == usuario);

            return usuarioEncontrado;
        }

        public int VerRolUsuario(string usuario, string idAdmin)
        { 
            JToken usuarioRol = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            int rol = usuarioRol["host"].Value<int>();
            return rol; 
        }

        public string VerIdUsuario(string usuario, string idAdmin)
        {
            JToken usuarioId = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            string id = usuarioId["id"].Value<string>();
            return id;
        }

        public DateTime VerFechaAltaUsuario(string usuario, string idAdmin)
        {
            JToken usuariofechaAlta = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            //DateTime fechaAlta = usuariofechaAlta["fechaAlta"].Value<DateTime>();
            DateTime fechaAlta = DateTime.Now;
            return fechaAlta;
        }

        public bool existeUsuario(string usuario, string idAdmin)
        {
            bool existe = false;
            JToken usuarioRol = BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            if (usuarioRol == null)
            {
                existe = false;
            }
            else if (usuarioRol != null){
                existe = true; 
            }
            return existe;  
        }

        public List<UsuarioDTO> ListarUsuariosPorNombreUsuario(string valor, string idAdmin, string filtro)
        {
            // Primermo se obtiene la lista de usuarios activos
            List<UsuarioDTO> usuarios = ListarUsuarios(idAdmin);

            // Segundo se filtra los usuarios cuyo nombre de usuario coincida con el nombre ingresado
            List<UsuarioDTO> usuariosEncontrados;

            switch (filtro.ToLower())
            {
                case "nombre usuario":
                    usuariosEncontrados = usuarios
                        .Where(u => u.NombreUsuario.Equals(valor, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                case "apellido":
                    usuariosEncontrados = usuarios
                        .Where(u => u.Apellido.Equals(valor, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                case "nombre":
                    usuariosEncontrados = usuarios
                        .Where(u => u.Nombre.Equals(valor, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;
                default:
                    throw new ArgumentException("Filtro no válido. Debe ser NombreUsuario , Apellido o Nombre.");
            }

            return usuariosEncontrados;
        }
        

        public void ModificarContraseña(String nombreUsuario, String contraseña, String contraseñaNueva)
        {
            String path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Cambio contraseña exitoso: {response.StatusCode} - {response.ReasonPhrase}");
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


