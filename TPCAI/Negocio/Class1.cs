using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCAI;
using Datos;
using Datos.Controller;
using System.IO;

namespace Negocio
{
    public class CrearUsuarioNegocio
    {
        private ControllerUsuario controllerUsuario;

        public CrearUsuarioNegocio()
        {
            controllerUsuario = new ControllerUsuario();
        }

        public async Task crearusuarioAsync(UsuarioPostRequest usuario, string idAdmin,string idUsuario)
        {
            List<string> usuarios = await controllerUsuario.TraerUsuariosActivos(idAdmin);
            if (usuarios.Contains(idUsuario))
            {
                throw new Exception($"The provided idUsuario '{idUsuario}' already exists in the database.");
            }
            else
            {
                await controllerUsuario.CrearusuarioAsync(usuario);
            }


        }
    }
}
