
namespace TrabajoPracticoPAV1_G02.Reportes.EmpleadosXJefes
{
    partial class Frm_EmpleadosXJefes
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.comboBox011 = new TrabajoPracticoPAV1_G02.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(600, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 26);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(97, 20);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Nombre Jefe:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(12, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(339, 32);
            this.lblClientes.TabIndex = 20;
            this.lblClientes.Text = "Listado de Empleados por Jefe";
            // 
            // comboBox011
            // 
            this.comboBox011._columna = null;
            this.comboBox011._MensajeError = null;
            this.comboBox011._repetible = false;
            this.comboBox011._Validable = false;
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(115, 69);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Size = new System.Drawing.Size(163, 23);
            this.comboBox011.TabIndex = 23;
            // 
            // Frm_EmpleadosXJefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblClientes);
            this.Name = "Frm_EmpleadosXJefes";
            this.Text = "Frm_EmpleadosXJefes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblClientes;
        private Clases.ComboBox01 comboBox011;
    }
}