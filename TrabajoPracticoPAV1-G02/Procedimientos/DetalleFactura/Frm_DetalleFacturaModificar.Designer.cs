
namespace TrabajoPracticoPAV1_G02.Procedimientos.DetalleFactura
{
    partial class Frm_DetalleFacturaModificar
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.textBox012 = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.textBox011 = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.comboBox011 = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(294, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(201, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 41;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // textBox012
            // 
            this.textBox012._columna = null;
            this.textBox012._mensajeError = null;
            this.textBox012._repetible = false;
            this.textBox012._validable = false;
            this.textBox012.Location = new System.Drawing.Point(87, 165);
            this.textBox012.Name = "textBox012";
            this.textBox012.Size = new System.Drawing.Size(168, 23);
            this.textBox012.TabIndex = 40;
            // 
            // textBox011
            // 
            this.textBox011._columna = null;
            this.textBox011._mensajeError = null;
            this.textBox011._repetible = false;
            this.textBox011._validable = false;
            this.textBox011.Location = new System.Drawing.Point(87, 118);
            this.textBox011.Name = "textBox011";
            this.textBox011.Size = new System.Drawing.Size(168, 23);
            this.textBox011.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Precio";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuit.Location = new System.Drawing.Point(12, 71);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(69, 20);
            this.lblCuit.TabIndex = 36;
            this.lblCuit.Text = "Producto";
            // 
            // comboBox011
            // 
            this.comboBox011._columna = null;
            this.comboBox011._MensajeError = null;
            this.comboBox011._repetible = false;
            this.comboBox011._Validable = false;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(87, 68);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Size = new System.Drawing.Size(168, 23);
            this.comboBox011.TabIndex = 35;
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarCliente.Location = new System.Drawing.Point(12, 9);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(280, 32);
            this.lblAgregarCliente.TabIndex = 34;
            this.lblAgregarCliente.Text = "Modificar Detalle Factura";
            // 
            // Frm_DetalleFacturaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 256);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textBox012);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.lblAgregarCliente);
            this.Name = "Frm_DetalleFacturaModificar";
            this.Text = "Modificar Detalle Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private Clases.TextBox01 textBox012;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCuit;
        private Clases.ComboBox01 comboBox011;
        private System.Windows.Forms.Label lblAgregarCliente;
    }
}