using System;
using System.Net;
using System.Web.Helpers;

namespace Datos.Controller
{
    public class UsuarioPostRequest
    {


        public class UserData
        {
            /*public Guid IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Dni { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Host { get; set; }*/

            public string id, nombre, apellido, direccion, telefono, email, nombreusuario, contraseña;
            public int host, dni;
            public string fechaNacimiento;

            public string IdUsuario { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Email { get => email; set => email = value; }
            public string NombreUsuario { get => nombreusuario; set => nombreusuario = value; }
            public string Contrasenia { get => contraseña; set => contraseña = value; }
            public int Host { get => host; set => host = value; }
            public int Dni { get => dni; set => dni = value; }
            public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        }

        // Atributos
        private string _id;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaNacimiento;
        private string _usuario;
        private int _host; // perfil
        private int _dni;
        private string _contrasenia;

        public string IdUsuario { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string NombreUsuario { get => _usuario; set => _usuario = value; }
        public int Host { get => _host; set => _host = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Contraseña { get => _contrasenia; set => _contrasenia = value; }

        // Constructor para metodo de crearusuario
        public UsuarioPostRequest(string id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string usuario, int host, int dni)
        {
            // Las que tienen mayuscula son las que tienen setter
            IdUsuario = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            NombreUsuario = usuario;
            _host = host;
            _dni = dni;
            Contraseña = "PrimerLogin2024";
        }


    }


}