using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeViajes.Clases
{
    public class Pedido
    {
        public int IdPedido;
        public int IdClienteOrigen;
        public int IdClienteDestino;
        public int IdViaje;
        public string Delivery;
        public double Peso;
        public double Piezas;
        public string Estatus;


        public Pedido(int idpedido,int idclienteorigen,int idclientedestino,int idviaje,string delivery,double peso,double piezas,string estatus)
        {
            IdPedido = idpedido;
            IdClienteDestino = idclientedestino;
            IdClienteOrigen = idclienteorigen;
            IdViaje = idviaje;
            Delivery = delivery;
            Peso = peso;
            Piezas = piezas;
            Estatus = estatus;
        }

        public Pedido(int idclienteorigen, int idclientedestino, int idviaje,string delivery, double peso, double piezas, string estatus)
        {
            IdClienteDestino = idclientedestino;
            IdClienteOrigen = idclienteorigen;
            IdViaje = idviaje;
            Delivery = delivery;
            Peso = peso;
            Piezas = piezas;
            Estatus = estatus;
        }

        public Pedido(int idclienteorigen, int idclientedestino,string delivery, double peso, double piezas, string estatus)
        {
            IdClienteDestino = idclientedestino;
            IdClienteOrigen = idclienteorigen;
            Delivery = delivery;
            Peso = peso;
            Piezas = piezas;
            Estatus = estatus;
        }

        public Pedido(int idpedido,string delivery)
        {
            IdPedido = idpedido;
            Delivery = delivery;
        }
    }
}
