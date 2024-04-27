

namespace Datos
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Web.Helpers;
    using TPCAI;


    namespace Controller
    {
        class ControllerUsuario
        {
            public async Task<UsuarioDTO> CrearusuarioAsync( UsuarioPostRequest usuarioPost)
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Usuario/Agregarusuario";

                    string jsonString = JsonSerializer.Serialize(usuarioPost);

                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        if (response.IsSuccessStatusCode)
                        {
                            string ResponseBody = await response.Content.ReadAsStringAsync();
                            UsuarioDTO ResponseData = JsonSerializer.Deserialize<UsuarioDTO>(ResponseBody);
                            Console.WriteLine("POST request was successful.");
                            return ResponseData;
                        }
                        else
                        {
                            Console.WriteLine($"POST request failed with status code {response.StatusCode}.");
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"An error occurred: {ex.Message}");
                        return null; 
                    }

                }
            }
            public async Task<UsuarioDTO> Login(Login login)
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Usuario/Agregarusuario";

                    string jsonString = JsonSerializer.Serialize(login);

                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        if (response.IsSuccessStatusCode)
                        {
                            string ResponseBody = await response.Content.ReadAsStringAsync();
                            UsuarioDTO ResponseData = JsonSerializer.Deserialize<UsuarioDTO>(ResponseBody);
                            Console.WriteLine("POST request was successful.");
                            return ResponseData;
                        }
                        else
                        {
                            Console.WriteLine($"POST request failed with status code {response.StatusCode}.");
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"An error occurred: {ex.Message}");
                        return null;
                    }

                }
            }
            public async Task<UsuarioDTO> CambiarContraseña(CambioContraseña cambioContraseña)
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Usuario/CambiarContrase";

                    string jsonString = JsonSerializer.Serialize(cambioContraseña);

                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    HttpMethod patchMethod = new HttpMethod("PATCH");

                    // Create a new HttpRequestMessage with the PATCH method
                    var request = new HttpRequestMessage(patchMethod, apiUrl)
                    {
                        Content = content
                    };

                    try
                    {
                        HttpResponseMessage response = await client.SendAsync(request);

                        if (response.IsSuccessStatusCode)
                        {
                            string ResponseBody = await response.Content.ReadAsStringAsync();
                            UsuarioDTO ResponseData = JsonSerializer.Deserialize<UsuarioDTO>(ResponseBody);
                            Console.WriteLine("POST request was successful.");
                            return ResponseData;
                        }
                        else
                        {
                            Console.WriteLine($"POST request failed with status code {response.StatusCode}.");
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"An error occurred: {ex.Message}");
                        return null;
                    }

                }
                
            }
        }
    }
}
