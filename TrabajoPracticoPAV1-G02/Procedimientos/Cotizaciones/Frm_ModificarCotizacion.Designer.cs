﻿
namespace TrabajoPracticoPAV1_G02.Procedimientos.Cotizaciones
{
    partial class Frm_ModificarCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificarCotizacion));
            this.lblModificarEmpleado = new System.Windows.Forms.Label();
            this.txtNumero = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMotivoPerdida = new System.Windows.Forms.Label();
            this.lblCompetidor = new System.Windows.Forms.Label();
            this.txtAño = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumDocVendedor = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtObservaciones = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtMotivoPerdida = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtNomCompetidor = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.cmbCuitCliente = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.cmbEstado = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.cmbTipoDocVendedor = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.txtNomCliente = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtApeCliente = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.txtTotal = new TrabajoPracticoPAV1_G02.Clases.TextBox01();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpFecha = new TrabajoPracticoPAV1_G02.Clases.DateTimePicker01();
            this.gridDetalleCot = new TrabajoPracticoPAV1_G02.Clases.Grid01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDetalleCot = new System.Windows.Forms.Button();
            this.btnBorrarDetalleCot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificarEmpleado
            // 
            this.lblModificarEmpleado.AutoSize = true;
            this.lblModificarEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblModificarEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblModificarEmpleado.Name = "lblModificarEmpleado";
            this.lblModificarEmpleado.Size = new System.Drawing.Size(233, 32);
            this.lblModificarEmpleado.TabIndex = 54;
            this.lblModificarEmpleado.Text = "Modificar Cotizacion";
            // 
            // txtNumero
            // 
            this.txtNumero._columna = "numeroCotizacion";
            this.txtNumero._mensajeError = "*";
            this.txtNumero._repetible = false;
            this.txtNumero._validable = true;
            this.txtNumero.Location = new System.Drawing.Point(139, 27);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(142, 23);
            this.txtNumero.TabIndex = 77;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(7, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 78;
            this.lblNombre.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = " - Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Cuit Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = " - Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(324, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(324, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(324, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Tipo Doc Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(324, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Doc Vendedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(324, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Observaciones";
            // 
            // lblMotivoPerdida
            // 
            this.lblMotivoPerdida.AutoSize = true;
            this.lblMotivoPerdida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivoPerdida.Location = new System.Drawing.Point(7, 239);
            this.lblMotivoPerdida.Name = "lblMotivoPerdida";
            this.lblMotivoPerdida.Size = new System.Drawing.Size(110, 20);
            this.lblMotivoPerdida.TabIndex = 89;
            this.lblMotivoPerdida.Text = "Motivo Perdida";
            // 
            // lblCompetidor
            // 
            this.lblCompetidor.AutoSize = true;
            this.lblCompetidor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompetidor.Location = new System.Drawing.Point(7, 279);
            this.lblCompetidor.Name = "lblCompetidor";
            this.lblCompetidor.Size = new System.Drawing.Size(89, 20);
            this.lblCompetidor.TabIndex = 91;
            this.lblCompetidor.Text = "Competidor";
            // 
            // txtAño
            // 
            this.txtAño._columna = "año";
            this.txtAño._mensajeError = "No cargó año.";
            this.txtAño._repetible = false;
            this.txtAño._validable = true;
            this.txtAño.Location = new System.Drawing.Point(139, 67);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(142, 23);
            this.txtAño.TabIndex = 92;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(324, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 93;
            this.label11.Text = "Total:";
            // 
            // txtNumDocVendedor
            // 
            this.txtNumDocVendedor._columna = "numDocVendedor";
            this.txtNumDocVendedor._mensajeError = "*";
            this.txtNumDocVendedor._repetible = false;
            this.txtNumDocVendedor._validable = true;
            this.txtNumDocVendedor.Location = new System.Drawing.Point(481, 107);
            this.txtNumDocVendedor.MaxLength = 20;
            this.txtNumDocVendedor.Name = "txtNumDocVendedor";
            this.txtNumDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.txtNumDocVendedor.TabIndex = 94;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones._columna = "observaciones";
            this.txtObservaciones._mensajeError = "No hay observacion cargada.";
            this.txtObservaciones._repetible = false;
            this.txtObservaciones._validable = true;
            this.txtObservaciones.Location = new System.Drawing.Point(481, 187);
            this.txtObservaciones.MaxLength = 50;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(142, 23);
            this.txtObservaciones.TabIndex = 95;
            // 
            // txtMotivoPerdida
            // 
            this.txtMotivoPerdida._columna = "motivoPerdida";
            this.txtMotivoPerdida._mensajeError = "*";
            this.txtMotivoPerdida._repetible = false;
            this.txtMotivoPerdida._validable = false;
            this.txtMotivoPerdida.Location = new System.Drawing.Point(139, 240);
            this.txtMotivoPerdida.MaxLength = 50;
            this.txtMotivoPerdida.Name = "txtMotivoPerdida";
            this.txtMotivoPerdida.Size = new System.Drawing.Size(142, 23);
            this.txtMotivoPerdida.TabIndex = 96;
            this.txtMotivoPerdida.Click += new System.EventHandler(this.txtMotivoPerdida_Click);
            // 
            // txtNomCompetidor
            // 
            this.txtNomCompetidor._columna = "nomCompetidor";
            this.txtNomCompetidor._mensajeError = "*";
            this.txtNomCompetidor._repetible = false;
            this.txtNomCompetidor._validable = false;
            this.txtNomCompetidor.Location = new System.Drawing.Point(139, 279);
            this.txtNomCompetidor.MaxLength = 50;
            this.txtNomCompetidor.Name = "txtNomCompetidor";
            this.txtNomCompetidor.Size = new System.Drawing.Size(142, 23);
            this.txtNomCompetidor.TabIndex = 97;
            this.txtNomCompetidor.Click += new System.EventHandler(this.txtNomCompetidor_Click);
            // 
            // cmbCuitCliente
            // 
            this.cmbCuitCliente._columna = "cuitCliente";
            this.cmbCuitCliente._MensajeError = "No hay Cuit del cliente.";
            this.cmbCuitCliente._repetible = false;
            this.cmbCuitCliente._Validable = true;
            this.cmbCuitCliente.FormattingEnabled = true;
            this.cmbCuitCliente.Location = new System.Drawing.Point(139, 107);
            this.cmbCuitCliente.Name = "cmbCuitCliente";
            this.cmbCuitCliente.Size = new System.Drawing.Size(142, 23);
            this.cmbCuitCliente.TabIndex = 99;
            this.cmbCuitCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCuitCliente_SelectionChangeCommitted);
            // 
            // cmbEstado
            // 
            this.cmbEstado._columna = "codEstadoCotizacion";
            this.cmbEstado._MensajeError = "*";
            this.cmbEstado._repetible = false;
            this.cmbEstado._Validable = true;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(481, 27);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(142, 23);
            this.cmbEstado.TabIndex = 100;
            this.cmbEstado.SelectionChangeCommitted += new System.EventHandler(this.cmbEstado_SelectionChangeCommitted);
            // 
            // cmbTipoDocVendedor
            // 
            this.cmbTipoDocVendedor._columna = "tipoDocVendedor";
            this.cmbTipoDocVendedor._MensajeError = "*";
            this.cmbTipoDocVendedor._repetible = false;
            this.cmbTipoDocVendedor._Validable = true;
            this.cmbTipoDocVendedor.FormattingEnabled = true;
            this.cmbTipoDocVendedor.Location = new System.Drawing.Point(481, 67);
            this.cmbTipoDocVendedor.Name = "cmbTipoDocVendedor";
            this.cmbTipoDocVendedor.Size = new System.Drawing.Size(142, 23);
            this.cmbTipoDocVendedor.TabIndex = 101;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente._columna = "nombreCliente";
            this.txtNomCliente._mensajeError = "*";
            this.txtNomCliente._repetible = false;
            this.txtNomCliente._validable = true;
            this.txtNomCliente.Location = new System.Drawing.Point(139, 147);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.ReadOnly = true;
            this.txtNomCliente.Size = new System.Drawing.Size(142, 23);
            this.txtNomCliente.TabIndex = 102;
            // 
            // txtApeCliente
            // 
            this.txtApeCliente._columna = "apellidoCliente";
            this.txtApeCliente._mensajeError = "*";
            this.txtApeCliente._repetible = false;
            this.txtApeCliente._validable = true;
            this.txtApeCliente.Location = new System.Drawing.Point(139, 187);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.ReadOnly = true;
            this.txtApeCliente.Size = new System.Drawing.Size(142, 23);
            this.txtApeCliente.TabIndex = 103;
            // 
            // txtTotal
            // 
            this.txtTotal._columna = "precioTotal";
            this.txtTotal._mensajeError = "*";
            this.txtTotal._repetible = false;
            this.txtTotal._validable = true;
            this.txtTotal.Location = new System.Drawing.Point(481, 240);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 23);
            this.txtTotal.TabIndex = 104;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(930, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 106;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(837, 368);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 30);
            this.btnModificar.TabIndex = 105;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha._columna = "fecha";
            this.dtpFecha._mensajeError = "no se q pasa con la fecha";
            this.dtpFecha._repetible = true;
            this.dtpFecha._validable = true;
            this.dtpFecha.CustomFormat = "dd MMMM yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(481, 147);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(142, 23);
            this.dtpFecha.TabIndex = 108;
            // 
            // gridDetalleCot
            // 
            this.gridDetalleCot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalleCot.Location = new System.Drawing.Point(17, 22);
            this.gridDetalleCot.Name = "gridDetalleCot";
            this.gridDetalleCot.RowTemplate.Height = 25;
            this.gridDetalleCot.Size = new System.Drawing.Size(334, 219);
            this.gridDetalleCot.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomCompetidor);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApeCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTipoDocVendedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCuitCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMotivoPerdida);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.lblMotivoPerdida);
            this.groupBox1.Controls.Add(this.txtNumDocVendedor);
            this.groupBox1.Controls.Add(this.lblCompetidor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 318);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cotizacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarDetalleCot);
            this.groupBox2.Controls.Add(this.btnBorrarDetalleCot);
            this.groupBox2.Controls.Add(this.gridDetalleCot);
            this.groupBox2.Location = new System.Drawing.Point(649, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 318);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Detalles Cotizacion";
            // 
            // btnAgregarDetalleCot
            // 
            this.btnAgregarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalleCot.BackgroundImage")));
            this.btnAgregarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDetalleCot.Location = new System.Drawing.Point(17, 247);
            this.btnAgregarDetalleCot.Name = "btnAgregarDetalleCot";
            this.btnAgregarDetalleCot.Size = new System.Drawing.Size(44, 43);
            this.btnAgregarDetalleCot.TabIndex = 110;
            this.btnAgregarDetalleCot.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDetalleCot
            // 
            this.btnBorrarDetalleCot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarDetalleCot.BackgroundImage")));
            this.btnBorrarDetalleCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrarDetalleCot.Location = new System.Drawing.Point(67, 247);
            this.btnBorrarDetalleCot.Name = "btnBorrarDetalleCot";
            this.btnBorrarDetalleCot.Size = new System.Drawing.Size(45, 43);
            this.btnBorrarDetalleCot.TabIndex = 111;
            this.btnBorrarDetalleCot.UseVisualStyleBackColor = true;
            // 
            // Frm_ModificarCotizacion
            // 
            this.AcceptButton = this.btnModificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1024, 406);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblModificarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 424);
            this.Name = "Frm_ModificarCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cotizacion";
            this.Load += new System.EventHandler(this.Frm_ModificarCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarEmpleado;
        private Clases.TextBox01 txtNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMotivoPerdida;
        private System.Windows.Forms.Label lblCompetidor;
        private Clases.TextBox01 txtAño;
        private System.Windows.Forms.Label label11;
        private Clases.TextBox01 txtNumDocVendedor;
        private Clases.TextBox01 txtObservaciones;
        private Clases.TextBox01 txtMotivoPerdida;
        private Clases.TextBox01 txtNomCompetidor;
        private Clases.ComboBox01 cmbCuitCliente;
        private Clases.ComboBox01 cmbEstado;
        private Clases.ComboBox01 cmbTipoDocVendedor;
        private Clases.TextBox01 txtNomCliente;
        private Clases.TextBox01 txtApeCliente;
        private Clases.TextBox01 txtTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private Clases.DateTimePicker01 dtpFecha;
        private Clases.Grid01 gridDetalleCot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarDetalleCot;
        private System.Windows.Forms.Button btnBorrarDetalleCot;
    }
}