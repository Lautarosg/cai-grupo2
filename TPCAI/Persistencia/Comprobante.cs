using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Comprobante
    {
        public void CrearComprovante(string comprovante)
        {

            // Define the folder path where you want to create the file
            string fullPaths = Directory.GetCurrentDirectory();
            string parentDirectory = Path.GetDirectoryName(Path.GetDirectoryName(fullPaths));


            // Get the current date and time
            DateTime now = DateTime.Now;

            // Format the date and time for the filename
            string dateTimeString = now.ToString("yyyyMMdd_HHmmss");

            // Combine folder path, formatted date and time, and the provided filename to create the full file path
            string fileName = $"{dateTimeString}.txt";
            string fullPath = Path.Combine(parentDirectory, fileName);

            // Create the file and write to it
            File.WriteAllText(fullPath, comprovante);

            // Optionally, print the full path to the console for verification
            Console.WriteLine($"File created at: {fullPath}");

  



        }
        public void AddVenta(Guid idUsuario, decimal monto)
        {


            // Define the folder path where you want to create the file
            string fullPaths = Directory.GetCurrentDirectory();
            string parentDirectory = Path.GetDirectoryName(Path.GetDirectoryName(fullPaths));


            // Get the current date and time
            DateTime now = DateTime.Now;

            // Format the date and time for the filename
            string dateTimeString = now.ToString("yyyyMMdd_HHmmss");

            // Combine folder path, formatted date and time, and the provided filename to create the full file path
            string fileName = $"{dateTimeString}.json";
            string fullPath = Path.Combine(parentDirectory, fileName);

            string comprovante = "{" +'\u0022' +"IdUsuario" + '\u0022' + " : " +'\u0022' +
                idUsuario +
                + '\u0022' +","+ '\u0022' +"monto"+ '\u0022' +":" +'\u0022' + monto + '\u0022'+
                "}";
            // Create the file and write to it
            File.WriteAllText(fullPath, comprovante);

            // Optionally, print the full path to the console for verification
            Console.WriteLine($"File created at: {fullPath}");


        }


            
        }

}
