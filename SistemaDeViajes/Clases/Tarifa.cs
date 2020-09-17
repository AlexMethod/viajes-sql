using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Tarifa
    {
        public int IdTarifa;
        public int IdRuta;
        public int IdUnidad;
        public int IdClienteFiscal;
        public double PrecioACliente;
        public double CostoATransportista;
        public string Estatus;

        public Tarifa(int idtarifa,int idruta,int idunidad,int idclientefiscal,double precio,double costo,string estatus)
        {
            IdTarifa = idtarifa;
            IdRuta = idruta;
            IdUnidad = idunidad;
            IdClienteFiscal = idclientefiscal;
            PrecioACliente = precio;
            CostoATransportista = costo;
            Estatus = estatus;
        }

        public Tarifa(int idruta, int idunidad, int idclientefiscal, double precio, double costo, string estatus)
        {
            IdRuta = idruta;
            IdUnidad = idunidad;
            IdClienteFiscal = idclientefiscal;
            PrecioACliente = precio;
            CostoATransportista = costo;
            Estatus = estatus;
        }

        public Tarifa(int idruta, int idunidad, int idclientefiscal, string estatus)
        {
            IdRuta = idruta;
            IdUnidad = idunidad;
            IdClienteFiscal = idclientefiscal;
            Estatus = estatus;
        }
    }
}
