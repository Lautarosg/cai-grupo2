using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Comprovante
    {
        public void CrearComprovante(string comprovante) {

            // Define the folder path where you want to create the file
            string folderPath = Directory.GetCurrentDirectory();

            // Get the current date and time
            DateTime now = DateTime.Now;

            // Format the date and time for the filename
            string dateTimeString = now.ToString("yyyyMMdd_HHmmss");

            // Combine folder path, formatted date and time, and the provided filename to create the full file path
            string fileName = $"{dateTimeString}.txt";
            string fullPath = Path.Combine(folderPath, fileName);

            // Create the file and write to it
            File.WriteAllText(fullPath, comprovante);

            // Optionally, print the full path to the console for verification
            Console.WriteLine($"File created at: {fullPath}");




        }
    }

}
