﻿using System;
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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente(Inicio inicio)
        {
            FormInicio = inicio;
            Accion = "ALTA";
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            cboTipo.Text = "Fiscal";
        }

        private void btnCerrarModal_Click(object sender, EventArgs e)
        {
            FormInicio.modalAgregarCliente = null;
            Hide();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            string razonSocial = txtRazonSocial.Text;
            string nombreComercial = txtNombreComercial.Text;
            string tipo = cboTipo.Text;
            string direccion = txtDireccion.Text;
            double porcentajeVenta = Convert.ToDouble(txtPorcentajeVenta.Text);
            string estatus = "ACTIVO";
            Cliente cliente = new Cliente(razonSocial,nombreComercial,tipo,direccion,porcentajeVenta,estatus);

            if(Accion == "ALTA")
            {
                FormInicio.GuardaCliente(cliente);
            }
            else if (Accion == "EDITAR")
            {
                FormInicio.EditaCliente(cliente);
            }
            else if(Accion == "ELIMINAR")
            {
                FormInicio.EliminaCliente(cliente);
            }
            
        }

        public void Show(Cliente cliente, string accion)
        {
            Accion = accion;
            if(Accion == "EDITAR")
            {
                txtRazonSocial.Text = cliente.RazonSocial;
                txtNombreComercial.Text = cliente.NombreComercial;
                cboTipo.Text = cliente.Tipo;
                txtDireccion.Text = cliente.Direccion;
                txtPorcentajeVenta.Text = cliente.PorcentajeVenta.ToString();
                btnGuardarCliente.Text = "EDITAR";
                Show();
            }
            else if(Accion == "ELIMINAR")
            {
                txtRazonSocial.Text = cliente.RazonSocial;
                txtNombreComercial.Text = cliente.NombreComercial;
                cboTipo.Text = cliente.Tipo;
                txtDireccion.Text = cliente.Direccion;
                txtPorcentajeVenta.Text = cliente.PorcentajeVenta.ToString();
                
                txtRazonSocial.Enabled = false;
                txtNombreComercial.Enabled = false;
                cboTipo.Enabled = false;
                txtDireccion.Enabled = false;
                txtPorcentajeVenta.Enabled = false;

                btnGuardarCliente.Text = "ELIMINAR";
                Show();
            }
            
        }
    }
}
