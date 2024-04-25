using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TPCAI
{
    internal class UsuarioDTO
    {

        //creo los constructores del usuario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime FechaContraseña { get; set; }
        public bool Estado {  get; set; }
        public int Rol {  get; set; }



        public UsuarioDTO(string nombre, string apellido, string direccion, int telefono, string email, string nombreusuario, string contraseña, int dni, DateTime fechaNacimiento, int rol, DateTime fechacontraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            NombreUsuario = nombreusuario;
            Contraseña = contraseña;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            FechaCreacion = DateTime.Now;
            Rol = rol;
            FechaContraseña = fechacontraseña;
            


            
        }
    }
}
