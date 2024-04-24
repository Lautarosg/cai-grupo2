using System;

namespace Datos.Controller
{
    public class UsuarioPostRequest
    {


        public class UserData
        {
            public Guid IdUsuario { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Dni { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Host { get; set; }
        }
    }
}