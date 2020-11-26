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
using SistemaDeViajes.Resources;
using System.Threading;
using System.Globalization;

namespace SistemaDeViajes
{
    public partial class AgregarUnidad : Form
    {
        public AgregarUnidad(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        private void CargaLabels()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormInicio.GetCulture());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(FormInicio.GetCulture());
            label2.Text = Strings.Nombre;
            label1.Text = Strings.Placas;
            label3.Text = Strings.PesoMaximo;
            label5.Text = Strings.CostoxKilometro;
            label4.Text = Strings.Transportista;
            btnGuardarUnidad.Text = Strings.Guardar;
            btnCerrarModal.Text = Strings.Cerrar;
        }

        private void ActualizaCulture()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormInicio.GetCulture());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(FormInicio.GetCulture());
        }

        private void btnGuardarUnidad_Click(object sender, EventArgs e)
        {
            if (cboTransportista.SelectedItem == null) throw new Exception();
            try
            {
                int idTransportista = Convert.ToInt32((cboTransportista.SelectedItem as ComboboxItem).Value.ToString());
                string nombre = txtNombre.Text;
                string placas = txtPlacas.Text;
                double pesoMaximo = Convert.ToDouble(txtPesoMaximo.Text);
                double costoxKilometro = Convert.ToDouble(txtCostoKilometro.Text);
                string estatus = "ACTIVO";
                Unidad unidad = new Unidad(idTransportista, nombre, placas, pesoMaximo, costoxKilometro, estatus);

                if (Accion == "ALTA")
                {
                    FormInicio.GuardaUnidad(unidad);
                }
                else if (Accion == "EDITAR")
                {
                    FormInicio.EditaUnidad(unidad);
                }
                else if (Accion == "ELIMINAR")
                {
                    FormInicio.EliminaUnidad(unidad);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el registro" + error.Message);
            }
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarUnidad = null;
            Hide();
        }

        
        public void Show(Unidad unidad, string accion)
        {
            Accion = accion;
            bindCboTransportistas();
            Transportista transportista = FormInicio.ObtenTransportista(unidad.IdTransportista);
            if (Accion == "EDITAR")
            {
                txtNombre.Text = unidad.Nombre;
                txtPlacas.Text = unidad.Placas;
                txtPesoMaximo.Text = unidad.PesoMaximo.ToString();
                txtCostoKilometro.Text = unidad.CostoxKilometro.ToString();
                cboTransportista.SelectedItem = new ComboboxItem(transportista.NombreComercial, transportista.IdTransportista);
                cboTransportista.Text = transportista.NombreComercial;
                btnGuardarUnidad.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                txtNombre.Text = unidad.Nombre;
                txtPlacas.Text = unidad.Placas;
                txtPesoMaximo.Text = unidad.PesoMaximo.ToString();
                txtCostoKilometro.Text = unidad.CostoxKilometro.ToString();
                cboTransportista.SelectedItem = new ComboboxItem(transportista.NombreComercial, transportista.IdTransportista);
                cboTransportista.Text = transportista.NombreComercial;

                txtNombre.Enabled = false;
                txtPlacas.Enabled = false;
                txtPesoMaximo.Enabled = false;
                txtCostoKilometro.Enabled = false;
                cboTransportista.Enabled = false;

                btnGuardarUnidad.Text = "ELIMINAR";
                Show();
            }

        }

        public void bindCboTransportistas()
        {
            List<Transportista> transportistas = FormInicio.ObtenTransportistas();
            cboTransportista.Items.Clear();
            foreach(Transportista t in transportistas)
            {
                ComboboxItem item = new ComboboxItem(t.NombreComercial, t.IdTransportista);
                cboTransportista.Items.Add(item);
            }

            if(transportistas.Count() > 0)
            {
                Transportista primerTransportista = transportistas.FirstOrDefault();
                ComboboxItem primerValor = new ComboboxItem(primerTransportista.NombreComercial, primerTransportista.IdTransportista);
                cboTransportista.SelectedItem = primerValor;
                cboTransportista.Text = primerTransportista.NombreComercial;
            }
            else
            {
                cboTransportista.SelectedItem = null;
                cboTransportista.Text = "NO DATA";
            }
            

        }

        private void AgregarUnidad_Load(object sender, EventArgs e)
        {
            if(Accion == "ALTA")
            {
                bindCboTransportistas();
            }
            CargaLabels();

        }

        private void txtCostoKilometro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPesoMaximo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboTransportista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPlacas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
