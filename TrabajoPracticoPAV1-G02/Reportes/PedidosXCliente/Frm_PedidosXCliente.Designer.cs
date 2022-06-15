
namespace TrabajoPracticoPAV1_G02.Reportes.PedidosXCliente
{
    partial class Frm_PedidosXCliente
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.comboBox011 = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(12, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(338, 32);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Listado de Pedidos por Cliente";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 20);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Cliente:";
            // 
            // comboBox011
            // 
            this.comboBox011._columna = null;
            this.comboBox011._MensajeError = null;
            this.comboBox011._repetible = false;
            this.comboBox011._Validable = true;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(77, 67);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Size = new System.Drawing.Size(121, 23);
            this.comboBox011.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(555, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 26);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Frm_PedidosXCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblClientes);
            this.Name = "Frm_PedidosXCliente";
            this.Text = "Frm_PedidosXCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblApellido;
        private Clases.ComboBox01 comboBox011;
        private System.Windows.Forms.Button btnBuscar;
    }
}