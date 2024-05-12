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
        private Guid Id { get; set; }
        private Guid IdCategoria { get; set; }
        private string Nombre { get; set; }
        private DateTime FechaAlta { get; set; }
        private DateTime? FechaBaja { get; set; }
        private double Precio { get; set; }
        private int Stock { get; set; }
        private Guid IdUsuario { get; set; }
        private Guid IdProveedor { get; set; }
        public ProductoDTO(Guid id, Guid idCategoria, string nombre, DateTime fechaAlta, double precio, int stock, Guid idUsuario, Guid idProveedor)
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
