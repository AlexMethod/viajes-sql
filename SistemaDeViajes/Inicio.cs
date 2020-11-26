using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaDeViajes.Clases;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using SistemaDeViajes.Resources;
using System.Threading;
using System.Globalization;

namespace SistemaDeViajes
{
    public partial class Inicio : Form
    {
        public Inicio(SqlConnection connectionSql)
        {
            InitializeComponent();
            ConnectionSQL = connectionSql;
        }

        public string GetCulture() { return Culture; }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CargaLabels()
        {
            //btnDash.Text = 

            //en-US
            //es-MX
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);
            CargaTitulo();
            btnClientes.Text = Strings.Clientes;
            btnSucursales.Text = Strings.Sucursales;
            btnUnidades.Text = Strings.Unidades;
            btnTransportistas.Text = Strings.Transportistas;
            btnRutas.Text = Strings.Rutas;
            btnTarifas.Text = Strings.Tarifas;
            btnViajes.Text = Strings.Viajes;
            btnPedidos.Text = Strings.Pedidos;
            btnHistorial.Text = Strings.Historial_viaje;

            btnAgregar.Text = Strings.Agregar;
            btnEditar.Text = Strings.Editar;
            btnEliminar.Text = Strings.Eliminar;
            btnEstatusViaje.Text = Strings.EstatusViaje;

        }

        private void CargaTitulo()
        {
            switch (CatalogoActual)
            {
                case "CLIENTES":
                    txtTitulo.Text = Strings.ClientesUpper;
                    break;
                case "SUCURSALES":
                    txtTitulo.Text = Strings.SucursalesUpper;
                    break;
                case "UNIDADES":
                    txtTitulo.Text = Strings.UnidadesUpper;
                    break;
                case "TRANSPORTISTAS":
                    txtTitulo.Text = Strings.TransportistasUpper;
                    break;
                case "RUTAS":
                    txtTitulo.Text = Strings.RutasUpper;
                    break;
                case "TARIFAS":
                    txtTitulo.Text = Strings.TarifasUpper;
                    break;
                case "VIAJES":
                    txtTitulo.Text = Strings.ViajesUpper;
                    break;
                case "PEDIDOS":
                    txtTitulo.Text = Strings.PedidosUpper;
                    break;
                case "HISTORIAL_VIAJE":
                    txtTitulo.Text = Strings.Historial_viajeUpper;
                    break;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cboIdioma.Text = "English";
            btnEstatusViaje.Visible = false;
            btnAgregar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;

            CargaLabels();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEliminar.Visible = true;
            btnEditar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "CLIENTES";
            txtTitulo.Text = Strings.ClientesUpper;
            GetAllData("Informacion", "Cliente");
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEliminar.Visible = true;
            btnEditar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;

            CatalogoActual = "SUCURSALES";
            txtTitulo.Text = Strings.SucursalesUpper;
            GetAllData("Informacion", "Sucursal");
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;

            CatalogoActual = "UNIDADES";
            txtTitulo.Text = Strings.UnidadesUpper;
            GetAllData("Informacion", "View_Unidad");
        }

        private void btnTransportistas_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;

            CatalogoActual = "TRANSPORTISTAS";
            txtTitulo.Text = Strings.TransportistasUpper;
            GetAllData("Informacion", "Transportista");
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEliminar.Visible = true;
            btnEditar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;


            CatalogoActual = "RUTAS";
            txtTitulo.Text = Strings.RutasUpper;
            GetAllData("Informacion", "Ruta");
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEliminar.Visible = true;
            btnEditar.Visible = false;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "TARIFAS";
            txtTitulo.Text = Strings.TarifasUpper;
            GetAllData("Operacion", "View_Tarifa");
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = true;
            btnEliminar.Visible = true;
            btnEditar.Visible = false;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "VIAJES";
            txtTitulo.Text = Strings.ViajesUpper;
            GetAllData("Operacion", "View_Viaje");
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = true;
            btnAgregar.Visible = true;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "PEDIDOS";
            txtTitulo.Text = Strings.PedidosUpper;
            GetAllData("Operacion", "View_Pedido");
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "HISTORIAL";
            txtTitulo.Text = Strings.Historial_viajeUpper;
            GetAllData("Operacion", "View_HistorialViajes");
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            graficaViajes.Visible = false;
            dgTabla.Visible = true;
            CatalogoActual = "DASHBOARD";
            txtTitulo.Text = "DASHBOARD";
            dgTabla.DataSource = new DataTable();
        }

        private void GetAllData(string esquema, string tabla, string campos = "*")
        {
            List<string> tablasDiferentes = new List<string>() { "View_Viaje", "View_Pedido", "View_HistorialViajes" };
            try
            {
                string query = "";
                if (tablasDiferentes.Contains(tabla))
                {
                    query = String.Format("SELECT " + campos + " FROM {0}.{1} WHERE Estatus IN " + "('" + "ACTIVO" + "','CARGA','DESCARGA','RUTA','FINALIZADO')", esquema, tabla);
                }
                else
                {
                    query = String.Format("SELECT " + campos + " FROM {0}.{1} WHERE Estatus = 'ACTIVO' ", esquema, tabla);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionSQL);
                DataTable datatable = new DataTable();

                adapter.Fill(datatable);
                dgTabla.DataSource = datatable;
                //Se esconde el Id del registro, esa informacion no la requiere el usuario
                dgTabla.Columns[0].Visible = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ha ocurrido un error al obtener la información\n" + erro.Message);
            }

        }

