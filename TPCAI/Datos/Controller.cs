

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
        class Controller
        {
            public async Task<Usuario> CrearClienteAsync( UsuarioPostRequest usuarioPost)
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Cliente/AgregarCliente";

                    string jsonString = JsonSerializer.Serialize(usuarioPost);

                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        if (response.IsSuccessStatusCode)
                        {
                            string ResponseBody = await response.Content.ReadAsStringAsync();
                            Usuario ResponseData = JsonSerializer.Deserialize<Usuario>(ResponseBody);
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
            public async Task<Usuario> GetClientesAsync()
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Cliente/AgregarCliente";


                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            string ResponseBody = await response.Content.ReadAsStringAsync();
                            Usuario ResponseData = JsonSerializer.Deserialize<Usuario>(ResponseBody);
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
