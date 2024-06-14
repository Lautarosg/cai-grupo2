using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Negocio
{
    public class NegocioVentas
    {
        private ControladorVentas controladorVentas = new ControladorVentas();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        HttpClient client = new HttpClient();

        public string listaVentasByCliente(string idCliente)
        {
            return controladorVentas.VentasByCliente(idCliente);
        }
               

        //uso de GetVentas
        public static string ListarVentas()
        {
            return ControladorVentas.ListarVentas();
        }

        //uso de GetVentas
        public static string GetVenta()
        {
            return ControladorVentas.GetVenta();
        }

        public void VentasReales()
        {
        }

        public bool AgregarVenta(Guid idCliente, Guid idUsuario, Guid idProducto,int cantidad )
        {
            return controladorVentas.AgregarVenta( idCliente,  idUsuario,  idProducto,  cantidad);
        }


        public class RootObject
        {
        public Guid idUsuario  { get; set; }
        public double monto { get; set; }
        }



        public string reajson()
        {
            try
            {
                List<RootObject> allRootObjects = new List<RootObject>();

                foreach (string fileName in Directory.GetFiles("TPCAI", "*.json"))
                {
                    using (StreamReader r = new StreamReader(fileName))
                    {
                        string json = r.ReadToEnd();
                        List<RootObject> ro = JsonConvert.DeserializeObject<List<RootObject>>(json);
                        allRootObjects.AddRange(ro);
                    }
                }

                // Group by idUsuario and calculate sum of monto for each group
                var groupedObjects = allRootObjects
                    .GroupBy(obj => obj.idUsuario)
                    .Select(group => new
                    {
                        idUsuario = group.Key,
                        TotalMonto = group.Sum(obj => obj.monto)
                    });

                // Sort by TotalMonto in descending order
                var sortedGroups = groupedObjects.OrderByDescending(group => group.TotalMonto);

                // Print sorted results
                Console.WriteLine("Sorted by idUsuario with the biggest sum of monto:");
                string a = "";
                foreach (var group in sortedGroups)
                {
                    a = a + $"idUsuario: {group.idUsuario}, Total monto: {group.TotalMonto}{Environment.NewLine}";
                }
                return a;
            }
            catch { return ""; }
        }
    }
}

