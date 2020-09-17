using System.Data.SqlClient;
using SistemaDeViajes.Clases;
namespace SistemaDeViajes
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.graficaViajes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEstatusViaje = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnTarifas = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnTransportistas = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.btnPDF);
            this.ContentPanel.Controls.Add(this.graficaViajes);
            this.ContentPanel.Controls.Add(this.btnEstatusViaje);
            this.ContentPanel.Controls.Add(this.btnEliminar);
            this.ContentPanel.Controls.Add(this.btnEditar);
            this.ContentPanel.Controls.Add(this.dgTabla);
            this.ContentPanel.Controls.Add(this.txtTitulo);
            this.ContentPanel.Controls.Add(this.btnAgregar);
            this.ContentPanel.Controls.Add(this.HeaderPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(144, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(786, 484);
            this.ContentPanel.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Gray;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPDF.Location = new System.Drawing.Point(691, 70);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(65, 28);
            this.btnPDF.TabIndex = 22;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // graficaViajes
            // 
            chartArea2.Name = "ChartArea1";
            this.graficaViajes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficaViajes.Legends.Add(legend2);
            this.graficaViajes.Location = new System.Drawing.Point(33, 136);
            this.graficaViajes.Name = "graficaViajes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficaViajes.Series.Add(series2);
            this.graficaViajes.Size = new System.Drawing.Size(343, 277);
            this.graficaViajes.TabIndex = 21;
            this.graficaViajes.Text = "chart1";
            // 
            // btnEstatusViaje
            // 
            this.btnEstatusViaje.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEstatusViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstatusViaje.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstatusViaje.ForeColor = System.Drawing.Color.White;
            this.btnEstatusViaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEstatusViaje.Location = new System.Drawing.Point(400, 136);
            this.btnEstatusViaje.Margin = new System.Windows.Forms.Padding(0);
            this.btnEstatusViaje.Name = "btnEstatusViaje";
            this.btnEstatusViaje.Size = new System.Drawing.Size(153, 28);
            this.btnEstatusViaje.TabIndex = 20;
            this.btnEstatusViaje.Text = "Cambiar Estatus";
            this.btnEstatusViaje.UseVisualStyleBackColor = false;
            this.btnEstatusViaje.Click += new System.EventHandler(this.btnEstatusViaje_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(478, 180);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditar.Location = new System.Drawing.Point(400, 180);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 28);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgTabla
            // 
            this.dgTabla.AllowUserToAddRows = false;
            this.dgTabla.AllowUserToDeleteRows = false;
            this.dgTabla.AllowUserToResizeColumns = false;
            this.dgTabla.AllowUserToResizeRows = false;
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.Location = new System.Drawing.Point(23, 223);
            this.dgTabla.MultiSelect = false;
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.ReadOnly = true;
            this.dgTabla.Size = new System.Drawing.Size(751, 249);
            this.dgTabla.TabIndex = 17;
            this.dgTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTabla_CellClick);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(26, 70);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(213, 38);
            this.txtTitulo.TabIndex = 16;
            this.txtTitulo.Text = "DASHBOARD";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Crimson;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(636, 180);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 28);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Crimson;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(786, 48);
            this.HeaderPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuPanel.Controls.Add(this.btnGraficas);
            this.MenuPanel.Controls.Add(this.btnHistorial);
            this.MenuPanel.Controls.Add(this.btnConfig);
            this.MenuPanel.Controls.Add(this.btnPedidos);
            this.MenuPanel.Controls.Add(this.btnViajes);
            this.MenuPanel.Controls.Add(this.btnTarifas);
            this.MenuPanel.Controls.Add(this.btnRutas);
            this.MenuPanel.Controls.Add(this.btnTransportistas);
            this.MenuPanel.Controls.Add(this.btnSucursales);
            this.MenuPanel.Controls.Add(this.btnUnidades);
            this.MenuPanel.Controls.Add(this.btnClientes);
            this.MenuPanel.Controls.Add(this.btnDash);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(140, 484);
            this.MenuPanel.TabIndex = 1;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Crimson;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHistorial.Location = new System.Drawing.Point(2, 304);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(136, 28);
            this.btnHistorial.TabIndex = 15;
            this.btnHistorial.Text = "Historial Viaje";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Crimson;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfig.Location = new System.Drawing.Point(2, 450);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(136, 28);
            this.btnConfig.TabIndex = 11;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Crimson;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPedidos.Location = new System.Drawing.Point(2, 276);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(136, 28);
            this.btnPedidos.TabIndex = 14;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.BackColor = System.Drawing.Color.Crimson;
            this.btnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViajes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.ForeColor = System.Drawing.Color.White;
            this.btnViajes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViajes.Location = new System.Drawing.Point(2, 248);
            this.btnViajes.Margin = new System.Windows.Forms.Padding(0);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(136, 28);
            this.btnViajes.TabIndex = 11;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.UseVisualStyleBackColor = false;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnTarifas
            // 
            this.btnTarifas.BackColor = System.Drawing.Color.Crimson;
            this.btnTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifas.ForeColor = System.Drawing.Color.White;
            this.btnTarifas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTarifas.Location = new System.Drawing.Point(2, 220);
            this.btnTarifas.Margin = new System.Windows.Forms.Padding(0);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(136, 28);
            this.btnTarifas.TabIndex = 13;
            this.btnTarifas.Text = "Tarifas";
            this.btnTarifas.UseVisualStyleBackColor = false;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.Crimson;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.White;
            this.btnRutas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRutas.Location = new System.Drawing.Point(2, 192);
            this.btnRutas.Margin = new System.Windows.Forms.Padding(0);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(136, 28);
            this.btnRutas.TabIndex = 10;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnTransportistas
            // 
            this.btnTransportistas.BackColor = System.Drawing.Color.Crimson;
            this.btnTransportistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransportistas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportistas.ForeColor = System.Drawing.Color.White;
            this.btnTransportistas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTransportistas.Location = new System.Drawing.Point(2, 164);
            this.btnTransportistas.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransportistas.Name = "btnTransportistas";
            this.btnTransportistas.Size = new System.Drawing.Size(136, 28);
            this.btnTransportistas.TabIndex = 12;
            this.btnTransportistas.Text = "Transportistas";
            this.btnTransportistas.UseVisualStyleBackColor = false;
            this.btnTransportistas.Click += new System.EventHandler(this.btnTransportistas_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.Crimson;
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursales.ForeColor = System.Drawing.Color.White;
            this.btnSucursales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSucursales.Location = new System.Drawing.Point(0, 108);
            this.btnSucursales.Margin = new System.Windows.Forms.Padding(0);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(138, 28);
            this.btnSucursales.TabIndex = 11;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.BackColor = System.Drawing.Color.Crimson;
            this.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidades.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidades.ForeColor = System.Drawing.Color.White;
            this.btnUnidades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUnidades.Location = new System.Drawing.Point(0, 136);
            this.btnUnidades.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(138, 28);
            this.btnUnidades.TabIndex = 10;
            this.btnUnidades.Text = "Unidades";
            this.btnUnidades.UseVisualStyleBackColor = false;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Crimson;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientes.Location = new System.Drawing.Point(0, 80);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(138, 28);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Crimson;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDash.Location = new System.Drawing.Point(0, 52);
            this.btnDash.Margin = new System.Windows.Forms.Padding(0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(138, 28);
            this.btnDash.TabIndex = 8;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Crimson;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(140, 48);
            this.LogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGraficas
            // 
            this.btnGraficas.BackColor = System.Drawing.Color.Crimson;
            this.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficas.ForeColor = System.Drawing.Color.White;
            this.btnGraficas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGraficas.Location = new System.Drawing.Point(2, 422);
            this.btnGraficas.Margin = new System.Windows.Forms.Padding(0);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(136, 28);
            this.btnGraficas.TabIndex = 16;
            this.btnGraficas.Text = "Gráficas";
            this.btnGraficas.UseVisualStyleBackColor = false;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 484);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnTransportistas;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnTarifas;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnAgregar;

        //Custom properties
        string CatalogoActual = "DASHBOARD";
        SqlConnection ConnectionSQL = null;
        public AgregarCliente modalAgregarCliente;
        public AgregarSucursal modalAgregarSucursal;
        public AgregarTransportista modalAgregarTransportista;
        public AgregarUnidad modalAgregarUnidad;
        public AgregarRuta modalAgregarRuta;
        public AgregarTarifa modalAgregarTarifa;
        public AgregarPedido modalAgregarPedido;
        public AgregarViaje modalAgregarViaje;


        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;

        //Variables para obtener la instancia del registro del catalogo actual
        Cliente ClienteActual = null;
        Sucursal SucursalActual = null;
        Transportista TransportistaActual = null;
        Unidad UnidadActual = null;
        Ruta RutaActual = null;
        Tarifa TarifaActual = null;
        Pedido PedidoActual = null;
        Viaje ViajeActual = null;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnEstatusViaje;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaViajes;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnGraficas;
    }
}