using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using TPCAI;
namespace Negocio
{

    class NegocioCarrito
    {
        private ControladorVentas controladorVentas = new ControladorVentas();

        private List<(ProductoDTO ProductoDTO, int quantity)> items = new List<(ProductoDTO ProductoDTO, int quantity)>();

        public void AgregarProductoCarro(ProductoDTO ProductoDTO, int Cantidad)
        {
            if (ProductoDTO.Stock >= Cantidad)
            {
                items.Add((ProductoDTO, Cantidad));
                ProductoDTO.Stock -= Cantidad;
                Console.WriteLine($"Agregaste {Cantidad} de {ProductoDTO.Nombre} al carro.");
            }
            else
            {
                Console.WriteLine($"stock insuficiente {ProductoDTO.Nombre}.");
            }
        }

        public void SacarProductoCarro(Guid ProductoDTOId)
        {
            var item = items.FirstOrDefault(i => i.ProductoDTO.Id == ProductoDTOId);
            if (item.ProductoDTO != null)
            {
                items.Remove(item);
                item.ProductoDTO.Stock += item.quantity;
                Console.WriteLine($" {item.ProductoDTO.Nombre} fue quitado.");
            }
        }

        public void VerCarro()
        {
            foreach (var (ProductoDTO, quantity) in items)
            {
                Console.WriteLine($"{ProductoDTO.Nombre} - Cantidad: {quantity} - Precio: {ProductoDTO.Precio}");
                
            }

        }

        public decimal TotalPrecioCarro()
        {
            decimal total = items.Sum(item => item.ProductoDTO.Precio * item.quantity);
            return total;
        }
        public bool ejecutarCompra(Guid idCliente, Guid idAdmin, Guid idProducto, int Cantidad)
        {

            try
            {
                foreach (var item in items)
                {
                   if( controladorVentas.AgregarVenta( idCliente,  idAdmin,  idProducto, Cantidad)==!true)
                    {
                        throw new Exception("somthing where howwibly wrong whit the stocking systems comunicate whit help desk for help hours 9-16 workweak");

                    }


                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    /* ejemplo implentacion de metodos 
    class Program
    {
        static void Main()
        {
            List<ProductoDTO> procutos = new List<ProductoDTO>();
            procutos = Persistencia.ControladorProducto.ListaTodosProductos();

            ShoppingCart carrito = new ShoppingCart();

            // Example operations
            carrito.AgregarProductoCarro(procutos[0], 1); 
            carrito.VerCarro();                 
            carrito.TotalPrecioCarro();                
            carrito.SacarProductoCarro(procutos[0].Id); 
            carrito.VerCarro();                 
        }
    }
    */

}
