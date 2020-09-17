using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaDeViajes.Clases
{
    public class Cliente
    {
        public int IdCliente;
        public string RazonSocial;
        public string NombreComercial;
        public string Tipo;
        public string Direccion;
        public double PorcentajeVenta;
        public string Estatus;
        
        public Cliente(int idCliente,string razonSocial,string nombreComercial, string tipo,string direccion,double porcentajeVenta,string estatus)
        {
            IdCliente = idCliente;
            RazonSocial = razonSocial;
            NombreComercial = nombreComercial;
            Tipo = tipo;
            Direccion = direccion;
            PorcentajeVenta = porcentajeVenta;
            Estatus = estatus;
        }

        public Cliente(string razonSocial, string nombreComercial, string tipo, string direccion, double porcentajeVenta, string estatus)
        {
            RazonSocial = razonSocial;
            NombreComercial = nombreComercial;
            Tipo = tipo;
            Direccion = direccion;
            PorcentajeVenta = porcentajeVenta;
            Estatus = estatus;
        }
    }
}
