
namespace TrabajoPracticoPAV1_G02.ABMs.Clientes
{
    partial class Frm_AltaClientes
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txt_Cuit = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txt_Nombre = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txt_Apellido = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.chk_Activo = new TrabajoPracticoPAV1_G02.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(285, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(192, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(16, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(16, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarCliente.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(180, 32);
            this.lblAgregarCliente.TabIndex = 18;
            this.lblAgregarCliente.Text = "Agregar Cliente";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(16, 56);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(40, 20);
            this.lblCuit.TabIndex = 26;
            this.lblCuit.Text = "CUIT";
            // 
            // txt_Cuit
            // 
            this.txt_Cuit._columna = "cuitCliente";
            this.txt_Cuit._mensajeError = "No ingreso el CUIT";
            this.txt_Cuit._repetible = false;
            this.txt_Cuit._validable = true;
            this.txt_Cuit.Location = new System.Drawing.Point(91, 53);
            this.txt_Cuit.Name = "txt_Cuit";
            this.txt_Cuit.Size = new System.Drawing.Size(148, 23);
            this.txt_Cuit.TabIndex = 29;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre._columna = "nombre";
            this.txt_Nombre._mensajeError = "No ingreso el NOMBRE";
            this.txt_Nombre._repetible = false;
            this.txt_Nombre._validable = true;
            this.txt_Nombre.Location = new System.Drawing.Point(91, 92);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(148, 23);
            this.txt_Nombre.TabIndex = 30;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido._columna = "apellido";
            this.txt_Apellido._mensajeError = "No ingreso el APELLIDO";
            this.txt_Apellido._repetible = false;
            this.txt_Apellido._validable = true;
            this.txt_Apellido.Location = new System.Drawing.Point(91, 133);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(148, 23);
            this.txt_Apellido.TabIndex = 31;
            // 
            // chk_Activo
            // 
            this.chk_Activo._columna = "activo";
            this.chk_Activo._mensajeError = "No selecciono el ESTADO";
            this.chk_Activo._validable = true;
            this.chk_Activo.AutoSize = true;
            this.chk_Activo.Location = new System.Drawing.Point(22, 191);
            this.chk_Activo.Name = "chk_Activo";
            this.chk_Activo.Size = new System.Drawing.Size(60, 19);
            this.chk_Activo.TabIndex = 32;
            this.chk_Activo.Text = "Activo";
            this.chk_Activo.UseVisualStyleBackColor = true;
            // 
            // Frm_AltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 237);
            this.Controls.Add(this.chk_Activo);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Cuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarCliente);
            this.Name = "Frm_AltaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.Label lblCuit;
        private Clases.TextBox01 txt_Cuit;
        private Clases.TextBox01 txt_Nombre;
        private Clases.TextBox01 txt_Apellido;
        private Clases.CheckBox01 chk_Activo;
    }
}