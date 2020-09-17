using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeViajes.Clases;

namespace SistemaDeViajes
{
    public partial class AgregarViaje : Form
    {
        public AgregarViaje(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        public void bindCboRutas()
        {
            List<Ruta> rutas = FormInicio.ObtenRutas();

            foreach (Ruta r in rutas)
            {
                ComboboxItem item = new ComboboxItem(r.EstadoOrigen + " => " + r.EstadoDestino, r.IdRuta);
                cboRuta.Items.Add(item);
            }

            if (rutas.Count() > 0)
            {
                Ruta primerRuta = rutas.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerRuta.EstadoOrigen + " => " + primerRuta.EstadoDestino, primerRuta.IdRuta);
                cboRuta.SelectedItem = primerValor;
                cboRuta.Text = primerRuta.EstadoOrigen + " => " + primerRuta.EstadoDestino;
            }
            else
            {
                cboRuta.SelectedItem = null;
                cboRuta.Text = "NO DATA";
            }
        }

        public void bindCboSucursales()
        {
            List<Sucursal> sucursales = FormInicio.ObtenSucursales();

            foreach (Sucursal s in sucursales)
            {
                ComboboxItem item = new ComboboxItem(s.Nombre, s.IdSucursal);
                cboSucursal.Items.Add(item);
            }

            if (sucursales.Count() > 0)
            {
                Sucursal primerSucursal = sucursales.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerSucursal.Nombre, primerSucursal.IdSucursal);
                cboSucursal.SelectedItem = primerValor;
                cboSucursal.Text = primerSucursal.Nombre;
            }
            else
            {
                cboSucursal.SelectedItem = null;
                cboSucursal.Text = "NO DATA";
            }


        }

        public void bindListPedidos(Viaje viaje = null)
        {
            List<Pedido> pedidos = new List<Pedido>();

            if (viaje == null)
            {
                pedidos = FormInicio.ObtenPedidos();
            }
            else
            {
                pedidos = FormInicio.ObtenPedidosxViaje(viaje.IdViaje);
            }

            foreach (Pedido p in pedidos)
            {
                ComboboxItem item = new ComboboxItem(p.Delivery, p.IdPedido);
                listPedidos.Items.Add(item);
            }
        }

        private void AgregarViaje_Load(object sender, EventArgs e)
        {
            if(Accion == "ALTA")
            {
                bindCboRutas();
                bindCboSucursales();
                bindListPedidos();
            }
            
            
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarViaje = null;
            Hide();
        }

        private void btnGuardarViaje_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos = new List<Pedido>();
            foreach(var i in listPedidos.CheckedItems)
            {
                ComboboxItem item = (i as ComboboxItem);
                Pedido pedido = FormInicio.ObtenPedido(item.Value);
                pedidos.Add(pedido);
            }

            double PesoTotal = pedidos.Sum(sum => sum.Peso);

            if (cboRuta.SelectedItem == null) throw new Exception();
            if (cboSucursal.SelectedItem == null) throw new Exception();
            if (Accion == "ALTA")
            {
                if (listPedidos.CheckedItems.Count == 0) throw new Exception();
            }
            
            try
            {
                int idRuta = Convert.ToInt32((cboRuta.SelectedItem as ComboboxItem).Value.ToString());
                int idSucursal = Convert.ToInt32((cboSucursal.SelectedItem as ComboboxItem).Value.ToString());
                string folio = txtFolio.Text;
                string estatus = "ACTIVO";
                Viaje viaje = new Viaje(idSucursal,idRuta,0, folio,PesoTotal, estatus);

                if (Accion == "ALTA")
                {
                    FormInicio.GuardaViaje(viaje);
                    Viaje nViaje = FormInicio.ObtenViaje(viaje.Folio);
                    FormInicio.EditaPedidosIdViaje(pedidos, nViaje.IdViaje);
                    //FormInicio.EditaViaje(nViaje);
                }
                else if (Accion == "EDITAR")
                {
                    FormInicio.EditaViaje(viaje);
                }
                else if (Accion == "ELIMINAR")
                {
                    FormInicio.EliminaViaje(viaje);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el registro" + error.Message);
            }
        }

        public void Show(Viaje viaje, string accion)
        {
            Accion = accion;
            bindCboRutas();
            bindCboSucursales();
            bindListPedidos(viaje);
            Ruta ruta = FormInicio.ObtenRuta(viaje.IdRuta);
            Sucursal sucursal = FormInicio.ObtenSucursal(viaje.IdSucursal);
            Tarifa tarifa = FormInicio.ObtenTarifa(viaje.IdTarifa);

            if (Accion == "EDITAR")
            {
                txtFolio.Text = viaje.Folio;
                txtPesoTotal.Text = viaje.PesoTotal.ToString();
                
                cboRuta.SelectedItem = new ComboboxItem(ruta.ToString(), ruta.IdRuta);
                cboRuta.Text = ruta.ToString();
                cboSucursal.SelectedItem = new ComboboxItem(sucursal.Nombre, sucursal.IdSucursal);
                cboSucursal.Text = sucursal.Nombre;


                btnGuardarViaje.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                txtFolio.Text = viaje.Folio;
                txtPesoTotal.Text = viaje.PesoTotal.ToString();

                cboRuta.SelectedItem = new ComboboxItem(ruta.ToString(), ruta.IdRuta);
                cboRuta.Text = ruta.ToString();
                cboSucursal.SelectedItem = new ComboboxItem(sucursal.Nombre, sucursal.IdSucursal);
                cboSucursal.Text = sucursal.Nombre;


                txtFolio.Enabled = false;
                txtPesoTotal.Enabled = false;
                cboRuta.Enabled = false;
                cboSucursal.Enabled = false;

                btnGuardarViaje.Text = "ELIMINAR";
                Show();
            }

        }
    }
}
