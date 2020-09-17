using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Sucursal
    {
        public int IdSucursal;
        public string Nombre;
        public string Direccion;
        public string Estatus;

        public Sucursal(int idsucursal, string nombre, string direccion, string estatus)
        {
            IdSucursal = idsucursal;
            Nombre = nombre;
            Direccion = direccion;
            Estatus = estatus;

        }

        public Sucursal(string nombre, string direccion, string estatus)
        {
            Nombre = nombre;
            Direccion = direccion;
            Estatus = estatus;

        }

        
    }
}
