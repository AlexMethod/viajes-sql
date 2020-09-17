using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Transportista
    {
        public int IdTransportista;
        public string RazonSocial;
        public string NombreComercial;
        public double Comision;
        public string Estatus;

        public Transportista(int idTransportista, string razonSocial, string nombreComercial, double comision, string estatus)
        {
            IdTransportista = idTransportista;
            RazonSocial = razonSocial;
            NombreComercial = nombreComercial;
            Comision = comision;
            Estatus = estatus;
        }

        public Transportista(string razonSocial,string nombreComercial,double comision,string estatus)
        {
            RazonSocial = razonSocial;
            NombreComercial = nombreComercial;
            Comision = comision;
            Estatus = estatus;
        }

        
        
    }
}
