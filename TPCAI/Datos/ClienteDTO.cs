using System;

namespace TPCAI
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Dni { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public String Host { get; set; }

        public ClienteDTO() { }
        public ClienteDTO(Guid id, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Host = host;
        }

        public ClienteDTO (string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            
        }
    }
}