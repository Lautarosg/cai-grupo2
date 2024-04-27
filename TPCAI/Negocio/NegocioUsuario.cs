using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TPCAI;
using Datos.Controller;
using static Datos.Controller.UsuarioPostRequest;
using TPCAI;


namespace Negocio
{
    public class NegocioUsuario
    {

        public String Login(string nombreUsuario, string password)
        {
            //Login usuarioDatos = new Login();
            //return usuarioDatos.Login(nombreUsuario, password);
            return null;
        }

        public int ObtenerPerfil(string idUsuario)
        {
            return 0;
        }

        public static void AgregarUsuario(UserData usuario)
        {
            //ConrollerUsuario.CrearusuarioAsync(usuario);
        }
    }
}
