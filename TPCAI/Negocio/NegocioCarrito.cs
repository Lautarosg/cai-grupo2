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

    public class NegocioCarrito
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

        public string VerCarro()
        {
            string carro = "";
            foreach (var (ProductoDTO, quantity) in items)
            {
                carro = carro + $"id producto:{ProductoDTO.Id}  {ProductoDTO.Nombre} - Cantidad: {quantity} - Precio unitario: {ProductoDTO.Precio} - Monto :{ProductoDTO.Precio * quantity}  {Environment.NewLine} ";

            }
            return carro;

        }



        /*public decimal TotalPrecioCarro()
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
        }*/

        public (decimal totalTrunk, string str) TotalPrecioCarro(Guid idCliente)
        {

            double total = items.Sum(item => item.ProductoDTO.Precio * item.quantity);

            decimal totalHogar = items
                .Where(item => item.ProductoDTO.IdCategoria == 3)
                .Sum(item => item.ProductoDTO.Precio * item.quantity);
            string str = "";

            var a = controladorVentas.VentasByCliente(idCliente.ToString());

            if (totalHogar > 100000 || a.Length > 0)
            {
                if (totalHogar > 100000 && a.Length > 0)
                {

                    total = total * 0.90;
                    str = "HF";
                }
                else
                {
                    if (totalHogar > 100000)
                    {
                        str = "H";
                    }
                    else
                    {
                        str = "F";
                    }
                    total = total * 0.95;
                }


            }
            double truncatedTotal = Math.Truncate(total * 100) / 100;

            decimal totalTrunk = (decimal)truncatedTotal;
            return (totalTrunk, str);
        }

        public bool ejecutarCompra(Guid idCliente, Guid idusuario)
        {

            try
            {
                // so it happen bofer the first purchase 
                var a = TotalPrecioCarro(idCliente);
                foreach (var item in items)
                {
                    if (controladorVentas.AgregarVenta(idCliente, idusuario, item.ProductoDTO.Id, item.quantity) == !true)
                    {
                        throw new Exception("somthing where howwibly wrong whit the stocking systems comunicate whit help desk for help hours 9-16 workweak");

                    }


                }
                remito(idCliente, idusuario, a.totalTrunk, a.str);
                return (true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void remito(Guid idCliente, Guid idusuario, decimal totalTrunk, string str)
        {
            string comprobante = $"Electro Hogar SRL {Environment.NewLine}";
            DateTime localDate = DateTime.Now;
            ControladorCliente cliente = new ControladorCliente();
            comprobante = comprobante + $"{cliente.ObtenerCliente(idCliente)}{Environment.NewLine}";
            comprobante = comprobante + $"{localDate}{Environment.NewLine}";
            comprobante = comprobante + $"{Environment.NewLine}{VerCarro()}";
            double total = (double)totalTrunk;
            switch (str)
            {
                case "H":
                    comprobante = comprobante + $"{Environment.NewLine} Descuento Hogar";
                    comprobante = comprobante + $"{Environment.NewLine} descuento : {total / 0.95 * 0.05}";

                    break;

                case "HF":
                    comprobante = comprobante + $"{Environment.NewLine} Descuento Hogar, Descuento Primera Compra";
                    comprobante = comprobante + $"{Environment.NewLine} descuento : {total / 0.90 * 0.10}";

                    break;
                case "F":
                    comprobante = comprobante + $"{Environment.NewLine} Descuento Primera Compra";
                    comprobante = comprobante + $"{Environment.NewLine} descuento: {total / 0.95 * 0.05}";

                    break;
                default:
                    comprobante = comprobante + $"{Environment.NewLine} ";
                    comprobante = comprobante + $"{Environment.NewLine} ";

                    break;

            }
            comprobante = comprobante + $"{Environment.NewLine} el total es :{totalTrunk}";

            Comprobante comprovante = new Comprobante();
            comprovante.CrearComprovante(comprobante);
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
