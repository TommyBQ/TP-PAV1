
namespace TrabajoPracticoPAV1_G02.ABMs.Pedidos
{
    partial class Frm_Modificar_Pedidos
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
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.txtBoxCondPago = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtBoxCuitCliente = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.cmbBoxTDVendedor = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.txtBoxDocVendedor = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblTipoDocVendedor = new System.Windows.Forms.Label();
            this.lblNumDocVendedor = new System.Windows.Forms.Label();
            this.txtBoxAnioCotizacion = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblAñoCotizacion = new System.Windows.Forms.Label();
            this.txtBoxNumCotizacion = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtBoxNumPedido = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblNumCotizacion = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblModificarPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(628, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarPedido.Location = new System.Drawing.Point(535, 329);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(87, 30);
            this.btnModificarPedido.TabIndex = 111;
            this.btnModificarPedido.Text = "Modificar";
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.btnModificarPedido_Click);
            // 
            // txtBoxCondPago
            // 
            this.txtBoxCondPago._columna = "nombre";
            this.txtBoxCondPago._mensajeError = "Hay un campo vacio";
            this.txtBoxCondPago._repetible = true;
            this.txtBoxCondPago._validable = true;
            this.txtBoxCondPago.Location = new System.Drawing.Point(566, 157);
            this.txtBoxCondPago.Name = "txtBoxCondPago";
            this.txtBoxCondPago.Size = new System.Drawing.Size(142, 23);
            this.txtBoxCondPago.TabIndex = 110;
            // 
            // txtBoxCuitCliente
            // 
            this.txtBoxCuitCliente._columna = "apellido";
            this.txtBoxCuitCliente._mensajeError = "Hay un campo vacio";
            this.txtBoxCuitCliente._repetible = true;
            this.txtBoxCuitCliente._validable = true;
            this.txtBoxCuitCliente.Location = new System.Drawing.Point(184, 215);
            this.txtBoxCuitCliente.Name = "txtBoxCuitCliente";
            this.txtBoxCuitCliente.Size = new System.Drawing.Size(142, 23);
            this.txtBoxCuitCliente.TabIndex = 109;
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuitCliente.Location = new System.Drawing.Point(19, 218);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(90, 20);
            this.lblCuitCliente.TabIndex = 108;
            this.lblCuitCliente.Text = "CUIT Cliente";
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondicionPago.Location = new System.Drawing.Point(350, 160);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(134, 20);
            this.lblCondicionPago.TabIndex = 107;
            this.lblCondicionPago.Text = "Condicion de Pago";
            // 
            // cmbBoxTDVendedor
            // 
            this.cmbBoxTDVendedor._columna = "TipoDocumento";
            this.cmbBoxTDVendedor._MensajeError = "Hay un campo vacio";
            this.cmbBoxTDVendedor._repetible = false;
            this.cmbBoxTDVendedor._Validable = false;
            this.cmbBoxTDVendedor.FormattingEnabled = true;
            this.cmbBoxTDVendedor.Location = new System.Drawing.Point(566, 115);
            this.cmbBoxTDVendedor.Name = "cmbBoxTDVendedor";
            this.cmbBoxTDVendedor.Size = new System.Drawing.Size(142, 23);
            this.cmbBoxTDVendedor.TabIndex = 106;
            // 
            // txtBoxDocVendedor
            // 
            this.txtBoxDocVendedor._columna = "nombre";
            this.txtBoxDocVendedor._mensajeError = "Hay un campo vacio";
            this.txtBoxDocVendedor._repetible = true;
            this.txtBoxDocVendedor._validable = true;
            this.txtBoxDocVendedor.Location = new System.Drawing.Point(566, 72);
            this.txtBoxDocVendedor.Name = "txtBoxDocVendedor";
            this.txtBoxDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.txtBoxDocVendedor.TabIndex = 105;
            // 
            // lblTipoDocVendedor
            // 
            this.lblTipoDocVendedor.AutoSize = true;
            this.lblTipoDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDocVendedor.Location = new System.Drawing.Point(350, 116);
            this.lblTipoDocVendedor.Name = "lblTipoDocVendedor";
            this.lblTipoDocVendedor.Size = new System.Drawing.Size(210, 20);
            this.lblTipoDocVendedor.TabIndex = 104;
            this.lblTipoDocVendedor.Text = "Tipo Documento de Vendedor";
            // 
            // lblNumDocVendedor
            // 
            this.lblNumDocVendedor.AutoSize = true;
            this.lblNumDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocVendedor.Location = new System.Drawing.Point(350, 75);
            this.lblNumDocVendedor.Name = "lblNumDocVendedor";
            this.lblNumDocVendedor.Size = new System.Drawing.Size(176, 20);
            this.lblNumDocVendedor.TabIndex = 103;
            this.lblNumDocVendedor.Text = "Documento de Vendedor";
            // 
            // txtBoxAnioCotizacion
            // 
            this.txtBoxAnioCotizacion._columna = "nombre";
            this.txtBoxAnioCotizacion._mensajeError = "Hay un campo vacio";
            this.txtBoxAnioCotizacion._repetible = true;
            this.txtBoxAnioCotizacion._validable = true;
            this.txtBoxAnioCotizacion.Location = new System.Drawing.Point(184, 164);
            this.txtBoxAnioCotizacion.Name = "txtBoxAnioCotizacion";
            this.txtBoxAnioCotizacion.Size = new System.Drawing.Size(142, 23);
            this.txtBoxAnioCotizacion.TabIndex = 102;
            // 
            // lblAñoCotizacion
            // 
            this.lblAñoCotizacion.AutoSize = true;
            this.lblAñoCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAñoCotizacion.Location = new System.Drawing.Point(19, 167);
            this.lblAñoCotizacion.Name = "lblAñoCotizacion";
            this.lblAñoCotizacion.Size = new System.Drawing.Size(110, 20);
            this.lblAñoCotizacion.TabIndex = 101;
            this.lblAñoCotizacion.Text = "Año Cotizacion";
            // 
            // txtBoxNumCotizacion
            // 
            this.txtBoxNumCotizacion._columna = "apellido";
            this.txtBoxNumCotizacion._mensajeError = "Hay un campo vacio";
            this.txtBoxNumCotizacion._repetible = true;
            this.txtBoxNumCotizacion._validable = true;
            this.txtBoxNumCotizacion.Location = new System.Drawing.Point(184, 116);
            this.txtBoxNumCotizacion.Name = "txtBoxNumCotizacion";
            this.txtBoxNumCotizacion.Size = new System.Drawing.Size(142, 23);
            this.txtBoxNumCotizacion.TabIndex = 100;
            // 
            // txtBoxNumPedido
            // 
            this.txtBoxNumPedido._columna = "nombre";
            this.txtBoxNumPedido._mensajeError = "Hay un campo vacio";
            this.txtBoxNumPedido._repetible = true;
            this.txtBoxNumPedido._validable = true;
            this.txtBoxNumPedido.Location = new System.Drawing.Point(184, 75);
            this.txtBoxNumPedido.Name = "txtBoxNumPedido";
            this.txtBoxNumPedido.Size = new System.Drawing.Size(142, 23);
            this.txtBoxNumPedido.TabIndex = 99;

