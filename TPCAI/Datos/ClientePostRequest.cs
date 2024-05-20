using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    using System;

    namespace Datos
    {
        public class ClientePostRequest
        {
            Guid _idUsuario;
            string _nombre;
            string _apellido;
            int _dni;
            string _direccion;
            string _telefono;
            string _email;
            DateTime _fechaNacimiento;
            string _host;

            public  ClientePostRequest(Guid idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
            {
                _idUsuario = idUsuario;
                _nombre = nombre;
                _apellido = apellido;
                _dni = dni;
                _direccion = direccion;
                _telefono = telefono;
                _email = email;
                _fechaNacimiento = fechaNacimiento;
                _host = host;
            }

            public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public string Apellido { get => _apellido; set => _apellido = value; }
            public int Dni { get => _dni; set => _dni = value; }
            public string Direccion { get => _direccion; set => _direccion = value; }
            public string Telefono { get => _telefono; set => _telefono = value; }
            public string Email { get => _email; set => _email = value; }
            public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
            public string Host { get => _host; set => _host = value; }
        }
    }

}
