namespace SistemaDeViajes
{
    partial class AgregarPedido
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClienteO = new System.Windows.Forms.ComboBox();
            this.btnCerrarModal = new System.Windows.Forms.Button();
            this.btnGuardarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClienteD = new System.Windows.Forms.ComboBox();
            this.txtPiezas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(44, 180);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(243, 20);
            this.txtPeso.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(40, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Peso";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(40, 123);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(500, 20);
            this.txtDelivery.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cliente Origen";
            // 
            // cboClienteO
            // 
            this.cboClienteO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteO.FormattingEnabled = true;
            this.cboClienteO.Location = new System.Drawing.Point(40, 64);
            this.cboClienteO.Name = "cboClienteO";
            this.cboClienteO.Size = new System.Drawing.Size(247, 21);
            this.cboClienteO.TabIndex = 39;
            // 
            // btnCerrarModal
            // 
            this.btnCerrarModal.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarModal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCerrarModal.ForeColor = System.Drawing.Color.White;
            this.btnCerrarModal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrarModal.Location = new System.Drawing.Point(322, 269);
            this.btnCerrarModal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarModal.Name = "btnCerrarModal";
            this.btnCerrarModal.Size = new System.Drawing.Size(182, 28);
            this.btnCerrarModal.TabIndex = 35;
            this.btnCerrarModal.Text = "Cerrar";
            this.btnCerrarModal.UseVisualStyleBackColor = false;
            this.btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPedido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarPedido.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarPedido.Location = new System.Drawing.Point(57, 269);
            this.btnGuardarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(182, 28);
            this.btnGuardarPedido.TabIndex = 34;
            this.btnGuardarPedido.Text = "Guardar";
            this.btnGuardarPedido.UseVisualStyleBackColor = false;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(293, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cliente Destino";
            // 
            // cboClienteD
            // 
            this.cboClienteD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteD.FormattingEnabled = true;
            this.cboClienteD.Location = new System.Drawing.Point(300, 64);
            this.cboClienteD.Name = "cboClienteD";
            this.cboClienteD.Size = new System.Drawing.Size(240, 21);
            this.cboClienteD.TabIndex = 45;
            // 
            // txtPiezas
            // 
            this.txtPiezas.Location = new System.Drawing.Point(300, 180);
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(243, 20);
            this.txtPiezas.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(296, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Piezas";
            // 
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.txtPiezas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClienteD);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboClienteO);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.btnGuardarPedido);
            this.Name = "AgregarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPedido";
            this.Load += new System.EventHandler(this.AgregarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClienteO;
        private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.Button btnGuardarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClienteD;
        private System.Windows.Forms.TextBox txtPiezas;
        private System.Windows.Forms.Label label4;

        //Custom Properties
        Inicio FormInicio;
        string Accion;
    }
}