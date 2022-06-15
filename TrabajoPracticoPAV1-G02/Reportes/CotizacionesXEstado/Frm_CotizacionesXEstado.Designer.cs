
namespace TrabajoPracticoPAV1_G02.Reportes.CotizacionesXEstado
{
    partial class Frm_CotizacionesXEstado
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkBox011 = new TrabajoPracticoPAV1_G02.Clases.CheckBox01();
            this.checkBox012 = new TrabajoPracticoPAV1_G02.Clases.CheckBox01();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(12, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(384, 32);
            this.lblClientes.TabIndex = 12;
            this.lblClientes.Text = "Listado de Cotizaciones por Estado";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 20);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Estado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(576, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 26);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // checkBox011
            // 
            this.checkBox011._columna = null;
            this.checkBox011._mensajeError = null;
            this.checkBox011._validable = false;
            this.checkBox011.AutoSize = true;
            this.checkBox011.Location = new System.Drawing.Point(76, 78);
            this.checkBox011.Name = "checkBox011";
            this.checkBox011.Size = new System.Drawing.Size(60, 19);
            this.checkBox011.TabIndex = 13;
            this.checkBox011.Text = "Activo";
            this.checkBox011.UseVisualStyleBackColor = true;
            // 
            // checkBox012
            // 
            this.checkBox012._columna = null;
            this.checkBox012._mensajeError = null;
            this.checkBox012._validable = false;
            this.checkBox012.AutoSize = true;
            this.checkBox012.Location = new System.Drawing.Point(76, 103);
            this.checkBox012.Name = "checkBox012";
            this.checkBox012.Size = new System.Drawing.Size(79, 19);
            this.checkBox012.TabIndex = 14;
            this.checkBox012.Text = "No Activo";
            this.checkBox012.UseVisualStyleBackColor = true;
            // 
            // Frm_CotizacionesXEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.checkBox012);
            this.Controls.Add(this.checkBox011);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Frm_CotizacionesXEstado";
            this.Text = "Frm_CotizacionesXEstado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnBuscar;
        private Clases.CheckBox01 checkBox011;
        private Clases.CheckBox01 checkBox012;
    }
}