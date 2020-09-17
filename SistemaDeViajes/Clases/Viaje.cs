using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Viaje
    {
        public int IdViaje;
        public int IdSucursal;
        public int IdRuta;
        public int IdTarifa;
        public string Folio;
        public double PesoTotal;
        public string Estatus;

        public Viaje(int idviaje, int idsucursal,int idruta, int idtarifa, string folio, double pesototal, string estatus)
        {
            IdViaje = idviaje;
            IdSucursal = idsucursal;
            IdRuta = idruta;
            IdTarifa = idtarifa;
            Folio = folio;
            PesoTotal = pesototal;
            Estatus = estatus;

        }

        public Viaje(int idsucursal,int idruta, int idtarifa, string folio, double pesototal, string estatus)
        {
            IdSucursal = idsucursal;
            IdRuta = idruta;
            IdTarifa = idtarifa;
            Folio = folio;
            PesoTotal = pesototal;
            Estatus = estatus;
        }
    }
}
