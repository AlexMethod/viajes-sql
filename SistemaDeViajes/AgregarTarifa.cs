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
    public partial class AgregarTarifa : Form
    {
        public AgregarTarifa(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        private void AgregarTarifa_Load(object sender, EventArgs e)
        {
            txtPrecioACliente.Visible = false;
            txtCostoATransportista.Visible = false;
            if(Accion == "ALTA")
            {
                bindCboRutas();
                bindCboUnidades();
                bindCboClientesFiscales();
            }
            
        }

        private void btnGuardarTarifa_Click(object sender, EventArgs e)
        {
            if (cboRuta.SelectedItem == null || cboUnidad.SelectedItem == null || cboClienteF.SelectedItem == null) throw new Exception();
            try
            {
                int idruta = Convert.ToInt32((cboRuta.SelectedItem as ComboboxItem).Value.ToString());
                int idunidad = Convert.ToInt32((cboUnidad.SelectedItem as ComboboxItem).Value.ToString());
                int idclientefiscal = Convert.ToInt32((cboClienteF.SelectedItem as ComboboxItem).Value.ToString());
                string estatus = "ACTIVO";
                Tarifa tarifa = new Tarifa(idruta, idunidad, idclientefiscal, estatus);

                if (Accion == "ALTA")
                {
                    FormInicio.GuardaTarifa(tarifa);
                }
                else if (Accion == "EDITAR")
                {
                    FormInicio.EditaTarifa(tarifa);
                }
                else if (Accion == "ELIMINAR")
                {
                    FormInicio.EliminaTarifa(tarifa);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el registro" + error.Message);
            }
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarTarifa = null;
            Hide();
        }

        public void bindCboRutas()
        {
            List<Ruta> rutas = FormInicio.ObtenRutas();
            cboRuta.Items.Clear();
            foreach (Ruta r in rutas)
            {
                ComboboxItem item = new ComboboxItem(r.EstadoOrigen + " => " + r.EstadoDestino,r.IdRuta);
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

        public void bindCboUnidades()
        {
            List<Unidad> unidades = FormInicio.ObtenUnidades();
            cboUnidad.Items.Clear();
            foreach (Unidad u in unidades)
            {
                ComboboxItem item = new ComboboxItem(u.Nombre, u.IdUnidad);
                cboUnidad.Items.Add(item);
            }

            if (unidades.Count() > 0)
            {
                Unidad primerUnidad = unidades.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerUnidad.Nombre, primerUnidad.IdUnidad);
                cboUnidad.SelectedItem = primerValor;
                cboUnidad.Text = primerUnidad.Nombre;
            }
            else
            {
                cboUnidad.SelectedItem = null;
                cboUnidad.Text = "NO DATA";
            }


        }

        public void bindCboClientesFiscales()
        {
            List<Cliente> clientes = FormInicio.ObtenClientesFiscales();
            cboClienteF.Items.Clear();
            foreach (Cliente c in clientes)
            {
                ComboboxItem item = new ComboboxItem(c.NombreComercial, c.IdCliente);
                cboClienteF.Items.Add(item);
            }

            if (clientes.Count() > 0)
            {
                Cliente primerCliente = clientes.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerCliente.NombreComercial, primerCliente.IdCliente);
                cboClienteF.SelectedItem = primerValor;
                cboClienteF.Text = primerCliente.NombreComercial;
            }
            else
            {
                cboClienteF.SelectedItem = null;
                cboClienteF.Text = "NO DATA";
            }


        }

        public void Show(Tarifa tarifa, string accion)
        {
            Accion = accion;
            bindCboRutas();
            bindCboUnidades();
            bindCboClientesFiscales();
            Ruta ruta = FormInicio.ObtenRuta(tarifa.IdRuta);
            Unidad unidad = FormInicio.ObtenUnidad(tarifa.IdUnidad);
            Cliente cliente = FormInicio.ObtenCliente(tarifa.IdClienteFiscal);

            if (Accion == "EDITAR")
            {
                cboRuta.SelectedItem = new ComboboxItem(ruta.ToString(), ruta.IdRuta);
                cboRuta.Text = ruta.ToString();
                cboClienteF.SelectedItem = new ComboboxItem(cliente.NombreComercial, cliente.IdCliente);
                cboClienteF.Text = cliente.NombreComercial;
                cboUnidad.SelectedItem = new ComboboxItem(unidad.Nombre, unidad.IdUnidad);
                cboUnidad.Text = unidad.Nombre;

                txtPrecioACliente.Text = tarifa.PrecioACliente.ToString();
                txtCostoATransportista.Text = tarifa.CostoATransportista.ToString();
                btnGuardarTarifa.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                cboRuta.SelectedItem = new ComboboxItem(ruta.ToString(), ruta.IdRuta);
                cboRuta.Text = ruta.ToString();
                cboClienteF.SelectedItem = new ComboboxItem(cliente.NombreComercial, cliente.IdCliente);
                cboClienteF.Text = cliente.NombreComercial;
                cboUnidad.SelectedItem = new ComboboxItem(unidad.Nombre, unidad.IdUnidad);
                cboUnidad.Text = unidad.Nombre;
                txtPrecioACliente.Text = tarifa.PrecioACliente.ToString();
                txtCostoATransportista.Text = tarifa.CostoATransportista.ToString();

                cboRuta.Enabled = false;
                cboUnidad.Enabled = false;
                cboClienteF.Enabled = false;
                btnGuardarTarifa.Text = "ELIMINAR";
                Show();
            }

        }
    }
}
