using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TPCAI
{
    public class Login
    {

        //creo los constructores del usuario login
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }




        public Login(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;



        }
    }
    public class CambioContraseña

    {

        //creo los constructores del usuario
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string ContraseñaNueva { get; set; }




        public CambioContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            ContraseñaNueva = contraseñaNueva;



        }
    }
}
