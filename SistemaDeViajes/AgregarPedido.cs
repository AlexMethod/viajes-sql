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
    public partial class AgregarPedido : Form
    {
        public AgregarPedido(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        public void Show(Pedido pedido, string accion)
        {
            Accion = accion;
            if (Accion == "EDITAR")
            {
                cboClienteO.Text = pedido.IdClienteOrigen.ToString();
                cboClienteD.Text = pedido.IdClienteDestino.ToString();
                txtDelivery.Text = pedido.Delivery;
                txtPeso.Text = pedido.Peso.ToString();
                txtPiezas.Text = pedido.Piezas.ToString();

                btnGuardarPedido.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                cboClienteO.Text = pedido.IdClienteOrigen.ToString();
                cboClienteD.Text = pedido.IdClienteDestino.ToString();
                txtDelivery.Text = pedido.Delivery;
                txtPeso.Text = pedido.Peso.ToString();
                txtPiezas.Text = pedido.Piezas.ToString();

                cboClienteO.Enabled = false;
                cboClienteD.Enabled = false;
                txtDelivery.Enabled = false;
                txtPeso.Enabled = false;
                txtPiezas.Enabled = false;

                btnGuardarPedido.Text = "ELIMINAR";
                Show();
            }

        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            bindCboClientes();
        }

        public void bindCboClientes()
        {
            List<Cliente> clientesOrigen = FormInicio.ObtenClientesOrigen();
            List<Cliente> clientesDestino = FormInicio.ObtenClientesDestino();
            cboClienteO.Items.Clear();
            cboClienteD.Items.Clear();

            foreach (Cliente c in clientesOrigen)
            {
                ComboboxItem item = new ComboboxItem(c.NombreComercial, c.IdCliente);
                cboClienteO.Items.Add(item);
            }

            foreach (Cliente c in clientesDestino)
            {
                ComboboxItem item = new ComboboxItem(c.NombreComercial, c.IdCliente);
                cboClienteD.Items.Add(item);
            }

            if (clientesOrigen.Count() > 0)
            {
                Cliente primerCliente = clientesOrigen.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerCliente.NombreComercial, primerCliente.IdCliente);
                cboClienteO.SelectedItem = primerValor;
                cboClienteO.Text = primerCliente.NombreComercial;
            }
            else
            {
                cboClienteO.SelectedItem = null;
                cboClienteO.Text = "NO DATA";
            }

            if (clientesDestino.Count() > 0)
            {
                Cliente primerCliente = clientesDestino.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerCliente.NombreComercial, primerCliente.IdCliente);
                cboClienteD.SelectedItem = primerValor;
                cboClienteD.Text = primerCliente.NombreComercial;
            }
            else
            {
                cboClienteD.SelectedItem = null;
                cboClienteD.Text = "NO DATA";
            }


        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                int idclienteorigen = Convert.ToInt32((cboClienteO.SelectedItem as ComboboxItem).Value);
                int idclientedestino = Convert.ToInt32((cboClienteD.SelectedItem as ComboboxItem).Value);
                string delivery = txtDelivery.Text;
                double peso = Convert.ToDouble(txtPeso.Text);
                double piezas = Convert.ToDouble(txtPiezas.Text);
                string estatus = "ACTIVO";
                Pedido pedido = new Pedido(idclienteorigen,idclientedestino,delivery,peso,piezas, estatus);

                if (Accion == "ALTA")
                {
                    FormInicio.GuardaPedido(pedido);
                }
                else if (Accion == "EDITAR")
                {
                    FormInicio.EditaPedido(pedido);
                }
                else if (Accion == "ELIMINAR")
                {
                    FormInicio.EliminaPedido(pedido);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el registro" + error.Message);
            }


        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarPedido = null;
            Hide();
        }
    }
}
