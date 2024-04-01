using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TPCAI
{
    internal class ValidadorUsuario
    {
        public static string ValidarNombre(string Text)
        {
            string nombre = Text.ToLower();

            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3 || nombre.Length > 50 || !Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                nombre = "\nError! Nombre no puede ser vacios, menos de 3 caracterses, mas de 50 caracteres ni contener carácteres especiales\n";
            }
            return nombre;
        }

        public static string ValidarApellido(string Text)
        {
            string apellido = Text.ToLower();

            if (string.IsNullOrEmpty(apellido) || apellido.Length < 3 || apellido.Length > 50)
            {
                apellido = "\nError! Apellido no puede ser vacios, menos de 3 caracterses ni mas de 50 caracteres\n";
            }
            return apellido;
        }

        public static int ValidarDNI(string Text)
        {
            
            if (Text.Length < 7 || Text.Length > 8)
            {
                Text = "DNI incorrecto";
               
            }
            if (!int.TryParse(Text, out int dni))
            {
                dni = -1;
                
            }
            
            return dni;

        }

        public static string ValidarTelefono(string telefono)
        {

            string patron = @"^\d+$";

            if (!Regex.IsMatch(telefono, patron) || (telefono.Length < 8 || telefono.Length > 11))
            {
                telefono = "\nError! No es un Teléfono válido\n";
            }
            return telefono;
        }

        public static string ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                email = "\nError! No es un mail válido\n";
            }
            return email;
        }

        public static string ValidarDireccion(string direccion) 
        {
            if (string.IsNullOrEmpty(direccion) || direccion.Length < 3 || direccion.Length > 255)
            {
                direccion = "\nError! Direccion no puede ser vacios, menos de 3 caracterses ni mas de 255 caracteres\n";
            }
            return direccion;
        }

        public static DateTime ValidarFechaNac(string DateText)
        {
            if (!DateTime.TryParseExact(DateText, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            
            {
                DateText = "\nFecha con formato incorrecto, porfavor ingrese dd/MM/yyyy \n";
            }

            return fechaNacimiento;
        }

    }
}
