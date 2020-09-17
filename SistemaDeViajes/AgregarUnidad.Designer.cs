namespace SistemaDeViajes
{
    partial class AgregarUnidad
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
            this.btnCerrarModal = new System.Windows.Forms.Button();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.txtCostoKilometro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTransportista = new System.Windows.Forms.ComboBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarModal
            // 
            this.btnCerrarModal.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarModal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCerrarModal.ForeColor = System.Drawing.Color.White;
            this.btnCerrarModal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrarModal.Location = new System.Drawing.Point(324, 273);
            this.btnCerrarModal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarModal.Name = "btnCerrarModal";
            this.btnCerrarModal.Size = new System.Drawing.Size(182, 28);
            this.btnCerrarModal.TabIndex = 11;
            this.btnCerrarModal.Text = "Cerrar";
            this.btnCerrarModal.UseVisualStyleBackColor = false;
            this.btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // btnGuardarUnidad
            // 
            this.btnGuardarUnidad.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUnidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarUnidad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUnidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarUnidad.Location = new System.Drawing.Point(59, 273);
            this.btnGuardarUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarUnidad.Name = "btnGuardarUnidad";
            this.btnGuardarUnidad.Size = new System.Drawing.Size(182, 28);
            this.btnGuardarUnidad.TabIndex = 10;
            this.btnGuardarUnidad.Text = "Guardar";
            this.btnGuardarUnidad.UseVisualStyleBackColor = false;
            this.btnGuardarUnidad.Click += new System.EventHandler(this.btnGuardarUnidad_Click);
            // 
            // txtCostoKilometro
            // 
            this.txtCostoKilometro.Location = new System.Drawing.Point(185, 124);
            this.txtCostoKilometro.Name = "txtCostoKilometro";
            this.txtCostoKilometro.Size = new System.Drawing.Size(358, 20);
            this.txtCostoKilometro.TabIndex = 8;
            this.txtCostoKilometro.TextChanged += new System.EventHandler(this.txtCostoKilometro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(181, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Costo por Kilometro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(31, 124);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(136, 20);
            this.txtPesoMaximo.TabIndex = 7;
            this.txtPesoMaximo.TextChanged += new System.EventHandler(this.txtPesoMaximo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transportista";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Maximo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboTransportista
            // 
            this.cboTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransportista.FormattingEnabled = true;
            this.cboTransportista.Location = new System.Drawing.Point(34, 196);
            this.cboTransportista.Name = "cboTransportista";
            this.cboTransportista.Size = new System.Drawing.Size(509, 21);
            this.cboTransportista.TabIndex = 9;
            this.cboTransportista.SelectedIndexChanged += new System.EventHandler(this.cboTransportista_SelectedIndexChanged);
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(300, 59);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(243, 20);
            this.txtPlacas.TabIndex = 6;
            this.txtPlacas.TextChanged += new System.EventHandler(this.txtPlacas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(296, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgregarUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.btnGuardarUnidad);
            this.Controls.Add(this.txtCostoKilometro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTransportista);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "AgregarUnidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUnidad";
            this.Load += new System.EventHandler(this.AgregarUnidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.Button btnGuardarUnidad;
        private System.Windows.Forms.TextBox txtCostoKilometro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTransportista;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;


        //Custom properties
        Inicio FormInicio;
        string Accion;
    }
}