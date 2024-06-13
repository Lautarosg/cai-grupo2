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
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


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
            // 1. usar logica de login para comprobar si existe
            Login usuarioDatos = new Login(usuario, contraseña);
            int loginComprobado = controllerUsuario.Login(usuarioDatos);
            

            // buscar rol 
            if (loginComprobado == 1)
            {
                // 1 admin, 2 supervisor, 3 vendedor
                loginComprobado = BuscarRol(usuario);
                
            }

            // comprobar porque no ingresa el usuario
            else if (loginComprobado == -1)
            {
                // 2. Si no es correcto, verifico q el usuario exista
                if (controllerUsuario.existeUsuario(usuario, idAdmin) == true)
                {
                    // si el usuario existe, pero no comprueba el login, entonces falla la contraseña
                    // -2 la contraseña es incorrecta
                        loginComprobado = -2;
                }
                else
                {
                    // -1 no existe el usuario con ese nombre de usuario
                    loginComprobado = -1;
                }
            }
            return loginComprobado;
        }

        public int EsPrimerLogin(string contraseña)
        {
            int primerLogin = 0;
            string contraseñaDefinitiva = "CAI20232";
            
            // si el usuario hace login correcto, pero con contraseña diferente a CAI20232, entonces es primer login. 
            if (contraseña != contraseñaDefinitiva)
            {
                primerLogin = 1; 
            }
            return primerLogin; 
        }

        public int EsContraseñaVencida (string usuario)
        {
            int fecha;
            DateTime fechaAlta = BuscarFechaAlta(usuario);
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferenciaFechas = fechaActual - fechaAlta;

            if (diferenciaFechas.TotalDays < 30)
            {
                fecha = 0; 
            }
            else
            {
                fecha=  1;
            }
            return fecha; 
        }

        public DateTime BuscarFechaAlta(string usuario)
        {
            DateTime fechaAlta = controllerUsuario.VerFechaAltaUsuario(usuario, idAdmin);
            return fechaAlta;
        }


        public void BajaUsuario(String idUsuario)
        {
            ControladorUsuario.BajaUsuario(idUsuario);
        }

        public void BajaUsuarioConNombre(String usuario)
        {
            JToken usuarioId = controllerUsuario.BuscarUsuarioPorNombreUsuario(usuario, idAdmin);
            string idUsuario = usuarioId["id"].Value<string>();
            BajaUsuario(idUsuario);
        }


        public void BuscarUsuarioporID(string idUsuario)
        {
            controllerUsuario.BuscarUsuarioporID(idUsuario, idAdmin);
        }

        public List<UsuarioDTO> listarUsuarios()
        {
            return controllerUsuario.ListarUsuarios(idAdmin); 
        }

        public int BuscarRol(string usuario)
        {
            int rol = controllerUsuario.VerRolUsuario(usuario, idAdmin);
            return rol;
        }

        public string BuscarId(string usuario)
        {
            string id = controllerUsuario.VerIdUsuario(usuario, idAdmin);
            return id;
        }

  
        public void ModificarContraseña(string usuario, string contraseña, string contraseñaNueva)
        {
            controllerUsuario.ModificarContraseña(usuario, contraseña, contraseñaNueva);
        }

        public List<UsuarioDTO> ListarUsuariosPorNombreUsuario(string valor, string filtro)
        {
            return controllerUsuario.ListarUsuariosPorNombreUsuario(valor, idAdmin, filtro);
        }
    }
}


        