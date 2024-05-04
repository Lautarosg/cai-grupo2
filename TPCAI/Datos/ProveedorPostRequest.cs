using System;

namespace TPCAI
{
    public class ProveedorPostRequest
    {

        String _idUsuario;
        String _nombre;
        String _apellido;
        String _email;
        String _cuit;


        public ProveedorPostRequest(string idUsuario, string nombre, string apellido, string email, string cuit)
        {
            _idUsuario = idUsuario;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string CUIT { get => _cuit; set => _cuit = value; }
    }
}

