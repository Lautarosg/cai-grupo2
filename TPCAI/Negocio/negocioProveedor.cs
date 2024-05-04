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
    public class negocioProveedor

    {
        private ControladorProveedor controladorProveedor = new ControladorProveedor();
        private String idAdmin = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void AgregarProveedor(ProveedorPostRequest proveedor)
        {
            controladorProveedor.AgregarProveedor(proveedor);
        }

        public List<ProveedorDTO> listaProveedores()
        {
            return controladorProveedor.ListarProveedores(idAdmin);
        }
        public void BajaProveedor(String idProveedor)
        {
            ControladorProveedor.BajaProveedor(idProveedor, idAdmin);
        }
    }
}


        