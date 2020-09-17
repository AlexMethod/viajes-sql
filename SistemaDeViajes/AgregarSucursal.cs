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
    public partial class AgregarSucursal : Form
    {
        public AgregarSucursal(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        public void Show(Sucursal sucursal,string accion)
        {
            Accion = accion;

            if (Accion == "EDITAR")
            {
                txtNombre.Text = sucursal.Nombre;
                txtDireccion.Text = sucursal.Direccion;
                btnGuardarSucursal.Text = "EDITAR";
                Show();
                
            }
            else if (Accion == "ELIMINAR")
            {
                txtNombre.Text = sucursal.Nombre;
                txtDireccion.Text = sucursal.Direccion;

                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;

                btnGuardarSucursal.Text = "ELIMINAR";
                Show();
            }
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarSucursal = null;
            Hide();
        }

        private void btnGuardarSucursal_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string estatus = "ACTIVO";
            Sucursal sucursal = new Sucursal(nombre, direccion, estatus);

            if (Accion == "ALTA")
            {
                FormInicio.GuardaSucursal(sucursal);
            }
            else if (Accion == "EDITAR")
            {
                FormInicio.EditaSucursal(sucursal);
            }
            else if (Accion == "ELIMINAR")
            {
                FormInicio.EliminaSucursal(sucursal);
            }
        }
    }
}
