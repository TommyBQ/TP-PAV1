
namespace TuLuzReportes.Reportes.CotizacionesXPrecio
{
    partial class Frm_CotizacionesXPrecio
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox011 = new TuLuzReportes.Clases.TextBox01();
            this.textBox012 = new TuLuzReportes.Clases.TextBox01();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio Minimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Cotizaciones entre Precios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio Maximo:";
            // 
            // textBox011
            // 
            this.textBox011._columna = null;
            this.textBox011._mensajeError = null;
            this.textBox011._repetible = false;
            this.textBox011._validable = false;
            this.textBox011.Location = new System.Drawing.Point(132, 73);
            this.textBox011.Name = "textBox011";
            this.textBox011.Size = new System.Drawing.Size(116, 20);
            this.textBox011.TabIndex = 15;
            // 
            // textBox012
            // 
            this.textBox012._columna = null;
            this.textBox012._mensajeError = null;
            this.textBox012._repetible = false;
            this.textBox012._validable = false;
            this.textBox012.Location = new System.Drawing.Point(132, 109);
            this.textBox012.Name = "textBox012";
            this.textBox012.Size = new System.Drawing.Size(116, 20);
            this.textBox012.TabIndex = 16;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(18, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(571, 303);
            this.reportViewer1.TabIndex = 17;
            // 
            // Frm_CotizacionesXPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox012);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CotizacionesXPrecio";
            this.Text = "Listado de Cotizaciones entre Precios";
            this.Load += new System.EventHandler(this.Frm_CotizacionesXPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Clases.TextBox01 textBox011;
        private Clases.TextBox01 textBox012;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}