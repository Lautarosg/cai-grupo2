using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaDTO
    {
        public string IdCliente { get; set; }
        public string IdUsuario { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }

        // Constructor que recibe valores iniciales para idCliente, idUsuario, idProducto y cantidad
        public VentaDTO(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            // Inicializar las propiedades con los valores proporcionados
            // Las que tienen mayuscula son las que tienen setter
            IdCliente = idCliente;
            IdUsuario = idUsuario;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }
}
