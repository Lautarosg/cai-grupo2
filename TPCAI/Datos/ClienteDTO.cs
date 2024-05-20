using System;

namespace TPCAI
{
    public class ClienteDTO
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

        public ClienteDTO(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Host = host;
        }
    }
}