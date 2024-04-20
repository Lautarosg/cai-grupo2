

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


    namespace YourNamespace
    {
        class Program
        {
            public async Task<Usuario> CrearClienteAsync( UsuarioPostRequest usuarioPost)
            {
                // Create an instance of HttpClient

                // Create an instance of HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Define the URL of the API endpoint
                    string apiUrl = "https://cai-tp.azurewebsites.net/api/Cliente/AgregarCliente";

                    // Serialize your data object to JSON
                    string jsonString = JsonSerializer.Serialize(usuarioPost);

                    // Create an instance of StringContent with your JSON payload
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    try
                    {
                        // Make the POST request
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                        // Check if the request was successful
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
