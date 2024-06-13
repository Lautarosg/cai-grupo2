using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoPostRequest
    {
        int _idCategoria;
        String _idUsuario;
        String _idProveedor;
        String _nombre;
        decimal _precio;
        int _stock;


        public ProductoPostRequest(int idCategoria, string idUsuario, string idProveedor, string nombre, decimal precio, int stock)
        {
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
        }

        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        
    }

}
