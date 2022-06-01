
namespace TrabajoPracticoPAV1_G02.ABMs.Productos
{
    partial class Frm_AltaProductos
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.cmbProveedor = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.txtNombre = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtPrecio = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtStock = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtDescripcion = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProdComponente = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProveedor.Location = new System.Drawing.Point(406, 144);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(99, 25);
            this.lblProveedor.TabIndex = 68;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.Click += new System.EventHandler(this.lblProveedor_Click);
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadStock.Location = new System.Drawing.Point(365, 75);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(137, 25);
            this.lblCantidadStock.TabIndex = 62;
            this.lblCantidadStock.Text = "Cantidad Stock";
            this.lblCantidadStock.Click += new System.EventHandler(this.lblCantidadStock_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(14, 208);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(65, 25);
            this.lblPrecio.TabIndex = 60;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(561, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 40);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(455, 287);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 40);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(14, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(14, 12);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(254, 41);
            this.lblAgregarEmpleado.TabIndex = 53;
            this.lblAgregarEmpleado.Text = "Agregar Producto";
            this.lblAgregarEmpleado.Click += new System.EventHandler(this.lblAgregarEmpleado_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor._columna = "cuitProveedor";
            this.cmbProveedor._MensajeError = "No eligió proveedor.";
            this.cmbProveedor._repetible = true;
            this.cmbProveedor._Validable = true;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(498, 144);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(162, 28);
            this.cmbProveedor.TabIndex = 69;
            // 
            // txtNombre
            // 
            this.txtNombre._columna = "nombre";
            this.txtNombre._mensajeError = "No completó nombre.";
            this.txtNombre._repetible = true;
            this.txtNombre._validable = true;
            this.txtNombre.Location = new System.Drawing.Point(128, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 27);
            this.txtNombre.TabIndex = 70;
            // 
            // txtPrecio
            // 
            this.txtPrecio._columna = "precio";
            this.txtPrecio._mensajeError = "No completó precio.";
            this.txtPrecio._repetible = false;
            this.txtPrecio._validable = true;
            this.txtPrecio.Location = new System.Drawing.Point(128, 204);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(155, 27);
            this.txtPrecio.TabIndex = 72;
            // 
            // txtStock
            // 
            this.txtStock._columna = "cantStock";
            this.txtStock._mensajeError = "No completó Stock.";
            this.txtStock._repetible = true;
            this.txtStock._validable = true;
            this.txtStock.Location = new System.Drawing.Point(496, 76);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(162, 27);
            this.txtStock.TabIndex = 73;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion._columna = "descripcion";
            this.txtDescripcion._mensajeError = "No completó descripcion.";
            this.txtDescripcion._repetible = true;
            this.txtDescripcion._validable = false;
            this.txtDescripcion.Location = new System.Drawing.Point(128, 139);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(155, 27);
            this.txtDescripcion.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Descripcion";
            // 
            // cmbProdComponente
            // 
            this.cmbProdComponente._columna = "codProductoEquivalente";
            this.cmbProdComponente._MensajeError = "No eligió producto componente.";
            this.cmbProdComponente._repetible = true;
            this.cmbProdComponente._Validable = false;
            this.cmbProdComponente.FormattingEnabled = true;
            this.cmbProdComponente.Location = new System.Drawing.Point(498, 204);
            this.cmbProdComponente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProdComponente.Name = "cmbProdComponente";
            this.cmbProdComponente.Size = new System.Drawing.Size(162, 28);
            this.cmbProdComponente.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Producto Componente";
            // 
            // Frm_AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 341);
            this.Controls.Add(this.cmbProdComponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblCantidadStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_AltaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.Frm_AltaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Clases.ComboBox01 cmbProveedor;
        private Clases.TextBox01 txtNombre;
        private Clases.TextBox01 txtPrecio;
        private Clases.TextBox01 txtStock;
        private Clases.TextBox01 txtDescripcion;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmbProdComponente;
        private System.Windows.Forms.Label label2;
    }
}