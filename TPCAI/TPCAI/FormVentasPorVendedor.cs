using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TPCAI
{
    public partial class FormVentasPorVendedor : Form
    {
        public FormVentasPorVendedor()
        {
            InitializeComponent();
            VentasByVendedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
            formMenuAdmin.ShowDialog();

        }

        //Esto devuelve una lista de vendedores del swagger, con su ID
        private void VentasByVendedor()
        {
            string clientes = NegocioCliente.listaCliente(); //traigo todos los clientes
            JArray arrayClientes = JArray.Parse(clientes);

            string nombreClienteMasVentas = "";
            string apellidoClienteMasVentas = "";
            int maxVentas = 0;
            
            
            foreach (JObject clienteJson in arrayClientes)
            {
                //lea cada cliente, y saco el idCliente, nombre y apellido
                string idCliente = clienteJson["id"].Value<string>();
                string nombre = clienteJson["nombre"].Value<string>();
                string apellido = clienteJson["apellido"].Value<string>();

                //con el id extraigo, saco el listado de ventas por cliente
                string ventasByCliente = NegocioVentas.listaVentasByCliente(idCliente);
                JArray arrayVentas = JArray.Parse(ventasByCliente);

                if (arrayVentas.Count > 0)
                {
                    listVentasPorVendedor.Items.Add($"Cliente {nombre} {apellido}");
                    listVentasPorVendedor.Items.Add("Ventas realizadas:");
                    foreach (JObject venta in arrayVentas)
                    {
                        string idVenta = venta["id"].Value<string>();
                        int cantidad = venta["cantidad"].Value<int>();
                        listVentasPorVendedor.Items.Add($"Id Venta: {idVenta} \nCantidad vendida: {cantidad}");
                    }
                    listVentasPorVendedor.Items.Add("");
                    //el vendedor con ventas maximas de swagger
                    if (arrayVentas.Count > maxVentas)
                    {
                        maxVentas = arrayVentas.Count;
                        nombreClienteMasVentas = nombre;
                        apellidoClienteMasVentas = apellido;
                    }
                }
            }
            MessageBox.Show($"El cliente que más ventas realizó es {nombreClienteMasVentas} {apellidoClienteMasVentas} con {maxVentas} ventas");
        }

        private void listVentasPorVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
