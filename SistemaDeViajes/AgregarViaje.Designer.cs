namespace SistemaDeViajes
{
    partial class AgregarViaje
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
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.btnCerrarModal = new System.Windows.Forms.Button();
            this.btnGuardarViaje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRuta = new System.Windows.Forms.ComboBox();
            this.listPedidos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Enabled = false;
            this.txtPesoTotal.Location = new System.Drawing.Point(297, 110);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(243, 20);
            this.txtPesoTotal.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(293, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Peso Total";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(37, 110);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(243, 20);
            this.txtFolio.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(33, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Folio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sucursal";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(297, 51);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(243, 21);
            this.cboSucursal.TabIndex = 37;
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
            // btnGuardarViaje
            // 
            this.btnGuardarViaje.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarViaje.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarViaje.ForeColor = System.Drawing.Color.White;
            this.btnGuardarViaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarViaje.Location = new System.Drawing.Point(57, 269);
            this.btnGuardarViaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarViaje.Name = "btnGuardarViaje";
            this.btnGuardarViaje.Size = new System.Drawing.Size(182, 28);
            this.btnGuardarViaje.TabIndex = 34;
            this.btnGuardarViaje.Text = "Guardar";
            this.btnGuardarViaje.UseVisualStyleBackColor = false;
            this.btnGuardarViaje.Click += new System.EventHandler(this.btnGuardarViaje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ruta";
            // 
            // cboRuta
            // 
            this.cboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuta.FormattingEnabled = true;
            this.cboRuta.Location = new System.Drawing.Point(37, 51);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.Size = new System.Drawing.Size(236, 21);
            this.cboRuta.TabIndex = 33;
            // 
            // listPedidos
            // 
            this.listPedidos.FormattingEnabled = true;
            this.listPedidos.Location = new System.Drawing.Point(37, 161);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(503, 94);
            this.listPedidos.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pedidos";
            // 
            // AgregarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.btnGuardarViaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRuta);
            this.Name = "AgregarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgrergarViaje";
            this.Load += new System.EventHandler(this.AgregarViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.Button btnGuardarViaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.CheckedListBox listPedidos;


        //Custom Properties
        Inicio FormInicio;
        string Accion;
        private System.Windows.Forms.Label label2;
    }
}