namespace SistemaDeViajes
{
    partial class AgregarSucursal
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarModal = new System.Windows.Forms.Button();
            this.btnGuardarSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(31, 162);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(512, 20);
            this.txtDireccion.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(512, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // btnCerrarModal
            // 
            this.btnCerrarModal.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarModal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCerrarModal.ForeColor = System.Drawing.Color.White;
            this.btnCerrarModal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrarModal.Location = new System.Drawing.Point(331, 268);
            this.btnCerrarModal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarModal.Name = "btnCerrarModal";
            this.btnCerrarModal.Size = new System.Drawing.Size(182, 28);
            this.btnCerrarModal.TabIndex = 17;
            this.btnCerrarModal.Text = "Cerrar";
            this.btnCerrarModal.UseVisualStyleBackColor = false;
            this.btnCerrarModal.Click += new System.EventHandler(this.btnCerrarModal_Click);
            // 
            // btnGuardarSucursal
            // 
            this.btnGuardarSucursal.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSucursal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSucursal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarSucursal.Location = new System.Drawing.Point(66, 268);
            this.btnGuardarSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarSucursal.Name = "btnGuardarSucursal";
            this.btnGuardarSucursal.Size = new System.Drawing.Size(182, 28);
            this.btnGuardarSucursal.TabIndex = 16;
            this.btnGuardarSucursal.Text = "Guardar";
            this.btnGuardarSucursal.UseVisualStyleBackColor = false;
            this.btnGuardarSucursal.Click += new System.EventHandler(this.btnGuardarSucursal_Click);
            // 
            // AgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(570, 334);
            this.Controls.Add(this.btnCerrarModal);
            this.Controls.Add(this.btnGuardarSucursal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "AgregarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarModal;
        private System.Windows.Forms.Button btnGuardarSucursal;

        //Custom Properties
        Inicio FormInicio = null;
        string Accion;
    }
}