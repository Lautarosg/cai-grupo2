using Datos.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CrearUsuarioNegocio
    {
        private ControllerUsuario controllerUsuario;
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public CrearUsuarioNegocio()
        {
            controllerUsuario = new ControllerUsuario();
        }

        public async Task CrearUsuarioAsync(UsuarioPostRequest usuario, string idUsuario)
        {
            List<string> usuarios = await controllerUsuario.TraerUsuariosActivos(idAdmin);

            // Check if idUsuario is equal to any of the strings in usuarios list
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
