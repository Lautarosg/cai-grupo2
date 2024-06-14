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

        private void VentasByVendedor()
        {
            NegocioVentas nv = new NegocioVentas();

            label2.Text = nv.reajson();
            label2.Refresh();



        }
        
        private void listVentasPorVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
