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
using Persistencia;
using TPCAI;
using System.Collections.Generic;
using Microsoft.Win32;


namespace Negocio
{
    public class NegocioUsuario
    {
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        private ControladorUsuario controllerUsuario = new ControladorUsuario();

        public void AgregarUsuario(UsuarioPostRequest usuario)
        {
            controllerUsuario.AgregarUsuario(usuario);
        }

        public int LoginUsuario(string usuario, string contraseña)
        {
            int rol = 0;
            Login usuarioDatos = new Login(usuario, contraseña);
            UsuarioDTO responseData = controllerUsuario.Login(usuarioDatos);
            if (responseData != null)
            {
                Console.WriteLine("Usuario encontrado");
                rol = responseData.Rol;
            }
            else
            {
                Console.WriteLine("No se pudo iniciar sesión.");
                rol = -1;
            }
            return rol; 
        }
    }
}


        