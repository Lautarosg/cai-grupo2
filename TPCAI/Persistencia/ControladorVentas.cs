using Datos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Persistencia.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TPCAI;

namespace Persistencia
{
    public class ControladorVentas
    {
        /*public static string VentasByCliente(string idCliente)
        {
            // 
            
            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Venta/GetVentaByCliente?id={idCliente}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }*/

        public string VentasByCliente(string idCliente)
        {
            // 

            string content = "";
            HttpResponseMessage response = WebHelper.Get($"/api/Venta/GetVentaByCliente?id={idCliente}");
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;

            }
            return content;
        }

        public static string GetVenta()
        {
            string path = "/api/Venta/GetVenta";

            string content = "";
            HttpResponseMessage response = WebHelper.Get(path);
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    content = response.Content.ReadAsStringAsync().Result;
                    return content;
                }
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                content = response.Content.ReadAsStringAsync().Result;
            }
            return content;
        }

        public static string ListarVentas()
        {
            string path = "/api/Venta/GetVenta";

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

        public bool AgregarVenta(Guid idCliente, Guid idAdmin,Guid idProducto, int Cantidad)
        {
            String path = "/api/Venta/AgregarVenta";

            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("idCliente", idCliente.ToString());
            map.Add("idUsuario", idAdmin.ToString());
            map.Add("idProducto", idProducto.ToString());
            map.Add("cantidad", Cantidad.ToString());


            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                return false;
                throw new Exception("Algo salio mal.");
            }
            else
            {
                return true;
               
            }
        }

    }
}
