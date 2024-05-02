using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPCAI
{
    internal  class ValidadorUtil
    {
        public bool validarVacio(string campo)
        {
            bool retorno = false;
            if (campo == "" || campo == null)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool validarMin(string campo, int min)
        {
            bool retorno = false;
            if (campo.Length < min)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool validarMax(string campo, int max)
        {
            bool retorno = false;
            if (campo.Length > max)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool validarMay(string campo)
        {
            bool retorno = true;
            foreach (char c in campo)
            {
                if (char.IsUpper(c))
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        public bool validarIguales(string a, string b)
        {
            bool retorno = true;

            if(a == b)
            {
                retorno = false;
            }
            return retorno;
        }
        public void ValidarInfoButton(String txtIngresado, String txtValidado, PictureBox pbError, PictureBox pbValidado)
        {
            if (txtIngresado != txtValidado)
            {
                pbError.BringToFront();
            }
            else
            {
                pbValidado.BringToFront();
            }
        }
    }
}
