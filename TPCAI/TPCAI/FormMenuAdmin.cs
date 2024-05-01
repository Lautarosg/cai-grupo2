using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();

        }

        private void buttonBajaSup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuUsuario formMenuUsuario = new FormMenuUsuario();
            formMenuUsuario.ShowDialog();
        }
    }
}
