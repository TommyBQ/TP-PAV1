
namespace TrabajoPracticoPAV1_G02.ABMs.Empleados
{
    partial class Frm_AltaEmpleados
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
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.comboBoxBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtNumDocJefe = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDocJefe = new System.Windows.Forms.ComboBox();
            this.lblTipoDocJefe = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNumDocJefe = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(179, 139);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(142, 23);
            this.txtCuit.TabIndex = 36;
            this.txtCuit.TextChanged += new System.EventHandler(this.txtBoxCuit_TextChanged);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(12, 138);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(40, 20);
            this.lblCuit.TabIndex = 35;
            this.lblCuit.Text = "CUIT";
            this.lblCuit.Click += new System.EventHandler(this.lblCuit_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(179, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(142, 23);
            this.txtApellido.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(546, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(453, 303);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 99);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(211, 32);
            this.lblAgregarEmpleado.TabIndex = 28;
            this.lblAgregarEmpleado.Text = "Agregar Empleado";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(491, 53);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(142, 23);
            this.txtNumDoc.TabIndex = 38;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(491, 96);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(142, 23);
            this.comboBoxTipoDoc.TabIndex = 40;
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 227);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 23);
            this.txtDireccion.TabIndex = 42;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(12, 230);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 41;
            this.lblDireccion.Text = "Dirección";
            // 
            // comboBoxBarrio
            // 
            this.comboBoxBarrio.FormattingEnabled = true;
            this.comboBoxBarrio.Location = new System.Drawing.Point(179, 183);
            this.comboBoxBarrio.Name = "comboBoxBarrio";
            this.comboBoxBarrio.Size = new System.Drawing.Size(142, 23);
            this.comboBoxBarrio.TabIndex = 44;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarrio.Location = new System.Drawing.Point(12, 186);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(49, 20);
            this.lblBarrio.TabIndex = 43;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtNumDocJefe
            // 
            this.txtNumDocJefe.Location = new System.Drawing.Point(491, 183);
            this.txtNumDocJefe.Name = "txtNumDocJefe";
            this.txtNumDocJefe.Size = new System.Drawing.Size(142, 23);
            this.txtNumDocJefe.TabIndex = 48;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(491, 139);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 23);
            this.txtTelefono.TabIndex = 50;
            // 
            // comboBoxTipoDocJefe
            // 
            this.comboBoxTipoDocJefe.FormattingEnabled = true;
            this.comboBoxTipoDocJefe.Location = new System.Drawing.Point(179, 270);
            this.comboBoxTipoDocJefe.Name = "comboBoxTipoDocJefe";
            this.comboBoxTipoDocJefe.Size = new System.Drawing.Size(142, 23);
            this.comboBoxTipoDocJefe.TabIndex = 52;
            // 
            // lblTipoDocJefe
            // 
            this.lblTipoDocJefe.AutoSize = true;
            this.lblTipoDocJefe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDocJefe.Location = new System.Drawing.Point(12, 273);
            this.lblTipoDocJefe.Name = "lblTipoDocJefe";
            this.lblTipoDocJefe.Size = new System.Drawing.Size(151, 20);
            this.lblTipoDocJefe.TabIndex = 51;
            this.lblTipoDocJefe.Text = "Tipo Documento Jefe";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumDoc.Location = new System.Drawing.Point(347, 56);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(108, 20);
            this.lblNumDoc.TabIndex = 37;
            this.lblNumDoc.Text = "N° Documento";
            this.lblNumDoc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(347, 141);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 75;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNumDocJefe
            // 
            this.lblNumDocJefe.AutoSize = true;
            this.lblNumDocJefe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocJefe.Location = new System.Drawing.Point(347, 185);
            this.lblNumDocJefe.Name = "lblNumDocJefe";
            this.lblNumDocJefe.Size = new System.Drawing.Size(138, 20);
            this.lblNumDocJefe.TabIndex = 74;
            this.lblNumDocJefe.Text = "N° Documento Jefe";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDoc.Location = new System.Drawing.Point(347, 95);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(121, 20);
            this.lblTipoDoc.TabIndex = 73;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // Frm_AltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 339);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNumDocJefe);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.comboBoxTipoDocJefe);
            this.Controls.Add(this.lblTipoDocJefe);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNumDocJefe);
            this.Controls.Add(this.comboBoxBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Name = "Frm_AltaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox comboBoxBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtNumDocJefe;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox comboBoxTipoDocJefe;
        private System.Windows.Forms.Label lblTipoDocJefe;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNumDocJefe;
        private System.Windows.Forms.Label lblTipoDoc;
    }
}