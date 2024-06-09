using Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormVentasCarrito : Form
    {
        // Assume these are your business logic classes
        private readonly NegocioProducto _negocioProvedores;
        private readonly NegocioCarrito _negocioCarro;

        public FormVentasCarrito()
        {
            InitializeComponent();

            // Initialize your business logic classes
            _negocioProvedores = new NegocioProducto();
            _negocioCarro = new NegocioCarrito();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            // Load the list of providers when the form loads
            LoadProvedores();
        }

        private void LoadProvedores()
        {
            var a = NegocioProducto.GetProductos();
            List<ProductoDTO> provedoresList = JsonConvert.DeserializeObject<List<ProductoDTO>>(a);

            comboBoxProvedores.DataSource = provedoresList;
            comboBoxProvedores.DisplayMember = "Nombre"; // Ensure this matches a property in ProductoDTO
            comboBoxProvedores.ValueMember = "Id"; // Use "Id" as the ValueMember
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (comboBoxProvedores.SelectedItem is ProductoDTO selectedProvedor)
            {
                int quantity = (int)numericUpDownQuantity.Value;
                _negocioCarro.AgregarProductoCarro(selectedProvedor, quantity);
                MessageBox.Show("Product added to cart successfully!");
            }
            else
            {
                MessageBox.Show("Please select a provider.");
            }
        }

        private void comboBoxProvedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle any logic needed when a different provider is selected
        }
        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (comboBoxProvedores.SelectedItem is ProductoDTO selectedProvedor)
            {
                _negocioCarro.SacarProductoCarro(selectedProvedor.Id);
                MessageBox.Show("Product removed from cart successfully!");
            }
            else
            {
                MessageBox.Show("Please select a provider.");
            }
        }
        private void buttonViewCart_Click(object sender, EventArgs e)
        {
            string cartContent = _negocioCarro.VerCarro();
            MessageBox.Show(cartContent, "Cart Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