        //AGREGAR UN NUEVO REGISTRO
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            switch (CatalogoActual)
            {
                case "CLIENTES":
                    if (modalAgregarCliente == null || (modalAgregarCliente != null && modalAgregarCliente.IsDisposed)) modalAgregarCliente = new AgregarCliente(this);
                    modalAgregarCliente.Show();
                    break;
                case "SUCURSALES":
                    if (modalAgregarSucursal == null || (modalAgregarSucursal != null && modalAgregarSucursal.IsDisposed)) modalAgregarSucursal = new AgregarSucursal(this);
                    modalAgregarSucursal.Show();
                    break;
                case "UNIDADES":
                    if (modalAgregarUnidad == null || (modalAgregarUnidad != null && modalAgregarUnidad.IsDisposed)) modalAgregarUnidad = new AgregarUnidad(this);
                    modalAgregarUnidad.Show();
                    break;
                case "TRANSPORTISTAS":
                    if (modalAgregarTransportista == null || (modalAgregarTransportista != null && modalAgregarTransportista.IsDisposed)) modalAgregarTransportista = new AgregarTransportista(this);
                    modalAgregarTransportista.Show();
                    break;
                case "RUTAS":
                    if (modalAgregarRuta == null || (modalAgregarRuta != null && modalAgregarRuta.IsDisposed)) modalAgregarRuta = new AgregarRuta(this);
                    modalAgregarRuta.Show();
                    break;
                case "TARIFAS":
                    if (modalAgregarTarifa == null || (modalAgregarTarifa != null && modalAgregarTarifa.IsDisposed)) modalAgregarTarifa = new AgregarTarifa(this);
                    modalAgregarTarifa.Show();
                    break;
                case "PEDIDOS":
                    if (modalAgregarPedido == null || (modalAgregarPedido != null && modalAgregarPedido.IsDisposed)) modalAgregarPedido = new AgregarPedido(this);
                    modalAgregarPedido.Show();
                    break;
                case "VIAJES":
                    if (modalAgregarViaje == null || (modalAgregarViaje != null && modalAgregarViaje.IsDisposed)) modalAgregarViaje = new AgregarViaje(this);
                    modalAgregarViaje.Show();
                    break;
                case "HISTORIAL":
                    //if (modalAgregarTarifa == null || (modalAgregarTarifa != null && modalAgregarTarifa.IsDisposed)) modalAgregarTarifa = new AgregarTarifa(this);
                    //modalAgregarTarifa.Show();
                    break;
            }

        }

        //SELECCIONAR UN REGISTRO
        private void dgTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRegistro = 0;
            try
            {
                //Obtiene el Id del registro que se esta seleccionando
                if (e != null && e.RowIndex != -1)
                {
                    DataGridViewRow row = dgTabla.Rows[e.RowIndex];
                    idRegistro = Convert.ToInt32(row.Cells[0].Value.ToString());
                    limpiaColorRows();
                    coloreaRow(row);

                    switch (CatalogoActual)
                    {
                        case "DASHBOARD":

                            break;
                        case "CLIENTES":
                            ClienteActual = ObtenCliente(idRegistro);
                            break;
                        case "SUCURSALES":
                            SucursalActual = ObtenSucursal(idRegistro);
                            break;
                        case "UNIDADES":
                            UnidadActual = ObtenUnidad(idRegistro);
                            break;
                        case "TRANSPORTISTAS":
                            TransportistaActual = ObtenTransportista(idRegistro);
                            break;
                        case "RUTAS":
                            RutaActual = ObtenRuta(idRegistro);
                            break;
                        case "TARIFAS":
                            TarifaActual = ObtenTarifa(idRegistro);
                            break;
                        case "PEDIDOS":
                            PedidoActual = ObtenPedido(idRegistro);
                            break;
                        case "VIAJES":
                            ViajeActual = ObtenViaje(idRegistro);
                            break;

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al seleccionar el registro" + error.Message);
            }
        }

        //EDITAR UN REGISTRO
        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (CatalogoActual)
            {
                case "CLIENTES":
                    if (modalAgregarCliente == null || (modalAgregarCliente != null && modalAgregarCliente.IsDisposed)) modalAgregarCliente = new AgregarCliente(this);
                    if (ClienteActual != null) modalAgregarCliente.Show(ClienteActual, "EDITAR");
                    break;
                case "SUCURSALES":
                    if (modalAgregarSucursal == null || (modalAgregarSucursal != null && modalAgregarSucursal.IsDisposed)) modalAgregarSucursal = new AgregarSucursal(this);
                    if (SucursalActual != null) modalAgregarSucursal.Show(SucursalActual, "EDITAR");
                    break;
                case "TRANSPORTISTAS":
                    if (modalAgregarTransportista == null || (modalAgregarTransportista != null && modalAgregarTransportista.IsDisposed)) modalAgregarTransportista = new AgregarTransportista(this);
                    if (TransportistaActual != null) modalAgregarTransportista.Show(TransportistaActual, "EDITAR");
                    break;
                case "UNIDADES":
                    if (modalAgregarUnidad == null || (modalAgregarUnidad != null && modalAgregarUnidad.IsDisposed)) modalAgregarUnidad = new AgregarUnidad(this);
                    if (UnidadActual != null) modalAgregarUnidad.Show(UnidadActual, "EDITAR");
                    break;
                case "RUTAS":
                    if (modalAgregarRuta == null || (modalAgregarRuta != null && modalAgregarRuta.IsDisposed)) modalAgregarRuta = new AgregarRuta(this);
                    if (RutaActual != null) modalAgregarRuta.Show(RutaActual, "EDITAR");
                    break;
                case "TARIFAS":
                    //if (modalAgregarTarifa == null || (modalAgregarTarifa != null && modalAgregarTarifa.IsDisposed)) modalAgregarTarifa = new AgregarTarifa(this);
                    //if (TarifaActual != null) modalAgregarTarifa.Show(TarifaActual, "EDITAR");
                    break;
                case "PEDIDOS":
                    if (modalAgregarPedido == null || (modalAgregarPedido != null && modalAgregarPedido.IsDisposed)) modalAgregarPedido = new AgregarPedido(this);
                    if (PedidoActual != null) modalAgregarPedido.Show(PedidoActual, "EDITAR");
                    break;
                case "VIAJES":
                    //if (modalAgregarRuta == null || (modalAgregarRuta != null && modalAgregarRuta.IsDisposed)) modalAgregarRuta = new AgregarRuta(this);
                    //if (RutaActual != null) modalAgregarRuta.Show(RutaActual, "EDITAR");
                    break;
            }
        }

        //ELIMINAR UN REGISTRO       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (CatalogoActual)
            {
                case "CLIENTES":
                    if (modalAgregarCliente == null || (modalAgregarCliente != null && modalAgregarCliente.IsDisposed)) modalAgregarCliente = new AgregarCliente(this);
                    if (ClienteActual != null) modalAgregarCliente.Show(ClienteActual, "ELIMINAR");
                    break;
                case "SUCURSALES":
                    if (modalAgregarSucursal == null || (modalAgregarSucursal != null && modalAgregarSucursal.IsDisposed)) modalAgregarSucursal = new AgregarSucursal(this);
                    if (SucursalActual != null) modalAgregarSucursal.Show(SucursalActual, "ELIMINAR");
                    break;
                case "UNIDADES":
                    if (modalAgregarUnidad == null || (modalAgregarUnidad != null && modalAgregarUnidad.IsDisposed)) modalAgregarUnidad = new AgregarUnidad(this);
                    if (UnidadActual != null) modalAgregarUnidad.Show(UnidadActual, "ELIMINAR");
                    break;
                case "TRANSPORTISTAS":
                    if (modalAgregarTransportista == null || (modalAgregarTransportista != null && modalAgregarTransportista.IsDisposed)) modalAgregarTransportista = new AgregarTransportista(this);
                    if (TransportistaActual != null) modalAgregarTransportista.Show(TransportistaActual, "ELIMINAR");
                    break;
                case "RUTAS":
                    if (modalAgregarRuta == null || (modalAgregarRuta != null && modalAgregarRuta.IsDisposed)) modalAgregarRuta = new AgregarRuta(this);
                    if (RutaActual != null) modalAgregarRuta.Show(RutaActual, "ELIMINAR");
                    break;
                case "TARIFAS":
                    if (modalAgregarTarifa == null || (modalAgregarTarifa != null && modalAgregarTarifa.IsDisposed)) modalAgregarTarifa = new AgregarTarifa(this);
                    if (TarifaActual != null) modalAgregarTarifa.Show(TarifaActual, "ELIMINAR");
                    break;
                case "PEDIDOS":
                    if (modalAgregarPedido == null || (modalAgregarPedido != null && modalAgregarPedido.IsDisposed)) modalAgregarPedido = new AgregarPedido(this);
                    if (PedidoActual != null) modalAgregarPedido.Show(PedidoActual, "ELIMINAR");
                    break;
                case "VIAJES":
                    if (modalAgregarViaje == null || (modalAgregarViaje != null && modalAgregarViaje.IsDisposed)) modalAgregarViaje = new AgregarViaje(this);
                    if (ViajeActual != null) modalAgregarViaje.Show(ViajeActual, "ELIMINAR");
                    break;
            }
        }

        public void limpiaColorRows()
        {
            DataGridViewRowCollection rows = dgTabla.Rows;
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();

            foreach (DataGridViewRow row in rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    c.Style = CellStyle;
                }
            }
        }

        public void coloreaRow(DataGridViewRow row)
        {
            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            CellStyle.BackColor = Color.DodgerBlue;

            foreach (DataGridViewCell c in row.Cells)
            {
                c.Style = CellStyle;
            }
        }


        //Funciones para CRUD de todos los catalogos
        #region Clientes
        public void GuardaCliente(Cliente cliente)
        {

            string queryInsertar = "INSERT INTO Informacion.Cliente (RazonSocial,NombreComercial,Tipo,Direccion,PorcentajeVenta,Estatus) VALUES(@razonSocial,@nombreComercial,@tipo,@direccion,@porcentajeVenta,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                comando.Parameters.AddWithValue("@nombreComercial", cliente.NombreComercial);
                comando.Parameters.AddWithValue("@tipo", cliente.Tipo);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@porcentajeVenta", cliente.PorcentajeVenta);
                comando.Parameters.AddWithValue("@estatus", cliente.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Cliente");
                modalAgregarCliente.Hide();
                modalAgregarCliente = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaCliente(Cliente cliente)
        {

            string queryInsertar = "UPDATE Informacion.Cliente SET RazonSocial = @razonSocial,NombreComercial = @nombreComercial,Tipo = @tipo,Direccion = @direccion,PorcentajeVenta = @porcentajeVenta WHERE IdCliente = @idCliente";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idCliente", ClienteActual.IdCliente);
                comando.Parameters.AddWithValue("@razonSocial", cliente.RazonSocial);
                comando.Parameters.AddWithValue("@nombreComercial", cliente.NombreComercial);
                comando.Parameters.AddWithValue("@tipo", cliente.Tipo);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@porcentajeVenta", cliente.PorcentajeVenta);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Cliente");
                ClienteActual = ObtenCliente(ClienteActual.IdCliente);
                modalAgregarCliente.Hide();
                modalAgregarCliente = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaCliente(Cliente cliente)
        {

            string queryInsertar = "UPDATE Informacion.Cliente SET Estatus = @estatus  WHERE IdCliente = @idCliente";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idCliente", ClienteActual.IdCliente);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Cliente");
                ClienteActual = ObtenCliente(ClienteActual.IdCliente);
                modalAgregarCliente.Hide();
                modalAgregarCliente = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Cliente ObtenCliente(int IDCliente)
        {
            Cliente cliente = null;

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Cliente WHERE IDCliente = @idcliente");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idcliente", IDCliente);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        string tipo = lector["Tipo"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        double porcentajeVenta = Convert.ToDouble(lector["PorcentajeVenta"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        cliente = new Cliente(IDCliente, razonSocial, nombreComercial, tipo, direccion, porcentajeVenta, estatus);
                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return cliente;
        }

        public List<Cliente> ObtenClientesFiscales()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Cliente WHERE Estatus = @estatus and Tipo = @tipo");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");
                comando.Parameters.AddWithValue("@tipo", "FISCAL");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idcliente = Convert.ToInt32(lector["IdCliente"].ToString());
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        string tipo = lector["Tipo"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        double porcentajeVenta = Convert.ToDouble(lector["PorcentajeVenta"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Cliente cliente = new Cliente(idcliente, razonSocial, nombreComercial, tipo, direccion, porcentajeVenta, estatus);
                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return clientes;
        }

        public List<Cliente> ObtenClientesOrigen()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Cliente WHERE Estatus = @estatus and Tipo = @tipo");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");
                comando.Parameters.AddWithValue("@tipo", "ORIGEN");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idcliente = Convert.ToInt32(lector["IdCliente"].ToString());
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        string tipo = lector["Tipo"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        double porcentajeVenta = Convert.ToDouble(lector["PorcentajeVenta"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Cliente cliente = new Cliente(idcliente, razonSocial, nombreComercial, tipo, direccion, porcentajeVenta, estatus);
                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return clientes;
        }

        public List<Cliente> ObtenClientesDestino()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Cliente WHERE Estatus = @estatus and Tipo = @tipo");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");
                comando.Parameters.AddWithValue("@tipo", "DESTINO");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idcliente = Convert.ToInt32(lector["IdCliente"].ToString());
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        string tipo = lector["Tipo"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        double porcentajeVenta = Convert.ToDouble(lector["PorcentajeVenta"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Cliente cliente = new Cliente(idcliente, razonSocial, nombreComercial, tipo, direccion, porcentajeVenta, estatus);
                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return clientes;
        }
        #endregion

        #region Sucursales
        public void GuardaSucursal(Sucursal sucursal)
        {

            string queryInsertar = "INSERT INTO Informacion.Sucursal (Nombre,Direccion,Estatus) VALUES(@nombre,@direccion,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@nombre", sucursal.Nombre);
                comando.Parameters.AddWithValue("@direccion", sucursal.Direccion);
                comando.Parameters.AddWithValue("@estatus", sucursal.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Sucursal");
                modalAgregarSucursal.Hide();
                modalAgregarSucursal = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaSucursal(Sucursal sucursal)
        {

            string queryInsertar = "UPDATE Informacion.Sucursal SET Nombre = @nombre,Direccion = @direccion WHERE IdSucursal = @idSucursal";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idSucursal", SucursalActual.IdSucursal);
                comando.Parameters.AddWithValue("@nombre", sucursal.Nombre);
                comando.Parameters.AddWithValue("@direccion", sucursal.Direccion);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Sucursal");
                SucursalActual = ObtenSucursal(SucursalActual.IdSucursal);
                modalAgregarSucursal.Hide();
                modalAgregarSucursal = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaSucursal(Sucursal sucursal)
        {

            string queryInsertar = "UPDATE Informacion.Sucursal SET Estatus = @estatus  WHERE IdSucursal = @idSucursal";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idSucursal", SucursalActual.IdSucursal);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Sucursal");
                SucursalActual = ObtenSucursal(SucursalActual.IdSucursal);
                modalAgregarSucursal.Hide();
                modalAgregarSucursal = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Sucursal ObtenSucursal(int IDSucursal)
        {
            Sucursal sucursal = null;

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Sucursal WHERE IdSucursal = @idSucursal");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idSucursal", IDSucursal);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        string estatus = lector["Estatus"].ToString();
                        sucursal = new Sucursal(IDSucursal, nombre, direccion, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return sucursal;
        }

        public List<Sucursal> ObtenSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Sucursal WHERE Estatus = @estatus");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idsucursal = Convert.ToInt32(lector["IdSucursal"].ToString());
                        string nombre = lector["Nombre"].ToString();
                        string direccion = lector["Direccion"].ToString();
                        string estatus = lector["Estatus"].ToString();
                        Sucursal sucursal = new Sucursal(idsucursal, nombre, direccion, estatus);
                        sucursales.Add(sucursal);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return sucursales;
        }
        #endregion

        #region Transportistas
        public void GuardaTransportista(Transportista transportista)
        {

            string queryInsertar = "INSERT INTO Informacion.Transportista (RazonSocial,NombreComercial,Comision,Estatus) VALUES(@razonSocial,@nombreComercial,@comision,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@razonSocial", transportista.RazonSocial);
                comando.Parameters.AddWithValue("@nombreComercial", transportista.NombreComercial);
                comando.Parameters.AddWithValue("@comision", transportista.Comision);
                comando.Parameters.AddWithValue("@estatus", transportista.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Transportista");
                modalAgregarTransportista.Hide();
                modalAgregarTransportista = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaTransportista(Transportista transportista)
        {

            string queryInsertar = "UPDATE Informacion.Transportista SET RazonSocial = @razonSocial,NombreComercial = @nombreComercial, Comision = @comision WHERE IdTransportista = @idTransportista";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idTransportista", TransportistaActual.IdTransportista);
                comando.Parameters.AddWithValue("@razonSocial", transportista.RazonSocial);
                comando.Parameters.AddWithValue("@nombreComercial", transportista.NombreComercial);
                comando.Parameters.AddWithValue("@comision", transportista.Comision);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Transportista");
                TransportistaActual = ObtenTransportista(TransportistaActual.IdTransportista);
                modalAgregarTransportista.Hide();
                modalAgregarTransportista = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaTransportista(Transportista transportista)
        {

            string queryInsertar = "UPDATE Informacion.Transportista SET Estatus = @estatus  WHERE IdTransportista = @idTransportista";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idTransportista", TransportistaActual.IdTransportista);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Transportista");
                TransportistaActual = ObtenTransportista(TransportistaActual.IdTransportista);
                modalAgregarTransportista.Hide();
                modalAgregarTransportista = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Transportista ObtenTransportista(int IDTransportista)
        {
            Transportista transportista = null;

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Transportista WHERE IdTransportista = @idTransportista");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idTransportista", IDTransportista);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        double comision = Convert.ToDouble(lector["Comision"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        transportista = new Transportista(IDTransportista, razonSocial, nombreComercial, comision, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return transportista;
        }

        public List<Transportista> ObtenTransportistas()
        {
            List<Transportista> transportistas = new List<Transportista>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Transportista WHERE Estatus = @estatus");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idTransportista = Convert.ToInt32(lector["IdTransportista"].ToString());
                        string razonSocial = lector["RazonSocial"].ToString();
                        string nombreComercial = lector["NombreComercial"].ToString();
                        double comision = Convert.ToDouble(lector["Comision"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Transportista transportista = new Transportista(idTransportista, razonSocial, nombreComercial, comision, estatus);
                        transportistas.Add(transportista);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return transportistas;
        }
        #endregion

        #region Unidades
        public void GuardaUnidad(Unidad unidad)
        {

            string queryInsertar = "INSERT INTO Informacion.Unidad (IdTransportista,Nombre,Placas,PesoMaximo,CostoXKilometro,Estatus) VALUES(@idTransportista,@nombre,@placas,@pesoMaximo,@costoxKilometro,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idTransportista", unidad.IdTransportista);
                comando.Parameters.AddWithValue("@nombre", unidad.Nombre);
                comando.Parameters.AddWithValue("@placas", unidad.Placas);
                comando.Parameters.AddWithValue("@pesoMaximo", unidad.PesoMaximo);
                comando.Parameters.AddWithValue("@costoxKilometro", unidad.CostoxKilometro);
                comando.Parameters.AddWithValue("@estatus", unidad.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "View_Unidad");
                modalAgregarUnidad.Hide();
                modalAgregarUnidad = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaUnidad(Unidad unidad)
        {

            string queryInsertar = "UPDATE Informacion.Unidad SET IdTransportista = @idTransportista,Nombre = @nombre,Placas = @placas, PesoMaximo = @pesoMaximo, CostoXKilometro = @costoxKilometro WHERE IdUnidad = @idUnidad";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idUnidad", UnidadActual.IdUnidad);
                comando.Parameters.AddWithValue("@idTransportista", unidad.IdTransportista);
                comando.Parameters.AddWithValue("@nombre", unidad.Nombre);
                comando.Parameters.AddWithValue("@placas", unidad.Placas);
                comando.Parameters.AddWithValue("@pesoMaximo", unidad.PesoMaximo);
                comando.Parameters.AddWithValue("@costoxKilometro", unidad.CostoxKilometro);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "View_Unidad");
                UnidadActual = ObtenUnidad(UnidadActual.IdUnidad);
                modalAgregarUnidad.Hide();
                modalAgregarUnidad = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaUnidad(Unidad unidad)
        {

            string queryInsertar = "UPDATE Informacion.Unidad SET Estatus = @estatus  WHERE IdUnidad = @idUnidad";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idUnidad", UnidadActual.IdUnidad);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "View_Unidad");
                UnidadActual = ObtenUnidad(UnidadActual.IdUnidad);
                modalAgregarUnidad.Hide();
                modalAgregarUnidad = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Unidad ObtenUnidad(int IDUnidad)
        {
            Unidad unidad = null;

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Unidad WHERE IdUnidad = @idUnidad");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idUnidad", IDUnidad);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idTransportista = Convert.ToInt32(lector["IdTransportista"].ToString());
                        string nombre = lector["Nombre"].ToString();
                        string placas = lector["Placas"].ToString();
                        double pesoMaximo = Convert.ToDouble(lector["PesoMaximo"].ToString());
                        double costoxKilometro = Convert.ToDouble(lector["CostoXKilometro"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        unidad = new Unidad(IDUnidad, idTransportista, nombre, placas, pesoMaximo, costoxKilometro, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return unidad;
        }

        public List<Unidad> ObtenUnidades()
        {
            List<Unidad> unidades = new List<Unidad>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Unidad WHERE Estatus = @estatus");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idunidad = Convert.ToInt32(lector["IdUnidad"].ToString());
                        int idtransportista = Convert.ToInt32(lector["IdTransportista"].ToString());
                        string nombre = lector["Nombre"].ToString();
                        string placas = lector["Placas"].ToString();
                        double pesomaximo = Convert.ToDouble(lector["PesoMaximo"].ToString());
                        double costoxkilometros = Convert.ToDouble(lector["CostoXKilometro"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Unidad unidad = new Unidad(idunidad, idtransportista, nombre, placas, pesomaximo, costoxkilometros, estatus);
                        unidades.Add(unidad);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return unidades;
        }
        #endregion

        #region Rutas
        public void GuardaRuta(Ruta ruta)
        {

            string queryInsertar = "INSERT INTO Informacion.Ruta (EstadoOrigen,EstadoDestino,CPOrigen,CPDestino,Kilometros,Estatus) VALUES(@estadoorigen,@estadodestino,@cporigen,@cpdestino,@kilometros,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@estadoorigen", ruta.EstadoOrigen);
                comando.Parameters.AddWithValue("@estadodestino", ruta.EstadoDestino);
                comando.Parameters.AddWithValue("@cporigen", ruta.CPOrigen);
                comando.Parameters.AddWithValue("@cpdestino", ruta.CPDestino);
                comando.Parameters.AddWithValue("@kilometros", ruta.Kilometros);
                comando.Parameters.AddWithValue("@estatus", ruta.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Ruta");
                modalAgregarRuta.Hide();
                modalAgregarRuta = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaRuta(Ruta ruta)
        {

            string queryInsertar = "UPDATE Informacion.Ruta SET EstadoOrigen = @estadoorigen,EstadoDestino = @estadodestino,CPOrigen = @cporigen , CPDestino = @cpdestino, Kilometros = @kilometros WHERE IdRuta = @idruta";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idruta", RutaActual.IdRuta);
                comando.Parameters.AddWithValue("@estadoorigen", ruta.EstadoOrigen);
                comando.Parameters.AddWithValue("@estadodestino", ruta.EstadoDestino);
                comando.Parameters.AddWithValue("@cporigen", ruta.CPOrigen);
                comando.Parameters.AddWithValue("@cpdestino", ruta.CPDestino);
                comando.Parameters.AddWithValue("@kilometros", ruta.Kilometros);
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Ruta");
                RutaActual = ObtenRuta(RutaActual.IdRuta);
                modalAgregarRuta.Hide();
                modalAgregarRuta = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaRuta(Ruta ruta)
        {

            string queryInsertar = "UPDATE Informacion.Ruta SET Estatus = @estatus  WHERE IdRuta = @idruta";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idruta", RutaActual.IdRuta);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Informacion", "Ruta");
                RutaActual = ObtenRuta(RutaActual.IdRuta);
                modalAgregarRuta.Hide();
                modalAgregarRuta = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Ruta ObtenRuta(int IDRuta)
        {
            Ruta ruta = null;

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Ruta WHERE IdRuta = @idruta");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idruta", IDRuta);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string estadoorigen = lector["EstadoOrigen"].ToString();
                        string estadodestino = lector["EstadoDestino"].ToString();
                        int cporigen = Convert.ToInt32(lector["CPOrigen"].ToString());
                        int cpdestino = Convert.ToInt32(lector["CPDestino"].ToString());
                        double kilometros = Convert.ToDouble(lector["Kilometros"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        ruta = new Ruta(IDRuta, estadoorigen, estadodestino, cporigen, cpdestino, kilometros, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return ruta;
        }

        public List<Ruta> ObtenRutas()
        {
            List<Ruta> rutas = new List<Ruta>();

            try
            {
                string query = string.Format("SELECT * FROM Informacion.Ruta WHERE Estatus = @estatus");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", "ACTIVO");

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idruta = Convert.ToInt32(lector["IdRuta"].ToString());
                        string estadoorigen = lector["EstadoOrigen"].ToString();
                        string estadodestino = lector["EstadoDestino"].ToString();
                        int cporigen = Convert.ToInt32(lector["CPOrigen"].ToString());
                        int cpdestino = Convert.ToInt32(lector["CPDestino"].ToString());
                        double kilometros = Convert.ToDouble(lector["Kilometros"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Ruta ruta = new Ruta(idruta, estadoorigen, estadodestino, cporigen, cpdestino, kilometros, estatus);
                        rutas.Add(ruta);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return rutas;
        }
        #endregion

        #region Tarifas
        public void GuardaTarifa(Tarifa tarifa)
        {

            string queryInsertar = "INSERT INTO Operacion.Tarifa (IdRuta,IdUnidad,IdClienteFiscal,Estatus) VALUES(@idruta,@idunidad,@idclientefiscal,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idruta", tarifa.IdRuta);
                comando.Parameters.AddWithValue("@idunidad", tarifa.IdUnidad);
                comando.Parameters.AddWithValue("@idclientefiscal", tarifa.IdClienteFiscal);
                comando.Parameters.AddWithValue("@estatus", tarifa.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Tarifa");
                modalAgregarTarifa.Hide();
                modalAgregarTarifa = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaTarifa(Tarifa tarifa)
        {

            string queryInsertar = "UPDATE Operacion.Tarifa SET IdRuta = @idruta,IdUnidad = @idunidad,IdClienteFiscal = @idclientefiscal WHERE IdTarifa = @idtarifa";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idtarifa", tarifa.IdTarifa);
                comando.Parameters.AddWithValue("@idruta", tarifa.IdRuta);
                comando.Parameters.AddWithValue("@idunidad", tarifa.IdUnidad);
                comando.Parameters.AddWithValue("@idclientefiscal", tarifa.IdClienteFiscal);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Tarifa");
                TarifaActual = ObtenTarifa(TarifaActual.IdTarifa);
                modalAgregarTarifa.Hide();
                modalAgregarTarifa = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaTarifa(Tarifa tarifa)
        {

            string queryInsertar = "UPDATE Operacion.Tarifa SET Estatus = @estatus  WHERE IdTarifa = @idtarifa";
                
            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idtarifa", TarifaActual.IdTarifa);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Tarifa");
                TarifaActual = ObtenTarifa(TarifaActual.IdTarifa);
                modalAgregarTarifa.Hide();
                modalAgregarTarifa = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Tarifa ObtenTarifa(int IDTarifa)
        {
            Tarifa tarifa = null;

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Tarifa WHERE IdTarifa = @idtarifa");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idtarifa", IDTarifa);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idruta = Convert.ToInt32(lector["IdRuta"].ToString());
                        int idunidad = Convert.ToInt32(lector["IdUnidad"].ToString());
                        int idclientefiscal = Convert.ToInt32(lector["IdClienteFiscal"].ToString());
                        double precio = Convert.ToDouble(lector["PrecioACliente"].ToString());
                        double costo = Convert.ToDouble(lector["CostoATransportista"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        tarifa = new Tarifa(IDTarifa, idruta, idunidad, idclientefiscal, precio, costo, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return tarifa;
        }

        #endregion

        #region Pedidos
        public void GuardaPedido(Pedido pedido)
        {

            string queryInsertar = "INSERT INTO Operacion.Pedido (IdClienteOrigen,IdClienteDestino,Delivery,Peso,Piezas,Estatus) VALUES(@idclienteorigen,@idclientedestino,@delivery,@peso,@piezas,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idclienteorigen", pedido.IdClienteOrigen);
                comando.Parameters.AddWithValue("@idclientedestino", pedido.IdClienteDestino);
                comando.Parameters.AddWithValue("@delivery", pedido.Delivery);
                comando.Parameters.AddWithValue("@peso", pedido.Peso);
                comando.Parameters.AddWithValue("@piezas", pedido.Piezas);
                comando.Parameters.AddWithValue("@estatus", pedido.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Pedido");
                modalAgregarPedido.Hide();
                modalAgregarPedido = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public void EditaPedido(Pedido pedido)
        {

            string queryInsertar = "UPDATE Operacion.Pedido SET IdClienteOrigen = @idclienteorigen,IdClienteDestino = @idclientedestino,Delivery = @delivery,Peso = @peso, Piezas = @piezas WHERE IdPedido = @idpedido";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idpedido", pedido.IdPedido);
                comando.Parameters.AddWithValue("@idclienteorigen", pedido.IdClienteOrigen);
                comando.Parameters.AddWithValue("@idclientedestino", pedido.IdClienteDestino);
                comando.Parameters.AddWithValue("@delivery", pedido.Delivery);
                comando.Parameters.AddWithValue("@peso", pedido.Peso);
                comando.Parameters.AddWithValue("@piezas", pedido.Piezas);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Pedido");
                PedidoActual = ObtenPedido(PedidoActual.IdPedido);
                modalAgregarPedido.Hide();
                modalAgregarPedido = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EditaPedidoIdViaje(Pedido pedido, int IDViaje)
        {

            string queryInsertar = "UPDATE Operacion.Pedido SET IdViaje = @idviaje WHERE IdPedido = @idpedido";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idpedido", pedido.IdPedido);
                comando.Parameters.AddWithValue("@idviaje", IDViaje);
                comando.ExecuteNonQuery();
                PedidoActual = ObtenPedido(pedido.IdPedido);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EditaPedidosIdViaje(List<Pedido> pedidos, int IDViaje)
        {

            try
            {
                foreach (Pedido p in pedidos)
                {
                    EditaPedidoIdViaje(p, IDViaje);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaPedido(Pedido pedido)
        {

            string queryInsertar = "UPDATE Operacion.Pedido SET Estatus = @estatus  WHERE IdPedido = @idpedido";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idpedido", PedidoActual.IdPedido);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Pedido");
                PedidoActual = ObtenPedido(PedidoActual.IdPedido);
                modalAgregarPedido.Hide();
                modalAgregarPedido = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Pedido ObtenPedido(int IDPedido)
        {
            Pedido pedido = null;

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Pedido WHERE IdPedido = @idpedido");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idpedido", IDPedido);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idpedido = Convert.ToInt32(lector["IdPedido"].ToString());
                        int idclienteorigen = Convert.ToInt32(lector["IdClienteOrigen"].ToString());
                        int idclientedestino = Convert.ToInt32(lector["IdClienteDestino"].ToString());
                        string stridviaje = lector["IdViaje"].ToString();
                        int idviaje = (stridviaje != "" ? Convert.ToInt32(stridviaje) : 0);
                        string delivery = lector["Delivery"].ToString();
                        double peso = Convert.ToDouble(lector["Peso"].ToString());
                        double piezas = Convert.ToDouble(lector["Piezas"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        pedido = new Pedido(IDPedido, idclienteorigen, idclientedestino, idviaje, delivery, peso, piezas, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return pedido;
        }
        public List<Pedido> ObtenPedidos(string status = "ACTIVO")
        {
            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Pedido WHERE Estatus = @estatus");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@estatus", status);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idpedido = Convert.ToInt32(lector["IdPedido"].ToString());
                        int idclienteorigen = Convert.ToInt32(lector["IdClienteOrigen"].ToString());
                        int idclientedestino = Convert.ToInt32(lector["IdClienteDestino"].ToString());
                        string stridviaje = lector["IdViaje"].ToString();
                        int idviaje = (stridviaje != "" ? Convert.ToInt32(lector["IdViaje"].ToString()) : 0);
                        string delivery = lector["Delivery"].ToString();
                        double peso = Convert.ToDouble(lector["Peso"].ToString());
                        double piezas = Convert.ToDouble(lector["Piezas"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Pedido pedido = new Pedido(idpedido, idclienteorigen, idclientedestino, idviaje, delivery, peso, piezas, estatus);
                        pedidos.Add(pedido);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return pedidos;
        }

        public List<Pedido> ObtenPedidosxViaje(int IDViaje)
        {
            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Pedido WHERE IdViaje = @idviaje");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idviaje", IDViaje);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idpedido = Convert.ToInt32(lector["IdPedido"].ToString());
                        int idclienteorigen = Convert.ToInt32(lector["IdClienteOrigen"].ToString());
                        int idclientedestino = Convert.ToInt32(lector["IdClienteDestino"].ToString());
                        int idviaje = Convert.ToInt32(lector["IdViaje"].ToString());
                        string delivery = lector["Delivery"].ToString();
                        double peso = Convert.ToDouble(lector["Peso"].ToString());
                        double piezas = Convert.ToDouble(lector["Piezas"].ToString());
                        string estatus = lector["Estatus"].ToString();
                        Pedido pedido = new Pedido(idpedido, idclienteorigen, idclientedestino, idviaje, delivery, peso, piezas, estatus);
                        pedidos.Add(pedido);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return pedidos;
        }
        #endregion

        #region Viajes
        public void GuardaViaje(Viaje viaje)
        {

            string queryInsertar = "INSERT INTO Operacion.Viaje (IdSucursal,IdRuta,Folio,PesoTotal,Estatus) VALUES(@idsucursal,@idruta,@folio,@pesototal,@estatus)";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idsucursal", viaje.IdSucursal);
                comando.Parameters.AddWithValue("@idruta", viaje.IdRuta);
                comando.Parameters.AddWithValue("@folio", viaje.Folio);
                comando.Parameters.AddWithValue("@pesototal", viaje.PesoTotal);
                comando.Parameters.AddWithValue("@estatus", viaje.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Viaje");
                modalAgregarViaje.Hide();
                modalAgregarViaje = null;

            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }


        }

        public void EditaViaje(Viaje viaje)
        {

            string queryInsertar = "UPDATE Operacion.Viaje SET Estatus = @estatus WHERE IdViaje = @idviaje";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idviaje", viaje.IdViaje);
                comando.Parameters.AddWithValue("@estatus", viaje.Estatus);
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Viaje");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al editar", err.Message);
            }
        }

        public void EliminaViaje(Viaje viaje)
        {

            string queryInsertar = "UPDATE Operacion.Viaje SET Estatus = @estatus  WHERE IdViaje = @idviaje";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsertar, ConnectionSQL);
                comando.Parameters.AddWithValue("@idviaje", ViajeActual.IdViaje);
                comando.Parameters.AddWithValue("@estatus", "CANCELADO");
                comando.ExecuteNonQuery();
                GetAllData("Operacion", "View_Viaje");
                ViajeActual = ObtenViaje(ViajeActual.IdViaje);
                modalAgregarViaje.Hide();
                modalAgregarViaje = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ha ocurrido un error al insertar", err.Message);
            }
        }

        public Viaje ObtenViaje(int IDViaje)
        {
            Viaje viaje = null;

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Viaje WHERE IdViaje = @idviaje");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@idviaje", IDViaje);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idviaje = Convert.ToInt32(lector["IdViaje"].ToString());
                        int idsucursal = Convert.ToInt32(lector["IdSucursal"].ToString());
                        int idruta = Convert.ToInt32(lector["IdRuta"].ToString());
                        string stridtarifa = lector["IdTarifa"].ToString();
                        int idtarifa = (stridtarifa != "") ? Convert.ToInt32(stridtarifa) : 0;
                        string folio = lector["Folio"].ToString();
                        string strpesototal = lector["PesoTotal"].ToString();
                        double pesototal = (strpesototal != "") ? Convert.ToDouble(lector["PesoTotal"].ToString()) : 0;
                        string estatus = lector["Estatus"].ToString();
                        viaje = new Viaje(IDViaje, idsucursal, idruta, idtarifa, folio, pesototal, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return viaje;
        }

        public Viaje ObtenViaje(string Folio)
        {
            Viaje viaje = null;

            try
            {
                string query = string.Format("SELECT * FROM Operacion.Viaje WHERE Folio = @folio");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);
                comando.Parameters.AddWithValue("@folio", Folio);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        int idviaje = Convert.ToInt32(lector["IdViaje"].ToString());
                        int idsucursal = Convert.ToInt32(lector["IdSucursal"].ToString());
                        int idruta = Convert.ToInt32(lector["IdRuta"].ToString());
                        string stridtarifa = lector["IdTarifa"].ToString();
                        int idtarifa = (stridtarifa != "") ? Convert.ToInt32(stridtarifa) : 0;
                        string folio = lector["Folio"].ToString();
                        string strpesototal = lector["PesoTotal"].ToString();
                        double pesototal = (strpesototal != "") ? Convert.ToDouble(lector["PesoTotal"].ToString()) : 0;
                        string estatus = lector["Estatus"].ToString();
                        viaje = new Viaje(idviaje, idsucursal, idruta, idtarifa, folio, pesototal, estatus);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener el registro" + error.Message);
            }

            return viaje;
        }

        public Viaje ObtenViaje() { return ViajeActual; }

        #endregion

        private void btnEstatusViaje_Click(object sender, EventArgs e)
        {
            string estatusActual = ViajeActual.Estatus;

            if(estatusActual == "ACTIVO")
            {
                ViajeActual.Estatus = "CARGA";
            }else if(estatusActual == "CARGA")
            {
                ViajeActual.Estatus = "RUTA";
            }else if(estatusActual == "RUTA")
            {
                ViajeActual.Estatus = "DESCARGA";
            } else if(estatusActual == "DESCARGA")
            {
                ViajeActual.Estatus = "FINALIZADO";
            }

            EditaViaje(ViajeActual);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTable();
            string path = "C:\\Users\\USUARIO DELL\\Desktop\\ejemplopdf.pdf";
            
            ExportTableToPDF(dt,path,CatalogoActual);
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            dgTabla.Visible = false;
            btnEstatusViaje.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            graficaViajes.Visible = true;
            loadGrafica();
            CatalogoActual = "GRAFICAS";
            txtTitulo.Text = "GRAFICAS";
        }

        public Dictionary<string, int> GetNoViajesxCliente() {

            Dictionary<string, int> noViajesxCliente = new Dictionary<string, int>();

            try
            {
                string query = string.Format("SELECT * FROM Grafica.View_NoViajesxCliente");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        
                       
                        string Cliente = lector["ClienteFiscal"].ToString();
                        int NoViajes = Convert.ToInt32(lector["NoViajes"].ToString());

                        noViajesxCliente.Add(Cliente, NoViajes);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return noViajesxCliente;
        }

        public Dictionary<string, double> GetGananciaxCliente()
        {

            Dictionary<string, double> gananciaxCliente = new Dictionary<string, double>();

            try
            {
                string query = string.Format("SELECT * FROM Grafica.View_GananciaxCliente");
                SqlCommand comando = new SqlCommand(query, ConnectionSQL);

                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string Cliente = lector["Cliente"].ToString();
                        double Ganancia = double.Parse(lector["Ganancia"].ToString());

                        gananciaxCliente.Add(Cliente, Ganancia);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los registros" + error.Message);
            }

            return gananciaxCliente;
        }

        public void loadGrafica() {

            Dictionary<string, int> info1 = GetNoViajesxCliente();
            Dictionary<string, double> info2 = GetGananciaxCliente();

            string[] clientes = info1.Keys.ToArray();
            string[] clientes1 = info2.Keys.ToArray();

            int[] numViajes = info1.Values.ToArray();
            double[] ganancias = info2.Values.ToArray();

            graficaViajes.Series.Clear();
            //graficaViajes.ChartAreas.Clear();
            //graficaViajes.Titles.Clear();

            graficaViajes.Palette = ChartColorPalette.Pastel;
            graficaViajes.Titles.Add("Viajes");
            

            int graf = 0;
            switch (graf)
            {

                case 0:
                    for (int i = 0; i < clientes.Length; i++)
                    {
                        Series series = graficaViajes.Series.Add(clientes[i]);
                        series.Label = numViajes[i].ToString();
                        series.Points.Add(numViajes[i]);
                    }
                    break;
                case 1:
                    for (int i = 0; i < clientes1.Length; i++)
                    {
                        Series series = graficaViajes.Series.Add(clientes1[i]);
                        series.Label = ganancias[i].ToString();
                        series.Points.Add(ganancias[i]);
                    }
                    break;
            }


            
            
        }

        public DataTable GetDataTable() {

            DataTable dt = new DataTable();
            for(int i = 0; i < dgTabla.Columns.Count; i++)
            {
                string col = dgTabla.Columns[i].Name;
                dt.Columns.Add(col);
            }

            for(int i = 0; i < dgTabla.Rows.Count; i++)
            {
                var row = dgTabla.Rows[i];
                List<string> values = new List<string>();
                for(int j = 0; j < row.Cells.Count; j++)
                {
                    var value = row.Cells[j].Value.ToString();
                    values.Add(value);
                }
                dt.Rows.Add(values.ToArray());
            }

            return dt;
        }

        public void ExportTableToPDF(DataTable dt, String path, String title) {

            FileStream fs =
                new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //CREACION PROPIA DEL PDF

            //HEADER
            BaseFont bfHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN,BaseFont.CP1252,BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fnHead = new iTextSharp.text.Font(bfHead, 16, 1, BaseColor.GRAY);
            Paragraph pgHead = new Paragraph();
            pgHead.Alignment = Element.ALIGN_CENTER;
            pgHead.Add(new Chunk(title,fnHead));
            doc.Add(pgHead);

            //AUTOR
            BaseFont bfAutor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fnAutor = new iTextSharp.text.Font(bfHead, 8, 1, BaseColor.GRAY);
            Paragraph pgAutor = new Paragraph();
            pgAutor.Alignment = Element.ALIGN_RIGHT;
            pgAutor.Add(new Chunk("Logistik", fnAutor));
            doc.Add(pgAutor);

            //LINEA SEPARADORA
            Paragraph linea = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_JUSTIFIED, 0)));
            doc.Add(linea);


            //SALTO DE LINEA
            doc.Add(new Chunk("\n", fnHead));

            //TABLA
            PdfPTable table = new PdfPTable(dt.Columns.Count);
            //ENCABEZADO
            BaseFont ColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fnColumnHeader = new iTextSharp.text.Font(ColumnHeader, 10, 1, BaseColor.WHITE);
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dt.Columns[i].ColumnName.ToUpper().ToString(),fnColumnHeader));
                table.AddCell(cell);
            }
            //DATOS
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                for(int j = 0; j < dt.Columns.Count; j++)
                {

                    table.AddCell(dt.Rows[i][j].ToString());
                }
            }

            doc.Add(table);


            doc.Close();
            writer.Close();
            fs.Close();
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idioma = cboIdioma.Text;
            if(idioma == "English")
            {
                Culture = "en-US";
            }
            else if(idioma == "Español")
            {
                Culture = "es";
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Culture);
            CargaLabels();
        }
    }
}
