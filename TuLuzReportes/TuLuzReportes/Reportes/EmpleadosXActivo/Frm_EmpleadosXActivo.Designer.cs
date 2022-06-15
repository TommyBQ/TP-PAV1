
namespace TuLuzReportes.Reportes.EmpleadosXActivo
{
    partial class Frm_EmpleadosXActivo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox012 = new TuLuzReportes.Clases.CheckBox01();
            this.checkBox011 = new TuLuzReportes.Clases.CheckBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 137);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(538, 301);
            this.reportViewer1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox012
            // 
            this.checkBox012._columna = null;
            this.checkBox012._mensajeError = null;
            this.checkBox012._validable = false;
            this.checkBox012.AutoSize = true;
            this.checkBox012.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox012.Location = new System.Drawing.Point(78, 99);
            this.checkBox012.Name = "checkBox012";
            this.checkBox012.Size = new System.Drawing.Size(94, 24);
            this.checkBox012.TabIndex = 9;
            this.checkBox012.Text = "No Activo";
            this.checkBox012.UseVisualStyleBackColor = true;
            // 
            // checkBox011
            // 
            this.checkBox011._columna = null;
            this.checkBox011._mensajeError = null;
            this.checkBox011._validable = false;
            this.checkBox011.AutoSize = true;
            this.checkBox011.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox011.Location = new System.Drawing.Point(78, 76);
            this.checkBox011.Name = "checkBox011";
            this.checkBox011.Size = new System.Drawing.Size(70, 24);
            this.checkBox011.TabIndex = 8;
            this.checkBox011.Text = "Activo";
            this.checkBox011.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado de Empleados Por Activo";
            // 
            // Frm_EmpleadosXActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox012);
            this.Controls.Add(this.checkBox011);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EmpleadosXActivo";
            this.Text = "Listado de Empleados por Activo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private Clases.CheckBox01 checkBox012;
        private Clases.CheckBox01 checkBox011;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}