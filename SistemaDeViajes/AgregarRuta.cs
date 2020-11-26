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
    public partial class AgregarRuta : Form
    {
        public AgregarRuta(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        private void CargaLabels()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormInicio.GetCulture());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(FormInicio.GetCulture());
            label1.Text = Strings.EstadoDestino;
            label2.Text = Strings.EstadoOrigen;
            label3.Text = Strings.CPOrigen;
            label5.Text = Strings.CPDestino;
            label4.Text = Strings.Kilometros;
            btnGuardarRuta.Text = Strings.Guardar;
            btnCerrarModal.Text = Strings.Cerrar;
        }

        private void ActualizaCulture()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(FormInicio.GetCulture());
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(FormInicio.GetCulture());
        }

        private void AgregarRuta_Load(object sender, EventArgs e)
        {
            CargaLabels();
        }

        private void btnGuardarRuta_Click(object sender, EventArgs e)
        {
            List<Ruta> rutasExistentes = FormInicio.ObtenRutas();
            try
            {
                int cporigen = Convert.ToInt32(txtCPOrigen.Text);
                int cpdestino = Convert.ToInt32(txtCPDestino.Text);
                string estadodestino = txtEstadoDestino.Text;
                string estadoorigen = txtEstadoOrigen.Text;
                double kilometros = Convert.ToDouble(txtKilometros.Text);
                string estatus = "ACTIVO";
                Ruta ruta = new Ruta(estadoorigen, estadodestino, cporigen, cpdestino, kilometros, estatus);

                foreach (Ruta r in rutasExistentes)
                {
                    bool isEstadoOrigen = (r.EstadoOrigen == ruta.EstadoOrigen);
                    bool isEstadoDestino = (r.EstadoDestino == ruta.EstadoDestino);
                    bool isCPOrigen = (r.CPOrigen == ruta.CPOrigen);
                    bool isCPDestino = (r.CPDestino == ruta.CPDestino);
                    bool isKilometros = (r.Kilometros == ruta.Kilometros);
                    if (isEstadoOrigen && isEstadoDestino && isCPOrigen && isCPDestino && isKilometros) throw new Exception("\nInformacion Duplicada");
                }

                
                if (Accion == "ALTA")
                {
                    FormInicio.GuardaRuta(ruta);
                }
                else if (Accion == "EDITAR")
                {
                    FormInicio.EditaRuta(ruta);
                }
                else if (Accion == "ELIMINAR")
                {
                    FormInicio.EliminaRuta(ruta);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el registro" + error.Message);
            }
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarRuta = null;
            Hide();
        }

        public void Show(Ruta ruta, string accion)
        {
            Accion = accion;
            if (Accion == "EDITAR")
            {
                txtCPDestino.Text = ruta.CPDestino.ToString();
                txtCPOrigen.Text = ruta.CPOrigen.ToString();
                txtEstadoDestino.Text = ruta.EstadoDestino;
                txtEstadoOrigen.Text = ruta.EstadoOrigen;
                txtKilometros.Text = ruta.Kilometros.ToString();
                
                btnGuardarRuta.Text = "EDITAR";
                Show();
            }
            else if (Accion == "ELIMINAR")
            {
                txtCPDestino.Text = ruta.CPDestino.ToString();
                txtCPOrigen.Text = ruta.CPOrigen.ToString();
                txtEstadoDestino.Text = ruta.EstadoDestino;
                txtEstadoOrigen.Text = ruta.EstadoOrigen;
                txtKilometros.Text = ruta.Kilometros.ToString();

                txtCPDestino.Enabled = false;
                txtCPOrigen.Enabled = false;
                txtEstadoDestino.Enabled = false;
                txtEstadoOrigen.Enabled = false;
                txtKilometros.Enabled = false;

                btnGuardarRuta.Text = "ELIMINAR";
                Show();
            }

        }
    }
}
