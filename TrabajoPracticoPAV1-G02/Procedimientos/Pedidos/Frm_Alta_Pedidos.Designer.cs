
namespace TrabajoPracticoPAV1_G02.ABMs.Pedidos
{
    partial class Frm_Alta_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alta_Pedidos));
            this.lblAgregarPedido = new System.Windows.Forms.Label();
            this.txtTotal = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.cmbProducto = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.btnAgregarDetallePed = new System.Windows.Forms.Button();
            this.btnBorrarDetallePed = new System.Windows.Forms.Button();
            this.dataGridViewDetallePed = new TrabajoPracticoPAV1_G02.Clases.Grid01();
            this.txtCondPago = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.cmbCuitCliente = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.dtpFecha = new TrabajoPracticoPAV1_G02.Clases.DateTimePicker01();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.lblCondicionPago = new System.Windows.Forms.Label();
            this.cmbTDVendedor = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.txtDocVendedor = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblTipoDocVendedor = new System.Windows.Forms.Label();
            this.lblNumDocVendedor = new System.Windows.Forms.Label();
            this.txtAñoCotizacion = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblAñoCotizacion = new System.Windows.Forms.Label();
            this.txtNumCotizacion = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtNumPedido = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblNumCotizacion = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.btnCargarCotizacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarPedido
            // 
            this.lblAgregarPedido.AutoSize = true;
            this.lblAgregarPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarPedido.Location = new System.Drawing.Point(12, 19);
            this.lblAgregarPedido.Name = "lblAgregarPedido";
            this.lblAgregarPedido.Size = new System.Drawing.Size(178, 32);
            this.lblAgregarPedido.TabIndex = 29;
            this.lblAgregarPedido.Text = "Agregar Pedido";
            // 
            // txtTotal
            // 
            this.txtTotal._columna = "precioTotal";
            this.txtTotal._mensajeError = "*";
            this.txtTotal._repetible = false;
            this.txtTotal._validable = false;
            this.txtTotal.Location = new System.Drawing.Point(535, 341);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(199, 23);
            this.txtTotal.TabIndex = 178;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(374, 337);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 30);
            this.btnCalcular.TabIndex = 179;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(485, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 177;
            this.label11.Text = "Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(586, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 176;
            this.label12.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(374, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 175;
            this.label10.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad._columna = "cantidad";
            this.txtCantidad._mensajeError = "No seleccionó la cantidad";
            this.txtCantidad._repetible = false;
            this.txtCantidad._validable = false;
            this.txtCantidad.Location = new System.Drawing.Point(666, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 23);
            this.txtCantidad.TabIndex = 174;
            // 
            // cmbProducto
            // 
            this.cmbProducto._columna = "codProducto";
            this.cmbProducto._MensajeError = "No seleccionó Producto";
            this.cmbProducto._repetible = false;
            this.cmbProducto._Validable = false;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(459, 52);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 23);
            this.cmbProducto.TabIndex = 173;
            // 
            // btnAgregarDetallePed
            // 
            this.btnAgregarDetallePed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetallePed.BackgroundImage")));
            this.btnAgregarDetallePed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetallePed.Location = new System.Drawing.Point(739, 42);
            this.btnAgregarDetallePed.Name = "btnAgregarDetallePed";
            this.btnAgregarDetallePed.Size = new System.Drawing.Size(45, 43);
            this.btnAgregarDetallePed.TabIndex = 171;
            this.btnAgregarDetallePed.UseVisualStyleBackColor = true;
            this.btnAgregarDetallePed.Click += new System.EventHandler(this.btnAgregarDetallePed_Click);
            // 
            // btnBorrarDetallePed
            // 
            this.btnBorrarDetallePed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetallePed.BackgroundImage")));
            this.btnBorrarDetallePed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetallePed.Location = new System.Drawing.Point(739, 91);
            this.btnBorrarDetallePed.Name = "btnBorrarDetallePed";
            this.btnBorrarDetallePed.Size = new System.Drawing.Size(45, 43);
            this.btnBorrarDetallePed.TabIndex = 172;
            this.btnBorrarDetallePed.UseVisualStyleBackColor = true;
            this.btnBorrarDetallePed.Click += new System.EventHandler(this.btnBorrarDetallePed_Click);
            // 
            // dataGridViewDetallePed
            // 
            this.dataGridViewDetallePed.AllowUserToAddRows = false;
            this.dataGridViewDetallePed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetallePed.Location = new System.Drawing.Point(374, 91);
            this.dataGridViewDetallePed.Name = "dataGridViewDetallePed";
            this.dataGridViewDetallePed.RowHeadersVisible = false;
            this.dataGridViewDetallePed.RowTemplate.Height = 25;
            this.dataGridViewDetallePed.Size = new System.Drawing.Size(360, 240);
            this.dataGridViewDetallePed.TabIndex = 170;
            // 
            // txtCondPago
            // 
            this.txtCondPago._columna = "condicionPago";
            this.txtCondPago._mensajeError = "Falta condicion PAGO!";
            this.txtCondPago._repetible = false;
            this.txtCondPago._validable = true;
            this.txtCondPago.Location = new System.Drawing.Point(176, 75);
            this.txtCondPago.Name = "txtCondPago";
            this.txtCondPago.Size = new System.Drawing.Size(122, 23);
            this.txtCondPago.TabIndex = 169;
            // 
            // cmbCuitCliente
            // 
            this.cmbCuitCliente._columna = "cuitCliente";
            this.cmbCuitCliente._MensajeError = "No hay cuit seleccionado";
            this.cmbCuitCliente._repetible = false;
            this.cmbCuitCliente._Validable = true;
            this.cmbCuitCliente.FormattingEnabled = true;
            this.cmbCuitCliente.Location = new System.Drawing.Point(156, 280);
            this.cmbCuitCliente.Name = "cmbCuitCliente";
            this.cmbCuitCliente.Size = new System.Drawing.Size(142, 23);
            this.cmbCuitCliente.TabIndex = 168;
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fechaPedido";
            this.dtpFecha._mensajeError = "no se q pasa con la fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(156, 116);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(142, 23);
            this.dtpFecha.TabIndex = 167;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 166;
            this.label5.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(704, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 165;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPedido.Location = new System.Drawing.Point(611, 387);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(87, 30);
            this.btnAgregarPedido.TabIndex = 164;
            this.btnAgregarPedido.Text = "Agregar";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuitCliente.Location = new System.Drawing.Point(24, 279);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(90, 20);
            this.lblCuitCliente.TabIndex = 163;
            this.lblCuitCliente.Text = "CUIT Cliente";
            // 
            // lblCondicionPago
            // 
            this.lblCondicionPago.AutoSize = true;
            this.lblCondicionPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondicionPago.Location = new System.Drawing.Point(23, 74);
            this.lblCondicionPago.Name = "lblCondicionPago";
            this.lblCondicionPago.Size = new System.Drawing.Size(134, 20);
            this.lblCondicionPago.TabIndex = 162;
            this.lblCondicionPago.Text = "Condicion de Pago";
            // 
            // cmbTDVendedor
            // 
            this.cmbTDVendedor._columna = "tipoDniVendedor";
            this.cmbTDVendedor._MensajeError = "Hay un campo vacio";
            this.cmbTDVendedor._repetible = false;
            this.cmbTDVendedor._Validable = false;
            this.cmbTDVendedor.FormattingEnabled = true;
            this.cmbTDVendedor.Location = new System.Drawing.Point(185, 321);
            this.cmbTDVendedor.Name = "cmbTDVendedor";
            this.cmbTDVendedor.Size = new System.Drawing.Size(113, 23);
            this.cmbTDVendedor.TabIndex = 161;
            // 
            // txtDocVendedor
            // 
            this.txtDocVendedor._columna = "numDniVendedor";
            this.txtDocVendedor._mensajeError = "Hay un campo vacio";
            this.txtDocVendedor._repetible = true;
            this.txtDocVendedor._validable = true;
            this.txtDocVendedor.Location = new System.Drawing.Point(156, 361);
            this.txtDocVendedor.Name = "txtDocVendedor";
            this.txtDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.txtDocVendedor.TabIndex = 160;
            // 
            // lblTipoDocVendedor
            // 
            this.lblTipoDocVendedor.AutoSize = true;
            this.lblTipoDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDocVendedor.Location = new System.Drawing.Point(24, 320);
            this.lblTipoDocVendedor.Name = "lblTipoDocVendedor";
            this.lblTipoDocVendedor.Size = new System.Drawing.Size(141, 20);
            this.lblTipoDocVendedor.TabIndex = 159;
            this.lblTipoDocVendedor.Text = "Tipo Doc. Vendedor";
            // 
            // lblNumDocVendedor
            // 
            this.lblNumDocVendedor.AutoSize = true;
            this.lblNumDocVendedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumDocVendedor.Location = new System.Drawing.Point(23, 361);
            this.lblNumDocVendedor.Name = "lblNumDocVendedor";
            this.lblNumDocVendedor.Size = new System.Drawing.Size(107, 20);
            this.lblNumDocVendedor.TabIndex = 158;
            this.lblNumDocVendedor.Text = "Doc. Vendedor";
            // 
            // txtAñoCotizacion
            // 
            this.txtAñoCotizacion._columna = "añoCotizacion";
            this.txtAñoCotizacion._mensajeError = "Hay un campo vacio";
            this.txtAñoCotizacion._repetible = true;
            this.txtAñoCotizacion._validable = true;
            this.txtAñoCotizacion.Location = new System.Drawing.Point(156, 239);
            this.txtAñoCotizacion.Name = "txtAñoCotizacion";
            this.txtAñoCotizacion.Size = new System.Drawing.Size(142, 23);
            this.txtAñoCotizacion.TabIndex = 157;
            // 
            // lblAñoCotizacion
            // 
            this.lblAñoCotizacion.AutoSize = true;
            this.lblAñoCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAñoCotizacion.Location = new System.Drawing.Point(24, 238);
            this.lblAñoCotizacion.Name = "lblAñoCotizacion";
            this.lblAñoCotizacion.Size = new System.Drawing.Size(110, 20);
            this.lblAñoCotizacion.TabIndex = 156;
            this.lblAñoCotizacion.Text = "Año Cotizacion";
            // 
            // txtNumCotizacion
            // 
            this.txtNumCotizacion._columna = "numeroCotizacion";
            this.txtNumCotizacion._mensajeError = "Hay un campo vacio";
            this.txtNumCotizacion._repetible = true;
            this.txtNumCotizacion._validable = true;
            this.txtNumCotizacion.Location = new System.Drawing.Point(156, 198);
            this.txtNumCotizacion.Name = "txtNumCotizacion";
            this.txtNumCotizacion.Size = new System.Drawing.Size(142, 23);
            this.txtNumCotizacion.TabIndex = 155;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido._columna = "numeroPedido";
            this.txtNumPedido._mensajeError = "Hay un campo vacio";
            this.txtNumPedido._repetible = true;
            this.txtNumPedido._validable = true;
            this.txtNumPedido.Location = new System.Drawing.Point(156, 157);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(142, 23);
            this.txtNumPedido.TabIndex = 154;
            // 
            // lblNumCotizacion
            // 
            this.lblNumCotizacion.AutoSize = true;
            this.lblNumCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCotizacion.Location = new System.Drawing.Point(24, 197);
            this.lblNumCotizacion.Name = "lblNumCotizacion";
            this.lblNumCotizacion.Size = new System.Drawing.Size(111, 20);
            this.lblNumCotizacion.TabIndex = 153;
            this.lblNumCotizacion.Text = "Nro. Cotizacion";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumPedido.Location = new System.Drawing.Point(24, 156);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(87, 20);
            this.lblNumPedido.TabIndex = 152;
            this.lblNumPedido.Text = "Nro. Pedido";
            // 
            // btnCargarCotizacion
            // 
            this.btnCargarCotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarCotizacion.Location = new System.Drawing.Point(311, 198);
            this.btnCargarCotizacion.Name = "btnCargarCotizacion";
            this.btnCargarCotizacion.Size = new System.Drawing.Size(53, 64);
            this.btnCargarCotizacion.TabIndex = 180;
            this.btnCargarCotizacion.Text = "---->";
            this.btnCargarCotizacion.UseVisualStyleBackColor = true;
            this.btnCargarCotizacion.Click += new System.EventHandler(this.btnCargarCotizacion_Click);
            // 
            // Frm_Alta_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 429);
            this.Controls.Add(this.btnCargarCotizacion);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnAgregarDetallePed);
            this.Controls.Add(this.btnBorrarDetallePed);
            this.Controls.Add(this.dataGridViewDetallePed);
            this.Controls.Add(this.txtCondPago);
            this.Controls.Add(this.cmbCuitCliente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblCuitCliente);
            this.Controls.Add(this.lblCondicionPago);
            this.Controls.Add(this.cmbTDVendedor);
            this.Controls.Add(this.txtDocVendedor);
            this.Controls.Add(this.lblTipoDocVendedor);
            this.Controls.Add(this.lblNumDocVendedor);
            this.Controls.Add(this.txtAñoCotizacion);
            this.Controls.Add(this.lblAñoCotizacion);
            this.Controls.Add(this.txtNumCotizacion);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.lblNumCotizacion);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.lblAgregarPedido);
            this.Name = "Frm_Alta_Pedidos";
            this.Text = "Alta de pedidos";
            this.Load += new System.EventHandler(this.Frm_Alta_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallePed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarPedido;
        private Clases.TextBox01 txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txtCantidad;
        private Clases.ComboBox01 cmbProducto;
        private System.Windows.Forms.Button btnAgregarDetallePed;
        private System.Windows.Forms.Button btnBorrarDetallePed;
        private Clases.Grid01 dataGridViewDetallePed;
        private Clases.TextBox01 txtCondPago;
        private Clases.ComboBox01 cmbCuitCliente;
        private Clases.DateTimePicker01 dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.Label lblCondicionPago;
        private Clases.ComboBox01 cmbTDVendedor;
        private Clases.TextBox01 txtDocVendedor;
        private System.Windows.Forms.Label lblTipoDocVendedor;
        private System.Windows.Forms.Label lblNumDocVendedor;
        private Clases.TextBox01 txtAñoCotizacion;
        private System.Windows.Forms.Label lblAñoCotizacion;
        private Clases.TextBox01 txtNumCotizacion;
        private Clases.TextBox01 txtNumPedido;
        private System.Windows.Forms.Label lblNumCotizacion;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.Button btnCargarCotizacion;
    }
}