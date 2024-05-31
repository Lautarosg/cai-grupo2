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

    class ShoppingCart
    {
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
                Console.WriteLine($"{ProductoDTO.Nombre} - Quantity: {quantity} - Price per unit: {ProductoDTO.Precio}");
                
            }

        }

        public decimal TotalPrecioCarro()
        {
            decimal total = items.Sum(item => item.ProductoDTO.Precio * item.quantity);
            Console.WriteLine($"Total price: {total}");
            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            List<ProductoDTO> procutos = new List<ProductoDTO>();
            procutos = Persistencia.ControladorProducto.ListaTodosProductos();

            ShoppingCart cart = new ShoppingCart();

            // Example operations
            cart.AgregarProductoCarro(procutos[0], 1); 
            cart.VerCarro();                 
            cart.TotalPrecioCarro();                
            cart.SacarProductoCarro(procutos[0].Id); 
            cart.VerCarro();                 
        }
    }

}
