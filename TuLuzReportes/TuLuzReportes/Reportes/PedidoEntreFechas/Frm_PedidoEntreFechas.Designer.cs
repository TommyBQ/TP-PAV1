
namespace TuLuzReportes.Reportes.PedidoEntreFechas
{
    partial class Frm_PedidoEntreFechas
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker011 = new TuLuzReportes.Clases.DateTimePicker01();
            this.dateTimePicker012 = new TuLuzReportes.Clases.DateTimePicker01();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listado de Pedidos entre Precios";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(433, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Hasta:";
            // 
            // dateTimePicker011
            // 
            this.dateTimePicker011._columna = null;
            this.dateTimePicker011._mensajeError = null;
            this.dateTimePicker011._repetible = false;
            this.dateTimePicker011._validable = false;
            this.dateTimePicker011.Location = new System.Drawing.Point(117, 63);
            this.dateTimePicker011.Name = "dateTimePicker011";
            this.dateTimePicker011.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker011.TabIndex = 14;
            // 
            // dateTimePicker012
            // 
            this.dateTimePicker012._columna = null;
            this.dateTimePicker012._mensajeError = null;
            this.dateTimePicker012._repetible = false;
            this.dateTimePicker012._validable = false;
            this.dateTimePicker012.Location = new System.Drawing.Point(117, 111);
            this.dateTimePicker012.Name = "dateTimePicker012";
            this.dateTimePicker012.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker012.TabIndex = 15;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(18, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(501, 301);
            this.reportViewer1.TabIndex = 16;
            // 
            // Frm_PedidoEntreFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker012);
            this.Controls.Add(this.dateTimePicker011);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_PedidoEntreFechas";
            this.Text = "Listado de Pedido Entre Fechas";
            this.Load += new System.EventHandler(this.Frm_PedidoEntreFechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.DateTimePicker01 dateTimePicker011;
        private Clases.DateTimePicker01 dateTimePicker012;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}