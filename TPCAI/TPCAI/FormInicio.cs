﻿using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegistrar form = new FormRegistrar();
            form.ShowDialog();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void labelIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea salir?", "sale aplicacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}