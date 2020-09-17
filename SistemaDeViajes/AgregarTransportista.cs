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
    public partial class AgregarTransportista : Form
    {
        public AgregarTransportista(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarTransportista = null;
            Hide();
        }

        private void btnGuardarTransportista_Click(object sender, EventArgs e)
        {
            string razonSocial = txtRazonSocial.Text;
            string nombreComercial = txtNombreComercial.Text;
            double comision = Convert.ToDouble(txtComision.Text);
            string estatus = "ACTIVO";
            Transportista transportista = new Transportista(razonSocial, nombreComercial, comision, estatus);

            if (Accion == "ALTA")
            {
                FormInicio.GuardaTransportista(transportista);
            }
            else if (Accion == "EDITAR")
            {
                FormInicio.EditaTransportista(transportista);
            }
            else if (Accion == "ELIMINAR")
            {
                FormInicio.EliminaTransportista(transportista);
            }
        }

        public void Show(Transportista transportista, string accion)
        {
            Accion = accion;
            if (Accion == "EDITAR")
            {
                txtRazonSocial.Text = transportista.RazonSocial;
                txtNombreComercial.Text = transportista.NombreComercial;
                txtComision.Text = transportista.Comision.ToString();
                btnGuardarTransportista.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                txtRazonSocial.Text = transportista.RazonSocial;
                txtNombreComercial.Text = transportista.NombreComercial;
                txtComision.Text = transportista.Comision.ToString();

                txtRazonSocial.Enabled = false;
                txtNombreComercial.Enabled = false;
                txtComision.Enabled = false;

                btnGuardarTransportista.Text = "ELIMINAR";
                Show();
            }

        }
    }
}
