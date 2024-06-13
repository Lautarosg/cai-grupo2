using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCAI
{
    public enum CategoriaProducto
    {
        Audio = 1,
        Celulares = 2,
        ElectroHogar = 3,
        Informatica = 4,
        SmartTV = 5
    }
    public class ProductoDTO
    {
        public Guid Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        private DateTime FechaAlta { get; set; }
        private DateTime? FechaBaja { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        private string IdUsuario { get; set; }
        private string IdProveedor { get; set; }
        
        public ProductoDTO(Guid id, int idCategoria, string nombre, DateTime fechaAlta, int precio, int stock, string idUsuario, string idProveedor)
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
        }

    }
}
