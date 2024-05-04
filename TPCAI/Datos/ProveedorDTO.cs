using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace TPCAI
{
    public class ProveedorDTO
    {
        public Guid Id { get; set; }
        public List<Guid> IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public Guid IdUsuario { get; set; }
        public ProveedorDTO(Guid id, List<Guid> idCategoria, string nombre, string apellido, DateTime fechaAlta, string cuit, string email, Guid idUsuario)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            Apellido = apellido;
            FechaAlta = fechaAlta;
            CUIT = cuit;
            Email = email;
            IdUsuario = idUsuario;
        }

    }
}