            // 
            // lblNumCotizacion
            // 
            this.lblNumCotizacion.AutoSize = true;
            this.lblNumCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCotizacion.Location = new System.Drawing.Point(17, 119);
            this.lblNumCotizacion.Name = "lblNumCotizacion";
            this.lblNumCotizacion.Size = new System.Drawing.Size(137, 20);
            this.lblNumCotizacion.TabIndex = 98;
            this.lblNumCotizacion.Text = "Numero Cotizacion";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumPedido.Location = new System.Drawing.Point(19, 78);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(113, 20);
            this.lblNumPedido.TabIndex = 97;
            this.lblNumPedido.Text = "Numero Pedido";
            // 
            // lblModificarPedido
            // 
            this.lblModificarPedido.AutoSize = true;
            this.lblModificarPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarPedido.Location = new System.Drawing.Point(12, 19);
            this.lblModificarPedido.Name = "lblModificarPedido";
            this.lblModificarPedido.Size = new System.Drawing.Size(195, 32);
            this.lblModificarPedido.TabIndex = 96;
            this.lblModificarPedido.Text = "Modificar Pedido";
            // 
            // Frm_Modificar_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.txtBoxCondPago);
            this.Controls.Add(this.txtBoxCuitCliente);
            this.Controls.Add(this.lblCuitCliente);
            this.Controls.Add(this.lblCondicionPago);
            this.Controls.Add(this.cmbBoxTDVendedor);
            this.Controls.Add(this.txtBoxDocVendedor);
            this.Controls.Add(this.lblTipoDocVendedor);
            this.Controls.Add(this.lblNumDocVendedor);
            this.Controls.Add(this.txtBoxAnioCotizacion);
            this.Controls.Add(this.lblAñoCotizacion);
            this.Controls.Add(this.txtBoxNumCotizacion);
            this.Controls.Add(this.txtBoxNumPedido);
            this.Controls.Add(this.lblNumCotizacion);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.lblModificarPedido);
            this.Name = "Frm_Modificar_Pedidos";
            this.Text = "Modificar pedidos";
            this.Load += new System.EventHandler(this.Frm_Modificar_Pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarPedido;
        private Clases.TextBox01 txtBoxCondPago;
        private Clases.TextBox01 txtBoxCuitCliente;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Label lblCondicionPago;
        private Clases.ComboBox01 cmbBoxTDVendedor;
        private Clases.TextBox01 txtBoxDocVendedor;
        private System.Windows.Forms.Label lblTipoDocVendedor;
        private System.Windows.Forms.Label lblNumDocVendedor;
        private Clases.TextBox01 txtBoxAnioCotizacion;
        private System.Windows.Forms.Label lblAñoCotizacion;
        private Clases.TextBox01 txtBoxNumCotizacion;
        private Clases.TextBox01 txtBoxNumPedido;
        private System.Windows.Forms.Label lblNumCotizacion;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.Label lblModificarPedido;
    }
}