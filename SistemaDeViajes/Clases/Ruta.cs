using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Ruta
    {
        public int IdRuta;
        public string EstadoOrigen;
        public string EstadoDestino;
        public int CPOrigen;
        public int CPDestino;
        public double Kilometros;
        public string Estatus;

        public Ruta(int idRuta,string estadoOrigen,string estadoDestino,int cpOrigen,int cpDestino,double kilometros,string estatus)
        {
            IdRuta = idRuta;
            EstadoDestino = estadoDestino;
            EstadoOrigen = estadoOrigen;
            CPOrigen = cpOrigen;
            CPDestino = cpDestino;
            Kilometros = kilometros;
            Estatus = estatus;

        }

        public Ruta(string estadoOrigen, string estadoDestino, int cpOrigen, int cpDestino, double kilometros, string estatus)
        {
            EstadoDestino = estadoDestino;
            EstadoOrigen = estadoOrigen;
            CPOrigen = cpOrigen;
            CPDestino = cpDestino;
            Kilometros = kilometros;
            Estatus = estatus;
        }

        public override string ToString()
        {
            return EstadoOrigen + " => " + EstadoDestino;
        }
    }
}
