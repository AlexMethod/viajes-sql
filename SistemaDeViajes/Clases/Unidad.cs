using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Unidad
    {
        public int IdUnidad;
        public int IdTransportista;
        public string Nombre;
        public string Placas;
        public double PesoMaximo;
        public double CostoxKilometro;
        public string Estatus;

        public Unidad (int idUnidad,int idTransportista,string nombre,string placas, double pesoMaximo, double costoxKilometro,string estatus)
        {
            IdUnidad = idUnidad;
            IdTransportista = idTransportista;
            Nombre = nombre;
            Placas = placas;
            PesoMaximo = pesoMaximo;
            CostoxKilometro = costoxKilometro;
            Estatus = estatus;
        }

        public Unidad(int idTransportista,string nombre, string placas, double pesoMaximo, double costoxKilometro, string estatus)
        {
            IdTransportista = idTransportista;
            Nombre = nombre;
            Placas = placas;
            PesoMaximo = pesoMaximo;
            CostoxKilometro = costoxKilometro;
            Estatus = estatus;
        }
    }
}
