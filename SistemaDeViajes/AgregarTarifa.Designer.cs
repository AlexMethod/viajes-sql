namespace SistemaDeViajes
{
    partial class AgregarTarifa
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
            this.btnGuardarTarifa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRuta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClienteF = new System.Windows.Forms.ComboBox();
            this.txtPrecioACliente = new System.Windows.Forms.TextBox();
            this.txtCostoATransportista = new System.Windows.Forms.TextBox();
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
            this.btnCerrarModal.TabIndex = 23;
            this.btnCerrarModal.Text = "Cerrar";
            this.btnCerrarModal.UseVisualStyleBackColor = false;
            this.btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // btnGuardarTarifa
            // 
            this.btnGuardarTarifa.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTarifa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarTarifa.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTarifa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarTarifa.Location = new System.Drawing.Point(59, 273);
            this.btnGuardarTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarTarifa.Name = "btnGuardarTarifa";
            this.btnGuardarTarifa.Size = new System.Drawing.Size(182, 28);
            this.btnGuardarTarifa.TabIndex = 22;
            this.btnGuardarTarifa.Text = "Guardar";
            this.btnGuardarTarifa.UseVisualStyleBackColor = false;
            this.btnGuardarTarifa.Click += new System.EventHandler(this.btnGuardarTarifa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(32, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ruta";
            // 
            // cboRuta
            // 
            this.cboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuta.FormattingEnabled = true;
            this.cboRuta.Location = new System.Drawing.Point(39, 67);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.Size = new System.Drawing.Size(236, 21);
            this.cboRuta.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(295, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Unidad";
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(299, 67);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(243, 21);
            this.cboUnidad.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cliente Fiscal";
            // 
            // cboClienteF
            // 
            this.cboClienteF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteF.FormattingEnabled = true;
            this.cboClienteF.Location = new System.Drawing.Point(39, 126);
            this.cboClienteF.Name = "cboClienteF";
            this.cboClienteF.Size = new System.Drawing.Size(503, 21);
            this.cboClienteF.TabIndex = 27;
            // 
            // txtPrecioACliente
            // 
            this.txtPrecioACliente.Enabled = false;
            this.txtPrecioACliente.Location = new System.Drawing.Point(39, 194);
            this.txtPrecioACliente.Name = "txtPrecioACliente";
            this.txtPrecioACliente.Size = new System.Drawing.Size(243, 20);
            this.txtPrecioACliente.TabIndex = 29;
            // 
            // txtCostoATransportista
            // 
            this.txtCostoATransportista.Enabled = false;
            this.txtCostoATransportista.Location = new System.Drawing.Point(299, 194);
            this.txtCostoATransportista.Name = "txtCostoATransportista";
            this.txtCostoATransportista.Size = new System.Drawing.Size(243, 20);
            this.txtCostoATransportista.TabIndex = 31;
            // 
            // AgregarTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.txtCostoATransportista);
            this.Controls.Add(this.txtPrecioACliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboClienteF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.btnGuardarTarifa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRuta);
            this.Name = "AgregarTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTarifa";
            this.Load += new System.EventHandler(this.AgregarTarifa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.Button btnGuardarTarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClienteF;

        //Custom Properties
        Inicio FormInicio;
        string Accion;
        private System.Windows.Forms.TextBox txtPrecioACliente;
        private System.Windows.Forms.TextBox txtCostoATransportista;
    }
}