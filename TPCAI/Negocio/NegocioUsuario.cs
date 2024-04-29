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
using System.Collections.Generic;


namespace Negocio
{
    public class NegocioUsuario
    {
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        private ControllerUsuario controllerUsuario = new ControllerUsuario();

        //metodo que devuelve un int, si se logra hacer Login con los datos ingresados. 
        public async Task<int> Login(string nombreUsuario, string contraseña)
        {
            int rol = 0;
            Login usuarioDatos = new Login(nombreUsuario, contraseña);
            UsuarioDTO responseData = await controllerUsuario.Login(usuarioDatos);

            if (responseData != null)
            {
                rol = responseData.Rol;
            }
            else if (responseData == null) 
            {
                //permite comprobar si el webserice pudo hacer login. 
                rol = -1;
            }
            return rol;
        
        }
       
        public int ObtenerPerfil(string idUsuario)
        {
            return 3;
        }
        
        public static void AgregarUsuario(UsuarioPostRequest usuario, string id)
        {
            // se crea el nuevo usuario con CrearUsaurioAsyng   
            CrearUsuarioNegocio usuarioNegocio = new CrearUsuarioNegocio();
            usuarioNegocio.CrearUsuarioAsync(usuario, id);
        }
    }
}


        